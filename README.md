# README: How to Add or Fill in Languages for Rules and Questions

## Overview

This project manages rules and questions in multiple languages. The GetRule01 method in the Rules class demonstrates how rules, questions, and answers are stored with multilingual support. To add a new language or complete missing translations, follow the instructions below.

### File Structure

The rules are defined in a RuleDto object that contains a list of QuestionDto objects, which in turn hold AnswerDto objects. Each of these DTOs supports multilingual text for the properties Phrase, PhraseNl, PhraseFr, PhraseSvn, PhraseDe, etc.

Translations for the UI are stored in JSON files (`en.json`, `nl.json` `fr.json`, `de.json`, etc.).

## Adding a New Language

### Define the New Language Property:

To support a new language, such as Spanish, first update the RuleDto, QuestionDto, and AnswerDto classes to include a new property. For example:

```c#
public string PhraseEs { get; set; }  // Spanish translation
```

Populate the New Language in GetRule(number) Method of all the rule files:
Extend the RuleDto, QuestionDto, and AnswerDto objects to include the new language translations. For example:

```c#
NameEs = "El campo de juego",
```

Similarly, add the PhraseEs property for each question and answer:

```c#
PhraseEs = "¿Cuáles son las medidas del campo de juego según las reglas?",
```

## Filling in Missing Translations

### Locate the Missing Translations:

Missing translations are represented by empty strings (e.g., PhraseFr = ""). Find these in the GetRule(number) method of all the rule files.

### Add the Translation:

Replace the empty string with the correct translation. For example, for French:

```c#
PhraseFr = "Quelles sont les mesures du terrain de jeu selon les règles?",
```

### Review the Entire Rule:

Make sure all questions and answers have the translations filled in for all supported languages.

## JSON Translation Files

The JSON files (en.json, nl.json, fr.json, de.json, etc.) contain translations for various parts of the UI. Each file includes a structure for different sections like "home", "navigation", "questions", etc.

### Filling in Missing Translations in JSON Files

#### Open the JSON Files:

The JSON files are organized with keys and values where each value corresponds to a text string in a specific language.

#### Identify Empty Fields:

Look for keys with empty string values ("") in the JSON files. For example, in the de.json file:

```json
"home": {
  "alert": "",
  "all_questions_card": {
    "button": "",
    "content": "",
    "title": ""
  }
}
```

#### Add the Missing Translation:

Replace the empty strings with the appropriate translations. For example, in de.json:

```json
"home": {
  "alert": "Derzeit sind nur die englische und niederländische Version verfügbar. Sobald die Versionen in anderen Sprachen (Französisch, Deutsch, Slowenisch, ...) verfügbar sind, werden sie veröffentlicht.",
  "all_questions_card": {
    "button": "Alle Fragen beantworten",
    "content": "Gehe zur Liste aller Fragen.",
    "title": "Alle Fragen"
  }
}
```

### Adding a New Language in JSON Files

#### Duplicate an Existing JSON File:

If you are adding a new language, start by copying one of the existing JSON files (e.g., en.json).

#### Translate Each Key:

Translate each value in the JSON file to the new language. For example, if creating a Spanish (es.json) file:

```json
"home": {
    "alert": "Por ahora, solo están disponibles las versiones en inglés y holandés. Tan pronto como estén disponibles las versiones en otros idiomas (francés, alemán, esloveno,...), se publicarán.",
    "all_questions_card": {
        "button": "Responder todas las preguntas",
        "content": "Ve a la lista de todas las preguntas.",
        "title": "Todas las preguntas"
    }
}
```

#### Add the New Language to the Language Switcher:

Update the languages section in each JSON file to include the new language.

## Creating a Pull Request

Once you've made your changes to the code, you can submit them for review by creating a pull request (PR). Follow these steps:

### Fork the Repository:

If you haven't already, fork the repository to your own GitHub account.

### Clone Your Fork:

