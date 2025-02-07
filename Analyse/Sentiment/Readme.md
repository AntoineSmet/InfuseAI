
# Sentiment 

L'API d'analyse de sentiment permet d'analyser le sentiment exprimé dans un texte. Elle peut détecter si un texte est positif, négatif ou neutre, en évaluant les émotions et les opinions exprimées. 

## API Reference

```https
  POST ${endpoint}/text/analytics/v3.0/sentiment
```

#### Headers

| Key | Value     |
| :-------- | :------- |
| `Ocp-Apim-Subscription-Key` | `xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx` |

#### Body
```json
{
  "documents": [
    {
      "id": "1",
      "language": "fr",
      "text" : "Mesdames et Messieurs, Je me tiens devant vous aujourd'hui non pas comme un homme de succès, mais comme un homme qui aspire à la valeur4. Car ce qui compte vraiment ne peut pas toujours être compté, et ce qui peut être compté ne compte pas forcément4. L'imagination est plus importante que le savoir3. Le savoir est limité, tandis que l'imagination englobe le monde entier, stimule le progrès et suscite l'évolution4. C'est pourquoi je vous encourage à cultiver votre créativité, car elle est contagieuse - faites-la tourner8. Il n'y a que deux façons de vivre sa vie : l'une en faisant comme si rien n'était un miracle, l'autre en faisant comme si tout était un miracle4. Choisissez la seconde option. Émerveillez-vous devant la beauté de l'univers, car la joie de regarder et de comprendre est le plus beau cadeau de la nature8. N'ayez pas peur de commettre des erreurs. Une personne qui n'a jamais commis d'erreurs n'a jamais tenté d'innover8. La vie est comme une bicyclette, il faut avancer pour ne pas perdre l'équilibre2. Enfin, souvenez-vous que le monde tel que nous l'avons créé est un processus de notre pensée. Il ne peut pas être changé sans changer notre pensée8. Soyez donc le changement que vous voulez voir dans le monde. Apprenez d'hier, vivez pour aujourd'hui, espérez pour demain. Et surtout, n'arrêtez jamais de questionner8.\" Ce discours imaginaire capture l'essence de la pensée d'Einstein, mêlant sa vision scientifique à sa philosophie de vie."
    }
  ]
}
```

