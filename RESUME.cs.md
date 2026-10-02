---
schema_version: 7
type: library
file_count: 39
avg_lines_per_file: 128
move_to_legacy_percent: 10
generated_date: 2026-10-01
generated_time: 16:43:10
github_source_url: 
last_build_ok: yes
last_build_date: 2026-10-02
last_tests_run_date: 2026-10-02
covered_lines: 0
total_lines: 4643
---

## Description

Balíček Sunamo s generátory pomocných názvů a hlášek: ControlNameGenerator, ErrorMessageGenerator a SpecialFolders. Obsahuje také sdílené enumy (AppFoldersShared, LangsShared, TypeOfMessageShared) a vygenerované konstanty XlfKeys a Translate. Je určen k referencování z jiných projektů.

## Původ zdrojáků

Staženo z GitHubu: **ne** — vlastní projekt.

- Ověřeno: Součást vlastního ekosystému Sunamo, bez cizího remote.

## Doporučení přesunu do legacy

Doporučení přesunu do sunamocz-legacy.visualstudio.com: **10 %** — Funkční balíček, část kódu (XlfKeys) je sdílena i v jiných balíčcích.

- Reálný kód generátorů
- Duplicitní sdílené enumy a XlfKeys s SunamoRL

## Vazby na moje repa

- Submoduly: žádné
- ProjectReference / PackageReference: žádné
