#!/usr/bin/env bash
#author: omitida
#description: create and clean csharp files

function help() {
    echo "Usage: ./$(basename $0) -h | -a|-A|-b|-c|-C|-r|-n|-p|-s|-S|-m|-l|-w|-t|-T <filename>"
    echo "options:"
    echo "-A    add a project to a solution in C#"
    echo "-a    create a cshtml file in a folder"
    echo "-b    build and run project name"
    echo "-c    create project name"
    echo "-C    create a project folder, and a solution file and the project to the solution file."
    echo "-r    remove project bin folder"
    echo "-n    remove the entire project folder"
    echo "-p    add package from NuGet to the project"
    echo "-g    create a generic standalone cs file"
    echo "-h    display the help function"
    echo "-S    create a solution file in C #"
    echo "-s    run a c# script. The script can have either .csx or .cs file extension."
    echo "-t    create a unit test for a c# project"
    echo "-T    run a unit test for a named c# project"
    echo "-m    manually compiling and running a c# standalone file"
    echo "-l    create a library project folder and link with the project to use it."
    echo "-W    load the web development ASP.NET in 'watch' Mode."
    echo "-w    create a web project namely: ASP.NET MVC, ASP.NET CORE MVC/Razor (webApp) OR WebAPI"
}

# launch typescript script
#if [[ "${1}" == "typescript" || "${1}" == "type" ]]; then
#  echo "launch the typescript bash script";
#  makets.sh
#  exit 0
#fi

