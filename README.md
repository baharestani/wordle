# Wordle

## Run

Run the following and wait to see the `READY!` prompt

```bash
dotnet run --project src/Wordle.Console/Wordle.Console.csproj
```

## Architecture

The game consists of the following main components:

- `Game`: which is the staring point.
- `IWordProvider`: Is required by `Game` and is responsible for providing the words.
- `WordInspector`: Is required by `Game` and validates every guessed letter against the wordle word.
