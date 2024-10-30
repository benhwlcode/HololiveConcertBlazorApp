# HololiveConcertBlazorApp

This project is a Blazor SSR web app that calls into a Web API and the instructions for the app. To see the repo page for the API itself, [click here](https://github.com/benhwlcode/HololiveConcertApiApp).

## Introduction 

This is a Blazor SSR web app that calls into the API and displays the data retrieved. The data returned are information for the live performances of the streamer group hololive and the concerts they hosted. This page will include instructions on how to use the app.

## Authentication

The homepage of `https://hololiveconcertapiblazor-demo.azurewebsites.net/` will have a green button `Authorize`. Click on it.

- If the message `Authorization Token Aquired` is displayed, the app has successfully acquired the token. 
- If an error message is displayed, the API is either offline or there is a connection issue.

## Fixing Infinite Loading

Due to the SQL database being hosted on an Azure server with the free plan, there are times that the connection will timeout. If for whatever reason that the options for the following pages and instructions continue to display the `loading...` message after some time, simply refresh the page and return to `Home` to reacquire the token. That should fix the issue

## Expired Tokens

The authentication token lasts for 10 minutes. If the token expired, simply repeat the above instructions.

## Options

After successfully acquiring a token, you can select a page on the side bar to start acquiring data.

- `Talent`: select the performer and the page will return the performances by the talent.
- `Concert`: select the concert and the page will return the performances for the concert.
- `All`: return 50 performances per page.

## Afterword

Thanks for reading, and I hope the app was interesting. You can go to [my website](https://benhwliu.com/) to check out my other projects.
