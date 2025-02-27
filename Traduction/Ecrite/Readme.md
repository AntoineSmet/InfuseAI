
# Translate

Une API de traduction permet de convertir du texte d'une langue à une autre de manière automatisée. Elle reçoit un texte source et une langue cible en entrée, puis retourne le texte traduit.


## API Reference

```https
  POST https://api.cognitive.microsofttranslator.com/translate
```
#### Params

| Key | Value     | 
| :-------- | :------- | 
| `api-version` | `3.0` |  
| `to` | `fr` |  
| `from` | `el` |

Le paramètre from n'est pas obligatoire, car la langue peut être détectée automatiquement. Cependant, il est toujours préférable de le spécifier si vous connaissez la langue, afin d'éviter des erreurs telles que (chat : fr et chat : en).

#### Headers

| Key | Value     |
| :-------- | :------- |
| `Ocp-Apim-Subscription-Key` | `xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx` |
| `Ocp-Apim-Subscription-Region` | `westeurope` |
| `Content-Type` | `application/json` |

#### Body
```json
[
    {"Text":"Ἐκεῖνος ὃς ἀναβαίνει πάρα πολύ κοντά στον ἥλιο, τελικά καίγεται."}
]
```

#### Response
```json
[
    {
        "translations": [
            {
                "text": "Ce qui s’élève trop près du soleil finit par brûler",
                "to": "fr"
            }
        ]
    }
]
```

#### Langue disponible

## Langues prises en charge par l'API de traduction

