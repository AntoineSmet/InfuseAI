
# OCR 

L’OCR (*Optical Character Recognition* ou reconnaissance optique de caractères) est une technologie permettant de convertir des images de texte imprimé ou manuscrit en texte numérique exploitable.
## API Reference

```https
  POST https://westeurope.api.cognitive.microsoft.com/vision/v3.2/read/analyze
```

#### Headers

| Key | Value     |
| :-------- | :------- |
| `Ocp-Apim-Subscription-Key` | `xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx` |
|`Content-Type` | `application/json`

#### Body
```json
{
"url":"https://learn.microsoft.com/azure/ai-services/computer-vision/media/quickstarts/presentation.png"
}
```

Après l'envoi du post, consultez l'en-tête de la réponse pour récupérer l'URL de **Operation-Location**, puis effectuez une requête GET sur cette URL.

#### Response
```json

    {
    "status": "succeeded",
    "createdDateTime": "2025-02-10T13:23:28Z",
    "lastUpdatedDateTime": "2025-02-10T13:23:29Z",
    "analyzeResult": {
        "version": "3.2.0",
        "modelVersion": "2022-04-30",
        "readResults": [
            {
                "page": 1,
                "angle": 0,
                "width": 1038,
                "height": 692,
                "unit": "pixel",
                "lines": [
                    {
                        "boundingBox": [
                            130,
                            129,
                            215,
                            130,
                            215,
                            149,
                            130,
                            148
                        ],
                        "text": "9:35 AM",
                        "appearance": {
                            "style": {
                                "name": "other",
                                "confidence": 0.972
                            }
                        },
                        "words": [
                            {
                                "boundingBox": [
                                    131,
                                    130,
                                    171,
                                    130,
                                    171,
                                    149,
                                    130,
                                    149
                                ],
                                "text": "9:35",
                                "confidence": 0.993
                            },
                            {
                                "boundingBox": [
                                    179,
                                    130,
                                    204,
                                    130,
                                    203,
                                    149,
                                    178,
                                    149
                                ],
                                "text": "AM",
                                "confidence": 0.998
                            }
                        ]
                    },
                    {
                        "boundingBox": [
                            131,
                            153,
                            224,
                            153,
                            224,
                            161,
                            131,
                            160
                        ],
                        "text": "Conference room 154584354",
                        "appearance": {
                            "style": {
                                "name": "other",
                                "confidence": 0.972
                            }
                        },
                        "words": [
                            {
                                "boundingBox": [
                                    142,
                                    154,
                                    174,
                                    154,
                                    173,
                                    161,
                                    142,
                                    161
                                ],
                                "text": "Conference",
                                "confidence": 0.851
                            },
                            {
                                "boundingBox": [
                                    175,
                                    154,
                                    189,
                                    154,
                                    188,
                                    161,
                                    174,
                                    161
                                ],
                                "text": "room",
                                "confidence": 0.891
                            },
                            {
                                "boundingBox": [
                                    192,
                                    154,
                                    224,
                                    154,
                                    223,
                                    161,
                                    191,
                                    161
                                ],
                                "text": "154584354",
                                "confidence": 0.714
                            }
                        ]
                    },
                    {
                        "boundingBox": [
                            545,
                            179,
                            589,
                            180,
                            589,
                            190,
                            545,
                            189
                        ],
                        "text": "Town Hall",
                        "appearance": {
                            "style": {
                                "name": "other",
                                "confidence": 0.972
                            }
                        },
                        "words": [
                            {
                                "boundingBox": [
                                    546,
                                    180,
                                    568,
                                    180,
                                    568,
                                    190,
                                    546,
                                    190
                                ],
                                "text": "Town",
                                "confidence": 0.988
                            },
                            {
                                "boundingBox": [
                                    570,
                                    180,
                                    590,
                                    180,
                                    589,
                                    190,
                                    570,
                                    190
                                ],
                                "text": "Hall",
                                "confidence": 0.987
                            }
                        ]
                    },
                    {
                        "boundingBox": [
                            545,
                            192,
                            596,
                            193,
                            596,
                            200,
                            545,
                            199
                        ],
                        "text": "9:00 AM - 10:00 AM",
                        "appearance": {
                            "style": {
                                "name": "other",
                                "confidence": 0.972
                            }
                        },
                        "words": [
                            {
                                "boundingBox": [
                                    545,
                                    193,
                                    556,
                                    193,
                                    556,
                                    200,
                                    545,
                                    200
                                ],
                                "text": "9:00",
                                "confidence": 0.379
                            },
                            {
                                "boundingBox": [
                                    557,
                                    193,
                                    565,
                                    193,
                                    564,
                                    200,
                                    557,
                                    200
                                ],
                                "text": "AM",
                                "confidence": 0.993
                            },
                            {
                                "boundingBox": [
                                    567,
                                    193,
                                    569,
                                    193,
                                    568,
                                    200,
                                    567,
                                    200
                                ],
                                "text": "-",
                                "confidence": 0.843
                            },
                            {
                                "boundingBox": [
                                    570,
                                    193,
                                    584,
                                    193,
                                    584,
                                    200,
                                    570,
                                    200
                                ],
                                "text": "10:00",
                                "confidence": 0.854
                            },
                            {
                                "boundingBox": [
                                    586,
                                    193,
                                    593,
                                    193,
                                    593,
                                    200,
                                    585,
                                    200
                                ],
                                "text": "AM",
                                "confidence": 0.998
                            }
                        ]
                    },
                    {
                        "boundingBox": [
                            545,
                            201,
                            581,
                            202,
                            581,
                            208,
                            545,
                            208
                        ],
                        "text": "Aston Buien",
                        "appearance": {
                            "style": {
                                "name": "other",
                                "confidence": 0.972
                            }
                        },
                        "words": [
                            {
                                "boundingBox": [
                                    545,
                                    202,
                                    560,
                                    202,
                                    559,
                                    208,
                                    546,
                                    208
                                ],
                                "text": "Aston",
                                "confidence": 0.341
                            },
                            {
                                "boundingBox": [
                                    561,
                                    202,
                                    579,
                                    203,
                                    579,
                                    208,
                                    561,
                                    208
                                ],
                                "text": "Buien",
                                "confidence": 0.335
                            }
                        ]
                    },
                    {
                        "boundingBox": [
                            537,
                            258,
                            572,
                            258,
                            572,
                            265,
                            537,
                            265
                        ],
                        "text": "Daily SCRUM",
                        "appearance": {
                            "style": {
                                "name": "other",
                                "confidence": 0.972
                            }
                        },
                        "words": [
                            {
                                "boundingBox": [
                                    538,
                                    259,
                                    551,
                                    259,
                                    550,
                                    265,
                                    538,
                                    265
                                ],
                                "text": "Daily",
                                "confidence": 0.613
                            },
                            {
                                "boundingBox": [
                                    552,
                                    259,
                                    570,
                                    259,
                                    570,
                                    265,
                                    552,
                                    265
                                ],
                                "text": "SCRUM",
                                "confidence": 0.947
                            }
                        ]
                    },
                    {
                        "boundingBox": [
                            537,
                            266,
                            590,
                            266,
                            590,
                            272,
                            537,
                            272
                        ],
                        "text": "10:00 AM-11:00 AM",
                        "appearance": {
                            "style": {
                                "name": "other",
                                "confidence": 0.972
                            }
                        },
                        "words": [
                            {
                                "boundingBox": [
                                    538,
                                    267,
                                    552,
                                    267,
                                    552,
                                    273,
                                    538,
                                    273
                                ],
                                "text": "10:00",
                                "confidence": 0.931
                            },
                            {
                                "boundingBox": [
                                    553,
                                    267,
                                    577,
                                    266,
                                    578,
                                    272,
                                    554,
                                    273
                                ],
                                "text": "AM-11:00",
                                "confidence": 0.57
                            },
                            {
                                "boundingBox": [
                                    579,
                                    266,
                                    586,
                                    266,
                                    586,
                                    272,
                                    579,
                                    272
                                ],
                                "text": "AM",
                                "confidence": 0.995
                            }
                        ]

                        ....
```

