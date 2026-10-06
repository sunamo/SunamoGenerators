---
schema_version: 11
type: library
category_override: none
file_count: 39
file_extensions: cs:32, csproj:3, md:3, noext:1, slnx:1
file_extensions_updated: 2026-10-04
avg_lines_per_file: 128
total_lines: 4643
metrics_lm: 2026-10-01 16:43:10
move_to_legacy_percent: 10
description_updated: 2026-10-01
links_updated: 2026-10-01
github_source_url: not found
origin_status: found
origin_checked: 2026-10-01
article_source_url: not run
article_status: pending
article_checked: not run
last_build_ok: yes
last_build_date: 2026-10-02
last_tests_run_date: 2026-10-02
covered_lines: 0
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
