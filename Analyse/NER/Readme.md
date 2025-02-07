
# NER 

Une API NER qui consiste à identifier et classer des éléments spécifiques dans un texte, comme des noms de personnes, des lieux, des organisations, des dates, des quantités, etc. L'objectif est d'extraire ces informations clés pour mieux comprendre le contenu d'un texte


## API Reference

```https
  POST ${endpoint}/text/analytics/v3.0/entities/recognition/general?showStats=true`
```
#### Params

| Key | Value     | 
| :-------- | :------- | 
| `showStats` | `true` |  

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
      "text" : "Vercingétorix et Alésia\nLa bataille\n\nC’est à Alise-Sainte-Reine (Côte-d’or) qu’en 52 avant J.-C. s’est livré le siège d’Alésia qui devait mettre un terme à la guerre de libération menée par Vercingétorix et ses alliés contre les Romains entrés en Gaule.\n\nVercingétorix s’enferme sur la hauteur d’Alésia avec une armée composée, d’après César, de 12 000 cavaliers et de 80 000 fantassins. L’armée romaine, qui assiège les Gaulois, compte 10 à 12 légions, soit seulement 40 à 50 000 hommes.\n\nCésar fait établir, dans la plaine, une double ligne de fortifications renforcée par une série de camps implantés sur les plateaux environnants. La ligne interne (ou contrevallation) est destinée à empêcher les Gaulois de sortir de la place où ils se sont retranchés ; tandis que la ligne externe (ou circumvallation) doit leur interdire d’être délivrés de l’extérieur par d’autres troupes gauloises. Au total, ces ouvrages sont développés sur une longueur atteignant environ 40 kilomètres. On estime que les travaux du siège durent occuper les Romains pendant quatre à cinq semaines. Du côté gaulois, l’armée de Vercingétorix ne pouvait guère compter que sur environ un mois de vivres.\n\nAussi, Vercingétorix renvoie rapidement sa cavalerie en la chargeant de revenir avec une armée de secours. Celle-ci arrive devant Alésia avec, selon César, un contingent de 250 000 fantassins. La concentration d’hommes réunis dans cet affrontement décisif est extraordinaire : environ 400 000 combattants sont en présence, auxquels s’ajoutent la masse des civils emmenés avec les armées, les serviteurs et esclaves de l’armée romaine.\n\nLes Gaulois attaquent dans un double mouvement : à l’extérieur, l'armée de secours tente d’enfoncer les lignes romaines encerclant Alésia, tandis qu’à l’intérieur l’armée de Vercingétorix, descendue du plateau, essaie de forcer la contrevallation. Mais l’armée romaine prend les Gaulois à revers et leur coupe la retraite : la bataille d’Alésia est perdue. Le lendemain, Vercingétorix se rend. Après la reddition des Gaulois, 70 000 personnes seront déportées par les Romains, la plupart pour être données ou vendues comme esclaves. Du côté gaulois, le nombre des morts et des disparus est estimé à environ 10 000.\n\nTous les peuples de la Gaule ne sont pas venus au secours de Vercingétorix. Les monnaies retrouvées dans les fossés d’Alésia montrent que seuls les Eduens, les Bituriges, les Séquanes et les Arvernes ont entendu son appel à l’aide.\n\nLa Guerre des Gaules n’est pas celle de tous les Gaulois. Seuls les grands propriétaires terriens, qui voyaient Rome menacer leurs privilèges, souhaitent se débarrasser des Romains. Commerçants et artisans qui s’enrichissent de plus en plus au contact de Rome, espèrent ainsi se libérer de la tutelle de l’aristocratie.\n\nL’ensemble du mobilier archéologique lié au siège d’Alésia est déposé au Musée d'Archéologie nationale. La présentation des collections provenant de ce site est l’une des toutes premières à avoir été mise en oeuvre à Saint-Germain : ainsi, dès l’origine des collections, la Salle Alésia a constitué, à proprement parler, le coeur du Musée des Antiquités nationales."

    }
  ]
}
```