Clone your fork to your local machine using the following command:

```bash
git clone https://github.com/KristofGilis/ihf_rules_questions.git
```

Replace your-username with your GitHub username and repository-name with the repository's name.

### Create a New Branch:

Create a new branch for your changes. It's good practice to name your branch based on the feature or fix you're implementing:

```bash
git checkout -b add-spanish-translations
```

### Make Your Changes:

Edit the files to add the new language or fill in missing translations.

### Commit Your Changes:

Once you're happy with your changes, commit them with a meaningful message:

```bash
git add .
git commit -m "Added Spanish translations"
```

### Push Your Changes:

Push your changes to your fork on GitHub:

```bash
git push origin add-spanish-translations
```

### Create a Pull Request:

Go to your fork on GitHub, and you should see an option to create a pull request. Click on it and provide a clear description of the changes you made.

### Wait for Review:

Once submitted, your pull request will be reviewed by the project maintainers. They may ask for changes or approve your pull request directly.

#### Note

If you encounter any issues with creating a pull request, or if you prefer, you can also email your changes directly to kristof.gilis@outlook.be for review and inclusion.

## Example: Adding Spanish Language

Below is an example of how you can extend the existing code to include Spanish translations:

```c#
var rule = new RuleDto
{
    Name = "Playing Court",
    NameNl = "Speeloppervlak",
    NameFr = "L'aire de jeu",
    NameSvn = "Igrišče",
    NameDe = "Die Spielfläche",
    NameEs = "El campo de juego",  // Added Spanish translation
    RuleNumber = "1",
    Questions =
    [
        new QuestionDto
        {
            Phrase = "What are the measurements of the playing court according to the rules?",
            PhraseNl = "Wat zijn de afmetingen van het speelveld volgens de spelregels?",
            PhraseFr = "Quelles sont les mesures du terrain de jeu selon les règles?",
            PhraseSvn = "Kakšne so mere igrišča po pravilih?",
            PhraseDe = "Welche Maße hat das Spielfeld laut den Regeln?",
            PhraseEs = "¿Cuáles son las medidas del campo de juego según las reglas?",  // Added Spanish translation
            QuestionNumber = "1.1",
            Answers =
            [
                new AnswerDto
                {
                    Phrase = "40 x 20 metres",
                    PhraseNl = "40 m x 20 m",
                    PhraseFr = "40 x 20 mètres",
                    PhraseSvn = "40 x 20 metrov",
                    PhraseDe = "40 x 20 Meter",
                    PhraseEs = "40 x 20 metros",  // Added Spanish translation
                    AnswerNumber = "a",
                    Correct = true
                },
                // Additional answers with Spanish translations...
            ]
        },
        // Additional questions with Spanish translations...
    ]
};
```

## Conclusion

By following these instructions, you can easily add new languages, fill in missing translations, and submit your changes for review via a pull request. Alternatively, you can email your changes directly for review. Ensure all changes are consistent across the project to maintain the integrity of the multilingual support.

## Special thanks to our contributors

<table>
  <tbody>
    <tr>
    <td align="center" valign="top" width="14.28%"><a href="https://github.com/KristofGilis"><img src="https://avatars.githubusercontent.com/u/2454275?v=4?s=100" width="100px;" alt="Kristof Gilis"/><br /><sub><b>Kristof Gilis</b></sub></a><br /><a href="https://github.com/KristofGilis/ihf_rules_questions/commits?author=KristofGilis" title="Code"> En / Nl</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/branislavrt4316"><img src="https://avatars.githubusercontent.com/u/55112798?v=4?s=100" width="100px;" alt="Branislav Vujanovic"/><br /><sub><b>Branislav Vujanovic</b></sub></a><br /><a href="https://github.com/KristofGilis/ihf_rules_questions/commits?author=branislavrt4316" title="Code">Srb</a></td>
    </tr>
  </tbody>
</table>
