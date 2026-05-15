\# Agila Metoder - Git Laboration Utvärdering



\## Vad vi byggde



Vi utvecklade en funktionell kommandoradstodoapplikation i .NET 10.0 med följande features:

\- \*\*US1: Add Todo\*\* - Användare kan lägga till nya todos med titel och beskrivning

\- \*\*US2: View Todos\*\* - Visa alla todos med status (Pending/Done)

\- \*\*US3: Mark Complete\*\* - Markera todos som klara

\- \*\*US4: Delete Todo\*\* - Radera todos efter ID

\- \*\*US5: Save/Load\*\* - Automatisk persistering till JSON-fil



All kod är funktionell och integrerad i en gemensam kodbas.



\## Hur samarbetet fungerade



Teamet bestod av tre utvecklare som arbetade parallellt via Git-branches. Kommunikationen skedde via Discord i realtid. Vi roterade roller enligt mob programming-principen - en person var driver (skrev kod) medan de andra var navigatörer (diskuterade och granskade).



Varje developer hade tydligt ansvar för sina user stories:

\- \*\*Essan\*\*: US1 initial, sedan koordinering och merging av alla branches

\- \*\*Kassuar\*\*: US4 (Delete), US3 (Mark Complete)

\- \*\*Abdulsalam\*\*: US5 (Save/Load)

\- \*\*US2 (View)\*\*: Implementerades av Essan



Rollrotationen gjorde att alla fick erfarenhet av att både skriva kod och granska andras arbete.



\## Hur vi arbetade med Git



\### Branches

Vi skapade 5 feature-branches enligt mönstret `feature/usX-description`:

\- `feature/us1-add-todo`

\- `feature/us4-delete-todo`

\- `feature/us5-save-load`

\- `feature/us2-view-todos`

\- `feature/us3-mark-complete`



Varje branch var isolerad och byggde på master, vilket möjliggjorde parallell utveckling.



\### Commits

\- Alla commits hade beskrivande meddelanden

\- Commits skapades när en feature var klar och testerad

\- Totalt \~10+ commits dokumenterar utvecklingsprocessen



\### Merging

\- All kod gick via branches och merges in i master

\- \*\*Merge 1\*\*: US1 → master (smooth)

\- \*\*Merge 2\*\*: US4 → master (smooth)

\- \*\*Merge 3\*\*: US5 → master (KONFLIKT - löst tillsammans)

\- \*\*Merge 4\*\*: US2 → master (smooth)

\- \*\*Merge 5\*\*: US3 → master (KONFLIKT - löst tillsammans)



\### Merge-konflikter

Vi skapade och löste \*\*2 merge-konflikter\*\* i Services/TodoService.cs och Program.cs:

1\. \*\*Konflikt 1\*\*: När US5 mergades - SaveTodos/LoadTodos confliktade med DeleteTodo

2\. \*\*Konflikt 2\*\*: När US3 mergades - Mark Complete confliktade med View Todos



Båda lösts genom att kombinera all funktionalitet från båda branches.



\## Vad som fungerade bra



1\. \*\*Parallell utveckling\*\* - Tre personer kunde arbeta samtidigt utan att blockera varandra

2\. \*\*Git-arbetsflöde\*\* - Branch/merge-strategin var tydlig och enkel att följa

3\. \*\*Konflikthantering\*\* - Merge-konflikterna uppstod naturligt och löstes genom diskussion

4\. \*\*Integration\*\* - All kod fungerade tillsammans utan stora problem

5\. \*\*Testning\*\* - Vi testade efter varje feature-implementation

6\. \*\*Kommunikation\*\* - Discord gjorde det enkelt att koordinera



\## Vad vi hade gjort annorlunda



1\. \*\*Input-validering från början\*\* - Vi lade till validering senare (non-empty checks)

2\. \*\*Nullable-varningar\*\* - Kunde ha adresserat C# nullable-varningar tidigare

3\. \*\*Mer avancerad struktur\*\* - Kunde ha separat UI-layer från logic

4\. \*\*Unit-tests\*\* - Hade kunnat skriva tester för TodoService-metoderna

5\. \*\*Pull Requests\*\* - Hade kunnat använda PR-flow för code review före merge

6\. \*\*Dokumentation under arbete\*\* - Skriva planering.md mer i detalj initialt

7\. \*\*Fewer commits\*\* - Hade kunnat kombinera mindre commits för renare historik



\## Slutsatser



Projektet visade att Git är ett kraftfullt verktyg för teamsamarbete. Merge-konflikter är inte något att frukta utan en naturlig del av parallell utveckling. Genom tydlig kommunikation och strukturerade branches kunde vi integrera kod från tre utvecklare utan större problem.



Det viktigaste insikten: \*\*samarbete och kommunikation är viktigare än perfekt kod\*\*. Vi fokuserade på hur vi arbetade tillsammans, inte på att bygga en perfekt applikation. Det motsvarar uppgiftens syfte och lärande.



Att arbeta enligt XP-inspirerad arbetssätt med gemensam kodbas, kontinuerlig integration och realtidskommunikation gjorde det möjligt att få all kod integrerad och fungerande på kort tid.