if [[ $# -ne 2 ]]; then
    help
    exit 1
fi

function standalone_cs_file(){
    filename="${1}"
    file="${filename%.*}"
    file_extension="${filename#*.}"
    if [[ "${file}" == "${file_extension}" ]]; then
        file="${file^}.cs"
    fi
    touch "${file}"
echo "
using System;

class ${file%.*}
{
    public static void Main()
    {
        Console.WriteLine(\"Start Here!\");
    }
}
    " > "${file}"
}

function remove_unwanted_folders(){
    target_folder="${1}"
    directory1=$(dirname "${target_folder}"/bin)
    directory2=$(dirname "${target_folder}"/obj)
    file1=$(basename "$target_folder/bin")
    file2=$(basename "$target_folder/obj")
    filefound1=$(ls -r "${directory1}" | grep "${file1}")
    filefound2=$(ls -r "${directory2}" | grep "${file2}")
        if [[ -z "$filefound1" ]] && [[ -z "$filefound2" ]];then
            echo "Neither \"$OPTARG/bin\" nor \"$OPTARG/obj\" folders were found." && return
        fi
        echo "Deleted csharp project namely: ${target_folder}/bin && ${target_folder}/obj"
        #rm -rf "${target_folder}"/bin
        #rm -rf "${target_folder}"/obj
        files=("${target_folder}/bin" "${target_folder}/obj")
        for file in "${files[@]}"; do
            rm -rf "${file}"
        done
}

function lists_and_delete() {
    directory="${1}"
    echo "This check for bin and obj folders and delete them"
    echo -n "would you want to continue? [c|n]: "
    while read -r line; do
        case "${line,,}" in
           c)
             for file in "${directory}"/*; do
                if [[ -d "$file" ]]; then
                    remove_unwanted_folders "${file}"
               fi
              done
              break
            ;;
           n) echo "Bye.."
              exit 0
            ;;
           *) echo "\"${line}\" - Invalid option. Enter either c to continue or n to end."
            ;;
        esac
    done
}

function make_html_file() {
    echo "
    @{
        Layout = null;
    }
    <!DOCTYPE html>
    <html>
        <head>
            <meta name=\"\" content=\"width=device-width\" />
            <title></title>
        </head>
        <body>
            <div></div>
        </body>
    </html>
    " > "${1}"
}

options="A:a:c:C:r:n:g:b:s:S:m:l:p:w:W:t:T:h"
while getopts ${options} opt; do
    case $opt in
        A) # add a project to a solution file
            dotnet sln add "${OPTARG}"
            ;;
        a)
            filename=$(basename "${OPTARG}")
            file_ext="${filename##*.}"
            if [[ "${file_ext}" != "cshtml" ]]; then
               echo "File Extention must be cshtml."
               exit 1
            fi
            # create a file with a filename in a specified folder
            touch "${OPTARG}"
            directory=$(dirname "${OPTARG}")
            cd "${directory}"
            make_html_file "${filename}" # call function that makes a cshtml file
            ;;
        b) if [[ -e "${OPTARG}" ]]; then
               cd "${OPTARG}"
               dotnet run
            elif [[ $(basename "${file}") == "${OPTARG}" ]]; then
                dotnet run
            fi
            ;;
        c)
            echo "Creating csharp project namely: ${OPTARG}"
            dotnet new console -n "${OPTARG}"
            dotnet build "${OPTARG}"
            ;;
        C)
            mkdir "${OPTARG}"
            cd "${OPTARG}"
            dotnet new sln -n "${OPTARG}"
            ##
            echo "Creating csharp project namely: ${OPTARG}"
            dotnet new console -n "${OPTARG}"
            ##
            dotnet sln add "${OPTARG}"
            dotnet build "${OPTARG}"
            ;;
        g)
            ## create a generic cs file
            filename="${OPTARG}"
            standalone_cs_file "${filename}"
            ;;
        r)
            # call function list and delete
            echo "Are you deleting single project or multiple? "
            echo -n "m - Multiple | s - Single : "
            while read -r answer; do
                case "$answer" in
                m)
                lists_and_delete "${OPTARG}"
                break
                ;;
                s) remove_unwanted_folders "${OPTARG}"
                   break
                ;;
                *) echo "${answer} - Invalid input."
                   continue;;
                esac
            done
            ;;
        p)  # add a named package to the project
            dotnet add package "${OPTARG}"
            ;;
        n)
            filefound=$(ls | grep "$OPTARG")
            if [[ -z "$filefound" ]];then
                echo "No \"$OPTARG\" project was found." && exit 0
            fi
            echo "Deleting csharp project namely: ${OPTARG}"
            echo -n "Do you want to delete the whole project file \"${OPTARG}\"? [y|n]: "
            while read -r line; do
                if [[ "${line,,}" == 'y' ]]; then
                    rm -rf "${OPTARG}"
                    exit 0
                else exit 0
                fi
            done
            ;;
        t) # create a unit test for a named csharp project
           # using either mstest or nunit test framework
            while read -p "Which test framework you want? NUnit or MStest [n|m]: " ans; do
                case "${ans}" in
                    n)
                        dotnet new nunit -o "${OPTARG}"
                        exit 0
                        ;;
                    m)
                        dotnet new mstest -o "${OPTARG}"
                        exit 0
                        ;;
                    *) echo "You can only use either N for NUnit or M for MStest."
                    ;;
                esac
            done
            ;;
        T) # run a unit test project for c#
            dotnet test "${OPTARG}"
            ;;
        S)  # create a solution file in C# added to a folder of
            # the same name
            sln_directory=$(mkdir "${OPTARG}")
            cd "${OPTARG}"
            dotnet new sln -n "${sln_directory}"
            ;;
        s)  # compiling and runing c# script
            dotnet-script "${OPTARG}"
            ;;
        l)  # create class library
            dotnet new classlib -n "${OPTARG}"
            echo -n "Enter the name of the Project to include the library: "
            while read -r line; do
                # find the project entered
                findproject=$(ls | grep "${line}")
                if [[ -z "${findproject}" ]]; then
                    echo "Run $(basename $0) -c ${line}"
                    echo "To create the project first then run this command to make a library."
                    rm -rf "${OPTARG}"
                    exit 1
                else
                    projdirectory="${line}"
                    cd "$projdirectory"
                    dotnet add reference ../"${OPTARG}"/"${OPTARG}.csproj"
                    exit 0;
                fi
            done
            ;;
        m)  # compile and generate executable file
            csc "${OPTARG}" && mono "${OPTARG%.*}.exe"
            # remove the executable file after running it
            rm -rf "${OPTARG%.*}.exe";;
        w) makecweb.sh "${OPTARG}" # call the script namely makecweb.sh
        ;;
        W)
            if [[ "${PWD}" != "${OPTARG}" ]]; then
                cd "${OPTARG}"
            fi

            dotnet watch
        ;;
        h) help && exit1;;
        *) help && exit1;;
    esac
done

exit 0
