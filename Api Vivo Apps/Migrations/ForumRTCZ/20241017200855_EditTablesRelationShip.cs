using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vivo_Apps_API.Migrations.ForumRTCZ
{
    /// <inheritdoc />
    public partial class EditTablesRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FORUM_AVALIACAO_PUBLICACAO_FORUM_PUBLICACAO_ID_PUBLICACAO",
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO");

            migrationBuilder.DropForeignKey(
                name: "FK_FORUM_AVALIACAO_PUBLICACAO_FORUM_PUBLICACAO_SOLICITACAO_ID_PUBLICACAO",
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO");

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("2677fd8a-201e-460b-8e10-3e8c9c01489c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("51b3f383-98a6-4118-985b-7cb56c800ad9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("70792ee4-0b63-4c06-a86c-4ed463c1d23e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("723955eb-bf37-4232-b056-4b3bc2a50ed9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("7f43a799-b7a1-49cf-a34c-9b8f5e8747d3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("9288fcb6-fe87-4e8a-b46a-168a38cda267"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("a1657024-7d5e-4ca9-a7c5-f661241ef8bf"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("b3b315d5-8b6c-4c2d-937b-2734856f92b6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("c1fa5f30-348d-4296-a73b-d5927c900371"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("00180491-a286-4e13-8853-4ef512c07c37"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("0125dbc1-2fc8-4e10-9707-b25bea8a22f8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("013a6820-7d4d-42b8-a276-f2d89856be7a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("025a9a99-fe05-4a03-941c-96de2cb71b19"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("0556b6d9-9570-4889-b8c9-43b046cd2f36"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("08b97408-ddc8-47b3-a67e-a127a33fd49b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("0909293a-bbdc-456f-bc30-a48f27786b62"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("09f11f6b-4e0a-4708-b344-7deee7d0c7a6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("0dbd64bf-c1c3-4c3c-afca-a7aebabfaf7b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("0df30b0c-54b1-4766-91d5-2c914984ce52"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("124aced3-39af-45a4-8879-6b9101f9a95c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("1272ec7e-6c83-438e-b2de-f46708cd42c1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("15bdffaa-5c77-4b64-8091-a51cbc788077"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("1798bf02-1daa-43af-acae-f15220b809f5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("1945f3fc-bab8-4daa-aa29-c3e9c5cd9a35"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("1d4beae9-2c2c-4cf9-9b82-ee3684974f4f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("220f2dd5-89c8-4d4b-9df4-11026d87be16"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("22b5f9f3-ed51-41b2-9f74-7261e1c10183"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("23b2f834-a6ca-464a-84cf-74249344e1cf"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("2511e2f4-f38c-45b2-ac3c-9920c1b7ed2d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("266e2694-8d2f-4f94-ac64-e9d88473d009"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("2727831e-ba61-4672-a3ab-7df07dbe04c4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("28ef2ff6-9a3f-432b-aa7b-30e0a57f7e0b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("2a589265-bd92-4c53-9bd4-717767f18ce9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("2c68e0b5-634a-40f5-8950-c3d041e9ed0f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("2cbe8d4e-ae1d-4549-aed1-0895169d3706"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("2daec607-7fce-48be-89e1-bf79209a07fe"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("3015a19f-e037-45bf-82a6-8c89b2c39b9e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("30fed233-84d2-412d-b5c4-e21e307bb2f3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("3144d93d-09aa-4a42-8d7e-1981ae2edd3d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("344884b3-d3a9-4fb1-8e46-6da2cf4e2ed8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("34bccd68-7242-4b63-8ee3-3ad1ef1de304"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("35e6ad04-c3a8-400e-92d8-a44e213ac26a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("37c70b81-8558-46dc-8d1f-e1012387db1b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("3bcf13f7-9d0d-4004-af0a-05bd21907086"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("3bd91fba-352c-4017-928d-9cee0da87363"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("425808ce-f2d3-466b-806c-27723ea4f4f6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("43bb999f-ece6-43f6-8022-242b70d229a6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("4600a71b-db31-4d94-8782-9eaf0909679b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("4819c4f0-70f9-4b0e-bc46-be1d195dae8a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("4f56d631-3521-4b1f-b563-597fa0e97e3e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("4fa9cd14-5038-4809-8225-2a5603149a2b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("5210b97f-7cda-4d2f-b529-813ab9953ec4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("52374b74-ee7e-4765-b9a6-6b35af412c55"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("56ea8ddc-3374-4cc8-98a5-bcf3b8d8d6e7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("57a536fe-3b11-4afb-905c-f0e00c54f221"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("57e58807-53a7-446f-a91c-228fa6ed16e2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("5a1aafc9-97d8-4afb-b2a4-5f68d031f2bc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("5abb5921-a928-4a37-b2bb-f09a8c01f0a0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("5b113012-baeb-4d7f-8d8c-dec584039b5a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("5e7474a7-fc47-4b34-babf-13dc28a7d8f3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("608ccaf5-38bb-40e5-9b02-f759663b45a0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("62637e8f-802e-4747-92dc-c4939d9e168c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("6597e170-caf6-4e75-a2bf-eb479617d631"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("65b6be5b-30ee-47f0-9c37-a5d66381fb77"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("6806c5de-7704-4c94-8bee-9a0b780ce10c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("684c0e32-02ce-4c9d-a477-640df0de116d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("6d24c9a8-543d-4957-9ae1-eeb474b68cb1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("6faff85c-efad-4160-b5fb-c0a269f841f5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("7123ced9-5fa4-4151-915f-ac730de016d7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("71bc5ca4-492e-4f31-bf25-50e51472fdfb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("743eb16f-c5cf-4683-918c-25fe7df7f56c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("74ee64ca-37e0-4264-8d17-6d23d872395b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("772d6c9d-f9ac-4431-96b1-c26db8659446"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("780a11a1-7590-4ae3-b8a1-cdf6764a54cd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("7a0175bc-1f1e-47ab-a446-61dce5e87a5d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("7b19c273-607d-4642-9843-05c2aed3905e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("7f87606b-b6f1-40d0-bb0f-d315af64f85a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("819d64cd-f2e7-4528-87a3-51edcb252848"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("81e4fc76-9113-4db2-8323-389cf933805e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("8215d2ef-8091-43d4-b6d8-0660d4f5156d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("8810fa3c-7585-4bdd-9fe9-0fcf917d3781"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("8d45d58d-d73f-4824-b41e-9952d330295c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("8d55bd1c-db6a-4a8d-a519-3f2f94354615"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("8f7b44f4-7046-43cf-ac7a-28ae7da408a7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("8fd2547a-6c31-4da9-bfc5-efaefe25e45f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("92e13575-24b0-49bd-9d75-626de0e73f89"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("932a0433-9823-4156-b5af-d37a2cc5a283"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("935bab5d-0429-450c-b571-f72580ce982d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("93d9ffb4-1ba7-4fd9-be1d-2596506e7a79"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("93ee5549-b32f-47c7-ad60-16925d28de3d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("967030a6-ae5e-4d1f-8d93-79608c34bfc1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("a0d351a9-8622-4567-bdda-54b0eecaa9d9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("a1c39d81-a20f-44dc-85a3-b2e9a70537ee"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("a4428460-083d-4518-b20f-6e0826853cbc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("a468c148-8f5a-439d-903d-758264b2c502"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("a53fcd15-020a-4aa8-adec-91eb5e6b7cc5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("ad616b26-67f4-42d5-a485-de6d38daddb7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b23cad30-e32a-4dce-a4a2-6c307df9a313"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b3270037-b154-464a-ac56-00b649165b34"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b35e775c-c5c7-43ee-ad37-dcd3905f1fc0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b4545e62-8a4b-4a5a-be35-4f0ee1a62f5c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b4ef76e0-9015-478e-86bd-a84913c19695"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b9382c32-6280-4caf-a596-de2c0cda5862"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b9499cd5-d578-4dc0-9fa5-9a30b1ab5f77"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("ba62de01-5852-4a44-95a2-c3ebc1da74aa"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("bb2931fd-97c1-4aaf-a6e2-80c275030241"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("bb98fe78-ceaf-436e-b38d-516485985833"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("be210a8f-c6f3-4d26-98ad-95695ed21c01"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("bf1d8d37-590d-4a97-b68f-f78e7505efff"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("c0f15912-6a1b-488b-bda3-b2b4b3885c7d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("c119fd5a-0f6a-4fe1-8b20-ae9887aa71a5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("c63edf75-a9a4-4f55-819e-60fe76436f2d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("c6890e30-06dd-4ef9-ab22-36cc996b0db7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("c6f3d1e9-51b2-41b6-bd94-baeeeba8c081"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("c7600ce5-4338-4ba9-b8f1-6f95721aedb8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("c83cd8ec-fac2-4df2-b784-6cf415b8221f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("cb76b829-e14d-4407-bece-9e72a656b271"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("cdc23935-c83f-44ce-bbe8-c2ecd09d7a61"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("d25beb8f-5b58-42b5-9e77-8e698a91612f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("d50a71be-41eb-49b5-85b0-27fe19d3765c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("d64a54df-4dc0-43e8-921f-7d55dd8a9be7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("da15c51b-6174-4e0d-8ccb-95d1294a8432"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("dd15b101-116a-464f-80a6-613479c4385d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("e153c75f-2d28-4586-84af-74d10d7b2d2c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("e270f07a-c3b1-4f49-bce9-6604135e8e15"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("e2aac940-9abc-43b0-a342-9d65b820f2cd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("e314d157-1a24-4920-b3a8-e2ebd79c9447"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("e42e7cbc-b48d-4749-8044-5dd551373e5a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("e4cac47f-28b6-4fb3-9e3d-d1df4c00c9bd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("e59bba40-3081-4463-bd75-0d106d1d5f16"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("e5d7a4f8-afea-4b26-a576-14a3cf9cc09f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("e7eb97e1-b360-42a5-9f1a-f13d02072913"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("f0a6107d-3657-4d0d-841a-f8ec6f2bd478"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("f32e7ded-4d80-4df8-a3cc-48280cf9d5fb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("f3e1a7e7-77cf-428b-afeb-3cbca965ad16"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("f41270a7-4b9f-40a0-bef1-5c62bd0bda21"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("f82ec6c3-de2b-4331-b355-2f2c696071f9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("fc5c2929-8729-4c00-8054-e652ead777bf"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO_SOLICITACAO",
                keyColumn: "ID_SOLICITACAO_PUBLICACAO",
                keyValue: new Guid("ad85237c-8d13-44a8-863e-e97ac07c9508"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO_SOLICITACAO",
                keyColumn: "ID_SOLICITACAO_PUBLICACAO",
                keyValue: new Guid("c3c9765e-c8cf-47e8-9444-604f76ff119a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO_SOLICITACAO",
                keyColumn: "ID_SOLICITACAO_PUBLICACAO",
                keyValue: new Guid("ce0a12e2-b5cc-4fa2-85ba-484f55829c07"));

            migrationBuilder.InsertData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                columns: new[] { "ID_AVALIACAO", "AVALIACAO", "ID_PUBLICACAO", "MATRICULA_RESPONSAVEL" },
                values: new object[,]
                {
                    { new Guid("01e36c5c-8265-4683-b922-e57fc18f9945"), 2, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("08ded695-3a33-45ff-bb70-177b45a4d6eb"), 2, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("0aa8715c-6d43-48b0-837d-b65eb515d063"), 4, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("0c8c971e-b063-4b84-9ed5-d553b292d7f5"), 2, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("0e24324c-9783-46c8-97ed-96e4927fffc2"), 3, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("1074215f-dedd-41dd-b241-7fbabeb32786"), 4, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("116a95e7-42bb-4d25-a40d-c25d0f558d09"), 2, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("117265f4-4912-40ff-af95-6bcbdcfe631c"), 2, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("118a5fb0-9f1e-4545-9aa1-3271cc9adf18"), 4, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("123e053f-243e-4a28-bc45-51e9bdcc9ddd"), 1, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("12f6619e-1743-4b05-9200-7c8f777621a3"), 4, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("14498114-8be3-49c4-aaac-0b4c12254ff2"), 1, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("14aac53d-fff9-4409-abb3-90730219c433"), 3, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("165d8c41-7b55-4616-9978-a9dff6516ef8"), 3, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("16d7d8eb-a4ce-47f8-8dbb-7d18c8f4b535"), 2, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("18d4ee66-62cb-49c5-bfc4-b2f5b40c2998"), 1, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("195e541d-d070-4d8d-a022-9b2ae96523af"), 4, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("1c8c16d2-7e66-4a92-89bc-084c653ebc3d"), 2, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("1d53940f-91dd-4684-9fa8-3e52a468766b"), 4, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("1d8ac4ee-e7b1-4f00-a06e-de91cc662a66"), 3, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("1f32389b-507c-48bf-b9d2-b877fc5d6eb9"), 3, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("20fed970-726a-4b65-b8f1-bf0dc89f1133"), 1, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("21bfa636-4598-481a-acab-9c996b8e92d4"), 1, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("27533142-4358-4bea-ac81-8ff58a3dcc3c"), 4, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("289559b1-5d8d-4e0d-8232-b0d974373e58"), 1, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("296baacd-1084-453a-8d29-007e553ec33d"), 3, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("2d1c25a8-a43d-4096-94d9-fbec81c4290c"), 3, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("2e8e59ec-9432-4b03-bea7-8cb9faefe4ec"), 2, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("3288f11f-aed8-4d76-ad53-f03ef26bdbd0"), 1, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("3355f6d2-1a3d-489c-8a6d-1d60914ee78c"), 1, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("3377c89e-19b9-472e-bf7f-edd7a615773a"), 4, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("352e4d6e-ac1e-4044-93b9-f2da67b7f92e"), 1, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("3886e56e-b4a6-4d82-8f25-6fba8bfaf9c2"), 1, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("3b54e69c-610e-42d2-b6c9-d7ffccec675e"), 3, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("3cfb048a-9fc3-450b-981c-065907521b10"), 1, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("3d0502e3-786b-4736-9c84-d6349144b068"), 2, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("3d2b09dd-75af-430d-864d-70b77bedad8c"), 3, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("3de59c4a-d2fe-49a2-9736-8b205c31d70a"), 2, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("40fbc496-855f-407a-b17a-0078aed1332f"), 1, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("468fbc2c-bed6-4518-bb83-42c5ab707fa7"), 1, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("48be439a-ec30-4998-9ced-f4172555d719"), 4, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("49d0245c-1ef6-4d98-8404-32c2f33025b4"), 4, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("4b996504-eadc-4e97-8feb-d93507fe1d7d"), 3, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("4c49cc43-7db6-48cd-bee3-0eceed5b6ba3"), 4, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("4d0c5949-d02e-4c04-a4de-3a53b67627fb"), 1, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("4dbb6d6d-62f7-425b-a54b-31e593166ea4"), 1, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("5108ef47-7f5b-4f2d-866d-390078028081"), 2, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("51c666cb-a656-49a8-8196-eb6d0ce81248"), 4, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("57826438-e538-4d98-a4db-c75e52c112db"), 4, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("57aa3fdf-fad2-49e3-bf0c-9ea5a8abddb6"), 2, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("5b37d613-26bc-47ae-a60d-4afcede4fb29"), 4, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("5f2494e6-ba62-4198-aae6-da6fa976dc1b"), 4, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("602f291c-3c4f-4864-ab03-4255f4e1048c"), 1, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("6041917a-772b-4ac9-ab85-6c4709287e7a"), 2, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("62194446-ab6e-47d4-8606-d4b890b4fcbe"), 2, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("623b9725-fded-4655-a03c-98030919f174"), 3, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("626579eb-f359-487d-940d-fac4aba00c88"), 2, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("634c7467-a6d4-4714-88de-a9bc37225aa9"), 2, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("650ee645-f7f1-4846-b066-2e82992c99b4"), 2, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("68014b50-85c8-4481-9517-1c223cf9a113"), 2, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("689e8c5c-606a-4824-8fb8-6e5f20aa996b"), 3, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("6b41b30c-cfdd-4499-b0d5-1283910e774d"), 2, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("6d8300be-1e64-4dfe-b23a-5994d3cdc2e3"), 3, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("6dc1f77d-fd7a-425b-80ad-11a121a30d02"), 2, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("6eeed3ef-f891-45fe-8054-3d7c27f21974"), 3, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("6fa26ba3-6c6f-4a54-a0b7-9281cf2a9b31"), 4, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("70bbc602-a29f-4dd0-80db-dc3bbc59191b"), 4, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("70e97b69-762c-45a1-ad0d-b54e73301282"), 3, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("779a5375-c76a-4410-80a1-84338690e52b"), 3, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("78a6ead2-db1d-45a9-add9-4b25ba84242e"), 4, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("7eda9975-aee3-4fc6-aea6-23164ca7b42e"), 4, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("7f0760cc-6aba-412b-af3c-3431b8075f20"), 3, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("80ece597-4eb8-4c35-85a1-a53d6d5511cd"), 2, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("818cb4d3-2acb-4ede-ab74-58e26241c959"), 2, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("81a5f462-4a9c-4ba9-975b-8f964f5f6d15"), 4, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("829f1c89-7030-4df8-a683-e402a7cad61c"), 3, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("830a23e7-bbdf-4c5a-9be8-5d509cf87885"), 1, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("832140dc-99cb-429f-aa51-13325a7c1ceb"), 3, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("852465b2-d9a3-42db-ba4c-e93a061d89fa"), 4, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("8e36d05a-4399-4bd7-9844-e97e92e64a18"), 4, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("8ee41b55-3adb-4a15-9741-01077c428a45"), 3, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("8eebb0f1-fa11-4496-8086-aa324d42af63"), 4, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("8f109797-e066-4b45-8852-eaedfb46ae9b"), 3, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("8f87971e-04bd-473e-a0fb-1abc6d374a60"), 1, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("91c3014c-95e8-4831-80ea-e3396e9011c0"), 3, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("93550c0c-6bf6-48a5-94b5-8c46eb384866"), 3, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("9573427d-2be0-4113-afec-a4a17d87c8e4"), 3, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("96fa9bc5-ffea-4a83-8c0e-922c16d7c989"), 2, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("97a06546-547e-4ca4-bc84-48889ee76858"), 2, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("9892d8dc-c0a1-4494-9052-d5d35d120130"), 4, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("9958043f-941a-44eb-8896-f52e509f381f"), 1, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("9cae810a-2c08-46bd-bbb4-42b54a6550c1"), 2, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("9cf388e6-c4f4-4cc1-b0b1-dd21e5e6afbc"), 4, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("9db71c6c-139e-4e75-a813-6803290a3b57"), 4, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("9df57924-3f7d-446f-9dd1-98e09f8d8e0e"), 4, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("9e129e2c-a2cd-4cc7-8cd4-a5df0c3df48e"), 1, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("9e9ff5b7-f56c-45a9-b1a4-1110545596f8"), 3, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("a13f0f6c-2709-4b90-af3a-cec422d3e7df"), 2, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("a3b18598-76c9-45c7-8691-e76869c37d83"), 4, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("a41d37a5-0291-4e04-b809-cc03941a3640"), 4, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("a48b011c-90a9-4414-b4d8-7913fb0cde26"), 4, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("a579e9e9-2123-4219-9cd3-6ba9012bad15"), 3, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("a5dbf942-70a1-48a4-b121-14e58c823544"), 2, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("a610509d-2e33-4797-b6e1-c67eded35c22"), 2, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("a6802c07-2312-4be9-b14e-5d8dd825422c"), 1, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("a7739e69-9611-4626-bef5-af6b49ef592b"), 3, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("a8ff5576-df89-467a-9a4f-3c5cba9fcf40"), 3, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("aa9a8d1d-d626-4371-abdf-934e6b3a9ce8"), 1, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("ac74df97-e9f1-4df4-97a8-692d5334247d"), 3, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("aed5914d-0854-41bb-ba97-374f9daba968"), 2, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("b2a49da1-0844-4194-9673-c197de42e10c"), 4, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("b2ad9803-84a3-4d9c-919a-029ea4b98207"), 2, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("b2e3bacd-b6ee-4a93-a270-a32f122429c4"), 4, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("b488862d-19ac-4079-bfaa-01c9e75b8b0c"), 1, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("b819c724-4c8e-4937-b364-89cd2d7cd56a"), 2, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("b90842a1-d2bb-45fc-a827-e174c38638a6"), 4, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("b9801c13-2744-4067-9908-07257bffcf0d"), 4, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("bcce4268-e10d-49f1-8aaa-5ccde03555e5"), 1, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("be81eca8-99ef-49c3-863c-6e05f8b39d74"), 3, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("bed76ad9-9ce1-4ab4-9e28-3e6fdd7ba8da"), 2, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("bede888b-77b2-4d89-915e-8cb3c0d8b469"), 4, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("bf5b8c20-5ec5-419d-937f-8491a3316203"), 1, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("c0532645-45ec-45dd-93c9-88b733bffd37"), 1, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("c23a1eed-da7a-466e-b75f-56dd2bc650fc"), 2, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("c2c6d633-dc49-456b-b124-f1bdbe02ccf8"), 2, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("c2e9420b-e6e8-405d-a988-57cfe3cf1121"), 1, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("c73cc25c-9d18-4242-8151-236b852a9afc"), 3, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("c88c9041-4ab2-4e18-9463-37a109e48205"), 2, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("cba62d0d-36c1-4bed-9850-f5febc0b6c7f"), 3, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("cd74f32d-5ed7-4b31-a59f-031647874adf"), 3, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("d3411b6e-ee2d-4dfd-8e43-9ef60ee0f3fd"), 1, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("d6c5b3ef-94fa-4389-8b3c-db405189bd70"), 3, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("d761519b-0609-4da6-b54b-4bf6f80a0cf7"), 1, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("ddc1d8e9-5aaf-4b77-b392-008501d7053d"), 4, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("debd3909-4613-4a14-b233-80a230ce9e79"), 1, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("e14b4ac9-06af-43e4-b80e-fbe3f78a54c3"), 3, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("e24c739e-c484-481f-b3a2-bfbf3e223679"), 1, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("ea3e5998-7125-416b-9c0a-aa5fde4417b1"), 1, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("ebf92476-d837-4ec5-90ff-3e3e5d49a342"), 2, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("ec8bc7b1-245d-4194-b99f-272c68bd51fb"), 1, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("ed140a9a-5774-4840-8a76-dd2f838c454d"), 4, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("f1a3b22e-20ed-4699-829a-136febdf15b7"), 3, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 },
                    { new Guid("f204fe60-5d99-46a8-981d-a3a5361b1e89"), 4, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("f20daff7-f9df-42e4-b23b-f8ab37ab72a3"), 3, new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 151191 },
                    { new Guid("f5e1375d-70cf-4c9c-b2fd-fde8fa842d3d"), 4, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("f6608671-181f-4dc6-9cb4-12e13f0ee677"), 1, new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 151191 },
                    { new Guid("f9e6c5d5-606e-401c-9565-2afa5a8c98ac"), 2, new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 151191 }
                });

            migrationBuilder.InsertData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO_SOLICITACAO",
                columns: new[] { "ID_SOLICITACAO_PUBLICACAO", "HORA", "MAT_RESPONSAVEL", "SUB_TEMA", "TEXT_PUBLICACAO" },
                values: new object[,]
                {
                    { new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2363), 3511507, 21, "Apenas outro teste de publicação no fórum do Giro V" },
                    { new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2344), 80904800, 5, "Apenas um teste de publicação no fórum do Giro V" },
                    { new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2362), 156114, 102, "Apenas mais um teste de publicação no fórum do Giro V" }
                });

            migrationBuilder.InsertData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                columns: new[] { "ID_RESPONSAVEL_TEMA", "HORA", "MATRICULA_RESPONSAVEL", "SUB_TEMA" },
                values: new object[,]
                {
                    { new Guid("001fe752-a929-4ee7-a475-1946336faeea"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2745), 80796597, 53 },
                    { new Guid("00d68017-12ed-452a-9579-3a75165b8862"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2575), 80904800, 87 },
                    { new Guid("017803eb-0280-42f8-b5e9-6dab64638234"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2665), 156727, 122 },
                    { new Guid("03bd2531-97cf-4932-a376-53f527055081"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2551), 47333, 103 },
                    { new Guid("06b876a3-d5be-42a3-b6ad-28ecd9ed191a"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2944), 51336, 12 },
                    { new Guid("0838bb5c-5e80-41d2-a0ba-1500e34e5e84"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3209), 156305, 30 },
                    { new Guid("08d0e56c-4790-4ad4-8534-d92c2a4ceaba"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3061), 152001, 4 },
                    { new Guid("0b7a869f-291a-438e-b48e-2e606907fa0f"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2887), 156727, 39 },
                    { new Guid("0e8e8484-709a-4ea7-9e6a-cf28cdb232e8"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2673), 156727, 74 },
                    { new Guid("0f20aad5-e1af-4929-97f3-a97784d1a832"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2727), 25183, 51 },
                    { new Guid("107bf979-b3a4-4aa0-a79f-97ea8de897ca"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2830), 163794, 102 },
                    { new Guid("1272a904-a417-476e-8b85-18d625df5260"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2544), 160624, 128 },
                    { new Guid("12774129-8137-4b2e-918c-33c90117ecc8"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2882), 25677, 128 },
                    { new Guid("141026a5-2a50-44eb-a591-635ca2824483"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2978), 80904800, 94 },
                    { new Guid("14ca800b-aed0-486a-81f9-fc0ca5853252"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2827), 40416900, 86 },
                    { new Guid("1524d647-cedd-4ca0-a99a-1af85db0b94a"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2825), 156305, 98 },
                    { new Guid("16f02673-0f4c-49e0-8e13-a2a60872e8a1"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3123), 30722, 104 },
                    { new Guid("17dae9a6-0b79-4ed6-856b-0a566c127775"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2668), 40417113, 30 },
                    { new Guid("1a4c6c52-fdc4-43c2-8203-ef62a10fb0be"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3118), 157239, 90 },
                    { new Guid("1ab453a6-69ed-4324-9d91-3e7bdad96fd3"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2936), 30722, 66 },
                    { new Guid("1d9aaa1c-3908-4dab-80e6-71e97df82c4e"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2564), 71114, 27 },
                    { new Guid("1f7fa2d0-115f-4852-806b-e266e8eccdf6"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2608), 51336, 124 },
                    { new Guid("21354285-cb48-448d-90a7-050f02e18926"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2984), 64960, 9 },
                    { new Guid("2168be61-2b39-4019-9b35-14e693600096"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2640), 40418413, 103 },
                    { new Guid("26694fbc-a7f1-45c0-8d14-1dbfe2a28519"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2572), 80796597, 113 },
                    { new Guid("27fad6ab-a329-454a-86ae-9f0e81de73fd"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2570), 16279, 13 },
                    { new Guid("2853c8f6-3c01-4a9f-950e-5272c3ea2196"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2869), 157239, 49 },
                    { new Guid("28590727-cdb2-4a14-aa71-ba65f47e1409"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2567), 157239, 95 },
                    { new Guid("297298c3-5ab9-4e7b-9df3-63aae4f00ddb"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2591), 160624, 105 },
                    { new Guid("2a19e034-70ef-4f84-a172-44b1f1176c8f"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3051), 156114, 102 },
                    { new Guid("2a488b48-f4b5-4a86-a973-5cb6c2fdcbe2"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2689), 80904800, 98 },
                    { new Guid("2ad627b7-44f3-4de0-82f6-0949f3260ea5"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2653), 69372, 50 },
                    { new Guid("2e380e12-8a83-4180-a868-d544382147b4"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2892), 159706, 56 },
                    { new Guid("3272ec0e-76ed-4fc1-a3ec-03b28f47caf7"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2684), 156305, 22 },
                    { new Guid("33a78b3c-67f4-451a-85ff-576eb12b97b4"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2822), 40417113, 7 },
                    { new Guid("39f20962-eda7-4ef0-ba52-0e3a65acd094"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3054), 152001, 105 },
                    { new Guid("3a5eea17-953a-42b3-a462-992e92d8ec93"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2657), 156305, 73 },
                    { new Guid("3cfcbe6b-63f1-49b8-946a-53d7bc70cde2"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2807), 156114, 77 },
                    { new Guid("3f182247-86ba-4b4c-a163-2af21fc41d6f"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2741), 47333, 26 },
                    { new Guid("3fdd3906-c4fa-4b0a-9205-f102df19440f"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2735), 80886919, 16 },
                    { new Guid("41b614e4-a613-4495-85eb-047c658f39ac"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2926), 30722, 38 },
                    { new Guid("41ed41e6-89d0-4972-8d97-689eada2104d"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2662), 157239, 69 },
                    { new Guid("42038f52-fd87-43cf-9be8-be7d9dceb514"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2711), 80886919, 4 },
                    { new Guid("43f75eb6-96a7-4e65-8722-44f1532a80ed"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2949), 71114, 33 },
                    { new Guid("44a87ec6-c86d-4849-8a01-fdd63f8b153a"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2646), 40416900, 60 },
                    { new Guid("45a8a2cc-e815-4b98-8180-cca75f9b03b5"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2598), 80900909, 97 },
                    { new Guid("4757e9ae-84ea-4531-9151-718e6233a4b2"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3105), 3511507, 111 },
                    { new Guid("47a84a99-7bbc-457b-9ce8-3addd729cc61"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2549), 163794, 97 },
                    { new Guid("4866eca6-58c8-4aed-9feb-54665a966e1d"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3217), 40417113, 41 },
                    { new Guid("4dff4288-3472-4015-b87c-a55ee47b9574"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2874), 69372, 78 },
                    { new Guid("51dadea7-c098-4566-8526-7d0bc9df9a06"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3170), 71114, 82 },
                    { new Guid("5320ce4c-53cb-412e-814a-b8a016ccfb57"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2819), 156114, 22 },
                    { new Guid("53826b9f-66a9-4361-b715-50e2e252d3fe"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2812), 40416900, 109 },
                    { new Guid("55a8840d-19a0-4b86-b80f-970acd58ea9c"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2730), 152001, 65 },
                    { new Guid("5e4fcd96-337a-4034-9385-ed05bc5f9c2f"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2649), 152001, 75 },
                    { new Guid("5e8fdab4-d321-4372-a78c-73beedec51f2"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3067), 40416900, 24 },
                    { new Guid("5eb91d82-dacc-4d83-b1e4-117b33ca4d9d"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2934), 159706, 48 },
                    { new Guid("5ebd1239-1861-4aaf-bfe2-5693371cefb8"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2670), 3511507, 45 },
                    { new Guid("61bde707-9c71-4031-9279-bb23d4cc6c0d"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3120), 40417113, 36 },
                    { new Guid("64a00830-9fe7-44c5-a98f-f6194342869e"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2643), 156114, 116 },
                    { new Guid("69f7e3be-5999-4014-8f35-51795054c3b1"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2546), 3511507, 109 },
                    { new Guid("6a79f49e-c752-434c-9032-24421cfd5822"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2601), 94842, 99 },
                    { new Guid("6b386be6-47b4-43b3-80c4-041b1c6132ca"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2939), 156727, 118 },
                    { new Guid("70e6e385-77e8-416c-88e8-6debe84c3827"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2724), 47333, 53 },
                    { new Guid("7183ae9f-0c56-4e0f-b169-6264424e9e99"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2593), 51336, 116 },
                    { new Guid("738c38a8-a796-47cd-be2a-e099a9eb201a"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3158), 159706, 50 },
                    { new Guid("73eaca74-c067-44f1-abee-bac4c6a93c9c"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3174), 25677, 56 },
                    { new Guid("7b322fe6-0e2e-4656-a511-1cf2082350a8"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2686), 3511507, 117 },
                    { new Guid("7f2d15da-0b3d-44f8-adcb-9e92f5ecec15"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2557), 156727, 74 },
                    { new Guid("826aaf83-5d4a-43f3-b892-b8a6458f292d"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3179), 25183, 27 },
                    { new Guid("83967941-1b98-4e8b-acc1-554bc6377d0f"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2714), 156114, 81 },
                    { new Guid("853d770c-e698-4bf5-91a4-9f2e705de4f9"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2975), 156727, 24 },
                    { new Guid("86bbaf03-65d1-498a-ae15-0644bb52be31"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3215), 80904800, 87 },
                    { new Guid("890740f5-67dd-4a64-9b99-b6cbb1eff2e2"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3162), 160624, 78 },
                    { new Guid("8958a59c-f63c-4789-bc6b-c9b89d47fec3"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2879), 156114, 90 },
                    { new Guid("8d803616-aafc-41b4-b272-03b7fd6ca255"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2738), 25183, 95 },
                    { new Guid("8f090614-fce3-49c9-82f8-128288f6fd38"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2610), 3511507, 12 },
                    { new Guid("8fe538b0-0635-4a4b-bb85-fb4d50e910de"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2946), 80904800, 116 },
                    { new Guid("9789f75f-3411-4abf-87d6-aaab22f9828e"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2721), 16279, 98 },
                    { new Guid("97e3a789-5369-47a1-91a2-3a3a05e1b2ef"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3114), 51336, 63 },
                    { new Guid("9b373c3a-d9f1-45f2-a1d5-935b9df36718"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3167), 80886919, 78 },
                    { new Guid("9c743b5e-006b-42b1-a018-1025d698c19c"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2816), 152001, 23 },
                    { new Guid("9dafac4c-54bc-46f6-b821-d8d08786afa5"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3176), 80904800, 30 },
                    { new Guid("9f3bd394-d974-4a6b-b7cc-87eeebe3ef9d"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3069), 157239, 122 },
                    { new Guid("a2728b05-f57e-4760-8b2e-ad20dccceec1"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2982), 30722, 43 },
                    { new Guid("a45b3d54-8f6e-4cbb-b10f-3bf9965b86a7"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2660), 156305, 42 },
                    { new Guid("a52894ac-b8c1-4826-b2cc-37d2a4edc0f2"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3108), 80900909, 75 },
                    { new Guid("a7748ab2-9d9f-40ba-8394-972875ec7e88"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2799), 71114, 28 },
                    { new Guid("a91fca8a-5363-4d6e-bbf4-d1561af24d5f"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3111), 80886919, 82 },
                    { new Guid("aa4c94c8-4d53-4cb5-9276-ee742d7d8e34"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2596), 152001, 39 },
                    { new Guid("abd14d92-5108-4954-9450-7bf816d4897d"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3048), 156305, 22 },
                    { new Guid("aca86194-a919-4cb7-8ec5-2b44fedc0886"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2804), 163794, 105 },
                    { new Guid("ad8b8620-1bfb-4f8b-b5fc-ff500eb49a97"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2896), 156727, 33 },
                    { new Guid("ae56f094-791d-450d-bae5-bf16815b8c65"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2997), 47333, 43 },
                    { new Guid("aee2de2b-ddff-4fec-8935-fd72329656cc"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2582), 159706, 32 },
                    { new Guid("b0b866a3-d8ad-4b61-ae20-d1c4335503c5"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2682), 25677, 68 },
                    { new Guid("b24ddeba-6db3-4812-96f5-c61cea9b4b56"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3006), 69372, 80 },
                    { new Guid("b298d281-5e9f-4d73-9ddd-415cd9484ad4"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2586), 40416900, 111 },
                    { new Guid("b5494b17-8177-43a8-b50a-b8c658ee48a5"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3164), 163794, 28 },
                    { new Guid("b60aa6ed-37d2-4c0d-97d0-15906cb1657d"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2675), 163794, 24 },
                    { new Guid("b967b937-05e9-4850-9890-202622f55a97"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2603), 80796597, 60 },
                    { new Guid("b98e9402-d25c-4d03-9a6b-eb40498db60d"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2748), 16279, 32 },
                    { new Guid("ba8fa357-fc0b-4269-8a8e-f1dad16ce7f1"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2923), 156114, 36 },
                    { new Guid("bae61a5c-aff1-406d-b415-16b6dc3a224d"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2589), 69372, 109 },
                    { new Guid("bb0fd69b-0606-4ad0-af2c-8627a46adca9"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2877), 163794, 32 },
                    { new Guid("bc5c1f8e-4502-4551-b177-6e7528da1c37"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2987), 47333, 96 },
                    { new Guid("c5e7a1e7-e866-463c-98df-eb08883c2ddd"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2884), 69372, 116 },
                    { new Guid("c7872585-2dc3-4c9d-88a0-e9747fac629d"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2498), 16279, 70 },
                    { new Guid("c93625a6-0a52-4cb0-bcd0-f9cbe98c03a3"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2832), 3511507, 91 },
                    { new Guid("cb70a650-96e3-43b2-8154-b94a32367f08"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2929), 25677, 17 },
                    { new Guid("cdc68964-6830-4639-a7d9-2b268b163f88"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2539), 25183, 97 },
                    { new Guid("cfeb5717-0414-43e6-9902-080a31934789"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2555), 80796597, 61 },
                    { new Guid("d1aa5f41-20f2-4b63-81b8-088535e7437e"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3000), 47333, 104 },
                    { new Guid("d2684695-52eb-4f49-8c06-5e0c8b07202b"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2651), 157239, 110 },
                    { new Guid("d2a56ae0-8904-4b84-bb15-7228deac7263"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2580), 3511507, 79 },
                    { new Guid("d4cbeed1-8830-4b6c-97e8-dfdebcb43619"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3205), 80886919, 76 },
                    { new Guid("d750d2da-2217-4a5c-a041-722eec0aaa33"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2802), 40416900, 60 },
                    { new Guid("d7f70479-619e-4bad-990d-c647cc291014"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3212), 25677, 67 },
                    { new Guid("df704ddc-704a-4d2b-a287-888a6e2e23f8"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3003), 163794, 34 },
                    { new Guid("e08c2937-3e32-4040-b946-082b1ebf6075"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2716), 159706, 42 },
                    { new Guid("e0f35812-a600-4ceb-b71d-b550367474d9"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2577), 30722, 122 },
                    { new Guid("e135f5cf-7011-4411-aa89-c60bec0b18d9"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2732), 163794, 6 },
                    { new Guid("e1a683bf-4181-4d35-a6b5-2023b2a82764"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2889), 94842, 116 },
                    { new Guid("eb19fda6-6b9a-4998-9081-a948ccbb5f84"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2560), 152001, 99 },
                    { new Guid("eeda3900-4cec-46cd-85cf-e4389ee698e8"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2679), 16279, 108 },
                    { new Guid("f56f4c4f-0f38-4963-a30e-d704d9f685cd"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2810), 3458749, 67 },
                    { new Guid("fd529eb9-c48f-402a-9e81-b4790f0bb421"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(2931), 3511507, 40 },
                    { new Guid("fe3dbfa9-58e1-4323-8563-ac40e0e688ca"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3056), 163794, 126 },
                    { new Guid("ffc88170-de48-4f77-b1ad-2dba86b7ebb4"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3064), 64960, 125 }
                });

            migrationBuilder.InsertData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                columns: new[] { "ID_PUBLICACAO", "HORA", "ID_SOLICITACAO_PUBLICACAO", "MAT_SOLICITANTE", "TEXT_PUBLICACAO" },
                values: new object[,]
                {
                    { new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3364), new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 80796597, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3351), new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 40416900, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3356), new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 157239, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3358), new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 80796597, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3353), new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 152001, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3345), new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"), 80900909, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3355), new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"), 47333, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3359), new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 3458749, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), new DateTime(2024, 10, 17, 17, 8, 54, 43, DateTimeKind.Local).AddTicks(3361), new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"), 3511507, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" }
                });

            migrationBuilder.InsertData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                columns: new[] { "ID_AVALIACAO", "AVALIACAO", "ID_PUBLICACAO", "MATRICULA_RESPONSAVEL" },
                values: new object[,]
                {
                    { new Guid("009afd87-46f9-471e-af13-62946a63927b"), 3, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("01719fcb-801e-48de-a496-3103f130404b"), 1, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("01807670-0027-4f42-b91f-4f082587d07c"), 1, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("01dac2ed-a023-4973-bea1-769aa23e1607"), 2, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("023a3d29-ab41-46f6-92f5-803421d5e427"), 2, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("02ccda3c-5989-44c8-9709-ab1bdae1f22a"), 1, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("02d2a902-0f4f-477e-a50a-33676d98dd25"), 1, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("032333a7-5759-4915-83aa-be6263535125"), 3, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("0384c51c-9aea-4f9c-b81c-ae95f24c6a43"), 3, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("04475de0-12be-4be5-a62d-8dadcda1097b"), 4, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("05c92f05-7a31-4bfb-9ad3-719925ee1d76"), 2, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("06067e36-54c4-49b6-81c1-df68643df6ca"), 1, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("0882d207-9e7c-496f-8099-52c8e699930a"), 4, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("089f74a8-cec0-48da-b312-0cba0b15a923"), 4, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("094b4c68-c9e9-4c50-aec8-2a95671fb88d"), 1, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("0a53854e-036b-4b8e-8ca6-004b22db5028"), 4, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("0b65f5ff-2aa5-4d9f-8c9c-62807def9794"), 1, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("0b84edb2-eab4-47f1-a6c0-d4a61e2ab912"), 1, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("0bde8df0-23bf-4bb8-b350-34d9638aff14"), 2, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("0ee85c89-8deb-405e-ac94-83b708553700"), 2, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("0f4e555a-add0-4cf4-9d5f-1c0b8dcd0637"), 4, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("0fa49b4c-1760-4dd8-9887-c90c052d0446"), 3, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("12150332-921f-43af-b0cf-e71f4760f408"), 2, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("12f072dc-b6e6-4155-853f-91273b6950eb"), 4, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("1303f35e-8d2b-404a-a31e-d046b840a862"), 3, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("132ca337-123e-45e8-928a-b4c9904482a1"), 2, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("1370861f-80ab-4cae-a0c2-1761dc511ecc"), 1, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("13b95945-99bb-48b2-ab96-23d651ba7041"), 3, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("14a59d8f-571b-4175-ac79-06c30676adbc"), 2, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("14da3c2a-981d-4c54-877c-49d4ee837a58"), 1, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("152bc53f-265f-487d-91d5-0a86840a3f94"), 4, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("1541eaa7-be68-471b-8959-90b1fb8529c9"), 2, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("16668b92-c653-47ab-bcc6-6dc60ecb5e7c"), 4, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("16b47c94-72de-4b41-8e2c-2236e576ac84"), 4, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("16eaf2b3-7ee3-4708-b76f-7b20f6b7d61c"), 2, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("16f11cf4-893b-4580-a2d4-dceea945c8fd"), 3, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("170a06d5-591d-458f-ad45-138c33aff1d1"), 4, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("17502c8e-779d-4be8-802f-699a71f301cd"), 3, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("180dacbc-d85f-43b0-a8e9-567f6467f8af"), 1, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("1a2f6572-9c38-4fc9-9062-a35888dcb51c"), 3, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("1aa8d8e2-a438-463c-bee1-a6f0bba6b0b3"), 2, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("1b1f6d07-81d8-4550-893e-11ed141bfb26"), 1, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("1c0cc6f2-763e-4abc-96c0-c28987d6bcc1"), 3, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("1c0de1ae-6e64-49dc-913f-9f24ea087aef"), 4, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("1d10fd4b-becd-42c8-a1b0-e7f063703ffe"), 2, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("1d4da420-205c-4948-9094-51157e809b06"), 3, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("1d5d32e6-944f-4983-b4c1-acc3b0f46792"), 2, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("1dc4a902-4bbd-4ed4-a576-c5111cbbef93"), 3, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("1f26e157-9990-46b1-9ff5-01c741e8c8e9"), 1, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("1f83f966-1f6e-4653-94a2-b156d00a98dc"), 3, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("1fc72907-fc37-43b7-8608-b574fe9db9a4"), 2, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("1fe58361-d5d3-4cf6-a3c4-f1ebc5a70a89"), 1, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("2013b6d6-e04d-4bc3-8c9b-4385289f3906"), 1, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("2124b634-3d5e-4dd6-9a48-f6f4208a4e3f"), 2, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("2139fe43-bfa8-4cd6-828f-936750072438"), 3, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("2260f9f3-fabf-457c-94de-dbe773728853"), 4, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("23738cdb-c5e5-4c6f-bae4-5b5f1386740e"), 4, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("247e0aa0-f3e4-4c14-959b-2aecf86566d6"), 4, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("24955c78-1452-40a0-ad3d-7a52a5d065d3"), 2, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("25804793-acc6-432b-adab-dc8c02132ba0"), 4, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("27c8e398-745e-4d3f-b742-6ebd4bb208c2"), 3, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("2a8dfcaf-b2e3-46d7-bc1a-285e135668dd"), 3, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("2a96491c-afcd-4717-8d67-43963a36ec63"), 1, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("2ac6d2db-2985-4293-b5c7-ff6624d81fee"), 2, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("2ad1186f-91b4-4146-ae3d-72b61e7a87bc"), 4, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("2b492ba8-2129-4c3f-8a19-0232266b0fba"), 2, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("2b9f00b1-74b3-4bca-8fee-7f979d515339"), 2, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("2c4e809f-48b5-49db-b2b0-be26f715f1c8"), 2, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("2cae79ae-a9c9-48fb-b497-79f298489b7b"), 1, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("2d1f7804-d2bb-44ae-ac24-bb53a9c5b608"), 3, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("2d4d4e61-f3cc-454a-aa9a-b13637f45d15"), 3, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("2d692da4-7ec7-496d-82ee-6055d75d9be7"), 2, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("2d9bab02-cfd6-4ea6-9244-f913a193599f"), 3, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("2ddde465-cdbf-4c8c-9d1c-986079fd952f"), 3, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("2f161208-b412-4942-a8ef-2bff54ae725a"), 1, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("31918c80-dce1-4f1a-bbf5-74de4c927e67"), 2, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("31b73c71-b81b-401a-b8d4-09f5796d1bbf"), 4, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("327d9a36-b379-457c-960e-7ebb0938f7af"), 2, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("32d627da-dc8e-4a38-ae87-cb5b06a1eeca"), 3, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("32dfefa3-2847-4572-ac8f-e22b5bd4a51d"), 2, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("3374e49e-9fa8-43cf-b2a0-02e737ee2962"), 2, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("33ec1411-0dbd-45af-b60f-de35e00f34fb"), 2, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("33efa758-32e2-441e-9f0a-bd66cea8f382"), 4, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("3537fc71-96c0-4c0c-a5aa-96933809222b"), 4, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("35853c0e-d0dc-4d5d-b0ad-b072bdbd114d"), 1, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("363084e8-4961-4f0e-8504-4ed9a7ea6cd0"), 1, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("36a181c6-64f6-4e03-bf90-0ca53ec6a839"), 1, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("37494557-961d-4647-9f5f-0cbd7dd8e3c1"), 3, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("37dbc4c5-7b12-473a-ba47-e8cabcc2183c"), 3, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("38595545-4dee-4ae0-a83a-2f9331e8022e"), 1, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("38a5d776-807b-48da-aa38-be7f00b2a7a1"), 2, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("39614528-aec3-4f6e-a55a-912066455df6"), 1, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("39e3c8bc-28ef-4729-a7bc-82e393e56d9e"), 2, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("3a9d3728-8518-47b3-8518-2a305d4671bc"), 2, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("3b8de410-90a2-4f6a-863c-6579d0046ffc"), 4, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("3bb32aca-e9c2-4cc9-aea0-1fe6f76af7d6"), 1, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("3cc2ed4f-e795-4c65-ad1c-cab5abc85e26"), 2, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("3d576e9b-9f71-42de-be32-dca70805b9cf"), 1, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("3ef01ade-e280-41bb-a2d6-0f07dc812270"), 2, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("3efb05b7-a683-4302-a80a-dcc9c3d5ff88"), 3, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("3faafb01-b5cd-45ed-8322-bbee6a9b6ffc"), 3, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("40081016-0775-4e38-82a2-3116ea53f6aa"), 3, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("405eac35-4e06-4237-9829-01994bc53bf8"), 1, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("4108c4ef-dd0e-47d6-9fe0-69d45282b49c"), 1, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("41445bce-7bc7-4ca8-b29d-f3404286b7d4"), 1, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("4172252f-f925-4c59-b32c-3306a03916e1"), 3, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("419301a9-ec51-4d44-b6eb-76c875a67023"), 3, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("419493e9-cfc6-4395-9a37-6d518181be1c"), 4, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("42d1439d-babe-44b5-80d4-dafde7f19944"), 4, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("43334100-c064-43ee-9fe1-72f558b74b06"), 1, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("4335479a-73c0-4ed3-b67a-9797f7205384"), 4, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("43c15e66-4d2a-48b7-8efb-e37fe0e34777"), 2, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("440e5ac1-a70a-4ef0-80fb-55175dc11355"), 1, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("44fb8b7a-2b83-42b4-bfff-c545dca06b83"), 2, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("4595c69a-6e55-4229-845c-f0020c625e7b"), 1, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("46293153-5ddf-4557-9401-d79e4765d8cc"), 3, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("46cfdfdf-7660-4049-8553-c8063c204d1a"), 4, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("47598223-344c-4767-95ee-fab4ffa54f55"), 3, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("47708743-ed4c-44f5-a089-191900480ae8"), 4, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("47cf98e2-42e6-406b-bb5d-8b1b03fc7b0b"), 1, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("48433443-c4e8-43b9-ae60-12a61a145beb"), 2, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("484bc0ab-14c6-44af-bb8e-f1849e8ce4b6"), 4, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("4a03dffb-e5ae-41b5-9748-9fb1db8fab17"), 3, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("4a30fcaa-e99a-488b-81d0-3ba5872936e5"), 2, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("4a945490-4e96-4c23-9646-071b1ce027cc"), 3, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("4aa3e946-ca67-49fd-a994-b5b52fc50a98"), 4, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("4ab9e532-755d-4218-8f56-9a874404d503"), 4, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("4b2f73a2-52bf-4b3c-a9ee-8914a2c3a0d8"), 1, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("4b7ce08c-9def-4843-ae5b-4dad5036f50e"), 1, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("4bc34693-f129-46a0-a879-909ecd398145"), 4, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("4bcc7dbf-e9d8-4540-8289-3ce9628ff585"), 3, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("4c8a36e7-ff10-47b3-ae77-5e28d33710a6"), 2, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("4c9c7048-4e4e-48f8-b318-b9a4fd9514c3"), 3, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("4dbbe1fe-d9de-44cc-be49-5f95d492b121"), 2, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("4e347627-d631-41d3-8b51-4c116f9eb1ab"), 2, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("4e57759d-9f66-48f3-a4f1-838de4bb8497"), 3, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("51fb8bf6-1fb6-4088-be96-262bc99dfb9c"), 4, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("525e4ab5-ce13-4445-9b86-e514b37f3d99"), 2, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("54dd1e0b-4796-4043-9761-649a643b0e5f"), 2, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("5696bccc-372c-4d31-841c-b27da0875d7e"), 3, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("5851564a-8af1-4004-8ba0-8edc9e6b2df0"), 4, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("58a0e14a-aa20-42d7-a80c-4f4ec1915567"), 4, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("58a1b86b-a347-46a1-affc-18f9417fa3de"), 3, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("58e23f7c-aff6-4df2-bbd1-cfdc7a52e18a"), 3, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("596e7e81-bdfc-416a-a040-1052fc5c5f8b"), 4, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("597bf165-7c8a-4a88-897f-0b168b7c3490"), 3, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("5a4e4994-629d-4347-89f3-c5b6ea3ad35f"), 4, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("5a538abd-264a-4284-abd2-5137946edfa8"), 3, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("5b25f35f-f4cf-4d2e-b2dc-3e7da8feb223"), 4, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("5b46ffe1-0919-4875-8655-291fa1463e02"), 2, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("5b5f3443-f945-4b45-9fee-5e55bc40f3bb"), 1, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("5b786c5f-def5-4ecd-8fc9-092285ab094d"), 2, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("5c2173de-3057-4ff4-8f4e-bc66f97642bb"), 2, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("5c43282a-26f0-4d3e-b67b-820ca6514dd6"), 2, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("5cf5ce0e-9399-4c75-8699-084d75357635"), 2, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("5d0bff9b-c4db-4983-8b3a-f929a62ee45a"), 2, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("5da21990-734f-4b64-b796-44f6741f2b3c"), 2, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("5e61e56f-0233-4bab-a834-830ddf29433d"), 2, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("5ef5668d-8369-447b-8a02-6fc70c329586"), 2, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("5f6cdeb7-2554-4cf8-9271-ecd86c136b92"), 4, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("601f3dc6-e97d-4675-96f5-7ef61355d5e2"), 2, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("603e75a2-b060-483d-9676-9c24f6c92671"), 4, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("6282ca63-0d26-4eba-bf58-edcb741e9bf1"), 4, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("631f8163-c365-4789-96ac-0c99082aea4a"), 1, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("637b550e-099f-42a5-99c9-84c9a690b99d"), 3, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("64d5d086-0a49-4d59-a41a-4b030a55efdb"), 1, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("6580de69-33fe-4427-b672-0530b183f57f"), 3, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("68420d1e-decc-41d7-beb3-39fd06b2084e"), 4, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("6957569e-a677-498c-9c62-6b5355e0d756"), 4, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("697743ee-49d3-4f7a-808b-fa9550a12fc7"), 1, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("6a367c23-2e90-44a9-bebc-f82143305a83"), 1, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("6a926af7-977d-4c0b-b9f3-1d4f638c9be2"), 4, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("6b0f14e2-589c-403e-bf49-c7f71a4fa20d"), 3, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("6b242a09-1e40-456a-99b5-e3364eaedfae"), 3, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("6b4d64a2-24ac-45bd-aaa0-aef316caaa04"), 1, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("6bb431d9-f366-4939-8aa5-891a80018f5c"), 3, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("6c08e7c1-7bfc-4348-8797-8b1d85321223"), 4, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("6d1e4478-42db-44f9-8742-e9d42892413c"), 4, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("6d8ac51c-4f7b-4202-a411-289441489f71"), 2, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("6d971f9a-b647-4e66-8cf9-dba6686aaf5a"), 2, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("6efa13a2-fa0b-45f5-bbf4-bb1588720870"), 2, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("7288f0c6-ae38-4f33-b3e5-167f0eebc8fc"), 3, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("73015cd0-381d-4f5c-9206-17f27fed6d50"), 4, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("735911db-b1e7-4b5f-aa1a-2041a789f1ae"), 4, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("73d69791-ea4e-4c3c-9170-0116cfa8ee5c"), 2, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("744b7978-e3ad-43cd-a712-507eb50790d8"), 2, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("745526cf-9ab5-4218-8f11-c9e97f482bcc"), 2, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("749f6253-9001-4489-96b2-9aade6d01db9"), 2, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("74f0c983-fb23-40f4-86ba-ff49c57683e8"), 2, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("757e0e0d-8256-4523-be69-0d4f64e42c42"), 1, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("767f98f2-d7c8-4c56-836b-bcb8718f39b9"), 3, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("7696c334-574d-4aac-b2da-2f3869cd3abb"), 2, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("7708b824-ba96-4621-b194-32528f52601f"), 1, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("77665099-7061-42c3-8e43-2a37688b6505"), 2, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("778190e7-1cf1-4ecc-9e5d-b17f66e5fdf1"), 3, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("77db88ca-ef53-49e9-a0cb-f194193ee886"), 4, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("784a76bb-77bf-4860-8b31-b403f2afbaef"), 4, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("78db2d86-dd58-416f-abe6-15c6213b01ae"), 3, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("79e79403-150d-4dd7-a5f8-7a873b28d8c2"), 2, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("7a3249e6-1f5c-49a2-93cf-cd5dadff8348"), 3, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("7a506783-fd96-44e3-a7ab-9fd7cbea1384"), 3, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("7bd93609-8ade-40cf-8962-f4d7378393f6"), 2, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("7c4133d1-4f8e-4eb6-8663-2f6262b82c1e"), 4, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("7c7d9913-87e1-4626-9dfc-ea7d2be3aab8"), 3, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("7f0b289b-d766-4daa-bcdd-6ca5c67930c2"), 4, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("7f3e5665-dabe-405d-a369-a9038a1d2909"), 2, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("7f7d2615-fc2c-485b-a2d9-9f67fc362d0a"), 4, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("8026ca59-a672-4968-9bcc-181cc6266357"), 3, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("8174c0e6-1366-4757-9a38-8bb079cd8ed5"), 2, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("81e547e5-664d-47e5-ab73-b8177ca983d7"), 3, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("82d329aa-55b5-414e-a810-01d3a847be8c"), 3, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("82fa77b9-bc0b-4d47-9bd9-7e7f33b9eab1"), 4, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("83ffe861-e9df-4d3f-a2ad-e48924097257"), 4, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("84b6157f-8380-4b35-b8f9-43f3a2c57905"), 2, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("859f5db7-c42c-479e-ae14-80194673dc2c"), 4, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("86af37b9-db1c-476c-bdd4-15874d5c2658"), 3, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("86d3cc3d-c2cb-43df-b801-6ee32a7909a9"), 4, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("87c7b981-99ea-4fc5-94f3-95d3e76d9920"), 2, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("87cc5c74-5fd6-4bce-ba31-8ae846a60327"), 2, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("87d6dfbe-2c28-496a-bf6a-14e69a13e728"), 3, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("87e8c0a8-860b-4a55-8439-b4787f75e49f"), 3, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("8820562e-d0a4-45e8-85b2-9a1e4246bfb5"), 3, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("8889e53c-8fa3-4077-a186-f5e55d0b6853"), 1, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("88988c63-0187-45f0-a137-34d32f24c23c"), 1, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("889923cd-461f-44d5-b21f-ee860df62709"), 4, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("88aba398-5b26-46de-bf9f-917709f28c55"), 2, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("897c25dd-7735-4d91-bb2d-e67682f1a7a8"), 4, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("89b64ed8-d7d9-475a-a962-fdb1724ea752"), 1, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("8b56e091-3c18-4efd-949f-4fb1d5a56cab"), 3, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("8c4a6a7c-5d83-4554-8950-756c1daf9ef8"), 2, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("8d0cb317-3c30-4b09-8915-d10e88dd8fa3"), 1, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("8d4b4cda-9543-405a-a81d-8fee401468dd"), 3, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("8e1dcb8d-64dd-4922-a680-4b2637ba61b0"), 1, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("8e531098-6d04-4b59-9bbc-b92e1c995701"), 2, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("8fcda5a9-2162-409f-b0aa-efa366d7b2d2"), 4, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("8fd34b77-4443-4698-9a87-76acde3d7ce6"), 2, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("8ff55da5-897d-4bde-ba03-2f55cb9f3244"), 1, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("902968fd-d06e-49b3-89a9-519bced2e613"), 3, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("90da95a1-70f7-4f9d-bffc-57f76bec214c"), 2, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("91886ce0-ea51-4f6c-9064-3f34a1775996"), 1, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("9200e4ba-566a-43b8-ac0d-f85b68381649"), 2, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("921a7d62-8be4-487b-a77d-f6918a08a748"), 1, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("9221f53a-c4c7-4920-882a-16711c3a7a74"), 1, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("929ef0dd-e375-40f0-a0c4-987fbac704af"), 2, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("9374a3c5-9ec7-4ae5-8cb5-80cddc2c7e94"), 4, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("9396abee-4adb-41f6-bd75-e5eaf5f0bb89"), 2, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("94671791-369f-4d79-9ad8-f0a76a01fa45"), 2, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("9473f1ba-f2b0-47e5-a34c-941a0e5c5c4d"), 4, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("94921239-42d9-4e52-a0b7-b9da517f1612"), 4, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("9505a665-5e22-4896-90ad-3a4fb8feb3c5"), 1, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("955f9647-bf85-4012-bad0-e33442768ebc"), 4, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("9586d5f0-ea5d-4761-ba03-4b1de7b519a6"), 1, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("95a8ccf8-ea27-4a28-98e4-43867a95aa3d"), 2, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("95b788ef-d7cd-4d58-888e-686bdae12eb9"), 1, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("95c2359e-00ed-41e6-a2b8-49484acf6828"), 2, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("95c3b5da-07e4-40de-874c-1eac2f4013bf"), 3, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("9634ba04-f1de-4e6e-ad51-efa0259d428b"), 2, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("96813cde-3e78-4f52-82cd-d67f5ec3f9ec"), 2, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("974a3978-cd00-477e-b290-d7d3e27c2ece"), 2, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("97af6273-715c-487c-97d3-606b001e9e71"), 4, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("97eef54b-d8fb-480c-ac10-bdcdbc84f403"), 1, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("9af742f0-24de-4a3a-9855-b9334c2e6d4b"), 3, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("9b59e48f-f081-4735-bbb9-c336fef2eaab"), 4, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("9b8ea54f-e344-4936-8f27-3a49a9c9c5ad"), 1, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("9cda6d25-2278-4974-8134-05b3cc8e1d8f"), 1, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("9cf53212-3c06-4fd4-8b88-e0c31cfd4d04"), 4, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("9da02ec6-b6c2-41ee-88ac-9db5eaf739a7"), 1, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("9dc7381d-0fef-4914-b8ca-0e06a0916c5e"), 1, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("9f7c830e-189c-442c-a79a-763a10ab9ce4"), 3, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("9fb00353-6bdf-4a58-afe1-99a50bc229dc"), 2, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("9fb443cb-1e3b-4a7e-b51c-cc85c4c3e43a"), 2, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("a0078c4a-a41c-4b04-a980-c7945090734a"), 2, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("a08fa451-0290-4bcf-bed5-d69252c8e1aa"), 4, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("a22cbecc-9792-49d8-8869-a709cb8aa282"), 4, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("a25cde85-280f-412c-a805-33fa37e1d3c5"), 1, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("a26efec9-5908-4853-96e6-d97f9ea4da8e"), 1, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("a27bd56d-7e02-48cd-8ae0-825f492f3450"), 1, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("a2f2f3cc-bd8c-43ed-8065-565b7f89c5ed"), 4, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("a3f7bc2c-3a27-4e8e-b378-946b23dee857"), 4, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("a46e4019-b83b-47b5-b1fa-ba072a4f40fb"), 1, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("a4da80c9-3bb8-4f4e-becb-a5663ac973e8"), 3, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("a5d035ad-eb56-42bd-a202-826341aa6ea6"), 2, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("a63d11a8-58ed-4295-9ab5-6ac026f1d3db"), 4, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("a66035de-1011-4ce4-a018-c37d356b4bfd"), 2, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("a6abb135-f4ff-42ef-aa07-a95422dabd44"), 3, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("a71a4832-6847-44b1-84ee-a395fe3cf4cb"), 2, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("a863d596-2421-4c70-9474-80755cd108aa"), 4, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("a8d5725c-e3ad-494d-9e5a-1d0a0a781475"), 3, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("a922d531-db2f-4504-bb46-dfeddf114b90"), 4, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("aa812ae0-0471-440a-b6be-e8952e23b25f"), 3, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("aac0e77c-195a-4120-94ed-6ad20e68db1b"), 2, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("abd0b3cc-8bc4-43f8-8ff5-fee040077a2a"), 2, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("ac0ee13d-8f38-4e6a-aa86-f8206576a7e6"), 4, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("ac351aa5-a017-4bb0-9051-2067d9fa6d07"), 3, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("ac7a3784-b679-47bf-85c7-cff78ec9bc43"), 2, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("ac8b7de6-e9c1-425d-a304-b1286746b5e8"), 3, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("ad7302e1-77fd-453c-af40-a1f2db21b1b5"), 4, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("ad89d55a-26a0-43d1-a003-7e97497aab73"), 2, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("ad929d0c-3bd4-4784-8f45-0cb8a19048b2"), 2, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("adce716b-12b4-47b6-a856-45b1da223279"), 4, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("aeb21bf0-2a15-4f27-a699-8ce4e9061728"), 4, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("af0a5d1d-f171-482f-b284-48744d5b5a5b"), 1, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("b07ed85a-8035-4f63-b1ab-9f3e9853e836"), 3, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("b0b79510-5ff2-4a19-98fa-deb1962b10b8"), 4, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("b0c40669-e219-4938-90f4-f445fcf58855"), 4, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("b0ca410f-95c5-451d-bda9-687665472213"), 1, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("b13921a2-29f1-449b-8d37-dab35a3379bf"), 2, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("b1e57ccb-87fc-4c49-8f9f-e0d6f8a4bb01"), 4, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("b295a809-5086-403f-9cac-f4807db2371b"), 4, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("b2e06ea7-270a-4396-afcb-441caa6aafe3"), 3, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("b415b0a1-a043-4450-8d72-17d9838c29dc"), 4, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("b4f1f90c-c691-4b71-9217-059fbf790022"), 4, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("b59bdc7a-1832-4117-8fac-6ef8f45b7d5e"), 3, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("b5f4b100-5ddf-4a9c-9865-680406294393"), 3, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("b61ed1ab-c2fa-48da-914c-1e54cab07a4f"), 2, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("b700d965-98b6-4e45-8db6-bc7afbcbceea"), 1, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("b7731d50-6da3-485a-90cf-c4121ac64664"), 3, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("b8b1804b-2484-4d36-b23c-b600b5165591"), 1, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("b9d825fa-4ef8-4390-addc-7a1b10c4cac9"), 1, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("ba813fda-5387-4bc8-ba76-7f74f011b047"), 1, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("ba919e32-92c5-490f-889b-c840fe0c0ee0"), 1, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("bb75fea8-e5e8-4eab-9583-8ee9ee2eecba"), 1, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("bbc74261-f7c0-4277-bf65-4614e0c1c887"), 3, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("bc67da3b-e794-4b90-a73c-37c3d5507f03"), 4, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("bc883a6b-85ac-4b70-8691-4e9bfda2c214"), 2, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("bc8d8eec-ba4d-40bb-bed0-1204539a3f37"), 4, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("bcd67caf-1a4b-4a67-a62e-e300d4f046af"), 2, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("bd0417d1-6809-4255-b1da-2e49f2c7b133"), 2, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("bd4afb44-761f-4779-b617-c17267a3f2e3"), 1, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("bde5d714-b5ce-4bca-a84e-4feb1192a810"), 1, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("be032fb1-9611-4301-9e6a-b0a279fd1ac5"), 3, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("bf40d8ca-7297-4224-ae02-a1cbe3e8cf71"), 4, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("c00334c6-e98c-4fad-ace8-3aae1fc321d6"), 2, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("c12f276d-bad2-496d-bc95-3420eb502dfa"), 4, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("c1c49ed7-c967-4ee5-a8cc-9277c10d3fce"), 2, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("c1eabce9-8d42-4131-84dc-89fab41bf56c"), 2, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("c2258bb3-5a77-4635-9b9c-5b04b476da01"), 1, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("c272a2fa-f857-4c49-92e5-7cc50c81326f"), 4, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("c2dae795-d713-42f0-9a85-db77f3082974"), 3, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("c32aad31-99d3-45e4-942d-28e4ddc0c103"), 4, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("c34fcae7-7354-4134-9d76-fd3af03b7108"), 3, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("c374addf-0afe-44c2-a1d3-1e50491ed230"), 4, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("c42c2ccd-8b70-43a7-b2cf-2bb9b6939244"), 4, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("c4eebb60-4efa-4b9c-920a-b59d3370d30c"), 3, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("c563ca22-7923-436b-b5b4-a544341836f2"), 3, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("c598431c-4c09-4c95-be16-c761d4a15cb3"), 2, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("c5beeec3-e991-42de-9e18-2742194c74ef"), 1, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("c663a904-f7a5-4770-8945-b855e27449c3"), 1, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("c6667d65-ab82-451d-be34-0923dee76f08"), 2, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("c6991938-3bd8-43d0-99bd-bbe07336600a"), 4, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("c79102a0-3b0f-4453-898e-9565357a760c"), 2, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("c89efa49-3044-4eb1-8f9e-5e543eb32b4a"), 2, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("c8a5c546-fc34-43ef-b1cb-4569a7556300"), 2, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("c8f55014-6e2a-4429-8c28-dd0137100d79"), 3, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("c9215e13-7c13-4e25-ab3f-9f2c6c799e8b"), 4, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("ca8eab25-f0a4-4cd1-a173-a00ea16275af"), 4, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("caa797b8-37e1-4ceb-9fb3-377a608937b9"), 4, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("caff111e-7f5c-4b59-8f44-4c23672c6e45"), 3, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("cb16f8ba-ca4a-417a-85ea-635b8b1fc446"), 3, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("cb428c65-a945-43f9-8206-0cd07617bb0a"), 4, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("cbe75886-3163-4552-9ef8-049942e66d86"), 3, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("cc5cbb1e-c696-4a84-b236-88ed9e6ecc21"), 4, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("cdc63df5-9ec2-47a2-be49-185c3b5f6c22"), 2, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("ce4fb876-5b0c-438a-a1be-03897ac2f806"), 4, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("cfca8a85-7331-49bb-8c29-01511c9730b2"), 1, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("d029db35-2741-48a7-933f-41ec69c0a2b8"), 4, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("d0f32fbb-c54c-4960-b2c8-ba99ffc5c206"), 1, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("d1c95a0c-874b-43f6-8dc6-d5e02a492b73"), 1, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("d2247fdd-2c59-4dbd-ab82-af0ac9b544e7"), 3, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("d25cbe8c-f9c7-4a85-a45f-09725273728b"), 4, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("d453f205-b6ba-433f-8191-a7ea331ab4f8"), 4, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("d4dfe969-eb15-4280-a6e6-dfcc32da3e90"), 2, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("d5cd963c-b2bb-413a-bbbe-32f02723097a"), 2, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("d68b694e-d7ae-482f-88f0-418101c04f62"), 4, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("d77d34f0-443a-4241-98cc-e03820dfe12a"), 2, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("d81e94cc-c375-4b54-bae5-bb1d5a0d6147"), 1, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("d86e3e8c-b860-4603-8362-1d9a834f25f6"), 4, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("da5137cc-4b43-47cf-96d1-58e4568beb0b"), 3, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("da5c2fa6-0e39-4489-8bb8-75a95530e9c3"), 1, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("dc24bd14-a88c-4f13-a0f2-cc2a3b83a5f5"), 3, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("dc5b780b-6eea-4c1c-8629-14ecec9d021f"), 1, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("dd35220b-9984-4db7-a307-b079d33d3393"), 1, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("dddada7a-2787-4676-94a8-ad32220d0783"), 3, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("deecee69-7e5c-4482-9772-291551de3a8c"), 2, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("dff8507b-9014-4502-8f1b-37089767d354"), 2, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("e028cfa2-97ca-4ce6-a792-7b5e98d1e2e7"), 4, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("e2390253-1c03-40d5-8f57-ec81942e932d"), 1, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("e28a46b2-07da-4052-bf3a-fce5e1ee0f6d"), 2, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("e2c21dba-20fb-4b21-bb9e-8a244f00592b"), 2, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("e3ac0de4-9cdf-4748-aced-011cf2632308"), 2, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("e3c32333-64ee-4643-a8b0-f3bf706304fb"), 3, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("e43c2b70-113d-4284-b829-0888fa803f40"), 3, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("e5616191-8ef6-4f64-bf8f-2409c8e39c56"), 4, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("e57c5b7c-6fb6-4ade-881f-19405e890397"), 1, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("e62337cf-dc10-4daa-84b1-85be5f5053d5"), 2, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("e69b2162-e6c8-406d-b877-c53b1ef1f051"), 2, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("e7749750-8bca-4b94-b096-216000b2a629"), 4, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("e84ce6d9-fda6-4edc-8aab-85f8fb0cd6ab"), 1, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("e86c9c42-01f7-446f-80ea-68469441ef1c"), 2, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("e93e5350-3342-4ba7-930c-5f88b7500326"), 2, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("e96b1e57-2eef-453b-a649-0848bd94a7d8"), 1, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("e9e78a1c-e701-432d-af5a-11fa899dcf55"), 2, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("eb5f774b-c02d-4427-962e-5700bfeda027"), 1, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("ebf64da0-9107-4b4d-abec-89b22ebeceab"), 1, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("ec14ebbc-fdcb-4a3e-92af-f55da291b69e"), 3, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("ec1b8d8d-87f3-4a80-91e3-710441cbdec7"), 4, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("ec5efb92-2b11-441f-a9f2-e5a724081452"), 1, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("ed688951-23c9-47d1-b822-2d9d9bd9d891"), 4, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("edc1ae65-404d-41db-abb6-dca3721f0e39"), 4, new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"), 151191 },
                    { new Guid("ee88e35c-4832-4158-8e4b-eef35f0ceeb9"), 3, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("eea5eb1d-1415-436e-90b1-319f41111de0"), 2, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("eed7d633-5927-4bb3-a4c9-4586a06958ea"), 1, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("ef0cad31-b179-49f1-8f3f-db18db8269ec"), 2, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("ef18c0d6-0502-4a05-9422-70cfe689e861"), 1, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("f0386f3d-0542-469c-9fa6-810706c6f347"), 3, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("f1206d20-a07b-4c5c-b297-779fba7ceb88"), 3, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("f1a5566b-ff14-433b-bab1-3307c06798fd"), 4, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("f2561f5c-2f31-4af0-ad21-c40239c0bc46"), 4, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("f2607164-7e79-44de-96af-63eb3489db18"), 3, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("f30fdc4d-9171-4bf9-976c-84772276c806"), 3, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("f363dbff-1a55-4738-a715-0059bf617a41"), 4, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("f38e746c-d2dd-42c6-ab0f-d71f398f1432"), 3, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("f4209af6-5263-47ea-a31b-98f3f89117da"), 4, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("f4258092-a0e8-4062-8d96-be78c91d68fa"), 3, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("f4271c0c-259b-4748-83ef-c9a5da3d0fe0"), 4, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("f4d74735-12bc-49ab-9dc4-7b0cfe353bff"), 4, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("f4ff1d84-8884-47ec-a6a3-00729ffcc214"), 1, new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"), 151191 },
                    { new Guid("f54aa4ed-e203-49b1-ad12-f20b5ee119e0"), 4, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("f577004e-0509-483b-ad79-075f18c8e93f"), 3, new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"), 151191 },
                    { new Guid("f6e15158-a96b-450f-887c-5a50bde64a96"), 1, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("f955cf6b-577f-4acb-90ea-249cba2a3a50"), 1, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("fa18a7ba-585b-455e-8253-5976716b2a31"), 4, new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"), 151191 },
                    { new Guid("fa3da13e-1df6-41ec-b02b-bc1d1a4dce55"), 4, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("faf12b3c-8ce2-4a8b-9ee0-dc6c9a2b4bb4"), 4, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("fb2d18ae-8517-4689-8510-46955a655c1d"), 1, new Guid("54949878-23e3-48c1-ae69-76157933c3eb"), 151191 },
                    { new Guid("fba8d927-63f7-4878-9090-d28f08a3e7d2"), 2, new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"), 151191 },
                    { new Guid("fcce5510-fe8e-429e-a95a-335cd26b5e69"), 4, new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"), 151191 },
                    { new Guid("fdbeac72-fc58-445c-b484-8323ff9548cc"), 3, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 },
                    { new Guid("fe125f84-0808-4bfc-aa08-ed2f54005813"), 3, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("ff492bdb-b79a-487f-a997-ae490d316cc5"), 3, new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"), 151191 },
                    { new Guid("ffcbe789-cc91-4a0b-9067-71f00a77dfcd"), 3, new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"), 151191 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_FORUM_AVALIACAO_PUBLICACAO_FORUM_PUBLICACAO_ID_PUBLICACAO",
            //    schema: "Fórum",
            //    table: "FORUM_AVALIACAO_PUBLICACAO");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_FORUM_AVALIACAO_PUBLICACAO_FORUM_PUBLICACAO_SOLICITACAO_ID_AVALIACAO",
            //    schema: "Fórum",
            //    table: "FORUM_AVALIACAO_PUBLICACAO");

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("009afd87-46f9-471e-af13-62946a63927b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("01719fcb-801e-48de-a496-3103f130404b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("01807670-0027-4f42-b91f-4f082587d07c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("01dac2ed-a023-4973-bea1-769aa23e1607"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("01e36c5c-8265-4683-b922-e57fc18f9945"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("023a3d29-ab41-46f6-92f5-803421d5e427"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("02ccda3c-5989-44c8-9709-ab1bdae1f22a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("02d2a902-0f4f-477e-a50a-33676d98dd25"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("032333a7-5759-4915-83aa-be6263535125"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0384c51c-9aea-4f9c-b81c-ae95f24c6a43"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("04475de0-12be-4be5-a62d-8dadcda1097b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("05c92f05-7a31-4bfb-9ad3-719925ee1d76"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("06067e36-54c4-49b6-81c1-df68643df6ca"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0882d207-9e7c-496f-8099-52c8e699930a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("089f74a8-cec0-48da-b312-0cba0b15a923"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("08ded695-3a33-45ff-bb70-177b45a4d6eb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("094b4c68-c9e9-4c50-aec8-2a95671fb88d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0a53854e-036b-4b8e-8ca6-004b22db5028"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0aa8715c-6d43-48b0-837d-b65eb515d063"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0b65f5ff-2aa5-4d9f-8c9c-62807def9794"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0b84edb2-eab4-47f1-a6c0-d4a61e2ab912"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0bde8df0-23bf-4bb8-b350-34d9638aff14"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0c8c971e-b063-4b84-9ed5-d553b292d7f5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0e24324c-9783-46c8-97ed-96e4927fffc2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0ee85c89-8deb-405e-ac94-83b708553700"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0f4e555a-add0-4cf4-9d5f-1c0b8dcd0637"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0fa49b4c-1760-4dd8-9887-c90c052d0446"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1074215f-dedd-41dd-b241-7fbabeb32786"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("116a95e7-42bb-4d25-a40d-c25d0f558d09"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("117265f4-4912-40ff-af95-6bcbdcfe631c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("118a5fb0-9f1e-4545-9aa1-3271cc9adf18"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("12150332-921f-43af-b0cf-e71f4760f408"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("123e053f-243e-4a28-bc45-51e9bdcc9ddd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("12f072dc-b6e6-4155-853f-91273b6950eb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("12f6619e-1743-4b05-9200-7c8f777621a3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1303f35e-8d2b-404a-a31e-d046b840a862"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("132ca337-123e-45e8-928a-b4c9904482a1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1370861f-80ab-4cae-a0c2-1761dc511ecc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("13b95945-99bb-48b2-ab96-23d651ba7041"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("14498114-8be3-49c4-aaac-0b4c12254ff2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("14a59d8f-571b-4175-ac79-06c30676adbc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("14aac53d-fff9-4409-abb3-90730219c433"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("14da3c2a-981d-4c54-877c-49d4ee837a58"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("152bc53f-265f-487d-91d5-0a86840a3f94"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1541eaa7-be68-471b-8959-90b1fb8529c9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("165d8c41-7b55-4616-9978-a9dff6516ef8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("16668b92-c653-47ab-bcc6-6dc60ecb5e7c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("16b47c94-72de-4b41-8e2c-2236e576ac84"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("16d7d8eb-a4ce-47f8-8dbb-7d18c8f4b535"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("16eaf2b3-7ee3-4708-b76f-7b20f6b7d61c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("16f11cf4-893b-4580-a2d4-dceea945c8fd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("170a06d5-591d-458f-ad45-138c33aff1d1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("17502c8e-779d-4be8-802f-699a71f301cd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("180dacbc-d85f-43b0-a8e9-567f6467f8af"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("18d4ee66-62cb-49c5-bfc4-b2f5b40c2998"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("195e541d-d070-4d8d-a022-9b2ae96523af"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1a2f6572-9c38-4fc9-9062-a35888dcb51c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1aa8d8e2-a438-463c-bee1-a6f0bba6b0b3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1b1f6d07-81d8-4550-893e-11ed141bfb26"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1c0cc6f2-763e-4abc-96c0-c28987d6bcc1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1c0de1ae-6e64-49dc-913f-9f24ea087aef"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1c8c16d2-7e66-4a92-89bc-084c653ebc3d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1d10fd4b-becd-42c8-a1b0-e7f063703ffe"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1d4da420-205c-4948-9094-51157e809b06"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1d53940f-91dd-4684-9fa8-3e52a468766b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1d5d32e6-944f-4983-b4c1-acc3b0f46792"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1d8ac4ee-e7b1-4f00-a06e-de91cc662a66"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1dc4a902-4bbd-4ed4-a576-c5111cbbef93"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1f26e157-9990-46b1-9ff5-01c741e8c8e9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1f32389b-507c-48bf-b9d2-b877fc5d6eb9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1f83f966-1f6e-4653-94a2-b156d00a98dc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1fc72907-fc37-43b7-8608-b574fe9db9a4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1fe58361-d5d3-4cf6-a3c4-f1ebc5a70a89"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2013b6d6-e04d-4bc3-8c9b-4385289f3906"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("20fed970-726a-4b65-b8f1-bf0dc89f1133"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2124b634-3d5e-4dd6-9a48-f6f4208a4e3f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2139fe43-bfa8-4cd6-828f-936750072438"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("21bfa636-4598-481a-acab-9c996b8e92d4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2260f9f3-fabf-457c-94de-dbe773728853"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("23738cdb-c5e5-4c6f-bae4-5b5f1386740e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("247e0aa0-f3e4-4c14-959b-2aecf86566d6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("24955c78-1452-40a0-ad3d-7a52a5d065d3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("25804793-acc6-432b-adab-dc8c02132ba0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("27533142-4358-4bea-ac81-8ff58a3dcc3c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("27c8e398-745e-4d3f-b742-6ebd4bb208c2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("289559b1-5d8d-4e0d-8232-b0d974373e58"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("296baacd-1084-453a-8d29-007e553ec33d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2a8dfcaf-b2e3-46d7-bc1a-285e135668dd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2a96491c-afcd-4717-8d67-43963a36ec63"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2ac6d2db-2985-4293-b5c7-ff6624d81fee"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2ad1186f-91b4-4146-ae3d-72b61e7a87bc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2b492ba8-2129-4c3f-8a19-0232266b0fba"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2b9f00b1-74b3-4bca-8fee-7f979d515339"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2c4e809f-48b5-49db-b2b0-be26f715f1c8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2cae79ae-a9c9-48fb-b497-79f298489b7b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2d1c25a8-a43d-4096-94d9-fbec81c4290c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2d1f7804-d2bb-44ae-ac24-bb53a9c5b608"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2d4d4e61-f3cc-454a-aa9a-b13637f45d15"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2d692da4-7ec7-496d-82ee-6055d75d9be7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2d9bab02-cfd6-4ea6-9244-f913a193599f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2ddde465-cdbf-4c8c-9d1c-986079fd952f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2e8e59ec-9432-4b03-bea7-8cb9faefe4ec"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2f161208-b412-4942-a8ef-2bff54ae725a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("31918c80-dce1-4f1a-bbf5-74de4c927e67"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("31b73c71-b81b-401a-b8d4-09f5796d1bbf"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("327d9a36-b379-457c-960e-7ebb0938f7af"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3288f11f-aed8-4d76-ad53-f03ef26bdbd0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("32d627da-dc8e-4a38-ae87-cb5b06a1eeca"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("32dfefa3-2847-4572-ac8f-e22b5bd4a51d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3355f6d2-1a3d-489c-8a6d-1d60914ee78c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3374e49e-9fa8-43cf-b2a0-02e737ee2962"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3377c89e-19b9-472e-bf7f-edd7a615773a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("33ec1411-0dbd-45af-b60f-de35e00f34fb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("33efa758-32e2-441e-9f0a-bd66cea8f382"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("352e4d6e-ac1e-4044-93b9-f2da67b7f92e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3537fc71-96c0-4c0c-a5aa-96933809222b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("35853c0e-d0dc-4d5d-b0ad-b072bdbd114d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("363084e8-4961-4f0e-8504-4ed9a7ea6cd0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("36a181c6-64f6-4e03-bf90-0ca53ec6a839"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("37494557-961d-4647-9f5f-0cbd7dd8e3c1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("37dbc4c5-7b12-473a-ba47-e8cabcc2183c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("38595545-4dee-4ae0-a83a-2f9331e8022e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3886e56e-b4a6-4d82-8f25-6fba8bfaf9c2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("38a5d776-807b-48da-aa38-be7f00b2a7a1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("39614528-aec3-4f6e-a55a-912066455df6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("39e3c8bc-28ef-4729-a7bc-82e393e56d9e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3a9d3728-8518-47b3-8518-2a305d4671bc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3b54e69c-610e-42d2-b6c9-d7ffccec675e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3b8de410-90a2-4f6a-863c-6579d0046ffc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3bb32aca-e9c2-4cc9-aea0-1fe6f76af7d6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3cc2ed4f-e795-4c65-ad1c-cab5abc85e26"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3cfb048a-9fc3-450b-981c-065907521b10"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3d0502e3-786b-4736-9c84-d6349144b068"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3d2b09dd-75af-430d-864d-70b77bedad8c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3d576e9b-9f71-42de-be32-dca70805b9cf"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3de59c4a-d2fe-49a2-9736-8b205c31d70a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3ef01ade-e280-41bb-a2d6-0f07dc812270"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3efb05b7-a683-4302-a80a-dcc9c3d5ff88"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3faafb01-b5cd-45ed-8322-bbee6a9b6ffc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("40081016-0775-4e38-82a2-3116ea53f6aa"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("405eac35-4e06-4237-9829-01994bc53bf8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("40fbc496-855f-407a-b17a-0078aed1332f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4108c4ef-dd0e-47d6-9fe0-69d45282b49c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("41445bce-7bc7-4ca8-b29d-f3404286b7d4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4172252f-f925-4c59-b32c-3306a03916e1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("419301a9-ec51-4d44-b6eb-76c875a67023"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("419493e9-cfc6-4395-9a37-6d518181be1c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("42d1439d-babe-44b5-80d4-dafde7f19944"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("43334100-c064-43ee-9fe1-72f558b74b06"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4335479a-73c0-4ed3-b67a-9797f7205384"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("43c15e66-4d2a-48b7-8efb-e37fe0e34777"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("440e5ac1-a70a-4ef0-80fb-55175dc11355"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("44fb8b7a-2b83-42b4-bfff-c545dca06b83"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4595c69a-6e55-4229-845c-f0020c625e7b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("46293153-5ddf-4557-9401-d79e4765d8cc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("468fbc2c-bed6-4518-bb83-42c5ab707fa7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("46cfdfdf-7660-4049-8553-c8063c204d1a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("47598223-344c-4767-95ee-fab4ffa54f55"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("47708743-ed4c-44f5-a089-191900480ae8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("47cf98e2-42e6-406b-bb5d-8b1b03fc7b0b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("48433443-c4e8-43b9-ae60-12a61a145beb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("484bc0ab-14c6-44af-bb8e-f1849e8ce4b6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("48be439a-ec30-4998-9ced-f4172555d719"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("49d0245c-1ef6-4d98-8404-32c2f33025b4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4a03dffb-e5ae-41b5-9748-9fb1db8fab17"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4a30fcaa-e99a-488b-81d0-3ba5872936e5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4a945490-4e96-4c23-9646-071b1ce027cc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4aa3e946-ca67-49fd-a994-b5b52fc50a98"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4ab9e532-755d-4218-8f56-9a874404d503"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4b2f73a2-52bf-4b3c-a9ee-8914a2c3a0d8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4b7ce08c-9def-4843-ae5b-4dad5036f50e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4b996504-eadc-4e97-8feb-d93507fe1d7d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4bc34693-f129-46a0-a879-909ecd398145"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4bcc7dbf-e9d8-4540-8289-3ce9628ff585"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4c49cc43-7db6-48cd-bee3-0eceed5b6ba3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4c8a36e7-ff10-47b3-ae77-5e28d33710a6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4c9c7048-4e4e-48f8-b318-b9a4fd9514c3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4d0c5949-d02e-4c04-a4de-3a53b67627fb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4dbb6d6d-62f7-425b-a54b-31e593166ea4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4dbbe1fe-d9de-44cc-be49-5f95d492b121"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4e347627-d631-41d3-8b51-4c116f9eb1ab"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4e57759d-9f66-48f3-a4f1-838de4bb8497"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5108ef47-7f5b-4f2d-866d-390078028081"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("51c666cb-a656-49a8-8196-eb6d0ce81248"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("51fb8bf6-1fb6-4088-be96-262bc99dfb9c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("525e4ab5-ce13-4445-9b86-e514b37f3d99"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("54dd1e0b-4796-4043-9761-649a643b0e5f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5696bccc-372c-4d31-841c-b27da0875d7e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("57826438-e538-4d98-a4db-c75e52c112db"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("57aa3fdf-fad2-49e3-bf0c-9ea5a8abddb6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5851564a-8af1-4004-8ba0-8edc9e6b2df0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("58a0e14a-aa20-42d7-a80c-4f4ec1915567"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("58a1b86b-a347-46a1-affc-18f9417fa3de"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("58e23f7c-aff6-4df2-bbd1-cfdc7a52e18a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("596e7e81-bdfc-416a-a040-1052fc5c5f8b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("597bf165-7c8a-4a88-897f-0b168b7c3490"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5a4e4994-629d-4347-89f3-c5b6ea3ad35f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5a538abd-264a-4284-abd2-5137946edfa8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5b25f35f-f4cf-4d2e-b2dc-3e7da8feb223"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5b37d613-26bc-47ae-a60d-4afcede4fb29"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5b46ffe1-0919-4875-8655-291fa1463e02"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5b5f3443-f945-4b45-9fee-5e55bc40f3bb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5b786c5f-def5-4ecd-8fc9-092285ab094d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5c2173de-3057-4ff4-8f4e-bc66f97642bb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5c43282a-26f0-4d3e-b67b-820ca6514dd6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5cf5ce0e-9399-4c75-8699-084d75357635"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5d0bff9b-c4db-4983-8b3a-f929a62ee45a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5da21990-734f-4b64-b796-44f6741f2b3c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5e61e56f-0233-4bab-a834-830ddf29433d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5ef5668d-8369-447b-8a02-6fc70c329586"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5f2494e6-ba62-4198-aae6-da6fa976dc1b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5f6cdeb7-2554-4cf8-9271-ecd86c136b92"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("601f3dc6-e97d-4675-96f5-7ef61355d5e2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("602f291c-3c4f-4864-ab03-4255f4e1048c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("603e75a2-b060-483d-9676-9c24f6c92671"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6041917a-772b-4ac9-ab85-6c4709287e7a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("62194446-ab6e-47d4-8606-d4b890b4fcbe"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("623b9725-fded-4655-a03c-98030919f174"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("626579eb-f359-487d-940d-fac4aba00c88"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6282ca63-0d26-4eba-bf58-edcb741e9bf1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("631f8163-c365-4789-96ac-0c99082aea4a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("634c7467-a6d4-4714-88de-a9bc37225aa9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("637b550e-099f-42a5-99c9-84c9a690b99d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("64d5d086-0a49-4d59-a41a-4b030a55efdb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("650ee645-f7f1-4846-b066-2e82992c99b4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6580de69-33fe-4427-b672-0530b183f57f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("68014b50-85c8-4481-9517-1c223cf9a113"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("68420d1e-decc-41d7-beb3-39fd06b2084e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("689e8c5c-606a-4824-8fb8-6e5f20aa996b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6957569e-a677-498c-9c62-6b5355e0d756"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("697743ee-49d3-4f7a-808b-fa9550a12fc7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6a367c23-2e90-44a9-bebc-f82143305a83"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6a926af7-977d-4c0b-b9f3-1d4f638c9be2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6b0f14e2-589c-403e-bf49-c7f71a4fa20d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6b242a09-1e40-456a-99b5-e3364eaedfae"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6b41b30c-cfdd-4499-b0d5-1283910e774d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6b4d64a2-24ac-45bd-aaa0-aef316caaa04"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6bb431d9-f366-4939-8aa5-891a80018f5c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6c08e7c1-7bfc-4348-8797-8b1d85321223"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6d1e4478-42db-44f9-8742-e9d42892413c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6d8300be-1e64-4dfe-b23a-5994d3cdc2e3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6d8ac51c-4f7b-4202-a411-289441489f71"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6d971f9a-b647-4e66-8cf9-dba6686aaf5a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6dc1f77d-fd7a-425b-80ad-11a121a30d02"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6eeed3ef-f891-45fe-8054-3d7c27f21974"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6efa13a2-fa0b-45f5-bbf4-bb1588720870"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6fa26ba3-6c6f-4a54-a0b7-9281cf2a9b31"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("70bbc602-a29f-4dd0-80db-dc3bbc59191b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("70e97b69-762c-45a1-ad0d-b54e73301282"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7288f0c6-ae38-4f33-b3e5-167f0eebc8fc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("73015cd0-381d-4f5c-9206-17f27fed6d50"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("735911db-b1e7-4b5f-aa1a-2041a789f1ae"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("73d69791-ea4e-4c3c-9170-0116cfa8ee5c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("744b7978-e3ad-43cd-a712-507eb50790d8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("745526cf-9ab5-4218-8f11-c9e97f482bcc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("749f6253-9001-4489-96b2-9aade6d01db9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("74f0c983-fb23-40f4-86ba-ff49c57683e8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("757e0e0d-8256-4523-be69-0d4f64e42c42"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("767f98f2-d7c8-4c56-836b-bcb8718f39b9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7696c334-574d-4aac-b2da-2f3869cd3abb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7708b824-ba96-4621-b194-32528f52601f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("77665099-7061-42c3-8e43-2a37688b6505"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("778190e7-1cf1-4ecc-9e5d-b17f66e5fdf1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("779a5375-c76a-4410-80a1-84338690e52b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("77db88ca-ef53-49e9-a0cb-f194193ee886"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("784a76bb-77bf-4860-8b31-b403f2afbaef"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("78a6ead2-db1d-45a9-add9-4b25ba84242e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("78db2d86-dd58-416f-abe6-15c6213b01ae"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("79e79403-150d-4dd7-a5f8-7a873b28d8c2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7a3249e6-1f5c-49a2-93cf-cd5dadff8348"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7a506783-fd96-44e3-a7ab-9fd7cbea1384"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7bd93609-8ade-40cf-8962-f4d7378393f6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7c4133d1-4f8e-4eb6-8663-2f6262b82c1e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7c7d9913-87e1-4626-9dfc-ea7d2be3aab8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7eda9975-aee3-4fc6-aea6-23164ca7b42e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7f0760cc-6aba-412b-af3c-3431b8075f20"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7f0b289b-d766-4daa-bcdd-6ca5c67930c2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7f3e5665-dabe-405d-a369-a9038a1d2909"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7f7d2615-fc2c-485b-a2d9-9f67fc362d0a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8026ca59-a672-4968-9bcc-181cc6266357"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("80ece597-4eb8-4c35-85a1-a53d6d5511cd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8174c0e6-1366-4757-9a38-8bb079cd8ed5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("818cb4d3-2acb-4ede-ab74-58e26241c959"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("81a5f462-4a9c-4ba9-975b-8f964f5f6d15"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("81e547e5-664d-47e5-ab73-b8177ca983d7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("829f1c89-7030-4df8-a683-e402a7cad61c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("82d329aa-55b5-414e-a810-01d3a847be8c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("82fa77b9-bc0b-4d47-9bd9-7e7f33b9eab1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("830a23e7-bbdf-4c5a-9be8-5d509cf87885"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("832140dc-99cb-429f-aa51-13325a7c1ceb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("83ffe861-e9df-4d3f-a2ad-e48924097257"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("84b6157f-8380-4b35-b8f9-43f3a2c57905"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("852465b2-d9a3-42db-ba4c-e93a061d89fa"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("859f5db7-c42c-479e-ae14-80194673dc2c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("86af37b9-db1c-476c-bdd4-15874d5c2658"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("86d3cc3d-c2cb-43df-b801-6ee32a7909a9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("87c7b981-99ea-4fc5-94f3-95d3e76d9920"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("87cc5c74-5fd6-4bce-ba31-8ae846a60327"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("87d6dfbe-2c28-496a-bf6a-14e69a13e728"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("87e8c0a8-860b-4a55-8439-b4787f75e49f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8820562e-d0a4-45e8-85b2-9a1e4246bfb5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8889e53c-8fa3-4077-a186-f5e55d0b6853"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("88988c63-0187-45f0-a137-34d32f24c23c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("889923cd-461f-44d5-b21f-ee860df62709"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("88aba398-5b26-46de-bf9f-917709f28c55"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("897c25dd-7735-4d91-bb2d-e67682f1a7a8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("89b64ed8-d7d9-475a-a962-fdb1724ea752"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8b56e091-3c18-4efd-949f-4fb1d5a56cab"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8c4a6a7c-5d83-4554-8950-756c1daf9ef8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8d0cb317-3c30-4b09-8915-d10e88dd8fa3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8d4b4cda-9543-405a-a81d-8fee401468dd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8e1dcb8d-64dd-4922-a680-4b2637ba61b0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8e36d05a-4399-4bd7-9844-e97e92e64a18"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8e531098-6d04-4b59-9bbc-b92e1c995701"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8ee41b55-3adb-4a15-9741-01077c428a45"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8eebb0f1-fa11-4496-8086-aa324d42af63"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8f109797-e066-4b45-8852-eaedfb46ae9b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8f87971e-04bd-473e-a0fb-1abc6d374a60"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8fcda5a9-2162-409f-b0aa-efa366d7b2d2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8fd34b77-4443-4698-9a87-76acde3d7ce6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8ff55da5-897d-4bde-ba03-2f55cb9f3244"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("902968fd-d06e-49b3-89a9-519bced2e613"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("90da95a1-70f7-4f9d-bffc-57f76bec214c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("91886ce0-ea51-4f6c-9064-3f34a1775996"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("91c3014c-95e8-4831-80ea-e3396e9011c0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9200e4ba-566a-43b8-ac0d-f85b68381649"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("921a7d62-8be4-487b-a77d-f6918a08a748"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9221f53a-c4c7-4920-882a-16711c3a7a74"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("929ef0dd-e375-40f0-a0c4-987fbac704af"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("93550c0c-6bf6-48a5-94b5-8c46eb384866"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9374a3c5-9ec7-4ae5-8cb5-80cddc2c7e94"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9396abee-4adb-41f6-bd75-e5eaf5f0bb89"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("94671791-369f-4d79-9ad8-f0a76a01fa45"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9473f1ba-f2b0-47e5-a34c-941a0e5c5c4d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("94921239-42d9-4e52-a0b7-b9da517f1612"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9505a665-5e22-4896-90ad-3a4fb8feb3c5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("955f9647-bf85-4012-bad0-e33442768ebc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9573427d-2be0-4113-afec-a4a17d87c8e4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9586d5f0-ea5d-4761-ba03-4b1de7b519a6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("95a8ccf8-ea27-4a28-98e4-43867a95aa3d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("95b788ef-d7cd-4d58-888e-686bdae12eb9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("95c2359e-00ed-41e6-a2b8-49484acf6828"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("95c3b5da-07e4-40de-874c-1eac2f4013bf"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9634ba04-f1de-4e6e-ad51-efa0259d428b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("96813cde-3e78-4f52-82cd-d67f5ec3f9ec"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("96fa9bc5-ffea-4a83-8c0e-922c16d7c989"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("974a3978-cd00-477e-b290-d7d3e27c2ece"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("97a06546-547e-4ca4-bc84-48889ee76858"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("97af6273-715c-487c-97d3-606b001e9e71"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("97eef54b-d8fb-480c-ac10-bdcdbc84f403"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9892d8dc-c0a1-4494-9052-d5d35d120130"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9958043f-941a-44eb-8896-f52e509f381f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9af742f0-24de-4a3a-9855-b9334c2e6d4b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9b59e48f-f081-4735-bbb9-c336fef2eaab"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9b8ea54f-e344-4936-8f27-3a49a9c9c5ad"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9cae810a-2c08-46bd-bbb4-42b54a6550c1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9cda6d25-2278-4974-8134-05b3cc8e1d8f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9cf388e6-c4f4-4cc1-b0b1-dd21e5e6afbc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9cf53212-3c06-4fd4-8b88-e0c31cfd4d04"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9da02ec6-b6c2-41ee-88ac-9db5eaf739a7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9db71c6c-139e-4e75-a813-6803290a3b57"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9dc7381d-0fef-4914-b8ca-0e06a0916c5e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9df57924-3f7d-446f-9dd1-98e09f8d8e0e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9e129e2c-a2cd-4cc7-8cd4-a5df0c3df48e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9e9ff5b7-f56c-45a9-b1a4-1110545596f8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9f7c830e-189c-442c-a79a-763a10ab9ce4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9fb00353-6bdf-4a58-afe1-99a50bc229dc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9fb443cb-1e3b-4a7e-b51c-cc85c4c3e43a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a0078c4a-a41c-4b04-a980-c7945090734a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a08fa451-0290-4bcf-bed5-d69252c8e1aa"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a13f0f6c-2709-4b90-af3a-cec422d3e7df"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a22cbecc-9792-49d8-8869-a709cb8aa282"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a25cde85-280f-412c-a805-33fa37e1d3c5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a26efec9-5908-4853-96e6-d97f9ea4da8e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a27bd56d-7e02-48cd-8ae0-825f492f3450"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a2f2f3cc-bd8c-43ed-8065-565b7f89c5ed"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a3b18598-76c9-45c7-8691-e76869c37d83"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a3f7bc2c-3a27-4e8e-b378-946b23dee857"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a41d37a5-0291-4e04-b809-cc03941a3640"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a46e4019-b83b-47b5-b1fa-ba072a4f40fb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a48b011c-90a9-4414-b4d8-7913fb0cde26"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a4da80c9-3bb8-4f4e-becb-a5663ac973e8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a579e9e9-2123-4219-9cd3-6ba9012bad15"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a5d035ad-eb56-42bd-a202-826341aa6ea6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a5dbf942-70a1-48a4-b121-14e58c823544"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a610509d-2e33-4797-b6e1-c67eded35c22"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a63d11a8-58ed-4295-9ab5-6ac026f1d3db"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a66035de-1011-4ce4-a018-c37d356b4bfd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a6802c07-2312-4be9-b14e-5d8dd825422c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a6abb135-f4ff-42ef-aa07-a95422dabd44"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a71a4832-6847-44b1-84ee-a395fe3cf4cb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a7739e69-9611-4626-bef5-af6b49ef592b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a863d596-2421-4c70-9474-80755cd108aa"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a8d5725c-e3ad-494d-9e5a-1d0a0a781475"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a8ff5576-df89-467a-9a4f-3c5cba9fcf40"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a922d531-db2f-4504-bb46-dfeddf114b90"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("aa812ae0-0471-440a-b6be-e8952e23b25f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("aa9a8d1d-d626-4371-abdf-934e6b3a9ce8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("aac0e77c-195a-4120-94ed-6ad20e68db1b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("abd0b3cc-8bc4-43f8-8ff5-fee040077a2a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ac0ee13d-8f38-4e6a-aa86-f8206576a7e6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ac351aa5-a017-4bb0-9051-2067d9fa6d07"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ac74df97-e9f1-4df4-97a8-692d5334247d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ac7a3784-b679-47bf-85c7-cff78ec9bc43"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ac8b7de6-e9c1-425d-a304-b1286746b5e8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ad7302e1-77fd-453c-af40-a1f2db21b1b5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ad89d55a-26a0-43d1-a003-7e97497aab73"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ad929d0c-3bd4-4784-8f45-0cb8a19048b2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("adce716b-12b4-47b6-a856-45b1da223279"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("aeb21bf0-2a15-4f27-a699-8ce4e9061728"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("aed5914d-0854-41bb-ba97-374f9daba968"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("af0a5d1d-f171-482f-b284-48744d5b5a5b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b07ed85a-8035-4f63-b1ab-9f3e9853e836"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b0b79510-5ff2-4a19-98fa-deb1962b10b8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b0c40669-e219-4938-90f4-f445fcf58855"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b0ca410f-95c5-451d-bda9-687665472213"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b13921a2-29f1-449b-8d37-dab35a3379bf"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b1e57ccb-87fc-4c49-8f9f-e0d6f8a4bb01"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b295a809-5086-403f-9cac-f4807db2371b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b2a49da1-0844-4194-9673-c197de42e10c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b2ad9803-84a3-4d9c-919a-029ea4b98207"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b2e06ea7-270a-4396-afcb-441caa6aafe3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b2e3bacd-b6ee-4a93-a270-a32f122429c4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b415b0a1-a043-4450-8d72-17d9838c29dc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b488862d-19ac-4079-bfaa-01c9e75b8b0c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b4f1f90c-c691-4b71-9217-059fbf790022"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b59bdc7a-1832-4117-8fac-6ef8f45b7d5e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b5f4b100-5ddf-4a9c-9865-680406294393"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b61ed1ab-c2fa-48da-914c-1e54cab07a4f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b700d965-98b6-4e45-8db6-bc7afbcbceea"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b7731d50-6da3-485a-90cf-c4121ac64664"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b819c724-4c8e-4937-b364-89cd2d7cd56a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b8b1804b-2484-4d36-b23c-b600b5165591"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b90842a1-d2bb-45fc-a827-e174c38638a6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b9801c13-2744-4067-9908-07257bffcf0d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b9d825fa-4ef8-4390-addc-7a1b10c4cac9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ba813fda-5387-4bc8-ba76-7f74f011b047"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ba919e32-92c5-490f-889b-c840fe0c0ee0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bb75fea8-e5e8-4eab-9583-8ee9ee2eecba"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bbc74261-f7c0-4277-bf65-4614e0c1c887"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bc67da3b-e794-4b90-a73c-37c3d5507f03"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bc883a6b-85ac-4b70-8691-4e9bfda2c214"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bc8d8eec-ba4d-40bb-bed0-1204539a3f37"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bcce4268-e10d-49f1-8aaa-5ccde03555e5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bcd67caf-1a4b-4a67-a62e-e300d4f046af"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bd0417d1-6809-4255-b1da-2e49f2c7b133"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bd4afb44-761f-4779-b617-c17267a3f2e3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bde5d714-b5ce-4bca-a84e-4feb1192a810"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("be032fb1-9611-4301-9e6a-b0a279fd1ac5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("be81eca8-99ef-49c3-863c-6e05f8b39d74"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bed76ad9-9ce1-4ab4-9e28-3e6fdd7ba8da"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bede888b-77b2-4d89-915e-8cb3c0d8b469"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bf40d8ca-7297-4224-ae02-a1cbe3e8cf71"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bf5b8c20-5ec5-419d-937f-8491a3316203"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c00334c6-e98c-4fad-ace8-3aae1fc321d6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c0532645-45ec-45dd-93c9-88b733bffd37"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c12f276d-bad2-496d-bc95-3420eb502dfa"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c1c49ed7-c967-4ee5-a8cc-9277c10d3fce"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c1eabce9-8d42-4131-84dc-89fab41bf56c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c2258bb3-5a77-4635-9b9c-5b04b476da01"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c23a1eed-da7a-466e-b75f-56dd2bc650fc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c272a2fa-f857-4c49-92e5-7cc50c81326f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c2c6d633-dc49-456b-b124-f1bdbe02ccf8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c2dae795-d713-42f0-9a85-db77f3082974"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c2e9420b-e6e8-405d-a988-57cfe3cf1121"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c32aad31-99d3-45e4-942d-28e4ddc0c103"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c34fcae7-7354-4134-9d76-fd3af03b7108"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c374addf-0afe-44c2-a1d3-1e50491ed230"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c42c2ccd-8b70-43a7-b2cf-2bb9b6939244"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c4eebb60-4efa-4b9c-920a-b59d3370d30c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c563ca22-7923-436b-b5b4-a544341836f2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c598431c-4c09-4c95-be16-c761d4a15cb3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c5beeec3-e991-42de-9e18-2742194c74ef"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c663a904-f7a5-4770-8945-b855e27449c3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c6667d65-ab82-451d-be34-0923dee76f08"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c6991938-3bd8-43d0-99bd-bbe07336600a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c73cc25c-9d18-4242-8151-236b852a9afc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c79102a0-3b0f-4453-898e-9565357a760c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c88c9041-4ab2-4e18-9463-37a109e48205"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c89efa49-3044-4eb1-8f9e-5e543eb32b4a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c8a5c546-fc34-43ef-b1cb-4569a7556300"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c8f55014-6e2a-4429-8c28-dd0137100d79"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c9215e13-7c13-4e25-ab3f-9f2c6c799e8b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ca8eab25-f0a4-4cd1-a173-a00ea16275af"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("caa797b8-37e1-4ceb-9fb3-377a608937b9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("caff111e-7f5c-4b59-8f44-4c23672c6e45"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("cb16f8ba-ca4a-417a-85ea-635b8b1fc446"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("cb428c65-a945-43f9-8206-0cd07617bb0a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("cba62d0d-36c1-4bed-9850-f5febc0b6c7f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("cbe75886-3163-4552-9ef8-049942e66d86"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("cc5cbb1e-c696-4a84-b236-88ed9e6ecc21"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("cd74f32d-5ed7-4b31-a59f-031647874adf"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("cdc63df5-9ec2-47a2-be49-185c3b5f6c22"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ce4fb876-5b0c-438a-a1be-03897ac2f806"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("cfca8a85-7331-49bb-8c29-01511c9730b2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d029db35-2741-48a7-933f-41ec69c0a2b8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d0f32fbb-c54c-4960-b2c8-ba99ffc5c206"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d1c95a0c-874b-43f6-8dc6-d5e02a492b73"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d2247fdd-2c59-4dbd-ab82-af0ac9b544e7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d25cbe8c-f9c7-4a85-a45f-09725273728b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d3411b6e-ee2d-4dfd-8e43-9ef60ee0f3fd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d453f205-b6ba-433f-8191-a7ea331ab4f8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d4dfe969-eb15-4280-a6e6-dfcc32da3e90"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d5cd963c-b2bb-413a-bbbe-32f02723097a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d68b694e-d7ae-482f-88f0-418101c04f62"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d6c5b3ef-94fa-4389-8b3c-db405189bd70"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d761519b-0609-4da6-b54b-4bf6f80a0cf7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d77d34f0-443a-4241-98cc-e03820dfe12a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d81e94cc-c375-4b54-bae5-bb1d5a0d6147"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d86e3e8c-b860-4603-8362-1d9a834f25f6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("da5137cc-4b43-47cf-96d1-58e4568beb0b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("da5c2fa6-0e39-4489-8bb8-75a95530e9c3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("dc24bd14-a88c-4f13-a0f2-cc2a3b83a5f5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("dc5b780b-6eea-4c1c-8629-14ecec9d021f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("dd35220b-9984-4db7-a307-b079d33d3393"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ddc1d8e9-5aaf-4b77-b392-008501d7053d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("dddada7a-2787-4676-94a8-ad32220d0783"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("debd3909-4613-4a14-b233-80a230ce9e79"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("deecee69-7e5c-4482-9772-291551de3a8c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("dff8507b-9014-4502-8f1b-37089767d354"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e028cfa2-97ca-4ce6-a792-7b5e98d1e2e7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e14b4ac9-06af-43e4-b80e-fbe3f78a54c3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e2390253-1c03-40d5-8f57-ec81942e932d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e24c739e-c484-481f-b3a2-bfbf3e223679"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e28a46b2-07da-4052-bf3a-fce5e1ee0f6d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e2c21dba-20fb-4b21-bb9e-8a244f00592b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e3ac0de4-9cdf-4748-aced-011cf2632308"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e3c32333-64ee-4643-a8b0-f3bf706304fb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e43c2b70-113d-4284-b829-0888fa803f40"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e5616191-8ef6-4f64-bf8f-2409c8e39c56"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e57c5b7c-6fb6-4ade-881f-19405e890397"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e62337cf-dc10-4daa-84b1-85be5f5053d5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e69b2162-e6c8-406d-b877-c53b1ef1f051"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e7749750-8bca-4b94-b096-216000b2a629"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e84ce6d9-fda6-4edc-8aab-85f8fb0cd6ab"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e86c9c42-01f7-446f-80ea-68469441ef1c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e93e5350-3342-4ba7-930c-5f88b7500326"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e96b1e57-2eef-453b-a649-0848bd94a7d8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e9e78a1c-e701-432d-af5a-11fa899dcf55"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ea3e5998-7125-416b-9c0a-aa5fde4417b1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("eb5f774b-c02d-4427-962e-5700bfeda027"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ebf64da0-9107-4b4d-abec-89b22ebeceab"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ebf92476-d837-4ec5-90ff-3e3e5d49a342"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ec14ebbc-fdcb-4a3e-92af-f55da291b69e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ec1b8d8d-87f3-4a80-91e3-710441cbdec7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ec5efb92-2b11-441f-a9f2-e5a724081452"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ec8bc7b1-245d-4194-b99f-272c68bd51fb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ed140a9a-5774-4840-8a76-dd2f838c454d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ed688951-23c9-47d1-b822-2d9d9bd9d891"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("edc1ae65-404d-41db-abb6-dca3721f0e39"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ee88e35c-4832-4158-8e4b-eef35f0ceeb9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("eea5eb1d-1415-436e-90b1-319f41111de0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("eed7d633-5927-4bb3-a4c9-4586a06958ea"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ef0cad31-b179-49f1-8f3f-db18db8269ec"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ef18c0d6-0502-4a05-9422-70cfe689e861"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f0386f3d-0542-469c-9fa6-810706c6f347"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f1206d20-a07b-4c5c-b297-779fba7ceb88"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f1a3b22e-20ed-4699-829a-136febdf15b7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f1a5566b-ff14-433b-bab1-3307c06798fd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f204fe60-5d99-46a8-981d-a3a5361b1e89"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f20daff7-f9df-42e4-b23b-f8ab37ab72a3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f2561f5c-2f31-4af0-ad21-c40239c0bc46"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f2607164-7e79-44de-96af-63eb3489db18"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f30fdc4d-9171-4bf9-976c-84772276c806"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f363dbff-1a55-4738-a715-0059bf617a41"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f38e746c-d2dd-42c6-ab0f-d71f398f1432"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f4209af6-5263-47ea-a31b-98f3f89117da"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f4258092-a0e8-4062-8d96-be78c91d68fa"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f4271c0c-259b-4748-83ef-c9a5da3d0fe0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f4d74735-12bc-49ab-9dc4-7b0cfe353bff"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f4ff1d84-8884-47ec-a6a3-00729ffcc214"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f54aa4ed-e203-49b1-ad12-f20b5ee119e0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f577004e-0509-483b-ad79-075f18c8e93f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f5e1375d-70cf-4c9c-b2fd-fde8fa842d3d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f6608671-181f-4dc6-9cb4-12e13f0ee677"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f6e15158-a96b-450f-887c-5a50bde64a96"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f955cf6b-577f-4acb-90ea-249cba2a3a50"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f9e6c5d5-606e-401c-9565-2afa5a8c98ac"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("fa18a7ba-585b-455e-8253-5976716b2a31"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("fa3da13e-1df6-41ec-b02b-bc1d1a4dce55"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("faf12b3c-8ce2-4a8b-9ee0-dc6c9a2b4bb4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("fb2d18ae-8517-4689-8510-46955a655c1d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("fba8d927-63f7-4878-9090-d28f08a3e7d2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("fcce5510-fe8e-429e-a95a-335cd26b5e69"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("fdbeac72-fc58-445c-b484-8323ff9548cc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("fe125f84-0808-4bfc-aa08-ed2f54005813"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ff492bdb-b79a-487f-a997-ae490d316cc5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ffcbe789-cc91-4a0b-9067-71f00a77dfcd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("001fe752-a929-4ee7-a475-1946336faeea"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("00d68017-12ed-452a-9579-3a75165b8862"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("017803eb-0280-42f8-b5e9-6dab64638234"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("03bd2531-97cf-4932-a376-53f527055081"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("06b876a3-d5be-42a3-b6ad-28ecd9ed191a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("0838bb5c-5e80-41d2-a0ba-1500e34e5e84"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("08d0e56c-4790-4ad4-8534-d92c2a4ceaba"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("0b7a869f-291a-438e-b48e-2e606907fa0f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("0e8e8484-709a-4ea7-9e6a-cf28cdb232e8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("0f20aad5-e1af-4929-97f3-a97784d1a832"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("107bf979-b3a4-4aa0-a79f-97ea8de897ca"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("1272a904-a417-476e-8b85-18d625df5260"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("12774129-8137-4b2e-918c-33c90117ecc8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("141026a5-2a50-44eb-a591-635ca2824483"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("14ca800b-aed0-486a-81f9-fc0ca5853252"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("1524d647-cedd-4ca0-a99a-1af85db0b94a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("16f02673-0f4c-49e0-8e13-a2a60872e8a1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("17dae9a6-0b79-4ed6-856b-0a566c127775"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("1a4c6c52-fdc4-43c2-8203-ef62a10fb0be"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("1ab453a6-69ed-4324-9d91-3e7bdad96fd3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("1d9aaa1c-3908-4dab-80e6-71e97df82c4e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("1f7fa2d0-115f-4852-806b-e266e8eccdf6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("21354285-cb48-448d-90a7-050f02e18926"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("2168be61-2b39-4019-9b35-14e693600096"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("26694fbc-a7f1-45c0-8d14-1dbfe2a28519"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("27fad6ab-a329-454a-86ae-9f0e81de73fd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("2853c8f6-3c01-4a9f-950e-5272c3ea2196"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("28590727-cdb2-4a14-aa71-ba65f47e1409"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("297298c3-5ab9-4e7b-9df3-63aae4f00ddb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("2a19e034-70ef-4f84-a172-44b1f1176c8f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("2a488b48-f4b5-4a86-a973-5cb6c2fdcbe2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("2ad627b7-44f3-4de0-82f6-0949f3260ea5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("2e380e12-8a83-4180-a868-d544382147b4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("3272ec0e-76ed-4fc1-a3ec-03b28f47caf7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("33a78b3c-67f4-451a-85ff-576eb12b97b4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("39f20962-eda7-4ef0-ba52-0e3a65acd094"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("3a5eea17-953a-42b3-a462-992e92d8ec93"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("3cfcbe6b-63f1-49b8-946a-53d7bc70cde2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("3f182247-86ba-4b4c-a163-2af21fc41d6f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("3fdd3906-c4fa-4b0a-9205-f102df19440f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("41b614e4-a613-4495-85eb-047c658f39ac"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("41ed41e6-89d0-4972-8d97-689eada2104d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("42038f52-fd87-43cf-9be8-be7d9dceb514"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("43f75eb6-96a7-4e65-8722-44f1532a80ed"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("44a87ec6-c86d-4849-8a01-fdd63f8b153a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("45a8a2cc-e815-4b98-8180-cca75f9b03b5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("4757e9ae-84ea-4531-9151-718e6233a4b2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("47a84a99-7bbc-457b-9ce8-3addd729cc61"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("4866eca6-58c8-4aed-9feb-54665a966e1d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("4dff4288-3472-4015-b87c-a55ee47b9574"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("51dadea7-c098-4566-8526-7d0bc9df9a06"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("5320ce4c-53cb-412e-814a-b8a016ccfb57"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("53826b9f-66a9-4361-b715-50e2e252d3fe"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("55a8840d-19a0-4b86-b80f-970acd58ea9c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("5e4fcd96-337a-4034-9385-ed05bc5f9c2f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("5e8fdab4-d321-4372-a78c-73beedec51f2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("5eb91d82-dacc-4d83-b1e4-117b33ca4d9d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("5ebd1239-1861-4aaf-bfe2-5693371cefb8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("61bde707-9c71-4031-9279-bb23d4cc6c0d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("64a00830-9fe7-44c5-a98f-f6194342869e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("69f7e3be-5999-4014-8f35-51795054c3b1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("6a79f49e-c752-434c-9032-24421cfd5822"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("6b386be6-47b4-43b3-80c4-041b1c6132ca"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("70e6e385-77e8-416c-88e8-6debe84c3827"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("7183ae9f-0c56-4e0f-b169-6264424e9e99"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("738c38a8-a796-47cd-be2a-e099a9eb201a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("73eaca74-c067-44f1-abee-bac4c6a93c9c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("7b322fe6-0e2e-4656-a511-1cf2082350a8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("7f2d15da-0b3d-44f8-adcb-9e92f5ecec15"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("826aaf83-5d4a-43f3-b892-b8a6458f292d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("83967941-1b98-4e8b-acc1-554bc6377d0f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("853d770c-e698-4bf5-91a4-9f2e705de4f9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("86bbaf03-65d1-498a-ae15-0644bb52be31"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("890740f5-67dd-4a64-9b99-b6cbb1eff2e2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("8958a59c-f63c-4789-bc6b-c9b89d47fec3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("8d803616-aafc-41b4-b272-03b7fd6ca255"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("8f090614-fce3-49c9-82f8-128288f6fd38"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("8fe538b0-0635-4a4b-bb85-fb4d50e910de"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("9789f75f-3411-4abf-87d6-aaab22f9828e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("97e3a789-5369-47a1-91a2-3a3a05e1b2ef"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("9b373c3a-d9f1-45f2-a1d5-935b9df36718"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("9c743b5e-006b-42b1-a018-1025d698c19c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("9dafac4c-54bc-46f6-b821-d8d08786afa5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("9f3bd394-d974-4a6b-b7cc-87eeebe3ef9d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("a2728b05-f57e-4760-8b2e-ad20dccceec1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("a45b3d54-8f6e-4cbb-b10f-3bf9965b86a7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("a52894ac-b8c1-4826-b2cc-37d2a4edc0f2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("a7748ab2-9d9f-40ba-8394-972875ec7e88"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("a91fca8a-5363-4d6e-bbf4-d1561af24d5f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("aa4c94c8-4d53-4cb5-9276-ee742d7d8e34"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("abd14d92-5108-4954-9450-7bf816d4897d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("aca86194-a919-4cb7-8ec5-2b44fedc0886"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("ad8b8620-1bfb-4f8b-b5fc-ff500eb49a97"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("ae56f094-791d-450d-bae5-bf16815b8c65"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("aee2de2b-ddff-4fec-8935-fd72329656cc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b0b866a3-d8ad-4b61-ae20-d1c4335503c5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b24ddeba-6db3-4812-96f5-c61cea9b4b56"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b298d281-5e9f-4d73-9ddd-415cd9484ad4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b5494b17-8177-43a8-b50a-b8c658ee48a5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b60aa6ed-37d2-4c0d-97d0-15906cb1657d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b967b937-05e9-4850-9890-202622f55a97"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b98e9402-d25c-4d03-9a6b-eb40498db60d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("ba8fa357-fc0b-4269-8a8e-f1dad16ce7f1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("bae61a5c-aff1-406d-b415-16b6dc3a224d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("bb0fd69b-0606-4ad0-af2c-8627a46adca9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("bc5c1f8e-4502-4551-b177-6e7528da1c37"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("c5e7a1e7-e866-463c-98df-eb08883c2ddd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("c7872585-2dc3-4c9d-88a0-e9747fac629d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("c93625a6-0a52-4cb0-bcd0-f9cbe98c03a3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("cb70a650-96e3-43b2-8154-b94a32367f08"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("cdc68964-6830-4639-a7d9-2b268b163f88"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("cfeb5717-0414-43e6-9902-080a31934789"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("d1aa5f41-20f2-4b63-81b8-088535e7437e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("d2684695-52eb-4f49-8c06-5e0c8b07202b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("d2a56ae0-8904-4b84-bb15-7228deac7263"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("d4cbeed1-8830-4b6c-97e8-dfdebcb43619"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("d750d2da-2217-4a5c-a041-722eec0aaa33"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("d7f70479-619e-4bad-990d-c647cc291014"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("df704ddc-704a-4d2b-a287-888a6e2e23f8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("e08c2937-3e32-4040-b946-082b1ebf6075"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("e0f35812-a600-4ceb-b71d-b550367474d9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("e135f5cf-7011-4411-aa89-c60bec0b18d9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("e1a683bf-4181-4d35-a6b5-2023b2a82764"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("eb19fda6-6b9a-4998-9081-a948ccbb5f84"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("eeda3900-4cec-46cd-85cf-e4389ee698e8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("f56f4c4f-0f38-4963-a30e-d704d9f685cd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("fd529eb9-c48f-402a-9e81-b4790f0bb421"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("fe3dbfa9-58e1-4323-8563-ac40e0e688ca"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("ffc88170-de48-4f77-b1ad-2dba86b7ebb4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("4628a4b0-8f6a-4d95-b704-8c72a117df98"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("54949878-23e3-48c1-ae69-76157933c3eb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("769ead10-3611-4f83-a4db-eacdc13fe3f5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("7f2a198f-58e6-4f14-b52e-98e6f284e5de"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("a49462df-57b1-47b7-abf6-a0a63f45db61"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("af786f1f-2207-4884-8b85-27dfbb3359ec"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("afe1f46d-37e6-41da-b901-9a0bc5402eaf"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("cad1f944-c64a-4663-92b1-a573d3e7a75d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("eabbbd0e-c0f7-44de-8492-ee8a160abdc2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO_SOLICITACAO",
                keyColumn: "ID_SOLICITACAO_PUBLICACAO",
                keyValue: new Guid("1253a1b6-20a3-4fcc-af23-7159776b8f26"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO_SOLICITACAO",
                keyColumn: "ID_SOLICITACAO_PUBLICACAO",
                keyValue: new Guid("936b02f8-0d89-41ef-beeb-b91be28470c7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO_SOLICITACAO",
                keyColumn: "ID_SOLICITACAO_PUBLICACAO",
                keyValue: new Guid("bf10a6d7-abfa-4a1a-888e-18c3d2fe613f"));

            migrationBuilder.InsertData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO_SOLICITACAO",
                columns: new[] { "ID_SOLICITACAO_PUBLICACAO", "HORA", "MAT_RESPONSAVEL", "SUB_TEMA", "TEXT_PUBLICACAO" },
                values: new object[,]
                {
                    { new Guid("ad85237c-8d13-44a8-863e-e97ac07c9508"), new DateTime(2024, 10, 15, 10, 29, 52, 712, DateTimeKind.Local).AddTicks(1249), 156114, 125, "Apenas mais um teste de publicação no fórum do Giro V" },
                    { new Guid("c3c9765e-c8cf-47e8-9444-604f76ff119a"), new DateTime(2024, 10, 15, 10, 29, 52, 712, DateTimeKind.Local).AddTicks(1250), 3511507, 44, "Apenas outro teste de publicação no fórum do Giro V" },
                    { new Guid("ce0a12e2-b5cc-4fa2-85ba-484f55829c07"), new DateTime(2024, 10, 15, 10, 29, 52, 712, DateTimeKind.Local).AddTicks(1229), 80904800, 8, "Apenas um teste de publicação no fórum do Giro V" }
                });

            migrationBuilder.InsertData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                columns: new[] { "ID_RESPONSAVEL_TEMA", "HORA", "MATRICULA_RESPONSAVEL", "SUB_TEMA" },
                values: new object[,]
                {
                    { new Guid("00180491-a286-4e13-8853-4ef512c07c37"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2357), 47333, 120 },
                    { new Guid("0125dbc1-2fc8-4e10-9707-b25bea8a22f8"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2695), 3511507, 17 },
                    { new Guid("013a6820-7d4d-42b8-a276-f2d89856be7a"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2258), 25677, 72 },
                    { new Guid("025a9a99-fe05-4a03-941c-96de2cb71b19"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2699), 30722, 86 },
                    { new Guid("0556b6d9-9570-4889-b8c9-43b046cd2f36"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2502), 80904800, 67 },
                    { new Guid("08b97408-ddc8-47b3-a67e-a127a33fd49b"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2148), 51336, 113 },
                    { new Guid("0909293a-bbdc-456f-bc30-a48f27786b62"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2710), 80900909, 75 },
                    { new Guid("09f11f6b-4e0a-4708-b344-7deee7d0c7a6"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2419), 40417113, 9 },
                    { new Guid("0dbd64bf-c1c3-4c3c-afca-a7aebabfaf7b"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2505), 159706, 71 },
                    { new Guid("0df30b0c-54b1-4766-91d5-2c914984ce52"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2592), 156114, 87 },
                    { new Guid("124aced3-39af-45a4-8879-6b9101f9a95c"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2265), 64960, 117 },
                    { new Guid("1272ec7e-6c83-438e-b2de-f46708cd42c1"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2558), 40417113, 111 },
                    { new Guid("15bdffaa-5c77-4b64-8091-a51cbc788077"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2412), 3458749, 124 },
                    { new Guid("1798bf02-1daa-43af-acae-f15220b809f5"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2706), 80886919, 122 },
                    { new Guid("1945f3fc-bab8-4daa-aa29-c3e9c5cd9a35"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2206), 16279, 87 },
                    { new Guid("1d4beae9-2c2c-4cf9-9b82-ee3684974f4f"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2132), 64960, 61 },
                    { new Guid("220f2dd5-89c8-4d4b-9df4-11026d87be16"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2226), 3511507, 102 },
                    { new Guid("22b5f9f3-ed51-41b2-9f74-7261e1c10183"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2437), 94842, 96 },
                    { new Guid("23b2f834-a6ca-464a-84cf-74249344e1cf"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2075), 64960, 94 },
                    { new Guid("2511e2f4-f38c-45b2-ac3c-9920c1b7ed2d"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2486), 64960, 99 },
                    { new Guid("266e2694-8d2f-4f94-ac64-e9d88473d009"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2261), 71114, 101 },
                    { new Guid("2727831e-ba61-4672-a3ab-7df07dbe04c4"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2214), 40418413, 110 },
                    { new Guid("28ef2ff6-9a3f-432b-aa7b-30e0a57f7e0b"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2144), 64960, 122 },
                    { new Guid("2a589265-bd92-4c53-9bd4-717767f18ce9"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2249), 80886919, 118 },
                    { new Guid("2c68e0b5-634a-40f5-8950-c3d041e9ed0f"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2118), 25183, 46 },
                    { new Guid("2cbe8d4e-ae1d-4549-aed1-0895169d3706"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2494), 40416900, 69 },
                    { new Guid("2daec607-7fce-48be-89e1-bf79209a07fe"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2718), 40416900, 41 },
                    { new Guid("3015a19f-e037-45bf-82a6-8c89b2c39b9e"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2155), 80796597, 23 },
                    { new Guid("30fed233-84d2-412d-b5c4-e21e307bb2f3"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2898), 159706, 98 },
                    { new Guid("3144d93d-09aa-4a42-8d7e-1981ae2edd3d"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2686), 80904800, 83 },
                    { new Guid("344884b3-d3a9-4fb1-8e46-6da2cf4e2ed8"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2091), 47333, 50 },
                    { new Guid("34bccd68-7242-4b63-8ee3-3ad1ef1de304"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2140), 64960, 19 },
                    { new Guid("35e6ad04-c3a8-400e-92d8-a44e213ac26a"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2768), 156114, 119 },
                    { new Guid("37c70b81-8558-46dc-8d1f-e1012387db1b"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2374), 71114, 87 },
                    { new Guid("3bcf13f7-9d0d-4004-af0a-05bd21907086"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2083), 3511507, 72 },
                    { new Guid("3bd91fba-352c-4017-928d-9cee0da87363"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2433), 64960, 49 },
                    { new Guid("425808ce-f2d3-466b-806c-27723ea4f4f6"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2886), 71114, 44 },
                    { new Guid("43bb999f-ece6-43f6-8022-242b70d229a6"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2597), 160624, 69 },
                    { new Guid("4600a71b-db31-4d94-8782-9eaf0909679b"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2098), 40417113, 105 },
                    { new Guid("4819c4f0-70f9-4b0e-bc46-be1d195dae8a"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2578), 156727, 26 },
                    { new Guid("4f56d631-3521-4b1f-b563-597fa0e97e3e"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2345), 25677, 14 },
                    { new Guid("4fa9cd14-5038-4809-8225-2a5603149a2b"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2136), 69372, 29 },
                    { new Guid("5210b97f-7cda-4d2f-b529-813ab9953ec4"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2714), 156305, 105 },
                    { new Guid("52374b74-ee7e-4765-b9a6-6b35af412c55"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2322), 3458749, 95 },
                    { new Guid("56ea8ddc-3374-4cc8-98a5-bcf3b8d8d6e7"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2070), 152001, 127 },
                    { new Guid("57a536fe-3b11-4afb-905c-f0e00c54f221"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2152), 156114, 30 },
                    { new Guid("57e58807-53a7-446f-a91c-228fa6ed16e2"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2318), 80796597, 45 },
                    { new Guid("5a1aafc9-97d8-4afb-b2a4-5f68d031f2bc"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2234), 156114, 110 },
                    { new Guid("5abb5921-a928-4a37-b2bb-f09a8c01f0a0"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2690), 80904800, 75 },
                    { new Guid("5b113012-baeb-4d7f-8d8c-dec584039b5a"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2122), 30722, 113 },
                    { new Guid("5e7474a7-fc47-4b34-babf-13dc28a7d8f3"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2114), 156114, 54 },
                    { new Guid("608ccaf5-38bb-40e5-9b02-f759663b45a0"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2518), 25677, 111 },
                    { new Guid("62637e8f-802e-4747-92dc-c4939d9e168c"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2779), 80900909, 96 },
                    { new Guid("6597e170-caf6-4e75-a2bf-eb479617d631"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2908), 71114, 29 },
                    { new Guid("65b6be5b-30ee-47f0-9c37-a5d66381fb77"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2582), 163794, 68 },
                    { new Guid("6806c5de-7704-4c94-8bee-9a0b780ce10c"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2514), 3458749, 18 },
                    { new Guid("684c0e32-02ce-4c9d-a477-640df0de116d"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2423), 51336, 16 },
                    { new Guid("6d24c9a8-543d-4957-9ae1-eeb474b68cb1"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2830), 156305, 82 },
                    { new Guid("6faff85c-efad-4160-b5fb-c0a269f841f5"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2638), 160624, 45 },
                    { new Guid("7123ced9-5fa4-4151-915f-ac730de016d7"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2522), 163794, 37 },
                    { new Guid("71bc5ca4-492e-4f31-bf25-50e51472fdfb"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2856), 40416900, 19 },
                    { new Guid("743eb16f-c5cf-4683-918c-25fe7df7f56c"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2336), 94842, 97 },
                    { new Guid("74ee64ca-37e0-4264-8d17-6d23d872395b"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2634), 156305, 112 },
                    { new Guid("772d6c9d-f9ac-4431-96b1-c26db8659446"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2126), 156727, 46 },
                    { new Guid("780a11a1-7590-4ae3-b8a1-cdf6764a54cd"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2326), 69372, 112 },
                    { new Guid("7a0175bc-1f1e-47ab-a446-61dce5e87a5d"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2230), 80900909, 34 },
                    { new Guid("7b19c273-607d-4642-9843-05c2aed3905e"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2772), 160624, 61 },
                    { new Guid("7f87606b-b6f1-40d0-bb0f-d315af64f85a"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2498), 163794, 127 },
                    { new Guid("819d64cd-f2e7-4528-87a3-51edcb252848"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2241), 152001, 26 },
                    { new Guid("81e4fc76-9113-4db2-8323-389cf933805e"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2834), 160624, 118 },
                    { new Guid("8215d2ef-8091-43d4-b6d8-0660d4f5156d"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2245), 157239, 67 },
                    { new Guid("8810fa3c-7585-4bdd-9fe9-0fcf917d3781"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2210), 152001, 71 },
                    { new Guid("8d45d58d-d73f-4824-b41e-9952d330295c"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2353), 69372, 43 },
                    { new Guid("8d55bd1c-db6a-4a8d-a519-3f2f94354615"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2361), 157239, 15 },
                    { new Guid("8f7b44f4-7046-43cf-ac7a-28ae7da408a7"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2269), 40416900, 10 },
                    { new Guid("8fd2547a-6c31-4da9-bfc5-efaefe25e45f"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2279), 157239, 58 },
                    { new Guid("92e13575-24b0-49bd-9d75-626de0e73f89"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2838), 156727, 50 },
                    { new Guid("932a0433-9823-4156-b5af-d37a2cc5a283"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2653), 156305, 126 },
                    { new Guid("935bab5d-0429-450c-b571-f72580ce982d"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2223), 51336, 127 },
                    { new Guid("93d9ffb4-1ba7-4fd9-be1d-2596506e7a79"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2283), 80796597, 64 },
                    { new Guid("93ee5549-b32f-47c7-ad60-16925d28de3d"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2787), 163794, 13 },
                    { new Guid("967030a6-ae5e-4d1f-8d93-79608c34bfc1"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2427), 152001, 62 },
                    { new Guid("a0d351a9-8622-4567-bdda-54b0eecaa9d9"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2218), 16279, 123 },
                    { new Guid("a1c39d81-a20f-44dc-85a3-b2e9a70537ee"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2661), 51336, 68 },
                    { new Guid("a4428460-083d-4518-b20f-6e0826853cbc"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2087), 51336, 48 },
                    { new Guid("a468c148-8f5a-439d-903d-758264b2c502"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2371), 94842, 88 },
                    { new Guid("a53fcd15-020a-4aa8-adec-91eb5e6b7cc5"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2102), 3458749, 15 },
                    { new Guid("ad616b26-67f4-42d5-a485-de6d38daddb7"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2848), 25183, 19 },
                    { new Guid("b23cad30-e32a-4dce-a4a2-6c307df9a313"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2286), 30722, 126 },
                    { new Guid("b3270037-b154-464a-ac56-00b649165b34"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2528), 30722, 109 },
                    { new Guid("b35e775c-c5c7-43ee-ad37-dcd3905f1fc0"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2509), 30722, 10 },
                    { new Guid("b4545e62-8a4b-4a5a-be35-4f0ee1a62f5c"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2159), 157239, 55 },
                    { new Guid("b4ef76e0-9015-478e-86bd-a84913c19695"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2760), 40417113, 127 },
                    { new Guid("b9382c32-6280-4caf-a596-de2c0cda5862"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2340), 25183, 17 },
                    { new Guid("b9499cd5-d578-4dc0-9fa5-9a30b1ab5f77"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2449), 80886919, 73 },
                    { new Guid("ba62de01-5852-4a44-95a2-c3ebc1da74aa"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2415), 152001, 76 },
                    { new Guid("bb2931fd-97c1-4aaf-a6e2-80c275030241"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2630), 163794, 42 },
                    { new Guid("bb98fe78-ceaf-436e-b38d-516485985833"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2106), 40416900, 117 },
                    { new Guid("be210a8f-c6f3-4d26-98ad-95695ed21c01"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2254), 40416900, 112 },
                    { new Guid("bf1d8d37-590d-4a97-b68f-f78e7505efff"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2657), 80886919, 57 },
                    { new Guid("c0f15912-6a1b-488b-bda3-b2b4b3885c7d"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2642), 51336, 63 },
                    { new Guid("c119fd5a-0f6a-4fe1-8b20-ae9887aa71a5"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2408), 16279, 116 },
                    { new Guid("c63edf75-a9a4-4f55-819e-60fe76436f2d"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2646), 25677, 90 },
                    { new Guid("c6890e30-06dd-4ef9-ab22-36cc996b0db7"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2852), 40417113, 69 },
                    { new Guid("c6f3d1e9-51b2-41b6-bd94-baeeeba8c081"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2457), 47333, 106 },
                    { new Guid("c7600ce5-4338-4ba9-b8f1-6f95721aedb8"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2110), 156305, 77 },
                    { new Guid("c83cd8ec-fac2-4df2-b784-6cf415b8221f"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2365), 157239, 121 },
                    { new Guid("cb76b829-e14d-4407-bece-9e72a656b271"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2062), 156727, 95 },
                    { new Guid("cdc23935-c83f-44ce-bbe8-c2ecd09d7a61"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2275), 51336, 67 },
                    { new Guid("d25beb8f-5b58-42b5-9e77-8e698a91612f"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2349), 40416900, 128 },
                    { new Guid("d50a71be-41eb-49b5-85b0-27fe19d3765c"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2764), 47333, 31 },
                    { new Guid("d64a54df-4dc0-43e8-921f-7d55dd8a9be7"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2571), 40416900, 20 },
                    { new Guid("da15c51b-6174-4e0d-8ccb-95d1294a8432"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2441), 80900909, 115 },
                    { new Guid("dd15b101-116a-464f-80a6-613479c4385d"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2588), 51336, 128 },
                    { new Guid("e153c75f-2d28-4586-84af-74d10d7b2d2c"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2562), 156114, 8 },
                    { new Guid("e270f07a-c3b1-4f49-bce9-6604135e8e15"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2453), 80900909, 50 },
                    { new Guid("e2aac940-9abc-43b0-a342-9d65b820f2cd"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2890), 156727, 69 },
                    { new Guid("e314d157-1a24-4920-b3a8-e2ebd79c9447"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2575), 25677, 22 },
                    { new Guid("e42e7cbc-b48d-4749-8044-5dd551373e5a"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2016), 3511507, 78 },
                    { new Guid("e4cac47f-28b6-4fb3-9e3d-d1df4c00c9bd"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2566), 69372, 55 },
                    { new Guid("e59bba40-3081-4463-bd75-0d106d1d5f16"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2894), 152001, 61 },
                    { new Guid("e5d7a4f8-afea-4b26-a576-14a3cf9cc09f"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2783), 163794, 99 },
                    { new Guid("e7eb97e1-b360-42a5-9f1a-f13d02072913"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2445), 64960, 48 },
                    { new Guid("f0a6107d-3657-4d0d-841a-f8ec6f2bd478"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2842), 16279, 38 },
                    { new Guid("f32e7ded-4d80-4df8-a3cc-48280cf9d5fb"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2902), 30722, 46 },
                    { new Guid("f3e1a7e7-77cf-428b-afeb-3cbca965ad16"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2665), 80900909, 100 },
                    { new Guid("f41270a7-4b9f-40a0-bef1-5c62bd0bda21"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2079), 157239, 32 },
                    { new Guid("f82ec6c3-de2b-4331-b355-2f2c696071f9"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2791), 40416900, 34 },
                    { new Guid("fc5c2929-8729-4c00-8054-e652ead777bf"), new DateTime(2024, 10, 15, 10, 29, 52, 716, DateTimeKind.Local).AddTicks(2330), 64960, 64 }
                });

            migrationBuilder.InsertData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                columns: new[] { "ID_PUBLICACAO", "HORA", "ID_SOLICITACAO_PUBLICACAO", "MAT_SOLICITANTE", "TEXT_PUBLICACAO" },
                values: new object[,]
                {
                    { new Guid("2677fd8a-201e-460b-8e10-3e8c9c01489c"), new DateTime(2024, 10, 15, 10, 29, 52, 717, DateTimeKind.Local).AddTicks(3632), new Guid("ce0a12e2-b5cc-4fa2-85ba-484f55829c07"), 40417113, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("51b3f383-98a6-4118-985b-7cb56c800ad9"), new DateTime(2024, 10, 15, 10, 29, 52, 717, DateTimeKind.Local).AddTicks(3630), new Guid("ce0a12e2-b5cc-4fa2-85ba-484f55829c07"), 40417113, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("70792ee4-0b63-4c06-a86c-4ed463c1d23e"), new DateTime(2024, 10, 15, 10, 29, 52, 717, DateTimeKind.Local).AddTicks(3634), new Guid("ad85237c-8d13-44a8-863e-e97ac07c9508"), 47333, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("723955eb-bf37-4232-b056-4b3bc2a50ed9"), new DateTime(2024, 10, 15, 10, 29, 52, 717, DateTimeKind.Local).AddTicks(3641), new Guid("ad85237c-8d13-44a8-863e-e97ac07c9508"), 80904800, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("7f43a799-b7a1-49cf-a34c-9b8f5e8747d3"), new DateTime(2024, 10, 15, 10, 29, 52, 717, DateTimeKind.Local).AddTicks(3636), new Guid("ad85237c-8d13-44a8-863e-e97ac07c9508"), 16279, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("9288fcb6-fe87-4e8a-b46a-168a38cda267"), new DateTime(2024, 10, 15, 10, 29, 52, 717, DateTimeKind.Local).AddTicks(3651), new Guid("c3c9765e-c8cf-47e8-9444-604f76ff119a"), 80886919, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("a1657024-7d5e-4ca9-a7c5-f661241ef8bf"), new DateTime(2024, 10, 15, 10, 29, 52, 717, DateTimeKind.Local).AddTicks(3643), new Guid("c3c9765e-c8cf-47e8-9444-604f76ff119a"), 40416900, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("b3b315d5-8b6c-4c2d-937b-2734856f92b6"), new DateTime(2024, 10, 15, 10, 29, 52, 717, DateTimeKind.Local).AddTicks(3616), new Guid("ce0a12e2-b5cc-4fa2-85ba-484f55829c07"), 160624, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("c1fa5f30-348d-4296-a73b-d5927c900371"), new DateTime(2024, 10, 15, 10, 29, 52, 717, DateTimeKind.Local).AddTicks(3653), new Guid("c3c9765e-c8cf-47e8-9444-604f76ff119a"), 25183, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_FORUM_AVALIACAO_PUBLICACAO_FORUM_PUBLICACAO_ID_PUBLICACAO",
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                column: "ID_PUBLICACAO",
                principalSchema: "Fórum",
                principalTable: "FORUM_PUBLICACAO",
                principalColumn: "ID_PUBLICACAO");

            migrationBuilder.AddForeignKey(
                name: "FK_FORUM_AVALIACAO_PUBLICACAO_FORUM_PUBLICACAO_SOLICITACAO_ID_PUBLICACAO",
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                column: "ID_PUBLICACAO",
                principalSchema: "Fórum",
                principalTable: "FORUM_PUBLICACAO_SOLICITACAO",
                principalColumn: "ID_SOLICITACAO_PUBLICACAO");
        }
    }
}
