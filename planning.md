\# Todo App - Planering



\## Produktidé



En enkel kommandoradstodoapplikation i C# / .NET 10.0 som låter användare hantera dagliga uppgifter. Applikationen sparar todos lokalt i en JSON-fil för persistering mellan sessioner.



\## User Stories \& Backlog (Prioriterad)



\### US1: Add Todo (HÖGSTA PRIORITET)

Beskrivning: Användare kan lägga till nya todos med titel och beskrivning.

\- Input: Titel och beskrivning

\- Output: Todo lagras med unikt ID

\- Status: IMPLEMENTERAD



\### US4: Delete Todo (HÖG PRIORITET)

Beskrivning: Användare kan radera todos efter ID.

\- Input: Todo ID

\- Action: Tar bort todo från listan

\- Status: IMPLEMENTERAD



\### US5: Save and Load (HÖG PRIORITET)

Beskrivning: Applikationen sparar todos till JSON-fil och laddar dem vid start.

\- Persistering: todos.json

\- Auto-load vid startup

\- Status: IMPLEMENTERAD



\### US2: View Todos (MEDEL PRIORITET)

Beskrivning: Visa alla todos med status (Pending/Done).

\- Display: \[ID] Title - Description (Status)

\- Tydlig formatering

\- Status: IMPLEMENTERAD



\### US3: Mark Complete (MEDEL PRIORITET)

Beskrivning: Markera todos som klara.

\- Input: Todo ID

\- Action: Ändra IsComplete till true

\- Status: IMPLEMENTERAD



\## Arbetssätt



\- Ramverk: .NET 10.0 Console Application

\- Språk: C#

\- Lagring: JSON-fil (todos.json)

\- Samarbete: Git med feature-branches per user story

\- Integration: Kontinuerlig merging in i master



\## Arkitektur



\- Models/Todo.cs - Data model för todos

\- Services/TodoService.cs - Business logic

\- Program.cs - UI och menyhantering



\## Definition of Done



\- Feature implementerad

\- Testad lokalt

\- Code committed och pushad

\- Merged in i master via feature-branch

