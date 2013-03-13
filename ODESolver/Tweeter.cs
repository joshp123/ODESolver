using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TweetSharp;
using System.Diagnostics;

namespace ODESolver
{
    class Tweeter
    {
        private TwitterService service;
        
        public Tweeter()
        {
            var _consumerKey = "J9iaXHK7R0bpKiRabxQ";
            var _consumerSecret = "Xs6XJggEvXtMVDvaYAvTLnIm13G70ymcdhwQ3J1M";

            // this authentication snippet borrowed from https://github.com/danielcrenna/tweetsharp

            service = new TwitterService(_consumerKey, _consumerSecret);

            // Step 1 - Retrieve an OAuth Request Token
            OAuthRequestToken requestToken = service.GetRequestToken();

            // Step 2 - Redirect to the OAuth Authorization URL
            // Uri uri = service.GetAuthorizationUri(requestToken);
            // Process.Start(uri.ToString());

            // Step 3 - Exchange the Request Token for an Access Token
            
            // OAuthAccessToken access = service.GetAccessToken(requestToken, verifier);
            // OAuthAccessToken generated manually through dev.twitter.com so no need for this bit since it's just me tweetin ma shit

            var access = new OAuthAccessToken();
            access.Token = "1196853272-8dPGl6g8dKA4rHrimyerE2WcJBSTKalVRngd4FN";
            access.TokenSecret = "0SJPjmnexaE5HwOPpLwxvqnrqMG3t0XQrTsH21d0WE";

            // Step 4 - User authenticates using the Access Token
            service.AuthenticateWith(access.Token, access.TokenSecret);
            // service.SendTweet(new SendTweetOptions { Status = "Hello World" });

        }

        public TwitterResponse SendTweet(string tweet)
        {
            service.SendTweet(new SendTweetOptions { Status = tweet });
            return service.Response;
        }
    }
}
