﻿namespace EMS.Common {
    using System;
    using System.Text.Json.Serialization;

    public class User {
        [JsonPropertyName("id")] public int Id { get; set; }

        [JsonPropertyName("name")] public string Name { get; set; }

        [JsonPropertyName("email")] public string Email { get; set; }

        [JsonPropertyName("gender")] public Gender Gender { get; set; }

        [JsonPropertyName("status")] public UserStatus Status { get; set; }

        [JsonPropertyName("created_at")] public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")] public DateTime UpdatedAt { get; set; }

        public bool IsSelected { get; set; }
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UserStatus {
        Active,
        Inactive
    }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Gender {
        Male,
        Female
    }
}