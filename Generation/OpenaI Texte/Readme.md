
# Generative OpenAi GPT

L'IA générative d'OpenAI, comme **GPT-4**, est un modèle avancé de traitement du langage capable de comprendre et générer du texte de manière fluide et contextuelle. Basée sur l'apprentissage profond, elle est entraînée sur de vastes ensembles de données et peut répondre à des questions, rédiger des textes, traduire des langues ou encore coder.
## API Reference

```https
  POST https://<nom-de-votre-instance>.openai.azure.com/openai/deployments/<nom-du-déploiement>/chat/completions?api-version=2024-08-01-preview

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

```json
{
    "messages": [
        {
            "role": "system",
            "content": "Tu es un assistant intelligent."
        },
        {
            "role": "user",
            "content": "Bonjour, comment vas-tu ?"
        }
    ],
    "max_tokens": 100,
    "temperature": 0.7
}
```

#### Body
```json
{
    "choices": [
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
            "finish_reason": "stop",
            "index": 0,
            "logprobs": null,
            "message": {
                "content": "Bonjour ! En tant qu'assistant intelligent, je n'ai pas d'émotions, mais je suis prêt à vous aider. Comment puis-je vous assister aujourd'hui ?",
                "role": "assistant"
            }
        }
    ],
    "created": 1739270930,
    "id": "chatcmpl-Azi6sR2BGTNClm5fLnvIlv2fLKEEm",
    "model": "gpt-35-turbo-16k",
    "object": "chat.completion",
    "prompt_filter_results": [
        {
            "prompt_index": 0,
            "content_filter_results": {
                "hate": {
                    "filtered": false,
                    "severity": "safe"
                },
                "jailbreak": {
                    "filtered": false,
                    "detected": false
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
            }
        }
    ],
    "system_fingerprint": "fp_0165350fbb",
    "usage": {
        "completion_tokens": 37,
        "prompt_tokens": 24,
        "total_tokens": 61
    }
}
```