#### Response
```json

    {
    "documents": [
        {
            "id": "1",
            "sentiment": "mixed",
            "confidenceScores": {
                "positive": 0.45,
                "neutral": 0.1,
                "negative": 0.45
            },
            "sentences": [
                {
                    "sentiment": "positive",
                    "confidenceScores": {
                        "positive": 0.76,
                        "neutral": 0.12,
                        "negative": 0.12
                    },
                    "offset": 0,
                    "length": 138,
                    "text": "Mesdames et Messieurs, Je me tiens devant vous aujourd'hui non pas comme un homme de succès, mais comme un homme qui aspire à la valeur4. "
                },
                {
                    "sentiment": "neutral",
                    "confidenceScores": {
                        "positive": 0.0,
                        "neutral": 0.99,
                        "negative": 0.01
                    },
                    "offset": 138,
                    "length": 114,
                    "text": "Car ce qui compte vraiment ne peut pas toujours être compté, et ce qui peut être compté ne compte pas forcément4. "
                },
                {
                    "sentiment": "neutral",
                    "confidenceScores": {
                        "positive": 0.0,
                        "neutral": 1.0,
                        "negative": 0.0
                    },
                    "offset": 252,
                    "length": 50,
                    "text": "L'imagination est plus importante que le savoir3. "
                },
                {
                    "sentiment": "neutral",
                    "confidenceScores": {
                        "positive": 0.05,
                        "neutral": 0.94,
                        "negative": 0.01
                    },
                    "offset": 302,
                    "length": 116,
                    "text": "Le savoir est limité, tandis que l'imagination englobe le monde entier, stimule le progrès et suscite l'évolution4. "
                },
                {
                    "sentiment": "negative",
                    "confidenceScores": {
                        "positive": 0.21,
                        "neutral": 0.32,
                        "negative": 0.48
                    },
                    "offset": 418,
                    "length": 109,
                    "text": "C'est pourquoi je vous encourage à cultiver votre créativité, car elle est contagieuse - faites-la tourner8. "
                },
                {
                    "sentiment": "negative",
                    "confidenceScores": {
                        "positive": 0.07,
                        "neutral": 0.04,
                        "negative": 0.89
                    },
                    "offset": 527,
                    "length": 146,
                    "text": "Il n'y a que deux façons de vivre sa vie : l'une en faisant comme si rien n'était un miracle, l'autre en faisant comme si tout était un miracle4. "
                },
                {
                    "sentiment": "neutral",
                    "confidenceScores": {
                        "positive": 0.0,
                        "neutral": 1.0,
                        "negative": 0.0
                    },
                    "offset": 673,
                    "length": 30,
                    "text": "Choisissez la seconde option. "
                },
                {
                    "sentiment": "positive",
                    "confidenceScores": {
                        "positive": 0.94,
                        "neutral": 0.06,
                        "negative": 0.0
                    },
                    "offset": 703,
                    "length": 128,
                    "text": "Émerveillez-vous devant la beauté de l'univers, car la joie de regarder et de comprendre est le plus beau cadeau de la nature8. "
                },
                {
                    "sentiment": "negative",
                    "confidenceScores": {
                        "positive": 0.01,
                        "neutral": 0.0,
                        "negative": 0.99
                    },
                    "offset": 831,
                    "length": 42,
                    "text": "N'ayez pas peur de commettre des erreurs. "
                },
                {
                    "sentiment": "negative",
                    "confidenceScores": {
                        "positive": 0.01,
                        "neutral": 0.0,
                        "negative": 0.99
                    },
                    "offset": 873,
                    "length": 74,
                    "text": "Une personne qui n'a jamais commis d'erreurs n'a jamais tenté d'innover8. "
                },
                {
                    "sentiment": "positive",
                    "confidenceScores": {
                        "positive": 0.86,
                        "neutral": 0.01,
                        "negative": 0.13
                    },
                    "offset": 947,
                    "length": 82,
                    "text": "La vie est comme une bicyclette, il faut avancer pour ne pas perdre l'équilibre2. "
                },
                {
                    "sentiment": "neutral",
                    "confidenceScores": {
                        "positive": 0.01,
                        "neutral": 0.99,
                        "negative": 0.0
                    },
                    "offset": 1029,
                    "length": 94,
                    "text": "Enfin, souvenez-vous que le monde tel que nous l'avons créé est un processus de notre pensée. "
                },
                {
                    "sentiment": "neutral",
                    "confidenceScores": {
                        "positive": 0.0,
                        "neutral": 0.98,
                        "negative": 0.01
                    },
                    "offset": 1123,
                    "length": 55,
                    "text": "Il ne peut pas être changé sans changer notre pensée8. "
                },
                {
                    "sentiment": "neutral",
                    "confidenceScores": {
                        "positive": 0.1,
                        "neutral": 0.9,
                        "negative": 0.0
                    },
                    "offset": 1178,
                    "length": 61,
                    "text": "Soyez donc le changement que vous voulez voir dans le monde. "
                },
                {
                    "sentiment": "positive",
                    "confidenceScores": {
                        "positive": 0.76,
                        "neutral": 0.24,
                        "negative": 0.0
                    },
                    "offset": 1239,
                    "length": 62,
                    "text": "Apprenez d'hier, vivez pour aujourd'hui, espérez pour demain. "
                },
                {
                    "sentiment": "neutral",
                    "confidenceScores": {
                        "positive": 0.0,
                        "neutral": 1.0,
                        "negative": 0.0
                    },
                    "offset": 1301,
                    "length": 47,
                    "text": "Et surtout, n'arrêtez jamais de questionner8.\" "
                },
                {
                    "sentiment": "neutral",
                    "confidenceScores": {
                        "positive": 0.16,
                        "neutral": 0.84,
                        "negative": 0.0
                    },
                    "offset": 1348,
                    "length": 120,
                    "text": "Ce discours imaginaire capture l'essence de la pensée d'Einstein, mêlant sa vision scientifique à sa philosophie de vie."
                }
            ],
            "warnings": []
        }
    ],
    "errors": [],
    "modelVersion": "2025-01-01"
}
```

