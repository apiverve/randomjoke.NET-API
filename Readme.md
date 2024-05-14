Random Joke API
============

Random Joke is a simple tool for getting random jokes. It returns a random joke from a collection of jokes.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [Random Joke API](https://apiverve.com/marketplace/api/randomjoke)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.RandomJoke
```

Using the Package Manager:
```
nuget install APIVerve.API.RandomJoke
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.RandomJoke
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for "APIVerve.API.RandomJoke".
5. Click on the APIVerve.API.RandomJoke package, select the appropriate version in the right-tab and click Install.


---

## Configuration

Before using the randomjoke API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The Random Joke API documentation is found here: [https://docs.apiverve.com/api/randomjoke](https://docs.apiverve.com/api/randomjoke).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
Random Joke API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new RandomJokeAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
This API does not require a Query
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response.data, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "score": 27,
    "setup": "Migraine headaches",
    "punchline": "There was this guy who constantly get migraine headaches, he tried all different type of drugs and it didn't work for him. So he decided to go to the specialist. He told the doctor about his migraine and also let him know he tried all the drugs that are available in market but they still didn't help him. Doctor said 'I know what you mean, I had the same problem, but I did something out of ordinary and it worked. Whenever I get headaches I go down on my wife and give her best oral sex. When she about to climax she squeezes my head with her thighs and its been helping me with my headaches.  And you should try it out.'  After couple of months doctor meets that guy on street and asks him I haven't seen you for long time after your visit, how's your headaches?   The guy said your technique really worked, but I just have one question who made that portrait of you and your wife top of your bed?"
  }
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the mailboxlayer website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.