# MFTECmd

## Command Line Interface

    MFTECmd version 0.5.0.1
    
    Author: Eric Zimmerman (saericzimmerman@gmail.com)
    https://github.com/EricZimmerman/MFTECmd
    Reworked by: Christiaan Masucci (cmasucci012@gmail.com)
    
            f               File to process ($MFT | $J | $LogFile | $Boot | $SDS). Required
	    r		    Pull resident files only
	    e		    Make the CSV excel compatible by splitting into mulitple CSVs
    
            json            Directory to save JSON formatted results to. This or --csv required unless --de or --body is specified
            jsonf           File name to save JSON formatted results to. When present, overrides default name
            csv             Directory to save CSV formatted results to. This or --json required unless --de or --body is specified
            csvf            File name to save CSV formatted results to. When present, overrides default name
    
            body            Directory to save bodyfile formatted results to. --bdl is also required when using this option
            bodyf           File name to save body formatted results to. When present, overrides default name
            bdl             Drive letter (C, D, etc.) to use with bodyfile. Only the drive letter itself should be provided
            blf             When true, use LF vs CRLF for newlines. Default is FALSE
    
            dd              Directory to save exported FILE record. --do is also required when using this option
            do              Offset of the FILE record to dump as decimal or hex. Ex: 5120 or 0x1400 Use --de or --vl 1 to see offsets
    
            de              Dump full details for entry/sequence #. Format is 'Entry' or 'Entry-Seq' as decimal or hex. Example: 5, 624-5 or 0x270-0x5.
            fls             When true, displays contents of directory specified by --de. Ignored when --de points to a file.
            ds              Dump full details for Security Id as decimal or hex. Example: 624 or 0x270
    
            dt              The custom date/time format to use when displaying time stamps. Default is: yyyy-MM-dd HH:mm:ss.fffffff
            sn              Include DOS file name types. Default is FALSE
            fl              Generate condensed file listing. Requires --csv. Default is FALSE
            at              When true, include all timestamps from 0x30 attribute vs only when they differ from 0x10. Default is FALSE
    
            vss             Process all Volume Shadow Copies that exist on drive specified by -f . Default is FALSE
            dedupe          Deduplicate -f & VSCs based on SHA-1. First file found wins. Default is FALSE
    
            debug           Show debug information during processing
            trace           Show trace information during processing


    Examples: MFTECmd.exe -f "C:\Temp\SomeMFT" --csv "c:\temp\out" --csvf MyOutputFile.csv
	      MFTECmd.exe -f "C:\Temp\SomeMFT" --csv "c:\temp\out" --csvf MyOutputFile.csv -r -e
              MFTECmd.exe -f "C:\Temp\SomeMFT" --csv "c:\temp\out"
              MFTECmd.exe -f "C:\Temp\SomeMFT" --json "c:\temp\jsonout"
              MFTECmd.exe -f "C:\Temp\SomeMFT" --body "c:\temp\bout" --bdl c
              MFTECmd.exe -f "C:\Temp\SomeMFT" --de 5-5

              Short options (single letter) are prefixed with a single dash. Long commands are prefixed with two dashes


# Original author

Eric Zimmerman:
https://github.com/EricZimmerman/MFTECmd


# Contributions made
-Add the option to extract only resident data files
-Properly extract all resident data from each file
-Add option for excel compatibility using CSV
