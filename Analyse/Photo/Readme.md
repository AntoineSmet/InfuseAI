
# Image 

Le service Analyse d’images de Azure AI Vision peut extraire un large éventail de caractéristiques visuelles à partir de vos images. Par exemple, il peut déterminer si une image contient du contenu pour adultes, identifier des marques ou des objets spécifiques, ou trouver des visages humains
## API Reference

```https
  POST https://{endpoint}/vision/v3.2/analyze?visualFeatures=Categories,Tags,Description,Faces,ImageType,Color,Objects&details=Landmarks&language=en
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


#### Response
```json

    {
    "categories": [
        {
            "name": "others_",
            "score": 0.0234375
        },
        {
            "name": "object_screen",
            "score": 0.91796875
        }
    ],
    "color": {
        "dominantColorForeground": "White",
        "dominantColorBackground": "White",
        "dominantColors": [
            "White"
        ],
        "accentColor": "1E6A8C",
        "isBwImg": false,
        "isBWImg": false
    },
    "imageType": {
        "clipArtType": 0,
        "lineDrawingType": 0
    },
    "tags": [
        {
            "name": "text",
            "confidence": 0.9966012835502625
        },
        {
            "name": "clothing",
            "confidence": 0.9801061749458313
        },
        {
            "name": "person",
            "confidence": 0.9596298933029175
        },
        {
            "name": "display device",
            "confidence": 0.9490274786949158
        },
        {
            "name": "indoor",
            "confidence": 0.947483241558075
        },
        {
            "name": "wall",
            "confidence": 0.9395942091941833
        },
        {
            "name": "media",
            "confidence": 0.9306115508079529
        },
        {
            "name": "television set",
            "confidence": 0.9280921816825867
        },
        {
            "name": "led-backlit lcd display",
            "confidence": 0.9254803657531738
        },
        {
            "name": "flat panel display",
            "confidence": 0.9209462404251099
        },
        {
            "name": "furniture",
            "confidence": 0.9132540225982666
        },
        {
            "name": "lcd tv",
            "confidence": 0.8950581550598145
        },
        {
            "name": "man",
            "confidence": 0.8883928060531616
        },
        {
            "name": "television",
            "confidence": 0.8766454458236694
        },
        {
            "name": "video",
            "confidence": 0.8746979236602783
        },
        {
            "name": "multimedia",
            "confidence": 0.8719363212585449
        },
        {
            "name": "output device",
            "confidence": 0.8585697412490845
        },
        {
            "name": "computer monitor",
            "confidence": 0.8441622257232666
        },
        {
            "name": "table",
            "confidence": 0.8429544568061829
        },
        {
            "name": "screen",
            "confidence": 0.7113145589828491
        },
        {
            "name": "standing",
            "confidence": 0.7051218152046204
        },
        {
            "name": "design",
            "confidence": 0.40424397587776184
        }
    ],
    "description": {
        "tags": [
            "text",
            "person",
            "indoor",
            "electronics",
            "television",
            "standing",
            "display"
        ],
        "captions": [
            {
                "text": "a man pointing at a screen",
                "confidence": 0.5098631381988525
            }
        ]
    },
    "faces": [],
    "objects": [
        {
            "rectangle": {
                "x": 655,
                "y": 83,
                "w": 263,
                "h": 605
            },
            "object": "person",
            "confidence": 0.905
        },
        {
            "rectangle": {
                "x": 75,
                "y": 76,
                "w": 678,
                "h": 414
            },
            "object": "television",
            "confidence": 0.808,
            "parent": {
                "object": "display",
                "confidence": 0.851
            }
        }
    ],
    "requestId": "1f819da9-3091-4c4e-adb3-549c38b5c282",
    "metadata": {
        "height": 692,
        "width": 1038,
        "format": "Png"
    },
    "modelVersion": "2021-05-01"
}
```

