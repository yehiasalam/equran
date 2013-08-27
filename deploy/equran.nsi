SetCompressor lzma
!include "MUI.nsh"
!include FontReg.nsh
!include FontName.nsh

Name "eQruan 3.5"
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
  
  SetOutPath "$INSTDIR\data"
  File "..\data\extensions.xml"
  File "..\data\recitations.xml" 
  File "..\data\quran.xml"
  File "..\data\quran_search.xml"
  File "..\data\quran_parts.xml"
  File "..\data\tafseer_en_shakir.xml"
  File "..\data\tafseer_en_ali.xml"
  File "..\data\tafseer_de.xml"
  File "..\data\tafseer_it.xml"
  File "..\data\tafseer_ch.xml"
  File "..\data\tafseer_fr.xml"
  File "..\data\hadeeth_bokhary.xml"
  File "..\data\hadeeth_muslim.xml"
  File "..\data\sonan_dawood.xml"
  File "..\data\sonan_elnasaey.xml"
  File "..\data\sonan_maga.xml"
  File "..\data\sonan_eltarmazy.xml"


  Call InstallFont

  SetOutPath "$INSTDIR"
  ;WriteRegStr HKCU "Software\Extension Changer" "Left" "100"
  WriteRegStr HKLM "${REG_UNINSTALL}" "DisplayName" "eQuran"
  WriteRegStr HKLM "${REG_UNINSTALL}" "DisplayIcon" "$INSTDIR\eQuran.exe"
  WriteRegStr HKLM "${REG_UNINSTALL}" "DisplayVersion" "3.5"
  WriteRegStr HKLM "${REG_UNINSTALL}" "Publisher" "Yehia A.Salam"
  WriteRegStr HKLM "${REG_UNINSTALL}" "UninstallString" "$INSTDIR\equranuninstall.exe"
  WriteRegStr HKLM "${REG_UNINSTALL}" "URLInfoAbout" "http://www.cairocubicles.com"
  WriteRegStr HKLM "${REG_UNINSTALL}" "Contact" "equran@cairocubicles.com"
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
		IfFileExists "$R0\v4.0.30319\*.*" VersionFound Version2NotFound

	Version2NotFound:
		MessageBox MB_OK|MB_ICONEXCLAMATION "You have an older version of the .NET framework installed on this \r\n computer. You must update it to continue with this installation."
		Quit

	VersionFound:
FunctionEnd


Function InstallFont 
  StrCpy $FONT_DIR $FONTS
 
  !insertmacro InstallTTFFont 'amiri-quran.ttf'
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