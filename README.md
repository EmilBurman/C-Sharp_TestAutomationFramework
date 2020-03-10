# Test automation framework
This respository is a simple template project that allows for API and frontend testing. Either executed through the Nunit plattform, or through Specflow based features.

It's based on:
 - Nunit 3 
 - RestSharp
 - Selenium
 - SpecFlow
  
It is possible to split this project into a pure frontend or a pure API testing template.The project also supports Specflow and BDD, but it is optional and the other parts of the project can be used without the BDD integration.

## Getting Started
The project does not have any external dependencies, it is simply a collection of methods and classes to get a test automation framework of the ground. 

Download the repo and check the underlying chapters for more info.

### Currently supported APIs
Since this is a template project there are currently two supported APIs, chosen due to their ease of use and their inherent difference.
- https://cat-fact.herokuapp.com/#/
- http://www.omdbapi.com/

The Omdb API uses a key that is contained within the secrets in this repository. Running these tests localy requires a API key that you need to order yourself. Currently there is no way to fetch the secret from within this repository.

## Running the tests

Tests can run inside of Visual Studio through its testrunner, but can also be run through the commandline.


### Secrets and API keys

While all tests can be run, some are dependent on API keys that are only available from Github (currently). In order to run the Omdb tests without them failing a API key needs to be added to property file aptly named "Resources". The specific key name is "omdb.api.key" in order to avoid any confussion.

Currently there is no way to fetch the key from within Github and place it locally, instead the key is currently known by only one person, Emil Burman. If you wish to run the tests yourself it is recommended that you fetch your own key to the omdb API.

## Built With

* See the dependencies packages for an overview of the tools used for this project.

## Extending the framework
Currently there are no hard rules within the framework, but there are several patterns used that is recommended to continue using:
- Every API test is currently using a builder pattern to create a URI and then use that for further tests towards their API management class.
- Every API management class currently implemenents the API management interface. This is to ensure consistency between classes and adhere to the facade pattern.
- The Selenium framework uses a factory pattern to determine the needed browser. It is recommended to maintain this pattern since it eases management of the webdriver itself.
- The implementation of Selenium is built upon the Page Object Model, which decouples tests and the selenium framework itself. It is highly recommended that every extension to the selenium test suite maintains this implementation.

### Possible improvements
The current BDD implementation using Specflow is barebones, it is more of a proof of concept than anything else. If anyone would like to further this implementation please feel free to do so. 

An improvement to the logging within the framewrok is needed, where different levels can be used to trace, info and debugg certain areas.

The XML implementation is mostly a proof of concept due to the frustration of working with XML.

## Authors

* **Emil Burman** - *Initial work* - [Github](https://github.com/EmilBurman)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
