SetCompressor lzma
!include "MUI.nsh"
!include FontReg.nsh
!include FontName.nsh

Name "eQruan 3.4"
BrandingText " "
ShowInstDetails Show
ShowUninstDetails Show
OutFile "equran.exe"
InstallDir "$PROGRAMFILES\eQuran"

!define MUI_ABORTWARNING ;when the user click cancel this will warn him
!define MUI_ICON "Icon.ico"
!define MUI_UNICON "Icon.ico"
!define MUI_WELCOMEFINISHPAGE_BITMAP "setup.bmp"
!define MUI_UNWELCOMEFINISHPAGE_BITMAP "setup.bmp"
!define REG_UNINSTALL "Software\Microsoft\Windows\CurrentVersion\Uninstall\eQuran"
!define MUI_FINISHPAGE_TEXT "eQuran has been installed on your computer. Click Finish to close this wizard."
;!define MUI_FINISHPAGE_TEXT_LARGE
!define MUI_FINISHPAGE_RUN  "$INSTDIR\eQuran.exe"

!insertmacro MUI_PAGE_WELCOME
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES
!insertmacro MUI_PAGE_FINISH
!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES
!insertmacro MUI_LANGUAGE "English"


Section "Install"
  Call CheckdotNET
  
  SetOutPath "$INSTDIR"
  File "..\bin\Release\eQuran.exe"
  File "..\bin\Release\eQuran.exe.config"  
  File "..\XML Files\extensions.xml"
  File "..\XML Files\recitations.xml"
  
  SetOutPath "$INSTDIR\quran"
  File "..\XML Files\quran\quran.xml"
  File "..\XML Files\quran\quran_search.xml"
  File "..\XML Files\quran\quran_parts.xml"
  File "..\XML Files\quran\tafseer_en_shakir.xml"
  File "..\XML Files\quran\tafseer_en_ali.xml"
  File "..\XML Files\quran\tafseer_de.xml"
  File "..\XML Files\quran\tafseer_it.xml"
  File "..\XML Files\quran\tafseer_ch.xml"
  File "..\XML Files\quran\tafseer_fr.xml"
  
  SetOutPath "$INSTDIR\hadeeth"
  File "..\XML Files\hadeeth\hadeeth_bokhary.xml"
  File "..\XML Files\hadeeth\hadeeth_muslim.xml"
  File "..\XML Files\hadeeth\sonan_dawood.xml"
  File "..\XML Files\hadeeth\sonan_elnasaey.xml"
  File "..\XML Files\hadeeth\sonan_maga.xml"
  File "..\XML Files\hadeeth\sonan_eltarmazy.xml"


  Call InstallFont

  SetOutPath "$INSTDIR"
  ;WriteRegStr HKCU "Software\Extension Changer" "Left" "100"
  WriteRegStr HKLM "${REG_UNINSTALL}" "DisplayName" "eQuran"
  WriteRegStr HKLM "${REG_UNINSTALL}" "DisplayIcon" "$INSTDIR\eQuran.exe"
  WriteRegStr HKLM "${REG_UNINSTALL}" "DisplayVersion" "3.3"
  WriteRegStr HKLM "${REG_UNINSTALL}" "Publisher" "Yehia A.Salam"
  WriteRegStr HKLM "${REG_UNINSTALL}" "UninstallString" "$INSTDIR\equranuninstall.exe"
  WriteRegStr HKLM "${REG_UNINSTALL}" "URLInfoAbout" "http://www.seegh.com"
  WriteRegStr HKLM "${REG_UNINSTALL}" "Contact" "equran@seegh.com"
  WriteUninstaller "$INSTDIR\equranuninstall.exe"
  CreateShortCut "$DESKTOP\eQuran.lnk" "$INSTDIR\eQuran.exe"
SectionEnd


Section "Uninstall"
  Delete "$DESKTOP\eQuran.lnk"
  DeleteRegKey HKLM "${REG_UNINSTALL}"
  DeleteRegKey HKCU "Software\eQuran"
  RmDir /r "$INSTDIR"
SectionEnd


Function CheckdotNET
	ReadRegStr $R0 HKLM "SOFTWARE\Microsoft\.NETFramework" "InstallRoot"
	StrCmp $R0 "" NoFramework VerifyVersion

	NoFramework:
		MessageBox MB_OK|MB_ICONEXCLAMATION "The .NET Framework is not installed on this machine. You must install it to continue with this installation."
		Quit

	VerifyVersion:
		IfFileExists "$R0\v2.0.50727\*.*" VersionFound Version2NotFound

	Version2NotFound:
		MessageBox MB_OK|MB_ICONEXCLAMATION "You have an older version of the .NET framework installed on this \r\n computer. You must update it to continue with this installation."
		Quit

	VersionFound:
FunctionEnd


Function InstallFont 
  StrCpy $FONT_DIR $FONTS
 
  !insertmacro InstallTTFFont 'ae_AlArabiya.ttf'
  !insertmacro InstallTTFFont 'Haettenschweiler.ttf'
 
  SendMessage ${HWND_BROADCAST} ${WM_FONTCHANGE} 0 0 /TIMEOUT=5000
FunctionEnd

;------------------------------------------------------------------------------
; GetWindowsVersion
;
; Based on Yazno's function, http://yazno.tripod.com/powerpimpit/
; Returns on top of stack
;
; Windows Version (95, 98, ME, NT x.x, 2000, XP)
; or
; '' (Unknown Windows Version)
;
; Usage:
;   Call GetWindowsVersion
;   Pop $0
;   ; at this point $0 is "NT 4.0" or whatnot

Function GetWindowsVersion
  Push $0
  Push $9
  ReadRegStr $0 HKLM "SOFTWARE\Microsoft\Windows NT\CurrentVersion" CurrentVersion
  StrCmp $0 "" 0 lbl_winnt
  ClearErrors
  ; we are not NT.
  ReadRegStr $0 HKLM SOFTWARE\Microsoft\Windows\CurrentVersion VersionNumber

  StrCpy $9 $0 1
  StrCmp $9 '4' 0 lbl_error

  StrCpy $9 $0 3

  StrCmp $9 '4.0' lbl_win32_95
  StrCmp $9 '4.9' lbl_win32_ME lbl_win32_98

  lbl_win32_95:
    StrCpy $0 '95'
  Goto lbl_done

  lbl_win32_98:
    StrCpy $0 '98'
  Goto lbl_done

  lbl_win32_ME:
    StrCpy $0 'ME'
  Goto lbl_done

  lbl_winnt:

    StrCpy $9 $0 3
    StrCmp $9 '5.1' lbl_winxp
    StrCpy $9 $0 1
    StrCmp $9 '3' lbl_winnt_x
    StrCmp $9 '4' lbl_winnt_x
    StrCmp $9 '5' lbl_winnt_5 lbl_error

    lbl_winnt_x:
      StrCpy $0 "NT $0" 6
    Goto lbl_done

    lbl_winnt_5:
      Strcpy $0 '2000'
    Goto lbl_done

    lbl_winxp:
      StrCpy $0 'XP'
    Goto lbl_done

  lbl_error:
    Strcpy $0 ''
  lbl_done:
  Pop $9
  Exch $0
FunctionEnd