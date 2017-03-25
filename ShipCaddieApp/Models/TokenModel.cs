using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCaddieApp.Models
{
    public class TokenModelResponse
    {
        public TokenModel Data { get; set; }
        public ApiErrorModel Error { get; set; }
    }

    /// <summary>
    /// Defines a model for Tokens
    /// </summary>
    public class TokenModel
    {
        /// <summary>
        /// Access Token
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// Token Type
        /// </summary>
        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        /// <summary>
        /// Refresh Token
        /// </summary>
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Refresh Token Issued date
        /// </summary>
        [JsonProperty("refreshIssued")]
        public string RefreshIssued { get; set; }

        /// <summary>
        /// Refresh token expiration date
        /// </summary>
        [JsonProperty("RefreshExpires")]
        public string refreshExpires { get; set; }

        /// <summary>
        /// Token issued date
        /// </summary>
        [JsonProperty("tokenIssued")]
        public string TokenIssued { get; set; }

        /// <summary>
        /// Token expiration date
        /// </summary>
        [JsonProperty("tokenExpires")]
        public string TokenExpires { get; set; }

        /// <summary>
        /// Error Message
        /// </summary>
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }
}