| Langage | Code langue | Cloud  | Traduction de texte | Custom Translator | Détection automatique  | Dictionnaire |
|---------|------------|------------------------------------------------------------|---------------------------------|-------------------|------------------------------------|-------------|
| Afrikaans | af | ✔ | ✔ | ✔ | ✔ | ✔ |
| Albanais | sq | ✔ | ✔ | | ✔ | |
| Amharique | am | ✔ | ✔ | | ✔ | |
| Arabe | ar | ✔ | ✔ | ✔ | ✔ | ✔ |
| Arménien | hy | ✔ | ✔ | | ✔ | |
| Assamais | as | ✔ | ✔ | ✔ | ✔ | |
| Azerbaïdjanais (Latin) | az | ✔ | ✔ | | ✔ | |
| Bangla | bn | ✔ | ✔ | ✔ | ✔ | ✔ |
| Bashkir | ba | ✔ | ✔ | | ✔ | |
| Basque | eu | ✔ | ✔ | | ✔ | |
| Bhojpouri | bho | ✔ | ✔ | | | |
| Bodo | brx | ✔ | ✔ | | | |
| Bosniaque (latin) | bs | ✔ | ✔ | ✔ | ✔ | ✔ |
| Bulgare | bg | ✔ | ✔ | ✔ | ✔ | ✔ |
| Cantonais (traditionnel) | yue | ✔ | ✔ | | ✔ | |
| Catalan | ca | ✔ | ✔ | ✔ | ✔ | ✔ |
| Chinois (littéraire) | lzh | ✔ | ✔ | | | |
| Chinois (simplifié) | zh-Hans | ✔ | ✔ | ✔ | ✔ | ✔ |
| Chinois (traditionnel) | zh-Hant | ✔ | ✔ | ✔ | ✔ | |
| chiShona | sn | ✔ | ✔ | | | |
| Croate | hr | ✔ | ✔ | ✔ | ✔ | ✔ |
| Tchèque | cs | ✔ | ✔ | ✔ | ✔ | ✔ |
| Danois | da | ✔ | ✔ | ✔ | ✔ | ✔ |
| Dari | prs | ✔ | ✔ | | ✔ | |
| Maldivien | dv | ✔ | ✔ | | ✔ | |
| Dogri | doi | ✔ | | | | |
| Néerlandais | nl | ✔ | ✔ | ✔ | ✔ | ✔ |
| Anglais | en | ✔ | ✔ | ✔ | ✔ | ✔ |
| Estonien | et | ✔ | ✔ | ✔ | ✔ | |
| Féroïen | fo | ✔ | ✔ | | ✔ | |
| Fidjien | fj | ✔ | ✔ | ✔ | ✔ | |
| Filipino | fil | ✔ | ✔ | ✔ | | |
| Finnois | fi | ✔ | ✔ | ✔ | ✔ | ✔ |
| Français | fr | ✔ | ✔ | ✔ | ✔ | ✔ |
| Français (Canada) | fr-ca | ✔ | ✔ | ✔ | | |
| Galicien | gl | ✔ | ✔ | | ✔ | |
| Géorgien | ka | ✔ | ✔ | | ✔ | |
| Allemand | de | ✔ | ✔ | ✔ | ✔ | ✔ |
| Grec | el | ✔ | ✔ | ✔ | ✔ | ✔ |
| Goudjrati | gu | ✔ | ✔ | ✔ | ✔ | |
| Créole haïtien | ht | ✔ | ✔ | | ✔ | ✔ |
| Hausa | ha | ✔ | ✔ | | ✔ | |
| Hébreu | he | ✔ | ✔ | ✔ | ✔ | ✔ |
| Hindi | hi | ✔ | ✔ | ✔ | ✔ | ✔ |
| Hmong daw (latin) | mww | ✔ | ✔ | | ✔ | ✔ |
| Hongrois | hu | ✔ | ✔ | ✔ | ✔ | ✔ |
| Islandais | is | ✔ | ✔ | ✔ | ✔ | ✔ |
| Igbo | ig | ✔ | ✔ | | ✔ | |
| Indonésien | id | ✔ | ✔ | ✔ | ✔ | ✔ |
| Irlandais | ga | ✔ | ✔ | ✔ | ✔ | |
| Italien | it | ✔ | ✔ | ✔ | ✔ | ✔ |
| Japonais | ja | ✔ | ✔ | ✔ | ✔ | ✔ |
| Kannada | kn | ✔ | ✔ | ✔ | ✔ | |
| Kazakh | kk | ✔ | ✔ | | ✔ | |
| Khmer | km | ✔ | ✔ | | ✔ | |
| Coréen | ko | ✔ | ✔ | ✔ | ✔ | ✔ |
| Letton | lv | ✔ | ✔ | ✔ | ✔ | ✔ |
| Lituanien | lt | ✔ | ✔ | ✔ | ✔ | ✔ |
| Malais (latin) | ms | ✔ | ✔ | ✔ | ✔ | ✔ |
| Malayalam | ml | ✔ | ✔ | ✔ | ✔ | |
| Maltais | mt | ✔ | ✔ | ✔ | ✔ | ✔ |
| Maori | mi | ✔ | ✔ | ✔ | ✔ | |
| Marathi | mr | ✔ | ✔ | ✔ | ✔ | |
| Mongol (cyrillique) | mn-Cyrl | ✔ | ✔ | | ✔ | |
| Népalais | ne | ✔ | ✔ | | ✔ | |
| Norvégien Bokmål | nb | ✔ | ✔ | ✔ | ✔ | ✔ |
| Persan | fa | ✔ | ✔ | ✔ | ✔ | ✔ |
| Polonais | pl | ✔ | ✔ | ✔ | ✔ | ✔ |
| Portugais (Brésil) | pt | ✔ | ✔ | ✔ | ✔ | ✔ |
| Portugais (Portugal) | pt-pt | ✔ | ✔ | ✔ | | |
| Pendjabi | pa | ✔ | ✔ | ✔ | ✔ | |
| Roumain | ro | ✔ | ✔ | ✔ | ✔ | ✔ |
| Russe | ru | ✔ | ✔ | ✔ | ✔ | ✔ |
| Serbe (latin) | sr-Latn | ✔ | ✔ | ✔ | ✔ | ✔ |
| Espagnol | es | ✔ | ✔ | ✔ | ✔ | ✔ |
| Swahili (latin) | sw | ✔ | ✔ | ✔ | ✔ | ✔ |
| Suédois | sv | ✔ | ✔ | ✔ | ✔ | ✔ |
| Tamoul | ta | ✔ | ✔ | ✔ | ✔ | ✔ |
| Télougou | te | ✔ | ✔ | ✔ | ✔ | |
| Thaï | th | ✔ | ✔ | ✔ | ✔ | ✔ |
| Turc | tr | ✔ | ✔ | ✔ | ✔ | ✔ |
| Ukrainien | uk | ✔ | ✔ | ✔ | ✔ | ✔ |
| Ourdou | ur | ✔ | ✔ | ✔ | ✔ | ✔ |
| Ouzbek (latin) | uz | ✔ | ✔ | | ✔ | |
| Vietnamien | vi | ✔ | ✔ | ✔ | ✔ | ✔ |
| Gallois | cy | ✔ | ✔ | ✔ | ✔ | ✔ |
| Zoulou | zu | ✔ | ✔ | | ✔ | |


