using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vivo_Apps_API.Migrations.ForumRTCZ
{
    /// <inheritdoc />
    public partial class InsertDataTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FORUM_PUBLICACAO_FORUM_PUBLICACAO_SOLICITACAO_ID_PUBLICACAO",
                schema: "Fórum",
                table: "FORUM_PUBLICACAO");

            migrationBuilder.DropForeignKey(
                name: "FK_FORUM_PUBLICACAO_JORNADA_BD_TEMAS_SUB_TEMAS_SUB_TEMA",
                schema: "Fórum",
                table: "FORUM_PUBLICACAO");

            migrationBuilder.DropIndex(
                name: "IX_FORUM_PUBLICACAO_SUB_TEMA",
                schema: "Fórum",
                table: "FORUM_PUBLICACAO");

            migrationBuilder.DropColumn(
                name: "SUB_TEMA",
                schema: "Fórum",
                table: "FORUM_PUBLICACAO");

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

            migrationBuilder.CreateIndex(
                name: "IX_FORUM_PUBLICACAO_ID_SOLICITACAO_PUBLICACAO",
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                column: "ID_SOLICITACAO_PUBLICACAO");

            migrationBuilder.AddForeignKey(
                name: "FK_FORUM_PUBLICACAO_FORUM_PUBLICACAO_SOLICITACAO_ID_SOLICITACAO_PUBLICACAO",
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                column: "ID_SOLICITACAO_PUBLICACAO",
                principalSchema: "Fórum",
                principalTable: "FORUM_PUBLICACAO_SOLICITACAO",
                principalColumn: "ID_SOLICITACAO_PUBLICACAO",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FORUM_PUBLICACAO_FORUM_PUBLICACAO_SOLICITACAO_ID_SOLICITACAO_PUBLICACAO",
                schema: "Fórum",
                table: "FORUM_PUBLICACAO");

            migrationBuilder.DropIndex(
                name: "IX_FORUM_PUBLICACAO_ID_SOLICITACAO_PUBLICACAO",
                schema: "Fórum",
                table: "FORUM_PUBLICACAO");

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

            migrationBuilder.AddColumn<int>(
                name: "SUB_TEMA",
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FORUM_PUBLICACAO_SUB_TEMA",
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                column: "SUB_TEMA");

            migrationBuilder.AddForeignKey(
                name: "FK_FORUM_PUBLICACAO_FORUM_PUBLICACAO_SOLICITACAO_ID_PUBLICACAO",
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                column: "ID_PUBLICACAO",
                principalSchema: "Fórum",
                principalTable: "FORUM_PUBLICACAO_SOLICITACAO",
                principalColumn: "ID_SOLICITACAO_PUBLICACAO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FORUM_PUBLICACAO_JORNADA_BD_TEMAS_SUB_TEMAS_SUB_TEMA",
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                column: "SUB_TEMA",
                principalTable: "JORNADA_BD_TEMAS_SUB_TEMAS",
                principalColumn: "ID_SUB_TEMAS",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
