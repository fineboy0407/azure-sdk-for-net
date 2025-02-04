// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ReprotectAgentDetails
    {
        internal static ReprotectAgentDetails DeserializeReprotectAgentDetails(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> biosId = default;
            Optional<string> fabricObjectId = default;
            Optional<string> fqdn = default;
            Optional<string> version = default;
            Optional<DateTimeOffset> lastHeartbeatUtc = default;
            Optional<ProtectionHealth> health = default;
            Optional<IReadOnlyList<HealthError>> healthErrors = default;
            Optional<int> protectedItemCount = default;
            Optional<IReadOnlyList<string>> accessibleDatastores = default;
            Optional<string> vCenterId = default;
            Optional<DateTimeOffset> lastDiscoveryInUtc = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("biosId"u8))
                {
                    biosId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricObjectId"u8))
                {
                    fabricObjectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fqdn"u8))
                {
                    fqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastHeartbeatUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastHeartbeatUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("health"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    health = new ProtectionHealth(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<HealthError> array = new List<HealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthError.DeserializeHealthError(item));
                    }
                    healthErrors = array;
                    continue;
                }
                if (property.NameEquals("protectedItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    protectedItemCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("accessibleDatastores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    accessibleDatastores = array;
                    continue;
                }
                if (property.NameEquals("vcenterId"u8))
                {
                    vCenterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastDiscoveryInUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastDiscoveryInUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ReprotectAgentDetails(id.Value, name.Value, biosId.Value, fabricObjectId.Value, fqdn.Value, version.Value, Optional.ToNullable(lastHeartbeatUtc), Optional.ToNullable(health), Optional.ToList(healthErrors), Optional.ToNullable(protectedItemCount), Optional.ToList(accessibleDatastores), vCenterId.Value, Optional.ToNullable(lastDiscoveryInUtc));
        }
    }
}