#### Response
```json

    "statistics": {
        "documentsCount": 1,
        "validDocumentsCount": 1,
        "erroneousDocumentsCount": 0,
        "transactionsCount": 4
    },
    "documents": [
        {
            "id": "1",
            "statistics": {
                "charactersCount": 3149,
                "transactionsCount": 4
            },
            "entities": [
                {
                    "text": "Vercingétorix",
                    "category": "Person",
                    "offset": 0,
                    "length": 13,
                    "confidenceScore": 1.0
                },
                {
                    "text": "Alésia",
                    "category": "Person",
                    "offset": 17,
                    "length": 6,
                    "confidenceScore": 0.99
                },
                {
                    "text": "bataille",
                    "category": "Event",
                    "offset": 27,
                    "length": 8,
                    "confidenceScore": 0.69
                },
                {
                    "text": "Alise-Sainte-Reine",
                    "category": "Location",
                    "subcategory": "City",
                    "offset": 45,
                    "length": 18,
                    "confidenceScore": 0.73
                },
                {
                    "text": "Côte-d’or",
                    "category": "Location",
                    "subcategory": "GPE",
                    "offset": 65,
                    "length": 9,
                    "confidenceScore": 0.94
                },
                {
                    "text": "52 avant J.-C.",
                    "category": "DateTime",
                    "subcategory": "DateRange",
                    "offset": 82,
                    "length": 14,
                    "confidenceScore": 0.88
                },
                {
                    "text": "siège d’Alésia",
                    "category": "Event",
                    "offset": 112,
                    "length": 14,
                    "confidenceScore": 0.76
                },
                {
                    "text": "un",
                    "category": "Quantity",
                    "subcategory": "Number",
                    "offset": 145,
                    "length": 2,
                    "confidenceScore": 0.8
                },
                {
                    "text": "guerre de libération",
                    "category": "Event",
                    "offset": 159,
                    "length": 20,
                    "confidenceScore": 0.91
                },
                {
                    "text": "Vercingétorix",
                    "category": "Person",
                    "offset": 190,
                    "length": 13,
                    "confidenceScore": 1.0
                },
                {
                    "text": "alliés",
                    "category": "PersonType",
                    "offset": 211,
                    "length": 6,
                    "confidenceScore": 0.89
                },
                {
                    "text": "Romains",
                    "category": "PersonType",
                    "offset": 229,
                    "length": 7,
                    "confidenceScore": 0.99
                },
                {
                    "text": "Gaule",
                    "category": "Location",
                    "subcategory": "GPE",
                    "offset": 247,
                    "length": 5,
                    "confidenceScore": 0.97
                },
                {
                    "text": "Vercingétorix",
                    "category": "Person",
                    "offset": 255,
                    "length": 13,
                    "confidenceScore": 0.99
                },
                {
                    "text": "Alésia",
                    "category": "Location",
                    "offset": 296,
                    "length": 6,
                    "confidenceScore": 0.86
                },
                {
                    "text": "une",
                    "category": "Quantity",
                    "subcategory": "Number",
                    "offset": 308,
                    "length": 3,
                    "confidenceScore": 0.8
                },
                {
                    "text": "César",
                    "category": "Person",
                    "offset": 336,
                    "length": 5,
                    "confidenceScore": 0.99
                },
                {
                    "text": "12 000",
                    "category": "Quantity",
                    "subcategory": "Number",
                    "offset": 346,
                    "length": 6,
                    "confidenceScore": 0.8
                },
                {
                    "text": "cavaliers",
                    "category": "PersonType",
                    "offset": 353,
                    "length": 9,
                    "confidenceScore": 0.99
                },
                {
                    "text": "80 000",
                    "category": "Quantity",
                    "subcategory": "Number",
                    "offset": 369,
                    "length": 6,
                    "confidenceScore": 0.8
                },
                {
                    "text": "fantassins",
                    "category": "PersonType",
                    "offset": 376,
                    "length": 10,
                    "confidenceScore": 0.98
                },
                {
                    "text": "armée romaine",
                    "category": "Organization",
                    "offset": 390,
                    "length": 13,
                    "confidenceScore": 0.6
                },
                {
                    "text": "Gaulois",
                    "category": "PersonType",
                    "offset": 421,
                    "length": 7,
                    "confidenceScore": 0.95
                },
                {
                    "text": "10 à 12",
                    "category": "Quantity",
                    "subcategory": "NumberRange",
                    "offset": 437,
                    "length": 7,
                    "confidenceScore": 0.98
                },
                {
                    "text": "légions",
                    "category": "PersonType",
                    "offset": 445,
                    "length": 7,
                    "confidenceScore": 0.74
                },
                {
                    "text": "40 à 50 000",
                    "category": "Quantity",
                    "subcategory": "NumberRange",
                    "offset": 469,
                    "length": 11,
                    "confidenceScore": 0.98
                },
                {
                    "text": "César",
                    "category": "Person",
                    "offset": 490,
                    "length": 5,
                    "confidenceScore": 0.99
                },

                .............
```

