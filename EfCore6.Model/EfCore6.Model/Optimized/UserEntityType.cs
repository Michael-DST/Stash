﻿// <auto-generated />
using System;
using System.Reflection;
using DragonSpark.Application.Security.Identity;
using EfCore6.Model.Definition;
using EfCore6.Model.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable enable

namespace EfCore6.Model.Optimized
{
    partial class UserEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "EfCore6.Model.Entities.User",
                typeof(User),
                baseEntityType);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(int),
                propertyInfo: typeof(IdentityUser<int>).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IdentityUser<int>).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw);
            id.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var accessFailedCount = runtimeEntityType.AddProperty(
                "AccessFailedCount",
                typeof(int),
                propertyInfo: typeof(IdentityUser<int>).GetProperty("AccessFailedCount", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IdentityUser<int>).GetField("<AccessFailedCount>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            accessFailedCount.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var concurrencyStamp = runtimeEntityType.AddProperty(
                "ConcurrencyStamp",
                typeof(string),
                propertyInfo: typeof(IdentityUser<int>).GetProperty("ConcurrencyStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IdentityUser<int>).GetField("<ConcurrencyStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                concurrencyToken: true);
            concurrencyStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var created = runtimeEntityType.AddProperty(
                "Created",
                typeof(DateTimeOffset),
                propertyInfo: typeof(IdentityUser).GetProperty("Created", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IdentityUser).GetField("<Created>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            created.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var definitionId = runtimeEntityType.AddProperty(
                "DefinitionId",
                typeof(Guid?),
                nullable: true);
            definitionId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var email = runtimeEntityType.AddProperty(
                "Email",
                typeof(string),
                propertyInfo: typeof(IdentityUser<int>).GetProperty("Email", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IdentityUser<int>).GetField("<Email>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 256);
            email.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var emailConfirmed = runtimeEntityType.AddProperty(
                "EmailConfirmed",
                typeof(bool),
                propertyInfo: typeof(IdentityUser<int>).GetProperty("EmailConfirmed", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IdentityUser<int>).GetField("<EmailConfirmed>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            emailConfirmed.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var enabled = runtimeEntityType.AddProperty(
                "Enabled",
                typeof(bool),
                propertyInfo: typeof(User).GetProperty("Enabled", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(User).GetField("<Enabled>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            enabled.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var lockoutEnabled = runtimeEntityType.AddProperty(
                "LockoutEnabled",
                typeof(bool),
                propertyInfo: typeof(IdentityUser<int>).GetProperty("LockoutEnabled", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IdentityUser<int>).GetField("<LockoutEnabled>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            lockoutEnabled.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var lockoutEnd = runtimeEntityType.AddProperty(
                "LockoutEnd",
                typeof(DateTimeOffset?),
                propertyInfo: typeof(IdentityUser<int>).GetProperty("LockoutEnd", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IdentityUser<int>).GetField("<LockoutEnd>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lockoutEnd.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modified = runtimeEntityType.AddProperty(
                "Modified",
                typeof(DateTimeOffset?),
                propertyInfo: typeof(IdentityUser).GetProperty("Modified", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IdentityUser).GetField("<Modified>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            modified.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var normalizedEmail = runtimeEntityType.AddProperty(
                "NormalizedEmail",
                typeof(string),
                propertyInfo: typeof(IdentityUser<int>).GetProperty("NormalizedEmail", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IdentityUser<int>).GetField("<NormalizedEmail>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 256);
            normalizedEmail.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var normalizedUserName = runtimeEntityType.AddProperty(
                "NormalizedUserName",
                typeof(string),
                propertyInfo: typeof(IdentityUser<int>).GetProperty("NormalizedUserName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IdentityUser<int>).GetField("<NormalizedUserName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 256);
            normalizedUserName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var passwordHash = runtimeEntityType.AddProperty(
                "PasswordHash",
                typeof(string),
                propertyInfo: typeof(IdentityUser<int>).GetProperty("PasswordHash", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IdentityUser<int>).GetField("<PasswordHash>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            passwordHash.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var phoneNumber = runtimeEntityType.AddProperty(
                "PhoneNumber",
                typeof(string),
                propertyInfo: typeof(IdentityUser<int>).GetProperty("PhoneNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IdentityUser<int>).GetField("<PhoneNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            phoneNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var phoneNumberConfirmed = runtimeEntityType.AddProperty(
                "PhoneNumberConfirmed",
                typeof(bool),
                propertyInfo: typeof(IdentityUser<int>).GetProperty("PhoneNumberConfirmed", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IdentityUser<int>).GetField("<PhoneNumberConfirmed>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            phoneNumberConfirmed.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var securityStamp = runtimeEntityType.AddProperty(
                "SecurityStamp",
                typeof(string),
                propertyInfo: typeof(IdentityUser<int>).GetProperty("SecurityStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IdentityUser<int>).GetField("<SecurityStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            securityStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var twoFactorEnabled = runtimeEntityType.AddProperty(
                "TwoFactorEnabled",
                typeof(bool),
                propertyInfo: typeof(IdentityUser<int>).GetProperty("TwoFactorEnabled", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IdentityUser<int>).GetField("<TwoFactorEnabled>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            twoFactorEnabled.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var userName = runtimeEntityType.AddProperty(
                "UserName",
                typeof(string),
                propertyInfo: typeof(IdentityUser<int>).GetProperty("UserName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IdentityUser<int>).GetField("<UserName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 256);
            userName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { definitionId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { normalizedEmail });
            index0.AddAnnotation("Relational:Name", "EmailIndex");

            var index1 = runtimeEntityType.AddIndex(
                new[] { normalizedUserName },
                unique: true);
            index1.AddAnnotation("Relational:Name", "UserNameIndex");

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("DefinitionId")! },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id")! })!,
                principalEntityType);

            var definition = declaringEntityType.AddNavigation("Definition",
                runtimeForeignKey,
                onDependent: true,
                typeof(Definition),
                propertyInfo: typeof(User).GetProperty("Definition", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(User).GetField("<Definition>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "AspNetUsers");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
