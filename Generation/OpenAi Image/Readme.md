
# Generative OpenAi Dalle

DALL·E est un modèle d’intelligence artificielle développé par OpenAI, conçu pour générer des images à partir de descriptions textuelles. 
## API Reference

```https
  POST https://<nom-de-votre-instance>.openai.azure.com/openai/deployments/<nom-du-déploiement>/images/generations?api-version=2024-02-01

```

#### Params

| Key | Value     |
| :-------- | :------- |
| `api-version` | `2024-08-01-preview` |


#### Headers

| Key | Value     |
| :-------- | :------- |
| `api-key` | `xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx` |
|`Content-Type` | `application/json`

#### Body
```json
{
  "prompt": "Un tableau numérique représentant Icare dans un style cyberpunk. L’ambiance est sombre et dramatique évoquant une tragédie mythologique revisitée dans un univers high-tech.",
  "n": 1,
  "size": "1024x1024"
}

```


#### Response
```json

 {
    "created": 1739273309,
    "data": [
        {
            "content_filter_results": {
                "hate": {
                    "filtered": false,
                    "severity": "safe"
                },
                "self_harm": {
                    "filtered": false,
                    "severity": "safe"
                },
                "sexual": {
                    "filtered": false,
                    "severity": "safe"
                },
                "violence": {
                    "filtered": false,
                    "severity": "safe"
                }
            },
            "prompt_filter_results": {
                "hate": {
                    "filtered": false,
                    "severity": "safe"
                },
                "profanity": {
                    "detected": false,
                    "filtered": false
                },
                "self_harm": {
                    "filtered": false,
                    "severity": "safe"
                },
                "sexual": {
                    "filtered": false,
                    "severity": "safe"
                },
                "violence": {
                    "filtered": false,
                    "severity": "safe"
                }
            },
            "revised_prompt": "A digital painting depicting Icarus in a cyberpunk style. The atmosphere is dark and dramatic, evoking a reimagined mythological tragedy in a high-tech universe.",
            "url": "https://dalleprodsec.blob.core.windows.net/private/images/1150dba4-c04d-4869-be41-794fba773f74/generated_00.png?se=2025-02-12T11%3A28%3A39Z&sig=4DJ2jeVDvF%2B5Br%2Bk7NoE%2F7wTtM%2F633UplslO82XFaec%3D&ske=2025-02-12T00%3A06%3A58Z&skoid=e52d5ed7-0657-4f62-bc12-7e5dbb260a96&sks=b&skt=2025-02-05T00%3A06%3A58Z&sktid=33e01921-4d64-4f8c-a055-5bdaffd5e33d&skv=2020-10-02&sp=r&spr=https&sr=b&sv=2020-10-02"
        }
    ]
}
```

![Generated Picture](../OpenAi%20Image/generated_00.png)


