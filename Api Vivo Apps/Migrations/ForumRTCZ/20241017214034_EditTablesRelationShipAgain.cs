using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vivo_Apps_API.Migrations.ForumRTCZ
{
    /// <inheritdoc />
    public partial class EditTablesRelationShipAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_FORUM_AVALIACAO_PUBLICACAO_FORUM_PUBLICACAO_ID_PUBLICACAO",
            //    schema: "Fórum",
            //    table: "FORUM_AVALIACAO_PUBLICACAO");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_FORUM_AVALIACAO_PUBLICACAO_FORUM_PUBLICACAO_SOLICITACAO_ID_AVALIACAO",
            //    schema: "Fórum",
            //    table: "FORUM_AVALIACAO_PUBLICACAO");

            migrationBuilder.DropIndex(
                name: "IX_FORUM_PUBLICACAO_ID_SOLICITACAO_PUBLICACAO",
                schema: "Fórum",
                table: "FORUM_PUBLICACAO");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "ID_PUBLICACAO",
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                columns: new[] { "ID_AVALIACAO", "AVALIACAO", "ID_PUBLICACAO", "MATRICULA_RESPONSAVEL" },
                values: new object[,]
                {
                    { new Guid("009b5cd7-08c5-4d7a-a617-d2526f6d51ae"), 2, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("010ae429-5961-453f-ae8c-a6283f5a3a34"), 3, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("01c2fe4f-f9dd-47a6-a15e-412c1a71ce71"), 1, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("01f9af92-5b54-4e77-9002-573b8e16b125"), 1, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("03ad985f-0602-47a8-8fdc-e7dbaf24cc5f"), 4, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("03c58242-7703-498a-8676-df9dba7cf54f"), 1, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("03f5ae31-9e76-4ef3-8927-261f2db5cd77"), 1, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("047f03ae-4a68-41c9-b556-28262753ec52"), 1, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("04f0637c-ace8-4f89-a5ce-af0e09552350"), 4, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("072500cb-e3a1-48dd-89da-cd6ec614daef"), 2, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("077f331f-e019-4955-894e-33a12f7b64b3"), 1, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("07c6bee1-0aaf-4f95-b6b7-822c49b31401"), 2, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("083a545a-9cd1-44db-8ef1-ca16b985753c"), 4, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("0991ca46-7610-4bde-93b4-a07e9b986ed6"), 3, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("0991ee33-3804-49c2-a1b9-286d4698c7d5"), 1, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("099c66e6-5ca7-4eab-81e1-7701603f461f"), 3, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("09ca1e80-34c6-4964-8a76-2832bb978095"), 2, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("0a0bea61-9108-4de0-8f11-0895fd64fb6b"), 3, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("0a92a8e8-b9cc-4f34-b84b-45a14ef2a9cb"), 1, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("0ba4ddf5-181a-4ed5-a817-b6ea16bfa35a"), 2, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("0bb51741-15f6-4511-815a-3cbb170588d3"), 3, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("0bf33772-659a-47f4-8e08-747f6cc5b4d9"), 3, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("0c7f541e-4356-46c7-875a-91bc4142c0f9"), 3, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("0ccc34f6-aa36-4d1a-aa71-21bb4507d4e6"), 2, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("0e17debf-8a4c-4813-bd16-bf83df51474d"), 2, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("0fdca43a-81f2-4d3c-836c-8a6d8115cafe"), 2, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("10844e96-9f61-4526-9cf5-ae3b20fc8d3d"), 3, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("10e1ce1a-bf29-4225-9cce-b6c5c9b3b210"), 4, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("117417a2-05a8-4772-ba9b-8bb6e79c6f19"), 3, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("11d60a8f-5cff-477e-ac3d-b81c103dd8fc"), 3, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("120f16d0-2bbf-499d-9afb-c0bd2ee89c63"), 2, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("12337ff9-07d2-45bb-9bd7-d221244189c2"), 1, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("129f7195-d6fd-4b9a-a723-1df9e4f17617"), 1, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("12a19735-b85f-48a9-bde9-03dd9ed34ac7"), 3, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("1437f8e1-d4ae-4733-8c79-0edc06de8eb1"), 1, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("14ddd805-c27b-4f84-8256-9b6b5e48ef4e"), 3, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("15fe7662-6e13-4858-97ff-d46833e5a238"), 4, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("166d4bc4-c5b8-4287-b9f4-28db7dcf89af"), 1, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("169f5690-9acb-4586-b302-50a579abca62"), 2, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("1740daec-10a9-4ab2-adbe-700a8defa17f"), 4, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("18ba938f-b71d-4f47-8d12-2772567a8830"), 2, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("18fa197d-310e-45c3-81cb-d33d88b5a8a8"), 3, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("1926237d-f4dd-4153-81de-c44c2723a825"), 1, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("1a1150cc-dcad-495e-943c-a035a7ff8c91"), 3, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("1b44968e-07e7-49fa-83f4-88fcb6e6e5ac"), 4, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("1b71a8c7-8f42-47e0-8dc1-ee9736b642b0"), 2, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("1bd07762-ee97-4649-ace4-e3602901ed1c"), 4, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("1d1c7a76-6249-4e8b-bda2-836d3c99cb6c"), 3, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("1d478cd1-8a96-47d4-8965-6c9b21357256"), 1, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("1db8df66-7735-4f1c-a86e-9e5aa8a4da43"), 1, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("1dbda91d-e449-4305-8446-69b4d2f428d9"), 3, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("1eca6e06-b9a5-4ca9-9e58-05ccc4c5af82"), 4, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("1ff65b5f-00c0-4ee0-856c-a2b6a9d37450"), 1, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("20fc2240-274a-47dc-bfe5-24475cb7fbfb"), 2, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("2130e959-d7e9-4a76-ac82-91448dde056f"), 1, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("214e8e4b-7f99-47a5-854b-d6bd1c51b325"), 2, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("2155441b-9848-4f0c-b326-f6a81a570fc4"), 3, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("21dffa61-dda9-4d3c-a750-be3253a1dc60"), 2, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("22f0dffd-a11d-47ac-aaf2-ea3cf7b5112f"), 1, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("24c1c38e-5603-441f-b619-313772ef4e14"), 2, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("25ceaec5-c6e2-414a-be22-886ef5e5127b"), 2, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("263c382c-9c08-4a36-bb2b-901ad83106e8"), 2, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("269c4391-d6f3-4412-8461-1b0b3b927ac5"), 3, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("26eab067-2d09-4a97-8b28-73d3a8f334d0"), 4, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("2796103a-8ab2-42fe-b21f-f6af462dcfad"), 4, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("2835c533-2df4-401b-b36b-4abdadbe4532"), 3, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("297cc5c0-7f8e-4e5e-95db-c5e070814516"), 2, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("2a261384-1575-4fdb-ab3c-4b8942dc32fb"), 4, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("2aa6bc07-9daa-49a3-b344-7102c08a7011"), 4, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("2ad2e8c9-e6a7-4a88-a4be-35057ad7a919"), 4, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("2b11eeb5-1912-4e6a-9c8a-8034c994a6e3"), 4, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("2c450bee-57fd-4f57-b95b-19507b8411d5"), 2, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("2c7824a4-9b13-473b-a068-813c38ba8e49"), 4, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("2d60d383-31d2-42a9-ae29-9722e72f11d2"), 2, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("2d7465f5-5176-4a89-bfa0-160544310e7b"), 1, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("2dddf397-651d-400e-b460-6809b6180686"), 2, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("2e35a705-9bcd-44b4-aa6d-84960d967350"), 4, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("2e42b858-48df-409c-b922-dc2f8d50c47a"), 2, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("2e80b469-2b74-488d-b57b-68606aa96775"), 3, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("2eba09d3-12d7-41d9-89e7-4aa3ef96044a"), 4, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("30a0e2d8-d2ec-4f63-9a28-56e013552578"), 2, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("31b1eade-1e0f-442b-9a52-033fd1d088f3"), 4, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("31bf5618-2929-48e5-9015-7cc2c958349b"), 4, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("321e717d-15d1-45c1-ab7b-9217d75ab3d2"), 1, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("3280e03b-214d-44a5-9af7-e737ca8ad960"), 4, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("3288fd4e-1f53-4970-8580-afe8b1f75a01"), 3, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("3290d03a-fba0-4979-a1c9-ef4888072844"), 3, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("32de6077-1bc0-4423-8315-ae4843705578"), 2, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("335fe6e3-96c9-4b01-aa05-a2eea61dede4"), 4, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("33be98c6-dc3c-4761-8d7e-4f39da7fe2fd"), 2, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("33df7354-8e56-4d43-9c35-d791c946539f"), 1, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("33ee1575-9fd9-4c53-997a-cb0d393314f1"), 2, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("34ccf1ef-0be4-4594-be79-4d8c42878241"), 2, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("35069333-952c-46b1-be19-9fc3d8a8fa04"), 4, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("3560015f-5779-46f7-95f4-39024570f998"), 3, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("358962ad-5f9f-443a-a1f1-8e464b11d5ff"), 2, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("358de2b0-3043-4e81-a761-5ee57ef1ab9c"), 1, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("35e3ed7c-c587-4f70-b1fe-c9063315c5e8"), 4, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("375a4746-f477-477b-b337-6e5238d1e9de"), 1, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("377f5a79-207c-4f31-94af-3cbf7a2f7bf1"), 3, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("38397856-f382-4fb9-a2d0-6430384b15d3"), 2, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("395ef341-3fa9-40e2-9e9a-7afcc9fbb0d9"), 4, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("3a314820-d2fc-4783-9067-427f54139490"), 3, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("3a43a337-831c-49d8-9226-8e552f52a35a"), 2, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("3aa59755-1aad-4979-b4ab-75647dfb95e4"), 1, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("3c2d30b4-55ef-45f5-92c8-80f29c08e44c"), 4, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("3c5d7b01-a5c4-468c-888c-5b951b567f1a"), 4, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("3d008140-2560-4d17-a3e5-6afcecbba804"), 3, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("3d76326a-dad4-4e60-ab2b-a55dbb6b5520"), 2, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("3e14cc1b-8c93-4360-851b-b0be29cc71a9"), 4, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("3e5f5f53-0606-4476-84f7-4479671a17ad"), 4, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("3fa294db-767a-4d93-8c38-0c5bbaeda9e6"), 3, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("3fe19121-ae42-457c-8630-276cf03a09a0"), 1, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("401e3cd4-0d31-4730-a144-f6d35e985ea5"), 2, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("40c7e610-1c3d-4006-a12c-f3133a703579"), 2, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("414a4ac0-28ca-48e0-860e-84d6ce54d969"), 3, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("41b9d319-398b-47fe-923b-f0f0620608c3"), 4, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("42418009-0795-4b5b-8000-8a12edab6607"), 1, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("42929052-2619-468c-a3f8-0ec33e882990"), 3, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("43396470-0d98-4318-8093-3f64b664c512"), 2, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("4382f812-4dc7-48e4-bd99-0562d1a0a3e6"), 3, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("43a8cca6-5cc6-4de3-a66a-e12ee6a0e160"), 2, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("43ba938e-ddfc-4474-b996-6ddd690704b2"), 4, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("4403cf70-0da8-4d49-9aa4-c0386d8a823e"), 2, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("44f36b9e-9f95-4708-bcba-5eccbf3f00b4"), 2, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("45362d1c-9a38-4ddf-8cb2-3200ba7f8763"), 2, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("454462ee-3953-41e6-9fe3-a1c3b9d8498d"), 3, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("455de7b5-e2a0-4adf-abff-08c8a5ce0894"), 4, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("45db5515-8abb-4f96-a5c4-dcafcb4124db"), 4, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("46bc233a-04e7-44c3-ab51-54b60ec196c0"), 3, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("46eafb91-00ed-4512-9b6c-3d0bcbe5b578"), 4, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("47b11d2e-d7c2-443f-9a15-dce5ad685791"), 3, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("482bfb3a-7467-4ed9-bfa7-0c2328770182"), 4, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("488e6775-ed37-4e7f-b84b-723af72677c1"), 1, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("4908469f-e898-43b8-aa12-4b5b9459caad"), 3, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("49d00c41-8bcc-4ea3-aae9-69f348e982b9"), 4, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("4a55376e-1479-4699-9f17-ccc8425d9637"), 3, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("4a70e262-ede0-4242-acf4-a7838e0de692"), 2, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("4bd00096-8945-49aa-b34b-a1945bf9ce2d"), 3, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("4d07e13e-8eab-4d0d-9195-6621ca152172"), 2, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("4d612aa1-7192-4dfd-bc0c-130fa98dccc4"), 3, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("4d885f8d-ec3b-4165-8a41-1187f062ca92"), 4, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("4dd0af53-d0e3-44d3-b479-c952f2940f75"), 3, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("4df14569-2855-47e9-a8ff-88820571c2f7"), 1, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("4f081235-4b5b-46a8-bc79-d830eac5410a"), 3, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("4fa5d373-76cd-44e0-943e-89a441ff2a8b"), 1, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("50448cb8-6065-4bb2-b31a-25bb0ba900c4"), 2, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("50949020-8adc-480e-9866-b24bd3ee6072"), 1, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("51eb6b12-295c-4504-8ba4-fcaddd27926e"), 4, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("52154811-2667-4273-a9d2-d424943a19ca"), 3, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("52480f6d-75f8-4690-b3ce-29656f237125"), 1, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("525ab72a-420c-4ae7-bf9f-549b7717d690"), 2, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("52deed40-71ce-4ffa-a2fd-a339342702d3"), 1, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("536e24c6-9d1f-4237-ab61-5f6a156a2fb6"), 4, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("544438f0-ae20-43cb-b407-7cb01cc49fe6"), 2, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("54f22ac4-f206-40f4-8abf-28bcb0ba57e1"), 3, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("566aebff-3223-47b2-8367-e266bb0894d0"), 2, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("5773980b-bb94-4d10-914f-09138455861a"), 3, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("58030517-6953-4dcc-a7bc-172317bacc3e"), 2, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("5871a0c7-a5ac-47c7-bb97-b8dabbb97cd1"), 4, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("5a2005f8-e7b9-4d21-ae15-897c10ed2cfd"), 3, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("5ac3a917-5e61-4c73-8f84-21a6b60572f2"), 1, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("5b83fa97-b5ea-4c7e-b168-44d37f517487"), 4, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("5cd62a6d-9ce5-44ac-be4f-e4cf9ab63dab"), 3, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("5d8780cc-4278-42c9-9d54-143e3101333f"), 1, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("5e0c3eda-7049-48ab-a3b4-e0a9be20bd46"), 3, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("5e1f6887-ecde-47d4-9eb7-bc01862e5c62"), 3, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("5ecf7ac8-cc92-49de-aa88-5875ee3444a6"), 2, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("5f3113e0-a657-449d-a5eb-6f8cfe6e8b91"), 1, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("5fc14bfa-9d8c-4dc2-b8fa-454f9f6b4953"), 1, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("6067a5e1-4267-48e5-9d8e-36ef25e3249e"), 1, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("60e6df5c-9f42-4f35-a519-5ef62cc75908"), 3, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("60fed711-b249-4158-a570-c396f50398ed"), 2, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("6146b995-5ff3-4a4f-8241-5f6f88ff4fc8"), 4, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("6185694f-7390-4cf8-a464-9572471ad4de"), 1, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("62241b4d-5397-402f-90b1-183f1d7120ec"), 4, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("63bd42fe-5821-4f75-a02c-e11e08198eea"), 4, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("63de81f6-0c76-49dc-ad40-d5d592c4519c"), 4, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("641975cb-d8b1-4b72-86e2-ef52adeff12b"), 3, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("6422cfab-ad09-4e62-8c64-49ee04a811e3"), 4, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("64febadd-cb20-4c4c-93f9-6824226b72eb"), 1, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("652990f6-8161-4530-a138-e9ce8ce99226"), 3, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("65d3038e-dd15-43ce-9640-d8ebf4e3af1f"), 1, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("66557c81-71fc-4e98-a398-36d66122c837"), 2, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("6681c5c5-cabf-482c-87a8-bdebf30764d3"), 3, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("66a0164f-9626-4880-869b-1d99fc7d13c5"), 4, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("66d2acee-2d6d-4649-961e-e655caf1c01f"), 1, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("67af5cad-c991-43ae-9824-c48e37ac5b0a"), 2, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("685d99fb-631e-40f9-9945-ffbdddd2c20c"), 3, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("68d1483c-b92d-4af5-9fc2-a3be08849855"), 3, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("68e387e1-36fd-4d62-b5c4-34c04324b9c8"), 4, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("693c83dc-354a-41c7-ad70-3352eb1046f8"), 1, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("699bf765-3225-406d-8495-bbaa905d4edd"), 2, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("6abd8049-46ce-4a31-b849-743f8d774f78"), 4, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("6adb9fb8-6359-43fa-9b00-fef4d10953bc"), 3, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("6addbf3e-10ef-4e24-b1ec-e4de678ab931"), 2, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("6be03f11-4a9d-4fb6-8803-42885ab1ecf5"), 2, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("6cadce85-f76f-42b2-be99-5274f710ae68"), 4, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("6e894aad-c6cc-49a4-a56f-6608856b62c4"), 2, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("6eefed13-9eec-43ad-9ad7-2875e9481077"), 2, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("70283978-c3df-46aa-846e-65547285e618"), 4, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("7075b889-a6a6-4ea8-af50-b76f81dd3890"), 3, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("71287f9e-0bf8-4825-be2b-8ba025088dbf"), 4, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("71556580-f545-48a2-9b3a-31deb8460368"), 2, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("717d4a7f-26ac-46a1-a580-4e50b8421159"), 4, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("71b03c36-b99b-4a36-b106-4f531883cdad"), 2, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("7242f959-30ab-40f0-b6c1-01da49e7472e"), 2, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("72f0bf6e-eeb9-4e70-a701-d0a95ab904d4"), 1, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("73196418-51a0-4e93-95ea-a36caf6150bc"), 3, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("7356d295-1cee-4405-b561-8ebaf18b07a4"), 3, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("73c3e851-0883-4ad6-9700-f1333858e234"), 2, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("743d6b15-34c2-4388-b0af-67450afffecd"), 1, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("761e79b4-e8f0-4da8-aba7-4f809e771597"), 2, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("7622d7f8-d6d7-4ce7-be3a-e7f053b578f0"), 2, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("76770819-466f-4281-a8bb-6c065f7e60b0"), 3, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("76cb0b1f-cda6-449a-a05a-1d942e69165d"), 2, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("77081944-b0a6-40cf-a6e0-c988befe9d6a"), 1, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("77808bf5-14fb-4a7c-8f25-565821313555"), 3, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("78273e74-50aa-42a9-bf51-89e4b81bae15"), 2, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("7860736a-17cf-4556-9fc2-8609f4e121a4"), 4, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("78d9af0b-8164-4f10-a1cd-1484955ac8cb"), 4, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("797c193b-046a-414f-bd90-8709551f4ee5"), 4, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("7a3b39c0-d4f6-473c-887b-4f1941b82703"), 1, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("7b5865c0-3771-47bb-b5ab-8949ea961ece"), 3, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("7b5d091c-1ca4-47db-a795-4221672cb3a9"), 1, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("7bd2b5a6-8583-4b81-9d0d-53c048ec141a"), 4, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("7c8b7ba3-89e3-4233-8c66-6269d6758f8e"), 4, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("7e3372df-1e40-4a19-a64e-2de92f5f7389"), 2, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("7eee5b14-00a3-40d7-8590-f4971b86c523"), 2, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("7f4a906e-e7d9-4250-a3e7-0a928b248131"), 3, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("7f6372fd-8055-4469-bcbb-0a5c5bc5883c"), 4, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("7f71ef08-5b4d-43ad-900a-7cfaf0c9c28c"), 4, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("80e26c4c-9b92-4929-808c-e6b5947fc201"), 1, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("81023c84-942c-4b7a-a04d-cf23f9122b0a"), 3, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("8112cd2d-2d25-4823-8b47-880af59e5797"), 4, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("815d3533-9a76-4c66-b965-94be9d03c8e9"), 4, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("818ecb24-b02c-441f-8692-13337cb43455"), 3, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("81ad2b96-c807-4cd8-8d6b-a5777d6cdf5d"), 4, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("82bd9c73-0f93-4664-939b-a0ef56090388"), 1, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("82f2bf7f-1e79-478c-b1fe-5099edbd4841"), 2, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("83c9bc42-3175-4873-a536-dc3db414d27d"), 3, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("842b2fef-19b8-4e5b-b668-a3a062e9425e"), 1, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("8451a0a5-8322-4cce-b5c6-908bfd3944f6"), 4, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("84abf745-5625-4931-88aa-dfc81c7c2ab2"), 2, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("87acf542-1311-4af1-abfd-73d0cf88c74a"), 1, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("87c2f043-f12d-4ce9-9df3-28789e2b0d65"), 2, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("87f08cca-cf88-4b9f-9c55-93d40bc55e92"), 1, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("88a94f7a-57be-4357-a1ce-c3ad455edc1f"), 3, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("88e5462b-89b9-449b-afff-46d68d5b4617"), 2, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("88fde9f1-b3c0-4b23-847f-f5b690a7061e"), 1, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("895b0a5f-8f13-4fa0-8fe8-19a16d9c228f"), 4, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("89d73f77-47c0-4feb-b0f7-c5183668afe0"), 4, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("89e5bfa7-ef68-45b7-865e-43b2c7c31f6d"), 1, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("8a05ab72-05bb-4e88-a320-298e9c5dcdb7"), 2, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("8b632ee9-a081-41d8-a680-08a9fb5f74b8"), 1, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("8bb6ccf2-85f6-4001-8982-e30f7b5b28d2"), 4, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("8c00cc38-5115-47ed-91a1-8a7a4bfa874c"), 4, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("8c07df47-01d2-4e41-99e3-0542ae7aa758"), 3, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("8c78edb7-81fd-4ee4-ab53-e8ba2ca71202"), 1, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("8f5d1d5e-087c-4e1a-b1ea-6159b85aff12"), 1, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("8fc393a0-2690-488a-8fcc-e6d1815655bc"), 3, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("9149c4c2-9a28-4016-9c97-87770feade98"), 4, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("9285fbc9-ddf2-4fcb-9656-2449da25d6d9"), 1, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("92860ab0-d5a8-4c68-8dbb-8df66df37eaf"), 2, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("946da6f4-de13-4326-9012-26116bb3267d"), 2, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("94a6c4ed-5066-4fbf-95ac-3d5fbb94d51b"), 3, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("95d7b645-f54a-4b38-b2f4-fac1a9b0c365"), 3, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("9666648e-905d-41cd-9c66-22c8dea05795"), 4, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("97190036-fe35-45be-91d4-d2f1d78c6fee"), 1, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("9771e996-4fb7-4f68-b1f9-07cfb708c760"), 1, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("97d8a71f-4626-47ce-a07e-f804f97e5326"), 3, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("97f6aa21-3f21-4955-8176-bc7283dcd5a2"), 1, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("98476af4-c641-4aaf-8893-b96f0a28c833"), 1, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("98ea312c-ec32-4aa4-824e-dd889b7380c9"), 2, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("999ab7a8-f524-450d-8f9b-3210d1f11a41"), 2, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("9b332062-a73a-4c9d-a51d-9c579cd1ee71"), 2, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("9c6f6d37-fdfc-40b7-a7a6-4b2ca8e60338"), 4, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("9d2ecb28-08c4-4bd5-b7f4-12c4b59b3a3e"), 1, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("9dfe2e2e-e4f3-41e5-bcc3-ba5d367135e9"), 2, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("9ee04d85-7a9e-45bd-86c4-635c738f2f5e"), 4, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("a03aa42e-78b3-4f8c-bb5d-6ea1fcd66f13"), 4, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("a157e850-cbab-450c-800c-4eb9f522a623"), 1, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("a19b6fbe-b9f2-4dd4-bff4-871058c070a8"), 3, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("a1b4a442-0af1-4bf7-9e00-2eed5fe7513f"), 2, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("a37778d6-59cc-45eb-8d08-80777e2a18f6"), 1, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("a3c3ddeb-f31c-4ba1-9f31-946c5ed0e5d5"), 2, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("a513a9d1-1146-4f63-829e-3eba89c51b2e"), 4, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("a670b6f0-e526-459f-bb40-5a5b43633552"), 1, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("a89c3f5d-cc08-439a-8d9c-c8256cfdbacb"), 1, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("a8d90d1d-885c-43e9-b5cc-a4fa9fed2ba6"), 2, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("a8e742e6-5bb7-41a3-a2b2-011bcbd18cff"), 2, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("a92a88e5-3344-4439-bb37-c85ccec88123"), 1, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("a9f7ad57-ba0e-4b96-a6e5-0a966808ecd6"), 4, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("aa6efb04-eae1-46b3-80e6-cca7b4491ce6"), 2, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("aa76d5dd-055b-40ae-814e-e0553bbc70ea"), 2, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("aaf19263-ec21-4afe-b2e6-75a82fd5b4d1"), 3, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("ac55f90b-8ba3-4242-a432-9ad241bcc2c9"), 2, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("acb4f46d-50b7-4dba-ab03-dc4c8b3f47b7"), 1, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("acf28e44-cd93-40c5-9447-b5d8410f0873"), 3, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("ad007473-46bd-4fa8-8418-abe19e317bc4"), 1, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("ad23a013-5703-4909-a0d0-f46f0a7e23a0"), 3, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("ad2a3a01-de7a-42a9-a8ce-0bbb4b580177"), 3, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("ad7e0c0e-5084-4490-9942-ddd906a19e1e"), 3, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("b0ca869d-f0ae-407a-8da9-f13220ae78b3"), 3, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("b0e33811-1c37-436d-b6f4-434591bb941c"), 1, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("b2a2dc57-63dd-4429-87af-5709c621fc51"), 3, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("b339a965-e391-4d5c-969a-38c2ab28b8a8"), 1, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("b38a063b-785c-4979-8d2a-ca6bcdf98454"), 4, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("b4f814ae-2be6-40a9-b32b-bffa97e747c1"), 4, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("b549aa17-1439-4533-a01e-6f0214f578d6"), 1, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("b54a362b-2303-4f1f-a998-1712d6f622c1"), 1, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("b5cda8fd-650a-48e9-aee5-0da95c78d679"), 2, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("b5ce8a53-fbe3-41e4-aaca-2cb42638f5e7"), 4, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("b66c447b-9f01-4433-bc52-1a2df5616c42"), 4, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("b6c88812-4300-4d60-acd8-8d7710d77d3e"), 3, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("b75cf35b-0787-40e6-9cb1-cdb19c271b42"), 4, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("b83d0f04-7b74-465c-a0b3-7e4952e561ef"), 2, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("b8d46eb8-3972-42cb-8713-82bfce98c4cf"), 4, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("b9bf8833-d956-477f-add1-f90bd0675ada"), 2, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("b9cf7791-073a-4e91-89e6-8c1e3f7ba7a4"), 3, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("ba096911-6d4f-473a-828a-0cd4829ef0d3"), 4, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("ba3ead92-be22-4153-8886-1211480bc36c"), 1, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("bb0fa2a6-4f6d-4607-8e31-4e17388346ea"), 3, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("bbc8adf1-995c-4fe1-9416-3af8f930bedb"), 1, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("bc2fad38-f547-4588-89f0-cf753d4f5dc5"), 4, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("bcfea81b-870c-499f-9377-a890b0588a22"), 1, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("bd0af52a-f317-4998-ae09-ddd9d787d198"), 4, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("bdae0e77-416c-4bba-b011-d1d2cb3d77d6"), 2, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("bdc72552-882c-477c-a707-be726b5e28e8"), 3, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("bef9b235-75f6-4a88-966b-ac8d5b476932"), 4, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("bf48bb86-8be8-4a8a-b350-4dc1430f1594"), 4, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("bff5ffa2-c0f3-4d7f-950e-0f997f011491"), 2, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("c02e1144-497b-4c96-bcc4-9ea2abed09fc"), 3, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("c08a83f2-40d6-483c-890c-6db656b0929d"), 4, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("c0c7ac9f-85dc-4629-8b47-01bf5f35dd06"), 3, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("c1094c21-9bd3-4ff7-95f5-29936f25b84c"), 4, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("c12a0aa4-3431-467d-b246-4b63e6a4a844"), 1, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("c1b19394-0856-4c06-a262-8fb4db801440"), 2, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("c3f5e041-03d5-4a16-8116-7e4ec30c24bc"), 3, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("c45e7edd-716b-4f86-81d9-72b94bed3df1"), 1, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("c4bbb658-8e5e-4214-ae91-f7ed900c6d2d"), 1, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("c4d3451b-2b85-4231-87f7-ea0b5c05894e"), 3, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("c58a4a7e-20c9-4171-bf73-e37f468e7d2f"), 3, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("c5a4d06f-7b23-417c-b812-464cd3043466"), 3, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("c6d003c1-a44e-43bd-9172-3ad45d0a0f86"), 3, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("c78dbd3b-07ca-41be-9025-a38183d7c339"), 3, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("c7f3807b-a368-4c31-bac6-fa7701178ddd"), 3, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("c82f005b-6088-4b31-b772-de04f779395a"), 4, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("c83e8765-2ba3-4b43-8baa-11a09da5f735"), 1, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("c8ad7409-0895-435f-8daf-19d6c3219994"), 4, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("c8d434e7-75a8-4053-9e4e-0855842710b8"), 2, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("c90506b7-1c33-4c0b-9a07-0da43fa29c27"), 3, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("ca30fd56-1e7a-4b2c-b2fb-415664458218"), 1, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("caa023b4-400a-4a08-890d-15e7386d2e48"), 2, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("cb470ccb-56ca-43a5-9b2d-1a3720d99c28"), 1, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("cbca740e-3e2a-4d70-ae8c-d8a681422945"), 4, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("cd1174cd-2cfb-48db-95cc-3fb1e9806792"), 2, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("cd3a20b0-454b-4f4c-94cb-c0d4691df87f"), 1, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("cee812c1-a80e-472d-b61f-a3f9c7ab76e4"), 4, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("cf36ed73-f990-4143-97c3-72ad8ce6fc01"), 1, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("cf49583a-d7c7-445b-a352-2364cb1342ae"), 2, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("cf7217e8-b8a6-4378-8d03-322880b43d32"), 3, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("d12e566b-4abe-4acc-8e01-ed530df81f04"), 1, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("d17d2d5e-9e63-42f0-9bb6-bc888bcb96a9"), 3, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("d28c7964-3506-4e4a-b61d-7d3886677e88"), 4, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("d2a5f7a7-ed71-4e56-9359-21d5e7d2992a"), 2, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("d5acb380-8860-470a-9bc5-5c4bc5155faf"), 1, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("d6610d2f-d1f7-421e-b33a-a4af1e23b83a"), 3, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("d777b2dd-a03a-4243-9512-c1e354ac6ed0"), 3, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("d7d4aedb-46ab-49fb-ac3d-4555ace5ae98"), 1, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("d85cc3d5-6c94-4f3a-853a-3f821ccee607"), 4, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("d90441d5-0783-435e-a3d6-eefdad880d43"), 2, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("db072129-158a-4117-a4f0-d658f514c9ee"), 3, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("db52ed91-6833-4337-8c51-e8418e661501"), 3, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("db991176-794b-4736-9f12-6ef01ea81661"), 2, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("db9db20c-2c22-44d4-92dc-0980eb79526c"), 1, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("dc290097-79d8-4a86-ad62-0e9ec0921217"), 4, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("dc37dd4e-7534-4aa3-97eb-ff067203572b"), 3, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("dc9d95e9-eadd-46c5-93d4-734b9ab3ec60"), 1, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("dcff258d-9260-4c64-bb7c-aa9bf04632a8"), 2, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("de1b1cfa-c258-4d2d-904a-4ab889bee664"), 4, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("de3d439d-80a4-4937-b09f-53ed5acfdb57"), 2, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("deabbcfe-1714-4163-8902-34d68d4bb0d4"), 4, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("dedab8da-b803-43ae-be00-aa09d6f87329"), 1, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("df1974d7-e56a-4182-8380-bfe316e18b24"), 1, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("df6ed450-f281-4471-9f6b-b126f750f19f"), 2, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("df90d294-7869-460a-a34b-b68325f2fb94"), 2, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("dfb8dfce-64be-405d-8e4c-7439ab0e759c"), 1, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("dfc64efa-5a2f-4d02-b1d8-e59f51660862"), 3, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("e024123a-01ac-42bd-b7aa-34374b93fcb8"), 1, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("e03a1c6c-f695-410b-aeab-80d4dfa1a32c"), 1, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("e03a1d70-7983-420e-aa6a-6f7174dab32e"), 1, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("e0db1f39-0e28-4416-a263-d9361ca20af5"), 1, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("e19dea53-8e2b-47f0-abf8-2bd7b45db19f"), 4, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("e2bbaab5-0829-4308-b029-1c8560f939c3"), 3, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("e38606ce-e6cc-49f0-8127-7563e67f3b8b"), 4, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("e3f4f1cb-23a0-4926-9736-5989127e5937"), 4, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("e47c1faf-79a7-4695-8ddf-2d3594a185c7"), 2, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("e4c6eb65-2f14-4ac5-96a5-32286b316a63"), 3, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("e5bfdcc0-6632-4e37-913a-4cf76a9f7dfd"), 3, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("e62a2084-6c40-418f-be7f-64b1cb4b95a6"), 4, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("e6992217-8d59-4fb9-837d-b5d6688fda4d"), 1, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("e6fa8112-aee0-480c-95fd-978e888d5be7"), 3, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("e7276db3-7eaf-40c1-b771-f5a9d8a2f5ee"), 1, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("e91e80d9-b943-4840-8691-cb9649711b91"), 3, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("e933f121-1015-4ed7-9d9e-4d50ecc0835c"), 4, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("e9588864-c5ce-4816-939a-fa1745435304"), 2, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("eae64783-3a1c-4214-a633-6613c68c8dd4"), 3, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("eb0d8d95-117c-42d9-87b6-f15b56d3d25c"), 4, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("eb903c01-5693-4bae-b199-06e26d8331a9"), 4, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("ee785283-29dc-488c-adf0-8686e77af202"), 4, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("ee8d3b21-649d-4919-9152-f8454b810939"), 1, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("eedee811-6703-4cba-9ab6-fbf870496e99"), 4, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("ef5eaeb2-d2d8-40f0-88d3-eed7b79472b6"), 3, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("f010c0af-d738-4ff1-831a-eecfd19692de"), 3, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("f0407f69-0089-470b-a54b-2c59bbb51c0a"), 3, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("f08e67ba-ca39-4438-a283-a7fd2fc0981e"), 1, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("f1e16ebd-fd30-47bb-ae2c-6706f06b1150"), 3, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("f1f3ffd2-04c5-4b83-be05-ed4e55c076b8"), 4, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("f2999255-80a7-4bd2-8ac8-9eecdaa9d783"), 2, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("f395644f-288a-481c-94ac-562fa01d9978"), 1, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("f3bab226-6f5a-419b-922b-2de130df3fc7"), 1, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("f3d85a34-f19a-431b-8f24-48d540e1c67f"), 3, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("f3f73ceb-c880-4a0d-81a2-ef0fda6bb2d5"), 1, new Guid("f7901011-9590-4066-8c36-f592c68817b7"), 151191 },
                    { new Guid("f4ab9780-cb04-485a-8d4f-2260577f6207"), 4, new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), 151191 },
                    { new Guid("f53d266d-a6a7-433f-a2d0-233c3ef55152"), 1, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("f6aa87c6-e4c8-46a8-909c-2c13cbd5c621"), 3, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("f6d7ed9f-da61-479e-9f5f-900087287fbd"), 3, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("f76b18c4-4b1b-46c8-ace2-d9fdfd48c445"), 1, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("f799d868-703f-437f-8fba-7ca21744ba5c"), 3, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("f7b1b54a-8600-49f8-bfaa-378c229fb319"), 1, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("f8ad8237-5e9e-42d5-8209-9717ab9fe03f"), 1, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("f8d26349-1f50-44fd-b1ff-505a8c8a1254"), 2, new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), 151191 },
                    { new Guid("f90f276a-eb82-4747-ae5a-4d6dbc8ba1d9"), 2, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("fae9c0be-b6a8-4b34-ae9a-954390f81ac2"), 2, new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), 151191 },
                    { new Guid("fc38b68a-817b-4480-a359-2c111cd5e743"), 2, new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), 151191 },
                    { new Guid("fde5fdf1-b7dc-4794-8167-23d685291387"), 1, new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), 151191 },
                    { new Guid("fdf2ea5f-d73a-4fd3-9b87-4c4277e7d95a"), 2, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 },
                    { new Guid("ff3e1882-c479-4949-b075-fe9789220025"), 2, new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), 151191 },
                    { new Guid("ff6a8745-cc92-4a78-9c38-b8779fc7df67"), 2, new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), 151191 },
                    { new Guid("ffdf497b-8a00-45db-b9fc-721da3acce3e"), 1, new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), 151191 }
                });

            migrationBuilder.InsertData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO_SOLICITACAO",
                columns: new[] { "ID_SOLICITACAO_PUBLICACAO", "HORA", "MAT_RESPONSAVEL", "SUB_TEMA", "TEXT_PUBLICACAO" },
                values: new object[,]
                {
                    { new Guid("7c111573-c45d-4164-a207-28ac0866a764"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3020), 80904800, 113, "Apenas um teste de publicação no fórum do Giro V" },
                    { new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3040), 3511507, 77, "Apenas outro teste de publicação no fórum do Giro V" },
                    { new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3038), 156114, 41, "Apenas mais um teste de publicação no fórum do Giro V" }
                });

            migrationBuilder.InsertData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                columns: new[] { "ID_RESPONSAVEL_TEMA", "HORA", "MATRICULA_RESPONSAVEL", "SUB_TEMA" },
                values: new object[,]
                {
                    { new Guid("0263d15e-c6b3-458a-9d54-978d2c1f0a5f"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3724), 80886919, 49 },
                    { new Guid("02715d7b-8b26-411e-ad93-4fb67dc19f84"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3493), 80900909, 4 },
                    { new Guid("05bf8b92-ddec-44a1-a87f-0a7088171dd3"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3634), 80886919, 127 },
                    { new Guid("0b68c9aa-5101-4d2b-a719-356fca5d2a89"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3288), 157239, 69 },
                    { new Guid("11bdaad7-cdac-40b1-9e5c-566d4897bc4c"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3383), 25677, 80 },
                    { new Guid("11d7cb13-6ce3-4f36-9ddc-af9d43d70590"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3558), 40417113, 52 },
                    { new Guid("14164b28-fa7b-4340-beec-4473268b9ceb"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3272), 80886919, 109 },
                    { new Guid("15089a33-90d0-4c47-ab00-bdf3e0eaba51"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3884), 25677, 47 },
                    { new Guid("155a6420-9845-456c-962b-75b055c4dc87"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3551), 30722, 97 },
                    { new Guid("1736345f-408d-4d75-8f43-eddb497a485e"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3745), 160624, 43 },
                    { new Guid("18e266fc-0e7b-4db8-a985-52e1166f356c"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3838), 80900909, 88 },
                    { new Guid("1f97d55e-9476-4c35-ad32-4db1f39a3d93"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3954), 25677, 68 },
                    { new Guid("20461e6a-5d8b-4284-aa50-2da939854fc9"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3515), 3511507, 83 },
                    { new Guid("29c34a04-4d3e-40db-8853-5c576e423594"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3688), 25183, 126 },
                    { new Guid("2ae13bc5-6793-4573-92ea-ef732e532387"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3242), 69372, 122 },
                    { new Guid("2b5dbef5-65f7-4982-ba05-659fae04b9ce"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3303), 30722, 8 },
                    { new Guid("2bb6774c-793d-45a9-a44b-92a3a311f605"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3394), 71114, 121 },
                    { new Guid("2c0807a4-5484-4afc-bab0-76c64673cc18"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3625), 160624, 103 },
                    { new Guid("2c54e80a-f449-4234-a09a-97f978ca0fa6"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3390), 157239, 66 },
                    { new Guid("2f0cc7dd-7ce4-418c-8781-a217f5b7952c"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3251), 16279, 103 },
                    { new Guid("3398844e-f908-4061-8e40-f88a0acfa277"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3254), 3458749, 76 },
                    { new Guid("34c9dbe3-5735-4ead-8db8-9f0e0fcc790c"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3965), 40416900, 90 },
                    { new Guid("35a71f09-8691-40fa-aa51-cbb4ade21481"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3779), 80900909, 79 },
                    { new Guid("35ae383d-420d-4396-8682-5a9a5b26d93a"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3683), 94842, 120 },
                    { new Guid("38bbb9c4-a90d-485d-a21f-f6c0cbe09811"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3670), 40418413, 40 },
                    { new Guid("39d20686-933b-499f-951c-da2027612fa9"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3693), 80900909, 113 },
                    { new Guid("3a959ebd-8a95-40b8-8147-d82ff8bd7786"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3385), 47333, 107 },
                    { new Guid("3f0c1fc9-6b50-4ecc-9330-fc803d6b01e5"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3676), 40417113, 60 },
                    { new Guid("40ec5a59-6425-49c5-a1e6-c48925a2905c"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3485), 157239, 65 },
                    { new Guid("4537f970-61f7-4185-964e-0b4844efa405"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3548), 30722, 82 },
                    { new Guid("467a9ddb-ccde-4cdb-b7a8-12f6a6e6f045"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3420), 156114, 20 },
                    { new Guid("4969c4a8-0552-44b7-a856-17264619ba8c"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3673), 40418413, 124 },
                    { new Guid("4ac63c47-b049-43eb-9b51-f7e90444699d"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3743), 3458749, 34 },
                    { new Guid("525b6a8e-afc3-4e47-8e32-861ab39caad0"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3823), 25183, 13 },
                    { new Guid("535f9ef8-c87d-497f-9fba-36ee3643b7a0"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3619), 80900909, 117 },
                    { new Guid("540d6bd6-e7fe-420d-a306-f98c38e85a7f"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3417), 3458749, 9 },
                    { new Guid("55431397-bdc6-43e3-8ec2-b3d752120800"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3561), 3458749, 30 },
                    { new Guid("55e36de1-8310-437b-901e-91983c6e13ea"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3247), 40418413, 58 },
                    { new Guid("56514033-50d1-44ee-bbde-6cab3f4ebdce"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3257), 156114, 129 },
                    { new Guid("5680c418-437d-4d0f-96f2-1dd7f45df35e"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3498), 156114, 41 },
                    { new Guid("58bbbda0-2453-4fda-9aea-4b0a1f7a0d8b"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3898), 156727, 32 },
                    { new Guid("590ebd61-5175-450a-9ee7-c7f03f242f78"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3263), 152001, 116 },
                    { new Guid("5b20763e-5d44-4743-9163-805c1a0d1259"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3403), 80796597, 92 },
                    { new Guid("5d164151-5cfd-4b5c-8f52-9253ac02dbec"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3612), 30722, 67 },
                    { new Guid("61a265fa-7abf-431e-9a3b-40c4f4b867d3"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3277), 40418413, 12 },
                    { new Guid("6373f7f2-61b7-45af-8cb3-3251e40cb90f"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3397), 40418413, 74 },
                    { new Guid("64923624-1a53-4bf4-aa9d-35e2e28f2dc7"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3280), 80900909, 54 },
                    { new Guid("6914cbd0-fbdd-4c75-8612-5b79d2e07bc6"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3323), 47333, 57 },
                    { new Guid("6bb8e1ea-7ec9-44f0-8752-9465d4974403"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3426), 80796597, 108 },
                    { new Guid("6c5d21c5-a215-4834-a271-4f99c888be40"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3555), 40416900, 47 },
                    { new Guid("6df2979a-61be-40f3-87cb-02d2e4db8aeb"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3622), 51336, 50 },
                    { new Guid("6fafeb83-e5ea-4a2a-8e10-256bdb7edda4"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3901), 69372, 14 },
                    { new Guid("70007b70-7393-417e-93d6-6873a4650dcf"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3306), 156114, 60 },
                    { new Guid("72238dd2-b4f2-4fdd-9bf7-23a92fa7677e"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3406), 80900909, 39 },
                    { new Guid("735d7ea4-3fe6-4342-b95a-45cbf9e23af0"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3297), 156727, 44 },
                    { new Guid("7603b5e3-3f8a-476a-aaa6-95f172fc31fc"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3409), 80904800, 60 },
                    { new Guid("76a0d3b7-e626-4e4e-a58e-c7cc4fb8eac6"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3510), 80886919, 105 },
                    { new Guid("77ca015a-f92f-4fd0-ba5b-270423218165"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3793), 25677, 95 },
                    { new Guid("7e19fdee-dc75-4d90-8329-3bfc89234439"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3490), 69372, 77 },
                    { new Guid("81728431-9171-4c67-8f7b-4f362741abb1"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3827), 30722, 85 },
                    { new Guid("818e5dcd-e5e5-4b12-84dc-0909ce8566f7"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3614), 3458749, 106 },
                    { new Guid("849bd51c-7b3d-4587-a386-f7daf552e534"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3960), 80900909, 89 },
                    { new Guid("8a73a2d3-a903-4c16-9af9-04eab26b6080"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3730), 94842, 74 },
                    { new Guid("8c582c68-0177-4890-82a7-610a05ad49b8"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3835), 16279, 36 },
                    { new Guid("8d63ce11-9c2b-40f0-888e-81b839423be8"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3690), 80796597, 51 },
                    { new Guid("8dc4ab16-71fa-4c28-9145-0a75e4737c7e"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3747), 3511507, 84 },
                    { new Guid("8e440578-dff1-4cad-bd53-16a633c25c41"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3266), 25183, 114 },
                    { new Guid("8fcb5351-7fc5-4a51-8558-cc9bfca63b60"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3571), 69372, 14 },
                    { new Guid("92537d02-b8cd-4a4f-be97-b102c0a3e67e"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3617), 152001, 41 },
                    { new Guid("92a33891-228e-4cfe-ac02-3032edb9d89f"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3563), 157239, 38 },
                    { new Guid("93fd03ff-ddb0-48a8-8166-6be1c07a5e2d"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3274), 30722, 12 },
                    { new Guid("94e2fa00-ee65-43cd-985e-4de14269a1e6"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3735), 80904800, 6 },
                    { new Guid("978ccb12-4565-45d9-b0a0-2f0af8762e25"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3477), 3511507, 28 },
                    { new Guid("98437447-6178-4fdb-9391-9330fcc50233"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3245), 156114, 90 },
                    { new Guid("99d3d343-4285-48e6-be13-4124634eb9a1"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3326), 51336, 17 },
                    { new Guid("9aa1e2c4-416b-432c-9023-a773b376f7aa"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3799), 47333, 25 },
                    { new Guid("9aaa7c3c-d470-469f-ac73-260be391aefc"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3379), 40417113, 7 },
                    { new Guid("9c24eff2-842b-45cb-81b8-12e7a48b2c0d"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3423), 3511507, 6 },
                    { new Guid("9c9e5953-5996-4b31-8651-5b273b47bd9c"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3686), 163794, 21 },
                    { new Guid("a092ea7e-6ab1-4d75-b712-2cb31ef0bdce"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3400), 3511507, 89 },
                    { new Guid("a0d001d6-6e8e-4437-a6e5-2e30c7681cf6"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3309), 156727, 115 },
                    { new Guid("a735bcb7-227f-432a-ab3e-2a412586585f"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3890), 25183, 94 },
                    { new Guid("ab922c21-9278-4b01-af33-9023d6227bfa"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3482), 69372, 115 },
                    { new Guid("ae35e51e-8228-4f8b-ae40-76f10bf2f9ea"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3495), 64960, 109 },
                    { new Guid("aeef49af-12db-4978-a33c-c43bfdb93485"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3236), 25677, 35 },
                    { new Guid("b0ee689a-0865-496c-8cbe-ef861eab4cd7"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3667), 16279, 42 },
                    { new Guid("b2d7d479-5b80-4124-8668-91b04b149e82"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3631), 80900909, 72 },
                    { new Guid("b3796584-15b0-49e7-bce2-df13a233ae6b"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3501), 157239, 47 },
                    { new Guid("b3d2f75a-c2ec-484f-8ba3-d847a124611b"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3957), 156305, 86 },
                    { new Guid("b4896e96-a5c2-46fc-975e-9a1c37c0316f"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3435), 157239, 106 },
                    { new Guid("b6ceef7c-dcf9-4b66-8e80-9d8ef9699f7c"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3300), 157239, 19 },
                    { new Guid("b6de7d23-8573-4e46-ac3d-2af829891e3d"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3728), 64960, 116 },
                    { new Guid("b71b798b-53ff-46c8-b66c-fc6bce81bd7f"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3609), 156305, 4 },
                    { new Guid("be97cde2-73e9-4e69-9f5a-488bb563f83f"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3737), 94842, 52 },
                    { new Guid("c766471e-9370-4f34-a031-eb934c0f7988"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3679), 156727, 26 },
                    { new Guid("c9fb3b2e-cb2e-4256-9bb3-4f6cfce9cee6"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3573), 3458749, 46 },
                    { new Guid("ca5160e5-e078-45e3-8629-0b27fb5c77b3"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3629), 69372, 96 },
                    { new Guid("cd4cf7ac-0f20-48ae-893c-8e57f7673452"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3412), 163794, 63 },
                    { new Guid("ce49e0fe-41c4-4695-a12d-e255f109a0d8"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3844), 71114, 36 },
                    { new Guid("ce6f9da4-1343-45bf-a9e1-aac177817f16"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3888), 80904800, 99 },
                    { new Guid("ce90b1c3-82dc-49c4-b0e9-e4b804b206dd"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3908), 30722, 54 },
                    { new Guid("d0d147ac-dbbe-4a7b-9ebf-18e4cb12eee4"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3577), 30722, 111 },
                    { new Guid("d118b756-ecb1-4598-89a6-398f04502368"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3513), 64960, 126 },
                    { new Guid("d1819035-78f3-46c0-965d-d7807ab15b2a"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3566), 160624, 57 },
                    { new Guid("d1a1b1ea-20aa-42b1-a6f8-580bd49934c5"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3905), 163794, 123 },
                    { new Guid("d4d3adec-0384-4ff0-98d5-90ad0296280a"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3787), 156305, 115 },
                    { new Guid("d539523a-9ae1-4212-9c95-38b6b355cc35"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3317), 16279, 59 },
                    { new Guid("d5f338f9-a434-4bc1-9b3b-629152227078"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3432), 25677, 6 },
                    { new Guid("d96cfa0d-e90f-437a-a0df-adbc1403f83c"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3841), 159706, 54 },
                    { new Guid("da65b850-26e1-42b5-ad01-611bf9f22786"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3895), 51336, 53 },
                    { new Guid("de5bbe1f-8bf6-4f5f-b6a5-445797393bf0"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3831), 64960, 8 },
                    { new Guid("e23546b8-66a4-42c9-a4cc-dcf004bb7dcc"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3802), 94842, 35 },
                    { new Guid("e2b28c68-1d11-4af7-8fb2-74c9f602b864"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3314), 80886919, 122 },
                    { new Guid("e3b8f0b5-2b72-41c4-a0b2-c38174c812e9"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3291), 51336, 78 },
                    { new Guid("e4f5f06c-6227-4d58-8f31-cd0ee72ea7a4"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3283), 163794, 125 },
                    { new Guid("e508f653-16dc-44b7-ad36-8652105c5cd5"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3545), 157239, 68 },
                    { new Guid("e5516bae-a847-4150-8798-32439864b335"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3488), 25183, 70 },
                    { new Guid("e5ab7711-4c2d-46ff-8825-90b78363495c"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3429), 25677, 74 },
                    { new Guid("ebbb0699-d419-40e2-89d0-657ef1c9312f"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3269), 152001, 86 },
                    { new Guid("ed006160-e3ee-4333-89a9-d363e712e491"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3740), 40418413, 96 },
                    { new Guid("edc8e88c-95df-4b66-82d5-b81d5148992c"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3507), 159706, 45 },
                    { new Guid("ef46368f-4f9d-43f2-964d-905dcb508348"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3568), 3458749, 65 },
                    { new Guid("ef4f814e-6064-43ff-a993-5bf399b28554"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3790), 69372, 92 },
                    { new Guid("f01246ca-0f35-437c-b27b-a037750096db"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3782), 30722, 124 },
                    { new Guid("f2597c9f-cff9-4c2e-8be6-1a557355fe4e"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3294), 64960, 22 },
                    { new Guid("f276e03d-1f0a-449b-bb5e-d997bcee76ca"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3320), 40417113, 57 },
                    { new Guid("f29f0176-bc34-4538-bae2-c9d99e9a86bd"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3206), 30722, 118 },
                    { new Guid("f4f4aa16-f8fd-4e3c-af15-97519ff5a3e6"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3505), 156727, 11 },
                    { new Guid("ff3f99b5-6ba0-48d7-9118-eefcedd7b705"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(3796), 40417113, 11 }
                });

            migrationBuilder.InsertData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                columns: new[] { "ID_PUBLICACAO", "HORA", "ID_SOLICITACAO_PUBLICACAO", "MAT_SOLICITANTE", "TEXT_PUBLICACAO" },
                values: new object[,]
                {
                    { new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(4093), new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 25183, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(4097), new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 3458749, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(4083), new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 25677, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(4096), new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 25677, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(4091), new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 40417113, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(4103), new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 152001, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(4089), new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 40416900, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(4101), new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 156727, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" },
                    { new Guid("f7901011-9590-4066-8c36-f592c68817b7"), new DateTime(2024, 10, 17, 18, 40, 33, 242, DateTimeKind.Local).AddTicks(4094), new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 163794, "Sua pergunta faz total sentido, você vai tirar nota MIL! na prova do GiroV CONGRATULATIONS 👌🎉🎉" }
                });

            migrationBuilder.InsertData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                columns: new[] { "ID_AVALIACAO", "AVALIACAO", "ID_PUBLICACAO", "MATRICULA_RESPONSAVEL" },
                values: new object[,]
                {
                    { new Guid("047171b9-9f23-4bd6-8abd-128a83945f23"), 1, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("0600936e-80c1-4f62-b7a5-2b184de2d69e"), 2, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("06c6276a-595b-420e-964a-117955ab5a35"), 4, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("07d502f9-00a8-4a9c-8daa-3da5a2f1bcc2"), 3, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("0a0ce10f-b66c-4401-b385-c11934ffa28b"), 4, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("0b02c845-d62d-433b-8f64-9219df1a0acc"), 4, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("0d33f6a3-8d8e-47c1-94a3-2c0af3f77624"), 4, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("0dd1a8cc-04e6-4ac0-8ad4-0d0f41dc5039"), 1, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("0e5562b2-0c9d-49b0-8c3d-33c037c944a0"), 2, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("0f9b9e8b-c3dc-4937-a4f7-c96d859f49fc"), 3, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("0ffe478c-c3de-4d1e-a381-f77e0008357a"), 3, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("1289ab2a-d673-4147-a42d-cdd88f99ea6c"), 3, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("12b6908f-87e7-449c-85ca-c78e8fb83630"), 2, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("14d8f854-7568-4e58-b2d7-e3e632c788bc"), 4, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("15176aca-6f6a-4689-918f-41fc71874d8f"), 3, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("175e4ea2-4114-47cf-854e-a482f7f31bd2"), 3, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("196101c9-6ed3-4eb3-be23-a15fef179a0d"), 2, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("19f4ae84-a16c-483f-b962-0503dfa12179"), 2, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("1c5e86cc-39f7-4323-a85f-f4932a69c642"), 2, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("1de31de6-5e86-472c-a674-18a4c94c070b"), 2, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("225eeccd-2d14-480e-8d68-4db7778fc8fb"), 1, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("23ee4469-ee97-43a2-9a91-2e4be6f908f6"), 1, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("24243505-af9c-42fd-921f-8fc7e9217ac3"), 3, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("2431cb33-ad37-4ba9-b1ce-7d80cdc20fbf"), 1, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("2933ecbf-de54-4adc-b81b-fec59e088738"), 2, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("2bdc8dc1-99d2-48b1-82f4-95b095a73857"), 2, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("2d5921c8-3c06-4f6d-ab82-48b8ed6365ee"), 1, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("30ee4dda-79c0-4dc5-8607-1223c5c0853d"), 2, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("31025cf2-f8bc-4f7e-b8c3-c61af9c9b251"), 3, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("34d3add7-d947-48a3-87cd-0872d23b4e3b"), 1, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("37a9980c-07a9-4046-adcf-965485707927"), 3, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("3c3dd256-219c-49eb-ba0b-af85c608e80a"), 4, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("3ecc42a4-106b-4a58-ba04-1584951ef86e"), 2, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("3fc41919-0874-47f5-83ff-536cfc306728"), 4, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("4028e64e-0a55-43fe-a9eb-3d92b3707c10"), 3, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("426e79b1-1f53-4500-8c56-235d26517b5e"), 3, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("42d0ec9e-3147-4947-a1f3-2fd74bc2a46b"), 2, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("43197505-fdab-4406-a452-29e33b732539"), 2, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("450bc2d5-4434-4246-a2fc-45e748572d1a"), 1, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("463df059-3779-4f9c-997e-2bb06bd50119"), 2, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("4832332b-129e-48ab-89ce-00626c527514"), 1, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("496fc0d0-3436-4e40-a9f9-80a3d87a8772"), 2, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("4bf46e62-93b9-4cf4-8aed-e069a7692843"), 3, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("4bfc13af-d15e-4b35-89e8-0c79250c68df"), 4, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("4c6c834d-f400-42bb-a7eb-8bfd6bad9a93"), 3, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("4e5464b3-5156-4685-9eda-7cde445ea8af"), 4, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("4f3be54d-0e31-4b7a-a1ca-3f3376b55ce0"), 4, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("52a721c6-f0d1-4283-87e2-afd94f4324ec"), 3, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("553f02cc-6689-46a2-a6fc-581c252a0cc7"), 3, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("597e4f7c-3666-45b8-9dd3-b93b6821ff26"), 3, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("5ca47553-ba8b-4ee9-a261-23bb488aba8c"), 4, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("5cb78cb1-478a-4eef-936c-6c527969f689"), 1, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("5f32ac74-4b79-4dd0-a25f-5593ad04b329"), 2, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("5ff0e0ea-738a-493d-893f-3458dfa03653"), 4, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("61430c8c-45e2-4999-a387-bbaa82f278bf"), 4, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("638d0411-5f59-4cec-a078-1537de630ee5"), 3, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("652822f7-f2a9-4189-9e0e-3c055c4f9096"), 4, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("67b51a1a-d316-4ecc-b4c0-46246420df8a"), 3, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("68fb8619-ddfa-48ef-abfe-104af4100f00"), 3, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("697dd650-5376-49b1-ac93-3531cccdff5c"), 1, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("6d8e4954-5bc4-42b7-a7db-f929c4632323"), 1, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("6e178ad4-e738-47e5-b64b-b05b16c4cedd"), 4, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("6f300b10-16e5-4dc1-81ef-1acea234c10e"), 3, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("7022f0a6-408a-400f-b1d3-680aadff3fc8"), 3, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("7063cf05-2c8f-4bc3-9553-10ccdde9a4bc"), 1, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("725aefc5-dbca-4b77-b170-f11d1c7277fd"), 1, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("7345a15a-0de0-49e5-8750-c37dacdd38c2"), 1, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("7350e897-91b5-4cc6-815a-7f3a01c84329"), 2, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("74b06774-55d6-4d40-bbbb-60a1f8cfb157"), 1, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("77055133-b5ae-4374-b0db-d40040fb6b30"), 1, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("80f22052-f822-46a2-a21b-c1d33f587316"), 2, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("8140a563-3a27-4d99-9ab2-afa25a2842ff"), 4, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("81fa14d7-9f31-4ae4-b0a7-328cede54f5e"), 1, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("82672017-28a3-41bc-88a6-285eae7555c8"), 3, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("82ad47b2-5f24-44d9-a396-29fbc722e197"), 2, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("82b15f4f-2f64-4ff8-87c9-ae80229b3395"), 3, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("8320d07b-78a1-44a4-a216-4d5229007e26"), 3, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("84a50ae1-93f1-41fe-8e68-1baaea5f45a4"), 2, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("8501efb2-c3e8-4700-b8ed-fe0b1b97aa4b"), 4, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("87030ae0-d105-4271-bf3f-4ab269e9ca89"), 4, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("872914ce-36ed-4902-8dda-72aa5a3e7614"), 1, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("879de554-de37-4dc8-9d3c-14fc0d23a308"), 1, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("8d4c37e1-2e28-407a-8eb5-39f9d3083612"), 3, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("8e3d13d5-2a03-46e2-b0ca-4dcc7a559f9f"), 3, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("8f649fa7-ea5e-49c4-b683-d6d41d08ef51"), 3, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("8fcff44c-5988-48ac-a40c-a5f34314eb27"), 3, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("92b46a1a-9a96-4168-b169-f67e2037c9f2"), 3, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("9737e366-ca5a-4f13-be6a-48f831c18a4c"), 3, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("996678c3-afb7-412d-85c7-b5ebc10b8fef"), 2, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("9d79b934-e1db-44de-999d-dc2bcfe2de36"), 2, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("9f5d920c-4747-433d-8e19-3297830721d5"), 1, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("a037bf61-8b46-4f00-bf40-e19c077d6ddb"), 1, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("a07fd8f3-ff84-4009-89c7-139d6c966b59"), 2, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("aa5ed5c8-de35-4873-908e-f32d166ca6a6"), 1, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("aa605f3a-ff93-4981-8784-d4c825dc62ce"), 3, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("aa6f512f-fcef-4c03-868c-eddc8deae740"), 2, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("ab183d22-d8fa-485f-82ea-9944da479262"), 4, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("ac2ff11e-3d9a-42fe-83dc-1d6c4000776f"), 4, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("af85b3c8-b774-4ca6-8f56-86d20e15a024"), 2, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("b03fa6b7-2cc1-4f94-bc87-a1812b9ec8da"), 3, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("b04c9737-7864-4ae7-9dfa-39db11f5b108"), 2, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("b0c6b175-00e9-46ba-89a4-ab6c73b5e210"), 4, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("b29770ae-cf78-4c24-9599-59ca7969a0cd"), 1, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("b3b8ec54-e59b-4062-a2ba-9415ad0fb5fd"), 2, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("bae7d643-7d89-4904-98c9-54f85e308715"), 2, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("bba3aa55-4e18-4d2c-b870-d7c3375cc559"), 1, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("bc262aea-a7b4-49dd-8296-7b91b70e1677"), 4, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("bfc62692-b076-43a4-b4aa-c6d74c6ab050"), 2, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("c1e7ed7d-3186-4b6d-b087-1d9964c207dc"), 4, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("c3866181-3218-4362-9719-2cebc302f664"), 2, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("c43370ec-89d2-4fe1-8542-af43789455c0"), 2, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("c4806959-b5bf-4fe3-ada6-00becf6a172a"), 4, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("c7e3c955-5667-409f-8fde-ca1f058bc64d"), 3, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("cac20c67-eb87-4f87-b062-8ed0bb2c1bc4"), 4, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("ce2817ce-8fe3-40f4-8bd0-e1cfede34617"), 1, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("d3d69075-8e95-498a-a357-bf283dfb0633"), 3, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("d4e8e91e-a12b-4092-8dec-51438b06644b"), 2, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("d50e963f-bb0c-4274-98a6-6c4a36ec6da4"), 1, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("d5130b69-5c1c-4536-847e-e620577f083f"), 3, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("d7174352-1216-44e5-bd2e-2501e9a8a437"), 2, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("d7584c29-45e3-48ad-b9f3-b6e7a2ff6baf"), 2, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("d96bf979-4608-454b-9e7d-e37d7c48d0af"), 4, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("da5b4d84-a0fa-46b7-b521-7a95308a20fa"), 2, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("de9dea16-fc5d-444f-92bf-231ca9d1bc4d"), 2, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("e0010d56-75db-4aff-a5b1-61e3568dd493"), 4, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("e4e1d027-b480-478b-b53f-e5506aea1074"), 1, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("e5546019-3a18-4e24-adc4-cfcca88d7776"), 4, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("e5947c33-bd8f-4161-b3c2-24dc281b48ff"), 4, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("e647a6f2-9ae8-436a-a098-82d62445e532"), 2, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("e73ca127-9319-4b25-87cd-0dafa7be1ef9"), 3, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("eb26057b-9cdd-489a-a157-b264208ac5f8"), 3, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("ec961d87-f10a-40f1-a986-7f07357ab127"), 1, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("eda958de-4d79-4bf4-82cb-a87af943bce2"), 3, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("ef3d81be-1d38-4f7e-a711-2b1c4a2b89cd"), 1, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("effeda7c-1c21-48f8-9868-a38dd7790738"), 2, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("f0f36868-f06c-4a8f-b27b-41b0099ab19e"), 1, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("f2bbc589-f99d-4a22-be46-c9639a6d4903"), 1, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("f302b352-c832-4533-bd7e-98fffc113dc5"), 2, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("f5321883-ca8e-4054-86a1-39da7963416d"), 1, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("f716b3b8-0b9b-4d3d-ba28-1fa6faea2e20"), 2, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("f7744b5f-3060-4caa-98e6-2b013c1fe188"), 1, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("f7bd7d7c-6713-4e38-90ee-f5f5b13c797e"), 1, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("f8f2b7f1-bb4d-4156-a651-f214194b9381"), 1, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("fa497690-8c0d-4740-a965-2fe3285781ff"), 3, new Guid("7c111573-c45d-4164-a207-28ac0866a764"), 151191 },
                    { new Guid("fbdc2c4d-103a-42a5-ad63-b3e5c87f10c2"), 1, new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"), 151191 },
                    { new Guid("fd2a6278-ef07-44e3-8368-75213bfe116d"), 3, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 },
                    { new Guid("fd5172fc-0747-47cc-af7d-40c1fb9f6c41"), 3, new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"), 151191 }
                });

            //migrationBuilder.AddForeignKey(
            //    name: "FK_FORUM_AVALIACAO_PUBLICACAO_FORUM_PUBLICACAO_SOLICITACAO_ID_PUBLICACAO",
            //    schema: "Fórum",
            //    table: "FORUM_AVALIACAO_PUBLICACAO",
            //    column: "ID_PUBLICACAO",
            //    principalSchema: "Fórum",
            //    principalTable: "FORUM_PUBLICACAO_SOLICITACAO",
            //    principalColumn: "ID_SOLICITACAO_PUBLICACAO");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_FORUM_AVALIACAO_PUBLICACAO_FORUM_PUBLICACAO_ID_PUBLICACAO",
            //    schema: "Fórum",
            //    table: "FORUM_AVALIACAO_PUBLICACAO",
            //    column: "ID_PUBLICACAO",
            //    principalSchema: "Fórum",
            //    principalTable: "FORUM_PUBLICACAO",
            //    principalColumn: "ID_PUBLICACAO"); 
            // Optional: Specify behavior on delete
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FORUM_AVALIACAO_PUBLICACAO_FORUM_PUBLICACAO_ID_PUBLICACAO",
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_FORUM_AVALIACAO_PUBLICACAO_FORUM_PUBLICACAO_SOLICITACAO_ID_PUBLICACAO",
            //    schema: "Fórum",
            //    table: "FORUM_AVALIACAO_PUBLICACAO");

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("009b5cd7-08c5-4d7a-a617-d2526f6d51ae"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("010ae429-5961-453f-ae8c-a6283f5a3a34"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("01c2fe4f-f9dd-47a6-a15e-412c1a71ce71"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("01f9af92-5b54-4e77-9002-573b8e16b125"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("03ad985f-0602-47a8-8fdc-e7dbaf24cc5f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("03c58242-7703-498a-8676-df9dba7cf54f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("03f5ae31-9e76-4ef3-8927-261f2db5cd77"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("047171b9-9f23-4bd6-8abd-128a83945f23"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("047f03ae-4a68-41c9-b556-28262753ec52"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("04f0637c-ace8-4f89-a5ce-af0e09552350"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0600936e-80c1-4f62-b7a5-2b184de2d69e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("06c6276a-595b-420e-964a-117955ab5a35"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("072500cb-e3a1-48dd-89da-cd6ec614daef"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("077f331f-e019-4955-894e-33a12f7b64b3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("07c6bee1-0aaf-4f95-b6b7-822c49b31401"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("07d502f9-00a8-4a9c-8daa-3da5a2f1bcc2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("083a545a-9cd1-44db-8ef1-ca16b985753c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0991ca46-7610-4bde-93b4-a07e9b986ed6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0991ee33-3804-49c2-a1b9-286d4698c7d5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("099c66e6-5ca7-4eab-81e1-7701603f461f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("09ca1e80-34c6-4964-8a76-2832bb978095"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0a0bea61-9108-4de0-8f11-0895fd64fb6b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0a0ce10f-b66c-4401-b385-c11934ffa28b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0a92a8e8-b9cc-4f34-b84b-45a14ef2a9cb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0b02c845-d62d-433b-8f64-9219df1a0acc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0ba4ddf5-181a-4ed5-a817-b6ea16bfa35a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0bb51741-15f6-4511-815a-3cbb170588d3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0bf33772-659a-47f4-8e08-747f6cc5b4d9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0c7f541e-4356-46c7-875a-91bc4142c0f9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0ccc34f6-aa36-4d1a-aa71-21bb4507d4e6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0d33f6a3-8d8e-47c1-94a3-2c0af3f77624"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0dd1a8cc-04e6-4ac0-8ad4-0d0f41dc5039"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0e17debf-8a4c-4813-bd16-bf83df51474d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0e5562b2-0c9d-49b0-8c3d-33c037c944a0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0f9b9e8b-c3dc-4937-a4f7-c96d859f49fc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0fdca43a-81f2-4d3c-836c-8a6d8115cafe"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("0ffe478c-c3de-4d1e-a381-f77e0008357a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("10844e96-9f61-4526-9cf5-ae3b20fc8d3d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("10e1ce1a-bf29-4225-9cce-b6c5c9b3b210"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("117417a2-05a8-4772-ba9b-8bb6e79c6f19"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("11d60a8f-5cff-477e-ac3d-b81c103dd8fc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("120f16d0-2bbf-499d-9afb-c0bd2ee89c63"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("12337ff9-07d2-45bb-9bd7-d221244189c2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1289ab2a-d673-4147-a42d-cdd88f99ea6c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("129f7195-d6fd-4b9a-a723-1df9e4f17617"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("12a19735-b85f-48a9-bde9-03dd9ed34ac7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("12b6908f-87e7-449c-85ca-c78e8fb83630"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1437f8e1-d4ae-4733-8c79-0edc06de8eb1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("14d8f854-7568-4e58-b2d7-e3e632c788bc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("14ddd805-c27b-4f84-8256-9b6b5e48ef4e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("15176aca-6f6a-4689-918f-41fc71874d8f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("15fe7662-6e13-4858-97ff-d46833e5a238"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("166d4bc4-c5b8-4287-b9f4-28db7dcf89af"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("169f5690-9acb-4586-b302-50a579abca62"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1740daec-10a9-4ab2-adbe-700a8defa17f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("175e4ea2-4114-47cf-854e-a482f7f31bd2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("18ba938f-b71d-4f47-8d12-2772567a8830"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("18fa197d-310e-45c3-81cb-d33d88b5a8a8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1926237d-f4dd-4153-81de-c44c2723a825"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("196101c9-6ed3-4eb3-be23-a15fef179a0d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("19f4ae84-a16c-483f-b962-0503dfa12179"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1a1150cc-dcad-495e-943c-a035a7ff8c91"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1b44968e-07e7-49fa-83f4-88fcb6e6e5ac"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1b71a8c7-8f42-47e0-8dc1-ee9736b642b0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1bd07762-ee97-4649-ace4-e3602901ed1c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1c5e86cc-39f7-4323-a85f-f4932a69c642"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1d1c7a76-6249-4e8b-bda2-836d3c99cb6c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1d478cd1-8a96-47d4-8965-6c9b21357256"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1db8df66-7735-4f1c-a86e-9e5aa8a4da43"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1dbda91d-e449-4305-8446-69b4d2f428d9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1de31de6-5e86-472c-a674-18a4c94c070b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1eca6e06-b9a5-4ca9-9e58-05ccc4c5af82"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("1ff65b5f-00c0-4ee0-856c-a2b6a9d37450"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("20fc2240-274a-47dc-bfe5-24475cb7fbfb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2130e959-d7e9-4a76-ac82-91448dde056f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("214e8e4b-7f99-47a5-854b-d6bd1c51b325"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2155441b-9848-4f0c-b326-f6a81a570fc4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("21dffa61-dda9-4d3c-a750-be3253a1dc60"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("225eeccd-2d14-480e-8d68-4db7778fc8fb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("22f0dffd-a11d-47ac-aaf2-ea3cf7b5112f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("23ee4469-ee97-43a2-9a91-2e4be6f908f6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("24243505-af9c-42fd-921f-8fc7e9217ac3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2431cb33-ad37-4ba9-b1ce-7d80cdc20fbf"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("24c1c38e-5603-441f-b619-313772ef4e14"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("25ceaec5-c6e2-414a-be22-886ef5e5127b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("263c382c-9c08-4a36-bb2b-901ad83106e8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("269c4391-d6f3-4412-8461-1b0b3b927ac5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("26eab067-2d09-4a97-8b28-73d3a8f334d0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2796103a-8ab2-42fe-b21f-f6af462dcfad"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2835c533-2df4-401b-b36b-4abdadbe4532"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2933ecbf-de54-4adc-b81b-fec59e088738"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("297cc5c0-7f8e-4e5e-95db-c5e070814516"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2a261384-1575-4fdb-ab3c-4b8942dc32fb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2aa6bc07-9daa-49a3-b344-7102c08a7011"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2ad2e8c9-e6a7-4a88-a4be-35057ad7a919"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2b11eeb5-1912-4e6a-9c8a-8034c994a6e3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2bdc8dc1-99d2-48b1-82f4-95b095a73857"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2c450bee-57fd-4f57-b95b-19507b8411d5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2c7824a4-9b13-473b-a068-813c38ba8e49"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2d5921c8-3c06-4f6d-ab82-48b8ed6365ee"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2d60d383-31d2-42a9-ae29-9722e72f11d2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2d7465f5-5176-4a89-bfa0-160544310e7b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2dddf397-651d-400e-b460-6809b6180686"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2e35a705-9bcd-44b4-aa6d-84960d967350"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2e42b858-48df-409c-b922-dc2f8d50c47a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2e80b469-2b74-488d-b57b-68606aa96775"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("2eba09d3-12d7-41d9-89e7-4aa3ef96044a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("30a0e2d8-d2ec-4f63-9a28-56e013552578"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("30ee4dda-79c0-4dc5-8607-1223c5c0853d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("31025cf2-f8bc-4f7e-b8c3-c61af9c9b251"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("31b1eade-1e0f-442b-9a52-033fd1d088f3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("31bf5618-2929-48e5-9015-7cc2c958349b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("321e717d-15d1-45c1-ab7b-9217d75ab3d2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3280e03b-214d-44a5-9af7-e737ca8ad960"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3288fd4e-1f53-4970-8580-afe8b1f75a01"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3290d03a-fba0-4979-a1c9-ef4888072844"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("32de6077-1bc0-4423-8315-ae4843705578"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("335fe6e3-96c9-4b01-aa05-a2eea61dede4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("33be98c6-dc3c-4761-8d7e-4f39da7fe2fd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("33df7354-8e56-4d43-9c35-d791c946539f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("33ee1575-9fd9-4c53-997a-cb0d393314f1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("34ccf1ef-0be4-4594-be79-4d8c42878241"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("34d3add7-d947-48a3-87cd-0872d23b4e3b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("35069333-952c-46b1-be19-9fc3d8a8fa04"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3560015f-5779-46f7-95f4-39024570f998"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("358962ad-5f9f-443a-a1f1-8e464b11d5ff"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("358de2b0-3043-4e81-a761-5ee57ef1ab9c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("35e3ed7c-c587-4f70-b1fe-c9063315c5e8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("375a4746-f477-477b-b337-6e5238d1e9de"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("377f5a79-207c-4f31-94af-3cbf7a2f7bf1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("37a9980c-07a9-4046-adcf-965485707927"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("38397856-f382-4fb9-a2d0-6430384b15d3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("395ef341-3fa9-40e2-9e9a-7afcc9fbb0d9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3a314820-d2fc-4783-9067-427f54139490"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3a43a337-831c-49d8-9226-8e552f52a35a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3aa59755-1aad-4979-b4ab-75647dfb95e4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3c2d30b4-55ef-45f5-92c8-80f29c08e44c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3c3dd256-219c-49eb-ba0b-af85c608e80a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3c5d7b01-a5c4-468c-888c-5b951b567f1a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3d008140-2560-4d17-a3e5-6afcecbba804"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3d76326a-dad4-4e60-ab2b-a55dbb6b5520"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3e14cc1b-8c93-4360-851b-b0be29cc71a9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3e5f5f53-0606-4476-84f7-4479671a17ad"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3ecc42a4-106b-4a58-ba04-1584951ef86e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3fa294db-767a-4d93-8c38-0c5bbaeda9e6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3fc41919-0874-47f5-83ff-536cfc306728"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("3fe19121-ae42-457c-8630-276cf03a09a0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("401e3cd4-0d31-4730-a144-f6d35e985ea5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4028e64e-0a55-43fe-a9eb-3d92b3707c10"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("40c7e610-1c3d-4006-a12c-f3133a703579"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("414a4ac0-28ca-48e0-860e-84d6ce54d969"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("41b9d319-398b-47fe-923b-f0f0620608c3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("42418009-0795-4b5b-8000-8a12edab6607"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("426e79b1-1f53-4500-8c56-235d26517b5e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("42929052-2619-468c-a3f8-0ec33e882990"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("42d0ec9e-3147-4947-a1f3-2fd74bc2a46b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("43197505-fdab-4406-a452-29e33b732539"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("43396470-0d98-4318-8093-3f64b664c512"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4382f812-4dc7-48e4-bd99-0562d1a0a3e6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("43a8cca6-5cc6-4de3-a66a-e12ee6a0e160"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("43ba938e-ddfc-4474-b996-6ddd690704b2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4403cf70-0da8-4d49-9aa4-c0386d8a823e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("44f36b9e-9f95-4708-bcba-5eccbf3f00b4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("450bc2d5-4434-4246-a2fc-45e748572d1a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("45362d1c-9a38-4ddf-8cb2-3200ba7f8763"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("454462ee-3953-41e6-9fe3-a1c3b9d8498d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("455de7b5-e2a0-4adf-abff-08c8a5ce0894"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("45db5515-8abb-4f96-a5c4-dcafcb4124db"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("463df059-3779-4f9c-997e-2bb06bd50119"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("46bc233a-04e7-44c3-ab51-54b60ec196c0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("46eafb91-00ed-4512-9b6c-3d0bcbe5b578"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("47b11d2e-d7c2-443f-9a15-dce5ad685791"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("482bfb3a-7467-4ed9-bfa7-0c2328770182"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4832332b-129e-48ab-89ce-00626c527514"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("488e6775-ed37-4e7f-b84b-723af72677c1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4908469f-e898-43b8-aa12-4b5b9459caad"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("496fc0d0-3436-4e40-a9f9-80a3d87a8772"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("49d00c41-8bcc-4ea3-aae9-69f348e982b9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4a55376e-1479-4699-9f17-ccc8425d9637"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4a70e262-ede0-4242-acf4-a7838e0de692"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4bd00096-8945-49aa-b34b-a1945bf9ce2d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4bf46e62-93b9-4cf4-8aed-e069a7692843"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4bfc13af-d15e-4b35-89e8-0c79250c68df"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4c6c834d-f400-42bb-a7eb-8bfd6bad9a93"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4d07e13e-8eab-4d0d-9195-6621ca152172"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4d612aa1-7192-4dfd-bc0c-130fa98dccc4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4d885f8d-ec3b-4165-8a41-1187f062ca92"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4dd0af53-d0e3-44d3-b479-c952f2940f75"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4df14569-2855-47e9-a8ff-88820571c2f7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4e5464b3-5156-4685-9eda-7cde445ea8af"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4f081235-4b5b-46a8-bc79-d830eac5410a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4f3be54d-0e31-4b7a-a1ca-3f3376b55ce0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("4fa5d373-76cd-44e0-943e-89a441ff2a8b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("50448cb8-6065-4bb2-b31a-25bb0ba900c4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("50949020-8adc-480e-9866-b24bd3ee6072"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("51eb6b12-295c-4504-8ba4-fcaddd27926e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("52154811-2667-4273-a9d2-d424943a19ca"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("52480f6d-75f8-4690-b3ce-29656f237125"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("525ab72a-420c-4ae7-bf9f-549b7717d690"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("52a721c6-f0d1-4283-87e2-afd94f4324ec"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("52deed40-71ce-4ffa-a2fd-a339342702d3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("536e24c6-9d1f-4237-ab61-5f6a156a2fb6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("544438f0-ae20-43cb-b407-7cb01cc49fe6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("54f22ac4-f206-40f4-8abf-28bcb0ba57e1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("553f02cc-6689-46a2-a6fc-581c252a0cc7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("566aebff-3223-47b2-8367-e266bb0894d0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5773980b-bb94-4d10-914f-09138455861a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("58030517-6953-4dcc-a7bc-172317bacc3e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5871a0c7-a5ac-47c7-bb97-b8dabbb97cd1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("597e4f7c-3666-45b8-9dd3-b93b6821ff26"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5a2005f8-e7b9-4d21-ae15-897c10ed2cfd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5ac3a917-5e61-4c73-8f84-21a6b60572f2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5b83fa97-b5ea-4c7e-b168-44d37f517487"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5ca47553-ba8b-4ee9-a261-23bb488aba8c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5cb78cb1-478a-4eef-936c-6c527969f689"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5cd62a6d-9ce5-44ac-be4f-e4cf9ab63dab"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5d8780cc-4278-42c9-9d54-143e3101333f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5e0c3eda-7049-48ab-a3b4-e0a9be20bd46"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5e1f6887-ecde-47d4-9eb7-bc01862e5c62"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5ecf7ac8-cc92-49de-aa88-5875ee3444a6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5f3113e0-a657-449d-a5eb-6f8cfe6e8b91"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5f32ac74-4b79-4dd0-a25f-5593ad04b329"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5fc14bfa-9d8c-4dc2-b8fa-454f9f6b4953"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("5ff0e0ea-738a-493d-893f-3458dfa03653"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6067a5e1-4267-48e5-9d8e-36ef25e3249e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("60e6df5c-9f42-4f35-a519-5ef62cc75908"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("60fed711-b249-4158-a570-c396f50398ed"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("61430c8c-45e2-4999-a387-bbaa82f278bf"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6146b995-5ff3-4a4f-8241-5f6f88ff4fc8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6185694f-7390-4cf8-a464-9572471ad4de"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("62241b4d-5397-402f-90b1-183f1d7120ec"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("638d0411-5f59-4cec-a078-1537de630ee5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("63bd42fe-5821-4f75-a02c-e11e08198eea"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("63de81f6-0c76-49dc-ad40-d5d592c4519c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("641975cb-d8b1-4b72-86e2-ef52adeff12b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6422cfab-ad09-4e62-8c64-49ee04a811e3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("64febadd-cb20-4c4c-93f9-6824226b72eb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("652822f7-f2a9-4189-9e0e-3c055c4f9096"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("652990f6-8161-4530-a138-e9ce8ce99226"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("65d3038e-dd15-43ce-9640-d8ebf4e3af1f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("66557c81-71fc-4e98-a398-36d66122c837"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6681c5c5-cabf-482c-87a8-bdebf30764d3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("66a0164f-9626-4880-869b-1d99fc7d13c5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("66d2acee-2d6d-4649-961e-e655caf1c01f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("67af5cad-c991-43ae-9824-c48e37ac5b0a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("67b51a1a-d316-4ecc-b4c0-46246420df8a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("685d99fb-631e-40f9-9945-ffbdddd2c20c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("68d1483c-b92d-4af5-9fc2-a3be08849855"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("68e387e1-36fd-4d62-b5c4-34c04324b9c8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("68fb8619-ddfa-48ef-abfe-104af4100f00"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("693c83dc-354a-41c7-ad70-3352eb1046f8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("697dd650-5376-49b1-ac93-3531cccdff5c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("699bf765-3225-406d-8495-bbaa905d4edd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6abd8049-46ce-4a31-b849-743f8d774f78"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6adb9fb8-6359-43fa-9b00-fef4d10953bc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6addbf3e-10ef-4e24-b1ec-e4de678ab931"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6be03f11-4a9d-4fb6-8803-42885ab1ecf5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6cadce85-f76f-42b2-be99-5274f710ae68"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6d8e4954-5bc4-42b7-a7db-f929c4632323"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6e178ad4-e738-47e5-b64b-b05b16c4cedd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6e894aad-c6cc-49a4-a56f-6608856b62c4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6eefed13-9eec-43ad-9ad7-2875e9481077"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("6f300b10-16e5-4dc1-81ef-1acea234c10e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7022f0a6-408a-400f-b1d3-680aadff3fc8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("70283978-c3df-46aa-846e-65547285e618"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7063cf05-2c8f-4bc3-9553-10ccdde9a4bc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7075b889-a6a6-4ea8-af50-b76f81dd3890"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("71287f9e-0bf8-4825-be2b-8ba025088dbf"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("71556580-f545-48a2-9b3a-31deb8460368"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("717d4a7f-26ac-46a1-a580-4e50b8421159"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("71b03c36-b99b-4a36-b106-4f531883cdad"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7242f959-30ab-40f0-b6c1-01da49e7472e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("725aefc5-dbca-4b77-b170-f11d1c7277fd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("72f0bf6e-eeb9-4e70-a701-d0a95ab904d4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("73196418-51a0-4e93-95ea-a36caf6150bc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7345a15a-0de0-49e5-8750-c37dacdd38c2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7350e897-91b5-4cc6-815a-7f3a01c84329"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7356d295-1cee-4405-b561-8ebaf18b07a4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("73c3e851-0883-4ad6-9700-f1333858e234"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("743d6b15-34c2-4388-b0af-67450afffecd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("74b06774-55d6-4d40-bbbb-60a1f8cfb157"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("761e79b4-e8f0-4da8-aba7-4f809e771597"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7622d7f8-d6d7-4ce7-be3a-e7f053b578f0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("76770819-466f-4281-a8bb-6c065f7e60b0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("76cb0b1f-cda6-449a-a05a-1d942e69165d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("77055133-b5ae-4374-b0db-d40040fb6b30"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("77081944-b0a6-40cf-a6e0-c988befe9d6a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("77808bf5-14fb-4a7c-8f25-565821313555"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("78273e74-50aa-42a9-bf51-89e4b81bae15"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7860736a-17cf-4556-9fc2-8609f4e121a4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("78d9af0b-8164-4f10-a1cd-1484955ac8cb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("797c193b-046a-414f-bd90-8709551f4ee5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7a3b39c0-d4f6-473c-887b-4f1941b82703"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7b5865c0-3771-47bb-b5ab-8949ea961ece"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7b5d091c-1ca4-47db-a795-4221672cb3a9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7bd2b5a6-8583-4b81-9d0d-53c048ec141a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7c8b7ba3-89e3-4233-8c66-6269d6758f8e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7e3372df-1e40-4a19-a64e-2de92f5f7389"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7eee5b14-00a3-40d7-8590-f4971b86c523"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7f4a906e-e7d9-4250-a3e7-0a928b248131"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7f6372fd-8055-4469-bcbb-0a5c5bc5883c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("7f71ef08-5b4d-43ad-900a-7cfaf0c9c28c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("80e26c4c-9b92-4929-808c-e6b5947fc201"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("80f22052-f822-46a2-a21b-c1d33f587316"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("81023c84-942c-4b7a-a04d-cf23f9122b0a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8112cd2d-2d25-4823-8b47-880af59e5797"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8140a563-3a27-4d99-9ab2-afa25a2842ff"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("815d3533-9a76-4c66-b965-94be9d03c8e9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("818ecb24-b02c-441f-8692-13337cb43455"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("81ad2b96-c807-4cd8-8d6b-a5777d6cdf5d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("81fa14d7-9f31-4ae4-b0a7-328cede54f5e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("82672017-28a3-41bc-88a6-285eae7555c8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("82ad47b2-5f24-44d9-a396-29fbc722e197"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("82b15f4f-2f64-4ff8-87c9-ae80229b3395"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("82bd9c73-0f93-4664-939b-a0ef56090388"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("82f2bf7f-1e79-478c-b1fe-5099edbd4841"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8320d07b-78a1-44a4-a216-4d5229007e26"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("83c9bc42-3175-4873-a536-dc3db414d27d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("842b2fef-19b8-4e5b-b668-a3a062e9425e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8451a0a5-8322-4cce-b5c6-908bfd3944f6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("84a50ae1-93f1-41fe-8e68-1baaea5f45a4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("84abf745-5625-4931-88aa-dfc81c7c2ab2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8501efb2-c3e8-4700-b8ed-fe0b1b97aa4b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("87030ae0-d105-4271-bf3f-4ab269e9ca89"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("872914ce-36ed-4902-8dda-72aa5a3e7614"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("879de554-de37-4dc8-9d3c-14fc0d23a308"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("87acf542-1311-4af1-abfd-73d0cf88c74a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("87c2f043-f12d-4ce9-9df3-28789e2b0d65"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("87f08cca-cf88-4b9f-9c55-93d40bc55e92"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("88a94f7a-57be-4357-a1ce-c3ad455edc1f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("88e5462b-89b9-449b-afff-46d68d5b4617"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("88fde9f1-b3c0-4b23-847f-f5b690a7061e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("895b0a5f-8f13-4fa0-8fe8-19a16d9c228f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("89d73f77-47c0-4feb-b0f7-c5183668afe0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("89e5bfa7-ef68-45b7-865e-43b2c7c31f6d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8a05ab72-05bb-4e88-a320-298e9c5dcdb7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8b632ee9-a081-41d8-a680-08a9fb5f74b8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8bb6ccf2-85f6-4001-8982-e30f7b5b28d2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8c00cc38-5115-47ed-91a1-8a7a4bfa874c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8c07df47-01d2-4e41-99e3-0542ae7aa758"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8c78edb7-81fd-4ee4-ab53-e8ba2ca71202"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8d4c37e1-2e28-407a-8eb5-39f9d3083612"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8e3d13d5-2a03-46e2-b0ca-4dcc7a559f9f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8f5d1d5e-087c-4e1a-b1ea-6159b85aff12"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8f649fa7-ea5e-49c4-b683-d6d41d08ef51"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8fc393a0-2690-488a-8fcc-e6d1815655bc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("8fcff44c-5988-48ac-a40c-a5f34314eb27"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9149c4c2-9a28-4016-9c97-87770feade98"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9285fbc9-ddf2-4fcb-9656-2449da25d6d9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("92860ab0-d5a8-4c68-8dbb-8df66df37eaf"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("92b46a1a-9a96-4168-b169-f67e2037c9f2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("946da6f4-de13-4326-9012-26116bb3267d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("94a6c4ed-5066-4fbf-95ac-3d5fbb94d51b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("95d7b645-f54a-4b38-b2f4-fac1a9b0c365"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9666648e-905d-41cd-9c66-22c8dea05795"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("97190036-fe35-45be-91d4-d2f1d78c6fee"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9737e366-ca5a-4f13-be6a-48f831c18a4c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9771e996-4fb7-4f68-b1f9-07cfb708c760"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("97d8a71f-4626-47ce-a07e-f804f97e5326"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("97f6aa21-3f21-4955-8176-bc7283dcd5a2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("98476af4-c641-4aaf-8893-b96f0a28c833"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("98ea312c-ec32-4aa4-824e-dd889b7380c9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("996678c3-afb7-412d-85c7-b5ebc10b8fef"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("999ab7a8-f524-450d-8f9b-3210d1f11a41"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9b332062-a73a-4c9d-a51d-9c579cd1ee71"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9c6f6d37-fdfc-40b7-a7a6-4b2ca8e60338"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9d2ecb28-08c4-4bd5-b7f4-12c4b59b3a3e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9d79b934-e1db-44de-999d-dc2bcfe2de36"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9dfe2e2e-e4f3-41e5-bcc3-ba5d367135e9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9ee04d85-7a9e-45bd-86c4-635c738f2f5e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("9f5d920c-4747-433d-8e19-3297830721d5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a037bf61-8b46-4f00-bf40-e19c077d6ddb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a03aa42e-78b3-4f8c-bb5d-6ea1fcd66f13"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a07fd8f3-ff84-4009-89c7-139d6c966b59"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a157e850-cbab-450c-800c-4eb9f522a623"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a19b6fbe-b9f2-4dd4-bff4-871058c070a8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a1b4a442-0af1-4bf7-9e00-2eed5fe7513f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a37778d6-59cc-45eb-8d08-80777e2a18f6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a3c3ddeb-f31c-4ba1-9f31-946c5ed0e5d5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a513a9d1-1146-4f63-829e-3eba89c51b2e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a670b6f0-e526-459f-bb40-5a5b43633552"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a89c3f5d-cc08-439a-8d9c-c8256cfdbacb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a8d90d1d-885c-43e9-b5cc-a4fa9fed2ba6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a8e742e6-5bb7-41a3-a2b2-011bcbd18cff"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a92a88e5-3344-4439-bb37-c85ccec88123"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("a9f7ad57-ba0e-4b96-a6e5-0a966808ecd6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("aa5ed5c8-de35-4873-908e-f32d166ca6a6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("aa605f3a-ff93-4981-8784-d4c825dc62ce"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("aa6efb04-eae1-46b3-80e6-cca7b4491ce6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("aa6f512f-fcef-4c03-868c-eddc8deae740"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("aa76d5dd-055b-40ae-814e-e0553bbc70ea"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("aaf19263-ec21-4afe-b2e6-75a82fd5b4d1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ab183d22-d8fa-485f-82ea-9944da479262"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ac2ff11e-3d9a-42fe-83dc-1d6c4000776f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ac55f90b-8ba3-4242-a432-9ad241bcc2c9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("acb4f46d-50b7-4dba-ab03-dc4c8b3f47b7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("acf28e44-cd93-40c5-9447-b5d8410f0873"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ad007473-46bd-4fa8-8418-abe19e317bc4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ad23a013-5703-4909-a0d0-f46f0a7e23a0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ad2a3a01-de7a-42a9-a8ce-0bbb4b580177"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ad7e0c0e-5084-4490-9942-ddd906a19e1e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("af85b3c8-b774-4ca6-8f56-86d20e15a024"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b03fa6b7-2cc1-4f94-bc87-a1812b9ec8da"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b04c9737-7864-4ae7-9dfa-39db11f5b108"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b0c6b175-00e9-46ba-89a4-ab6c73b5e210"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b0ca869d-f0ae-407a-8da9-f13220ae78b3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b0e33811-1c37-436d-b6f4-434591bb941c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b29770ae-cf78-4c24-9599-59ca7969a0cd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b2a2dc57-63dd-4429-87af-5709c621fc51"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b339a965-e391-4d5c-969a-38c2ab28b8a8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b38a063b-785c-4979-8d2a-ca6bcdf98454"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b3b8ec54-e59b-4062-a2ba-9415ad0fb5fd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b4f814ae-2be6-40a9-b32b-bffa97e747c1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b549aa17-1439-4533-a01e-6f0214f578d6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b54a362b-2303-4f1f-a998-1712d6f622c1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b5cda8fd-650a-48e9-aee5-0da95c78d679"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b5ce8a53-fbe3-41e4-aaca-2cb42638f5e7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b66c447b-9f01-4433-bc52-1a2df5616c42"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b6c88812-4300-4d60-acd8-8d7710d77d3e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b75cf35b-0787-40e6-9cb1-cdb19c271b42"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b83d0f04-7b74-465c-a0b3-7e4952e561ef"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b8d46eb8-3972-42cb-8713-82bfce98c4cf"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b9bf8833-d956-477f-add1-f90bd0675ada"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("b9cf7791-073a-4e91-89e6-8c1e3f7ba7a4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ba096911-6d4f-473a-828a-0cd4829ef0d3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ba3ead92-be22-4153-8886-1211480bc36c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bae7d643-7d89-4904-98c9-54f85e308715"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bb0fa2a6-4f6d-4607-8e31-4e17388346ea"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bba3aa55-4e18-4d2c-b870-d7c3375cc559"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bbc8adf1-995c-4fe1-9416-3af8f930bedb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bc262aea-a7b4-49dd-8296-7b91b70e1677"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bc2fad38-f547-4588-89f0-cf753d4f5dc5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bcfea81b-870c-499f-9377-a890b0588a22"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bd0af52a-f317-4998-ae09-ddd9d787d198"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bdae0e77-416c-4bba-b011-d1d2cb3d77d6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bdc72552-882c-477c-a707-be726b5e28e8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bef9b235-75f6-4a88-966b-ac8d5b476932"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bf48bb86-8be8-4a8a-b350-4dc1430f1594"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bfc62692-b076-43a4-b4aa-c6d74c6ab050"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("bff5ffa2-c0f3-4d7f-950e-0f997f011491"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c02e1144-497b-4c96-bcc4-9ea2abed09fc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c08a83f2-40d6-483c-890c-6db656b0929d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c0c7ac9f-85dc-4629-8b47-01bf5f35dd06"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c1094c21-9bd3-4ff7-95f5-29936f25b84c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c12a0aa4-3431-467d-b246-4b63e6a4a844"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c1b19394-0856-4c06-a262-8fb4db801440"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c1e7ed7d-3186-4b6d-b087-1d9964c207dc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c3866181-3218-4362-9719-2cebc302f664"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c3f5e041-03d5-4a16-8116-7e4ec30c24bc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c43370ec-89d2-4fe1-8542-af43789455c0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c45e7edd-716b-4f86-81d9-72b94bed3df1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c4806959-b5bf-4fe3-ada6-00becf6a172a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c4bbb658-8e5e-4214-ae91-f7ed900c6d2d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c4d3451b-2b85-4231-87f7-ea0b5c05894e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c58a4a7e-20c9-4171-bf73-e37f468e7d2f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c5a4d06f-7b23-417c-b812-464cd3043466"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c6d003c1-a44e-43bd-9172-3ad45d0a0f86"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c78dbd3b-07ca-41be-9025-a38183d7c339"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c7e3c955-5667-409f-8fde-ca1f058bc64d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c7f3807b-a368-4c31-bac6-fa7701178ddd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c82f005b-6088-4b31-b772-de04f779395a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c83e8765-2ba3-4b43-8baa-11a09da5f735"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c8ad7409-0895-435f-8daf-19d6c3219994"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c8d434e7-75a8-4053-9e4e-0855842710b8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("c90506b7-1c33-4c0b-9a07-0da43fa29c27"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ca30fd56-1e7a-4b2c-b2fb-415664458218"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("caa023b4-400a-4a08-890d-15e7386d2e48"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("cac20c67-eb87-4f87-b062-8ed0bb2c1bc4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("cb470ccb-56ca-43a5-9b2d-1a3720d99c28"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("cbca740e-3e2a-4d70-ae8c-d8a681422945"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("cd1174cd-2cfb-48db-95cc-3fb1e9806792"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("cd3a20b0-454b-4f4c-94cb-c0d4691df87f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ce2817ce-8fe3-40f4-8bd0-e1cfede34617"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("cee812c1-a80e-472d-b61f-a3f9c7ab76e4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("cf36ed73-f990-4143-97c3-72ad8ce6fc01"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("cf49583a-d7c7-445b-a352-2364cb1342ae"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("cf7217e8-b8a6-4378-8d03-322880b43d32"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d12e566b-4abe-4acc-8e01-ed530df81f04"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d17d2d5e-9e63-42f0-9bb6-bc888bcb96a9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d28c7964-3506-4e4a-b61d-7d3886677e88"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d2a5f7a7-ed71-4e56-9359-21d5e7d2992a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d3d69075-8e95-498a-a357-bf283dfb0633"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d4e8e91e-a12b-4092-8dec-51438b06644b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d50e963f-bb0c-4274-98a6-6c4a36ec6da4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d5130b69-5c1c-4536-847e-e620577f083f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d5acb380-8860-470a-9bc5-5c4bc5155faf"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d6610d2f-d1f7-421e-b33a-a4af1e23b83a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d7174352-1216-44e5-bd2e-2501e9a8a437"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d7584c29-45e3-48ad-b9f3-b6e7a2ff6baf"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d777b2dd-a03a-4243-9512-c1e354ac6ed0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d7d4aedb-46ab-49fb-ac3d-4555ace5ae98"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d85cc3d5-6c94-4f3a-853a-3f821ccee607"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d90441d5-0783-435e-a3d6-eefdad880d43"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("d96bf979-4608-454b-9e7d-e37d7c48d0af"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("da5b4d84-a0fa-46b7-b521-7a95308a20fa"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("db072129-158a-4117-a4f0-d658f514c9ee"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("db52ed91-6833-4337-8c51-e8418e661501"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("db991176-794b-4736-9f12-6ef01ea81661"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("db9db20c-2c22-44d4-92dc-0980eb79526c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("dc290097-79d8-4a86-ad62-0e9ec0921217"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("dc37dd4e-7534-4aa3-97eb-ff067203572b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("dc9d95e9-eadd-46c5-93d4-734b9ab3ec60"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("dcff258d-9260-4c64-bb7c-aa9bf04632a8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("de1b1cfa-c258-4d2d-904a-4ab889bee664"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("de3d439d-80a4-4937-b09f-53ed5acfdb57"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("de9dea16-fc5d-444f-92bf-231ca9d1bc4d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("deabbcfe-1714-4163-8902-34d68d4bb0d4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("dedab8da-b803-43ae-be00-aa09d6f87329"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("df1974d7-e56a-4182-8380-bfe316e18b24"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("df6ed450-f281-4471-9f6b-b126f750f19f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("df90d294-7869-460a-a34b-b68325f2fb94"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("dfb8dfce-64be-405d-8e4c-7439ab0e759c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("dfc64efa-5a2f-4d02-b1d8-e59f51660862"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e0010d56-75db-4aff-a5b1-61e3568dd493"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e024123a-01ac-42bd-b7aa-34374b93fcb8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e03a1c6c-f695-410b-aeab-80d4dfa1a32c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e03a1d70-7983-420e-aa6a-6f7174dab32e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e0db1f39-0e28-4416-a263-d9361ca20af5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e19dea53-8e2b-47f0-abf8-2bd7b45db19f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e2bbaab5-0829-4308-b029-1c8560f939c3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e38606ce-e6cc-49f0-8127-7563e67f3b8b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e3f4f1cb-23a0-4926-9736-5989127e5937"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e47c1faf-79a7-4695-8ddf-2d3594a185c7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e4c6eb65-2f14-4ac5-96a5-32286b316a63"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e4e1d027-b480-478b-b53f-e5506aea1074"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e5546019-3a18-4e24-adc4-cfcca88d7776"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e5947c33-bd8f-4161-b3c2-24dc281b48ff"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e5bfdcc0-6632-4e37-913a-4cf76a9f7dfd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e62a2084-6c40-418f-be7f-64b1cb4b95a6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e647a6f2-9ae8-436a-a098-82d62445e532"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e6992217-8d59-4fb9-837d-b5d6688fda4d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e6fa8112-aee0-480c-95fd-978e888d5be7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e7276db3-7eaf-40c1-b771-f5a9d8a2f5ee"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e73ca127-9319-4b25-87cd-0dafa7be1ef9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e91e80d9-b943-4840-8691-cb9649711b91"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e933f121-1015-4ed7-9d9e-4d50ecc0835c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("e9588864-c5ce-4816-939a-fa1745435304"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("eae64783-3a1c-4214-a633-6613c68c8dd4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("eb0d8d95-117c-42d9-87b6-f15b56d3d25c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("eb26057b-9cdd-489a-a157-b264208ac5f8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("eb903c01-5693-4bae-b199-06e26d8331a9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ec961d87-f10a-40f1-a986-7f07357ab127"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("eda958de-4d79-4bf4-82cb-a87af943bce2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ee785283-29dc-488c-adf0-8686e77af202"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ee8d3b21-649d-4919-9152-f8454b810939"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("eedee811-6703-4cba-9ab6-fbf870496e99"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ef3d81be-1d38-4f7e-a711-2b1c4a2b89cd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ef5eaeb2-d2d8-40f0-88d3-eed7b79472b6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("effeda7c-1c21-48f8-9868-a38dd7790738"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f010c0af-d738-4ff1-831a-eecfd19692de"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f0407f69-0089-470b-a54b-2c59bbb51c0a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f08e67ba-ca39-4438-a283-a7fd2fc0981e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f0f36868-f06c-4a8f-b27b-41b0099ab19e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f1e16ebd-fd30-47bb-ae2c-6706f06b1150"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f1f3ffd2-04c5-4b83-be05-ed4e55c076b8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f2999255-80a7-4bd2-8ac8-9eecdaa9d783"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f2bbc589-f99d-4a22-be46-c9639a6d4903"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f302b352-c832-4533-bd7e-98fffc113dc5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f395644f-288a-481c-94ac-562fa01d9978"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f3bab226-6f5a-419b-922b-2de130df3fc7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f3d85a34-f19a-431b-8f24-48d540e1c67f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f3f73ceb-c880-4a0d-81a2-ef0fda6bb2d5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f4ab9780-cb04-485a-8d4f-2260577f6207"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f5321883-ca8e-4054-86a1-39da7963416d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f53d266d-a6a7-433f-a2d0-233c3ef55152"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f6aa87c6-e4c8-46a8-909c-2c13cbd5c621"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f6d7ed9f-da61-479e-9f5f-900087287fbd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f716b3b8-0b9b-4d3d-ba28-1fa6faea2e20"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f76b18c4-4b1b-46c8-ace2-d9fdfd48c445"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f7744b5f-3060-4caa-98e6-2b013c1fe188"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f799d868-703f-437f-8fba-7ca21744ba5c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f7b1b54a-8600-49f8-bfaa-378c229fb319"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f7bd7d7c-6713-4e38-90ee-f5f5b13c797e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f8ad8237-5e9e-42d5-8209-9717ab9fe03f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f8d26349-1f50-44fd-b1ff-505a8c8a1254"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f8f2b7f1-bb4d-4156-a651-f214194b9381"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("f90f276a-eb82-4747-ae5a-4d6dbc8ba1d9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("fa497690-8c0d-4740-a965-2fe3285781ff"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("fae9c0be-b6a8-4b34-ae9a-954390f81ac2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("fbdc2c4d-103a-42a5-ad63-b3e5c87f10c2"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("fc38b68a-817b-4480-a359-2c111cd5e743"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("fd2a6278-ef07-44e3-8368-75213bfe116d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("fd5172fc-0747-47cc-af7d-40c1fb9f6c41"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("fde5fdf1-b7dc-4794-8167-23d685291387"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("fdf2ea5f-d73a-4fd3-9b87-4c4277e7d95a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ff3e1882-c479-4949-b075-fe9789220025"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ff6a8745-cc92-4a78-9c38-b8779fc7df67"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                keyColumn: "ID_AVALIACAO",
                keyValue: new Guid("ffdf497b-8a00-45db-b9fc-721da3acce3e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("0263d15e-c6b3-458a-9d54-978d2c1f0a5f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("02715d7b-8b26-411e-ad93-4fb67dc19f84"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("05bf8b92-ddec-44a1-a87f-0a7088171dd3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("0b68c9aa-5101-4d2b-a719-356fca5d2a89"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("11bdaad7-cdac-40b1-9e5c-566d4897bc4c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("11d7cb13-6ce3-4f36-9ddc-af9d43d70590"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("14164b28-fa7b-4340-beec-4473268b9ceb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("15089a33-90d0-4c47-ab00-bdf3e0eaba51"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("155a6420-9845-456c-962b-75b055c4dc87"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("1736345f-408d-4d75-8f43-eddb497a485e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("18e266fc-0e7b-4db8-a985-52e1166f356c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("1f97d55e-9476-4c35-ad32-4db1f39a3d93"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("20461e6a-5d8b-4284-aa50-2da939854fc9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("29c34a04-4d3e-40db-8853-5c576e423594"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("2ae13bc5-6793-4573-92ea-ef732e532387"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("2b5dbef5-65f7-4982-ba05-659fae04b9ce"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("2bb6774c-793d-45a9-a44b-92a3a311f605"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("2c0807a4-5484-4afc-bab0-76c64673cc18"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("2c54e80a-f449-4234-a09a-97f978ca0fa6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("2f0cc7dd-7ce4-418c-8781-a217f5b7952c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("3398844e-f908-4061-8e40-f88a0acfa277"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("34c9dbe3-5735-4ead-8db8-9f0e0fcc790c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("35a71f09-8691-40fa-aa51-cbb4ade21481"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("35ae383d-420d-4396-8682-5a9a5b26d93a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("38bbb9c4-a90d-485d-a21f-f6c0cbe09811"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("39d20686-933b-499f-951c-da2027612fa9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("3a959ebd-8a95-40b8-8147-d82ff8bd7786"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("3f0c1fc9-6b50-4ecc-9330-fc803d6b01e5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("40ec5a59-6425-49c5-a1e6-c48925a2905c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("4537f970-61f7-4185-964e-0b4844efa405"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("467a9ddb-ccde-4cdb-b7a8-12f6a6e6f045"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("4969c4a8-0552-44b7-a856-17264619ba8c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("4ac63c47-b049-43eb-9b51-f7e90444699d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("525b6a8e-afc3-4e47-8e32-861ab39caad0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("535f9ef8-c87d-497f-9fba-36ee3643b7a0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("540d6bd6-e7fe-420d-a306-f98c38e85a7f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("55431397-bdc6-43e3-8ec2-b3d752120800"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("55e36de1-8310-437b-901e-91983c6e13ea"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("56514033-50d1-44ee-bbde-6cab3f4ebdce"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("5680c418-437d-4d0f-96f2-1dd7f45df35e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("58bbbda0-2453-4fda-9aea-4b0a1f7a0d8b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("590ebd61-5175-450a-9ee7-c7f03f242f78"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("5b20763e-5d44-4743-9163-805c1a0d1259"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("5d164151-5cfd-4b5c-8f52-9253ac02dbec"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("61a265fa-7abf-431e-9a3b-40c4f4b867d3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("6373f7f2-61b7-45af-8cb3-3251e40cb90f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("64923624-1a53-4bf4-aa9d-35e2e28f2dc7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("6914cbd0-fbdd-4c75-8612-5b79d2e07bc6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("6bb8e1ea-7ec9-44f0-8752-9465d4974403"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("6c5d21c5-a215-4834-a271-4f99c888be40"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("6df2979a-61be-40f3-87cb-02d2e4db8aeb"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("6fafeb83-e5ea-4a2a-8e10-256bdb7edda4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("70007b70-7393-417e-93d6-6873a4650dcf"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("72238dd2-b4f2-4fdd-9bf7-23a92fa7677e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("735d7ea4-3fe6-4342-b95a-45cbf9e23af0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("7603b5e3-3f8a-476a-aaa6-95f172fc31fc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("76a0d3b7-e626-4e4e-a58e-c7cc4fb8eac6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("77ca015a-f92f-4fd0-ba5b-270423218165"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("7e19fdee-dc75-4d90-8329-3bfc89234439"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("81728431-9171-4c67-8f7b-4f362741abb1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("818e5dcd-e5e5-4b12-84dc-0909ce8566f7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("849bd51c-7b3d-4587-a386-f7daf552e534"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("8a73a2d3-a903-4c16-9af9-04eab26b6080"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("8c582c68-0177-4890-82a7-610a05ad49b8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("8d63ce11-9c2b-40f0-888e-81b839423be8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("8dc4ab16-71fa-4c28-9145-0a75e4737c7e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("8e440578-dff1-4cad-bd53-16a633c25c41"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("8fcb5351-7fc5-4a51-8558-cc9bfca63b60"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("92537d02-b8cd-4a4f-be97-b102c0a3e67e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("92a33891-228e-4cfe-ac02-3032edb9d89f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("93fd03ff-ddb0-48a8-8166-6be1c07a5e2d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("94e2fa00-ee65-43cd-985e-4de14269a1e6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("978ccb12-4565-45d9-b0a0-2f0af8762e25"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("98437447-6178-4fdb-9391-9330fcc50233"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("99d3d343-4285-48e6-be13-4124634eb9a1"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("9aa1e2c4-416b-432c-9023-a773b376f7aa"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("9aaa7c3c-d470-469f-ac73-260be391aefc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("9c24eff2-842b-45cb-81b8-12e7a48b2c0d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("9c9e5953-5996-4b31-8651-5b273b47bd9c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("a092ea7e-6ab1-4d75-b712-2cb31ef0bdce"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("a0d001d6-6e8e-4437-a6e5-2e30c7681cf6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("a735bcb7-227f-432a-ab3e-2a412586585f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("ab922c21-9278-4b01-af33-9023d6227bfa"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("ae35e51e-8228-4f8b-ae40-76f10bf2f9ea"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("aeef49af-12db-4978-a33c-c43bfdb93485"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b0ee689a-0865-496c-8cbe-ef861eab4cd7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b2d7d479-5b80-4124-8668-91b04b149e82"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b3796584-15b0-49e7-bce2-df13a233ae6b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b3d2f75a-c2ec-484f-8ba3-d847a124611b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b4896e96-a5c2-46fc-975e-9a1c37c0316f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b6ceef7c-dcf9-4b66-8e80-9d8ef9699f7c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b6de7d23-8573-4e46-ac3d-2af829891e3d"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("b71b798b-53ff-46c8-b66c-fc6bce81bd7f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("be97cde2-73e9-4e69-9f5a-488bb563f83f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("c766471e-9370-4f34-a031-eb934c0f7988"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("c9fb3b2e-cb2e-4256-9bb3-4f6cfce9cee6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("ca5160e5-e078-45e3-8629-0b27fb5c77b3"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("cd4cf7ac-0f20-48ae-893c-8e57f7673452"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("ce49e0fe-41c4-4695-a12d-e255f109a0d8"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("ce6f9da4-1343-45bf-a9e1-aac177817f16"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("ce90b1c3-82dc-49c4-b0e9-e4b804b206dd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("d0d147ac-dbbe-4a7b-9ebf-18e4cb12eee4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("d118b756-ecb1-4598-89a6-398f04502368"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("d1819035-78f3-46c0-965d-d7807ab15b2a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("d1a1b1ea-20aa-42b1-a6f8-580bd49934c5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("d4d3adec-0384-4ff0-98d5-90ad0296280a"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("d539523a-9ae1-4212-9c95-38b6b355cc35"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("d5f338f9-a434-4bc1-9b3b-629152227078"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("d96cfa0d-e90f-437a-a0df-adbc1403f83c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("da65b850-26e1-42b5-ad01-611bf9f22786"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("de5bbe1f-8bf6-4f5f-b6a5-445797393bf0"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("e23546b8-66a4-42c9-a4cc-dcf004bb7dcc"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("e2b28c68-1d11-4af7-8fb2-74c9f602b864"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("e3b8f0b5-2b72-41c4-a0b2-c38174c812e9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("e4f5f06c-6227-4d58-8f31-cd0ee72ea7a4"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("e508f653-16dc-44b7-ad36-8652105c5cd5"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("e5516bae-a847-4150-8798-32439864b335"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("e5ab7711-4c2d-46ff-8825-90b78363495c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("ebbb0699-d419-40e2-89d0-657ef1c9312f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("ed006160-e3ee-4333-89a9-d363e712e491"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("edc8e88c-95df-4b66-82d5-b81d5148992c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("ef46368f-4f9d-43f2-964d-905dcb508348"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("ef4f814e-6064-43ff-a993-5bf399b28554"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("f01246ca-0f35-437c-b27b-a037750096db"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("f2597c9f-cff9-4c2e-8be6-1a557355fe4e"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("f276e03d-1f0a-449b-bb5e-d997bcee76ca"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("f29f0176-bc34-4538-bae2-c9d99e9a86bd"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("f4f4aa16-f8fd-4e3c-af15-97519ff5a3e6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_RESPONSAVEL_TEMA",
                keyColumn: "ID_RESPONSAVEL_TEMA",
                keyValue: new Guid("ff3f99b5-6ba0-48d7-9118-eefcedd7b705"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("24b5d32b-7d64-42b4-8849-ec9223116b97"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("25ec09f9-5ad3-48d2-84b9-52a51c9e5fd6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("47570fb0-9dc9-4983-bef1-e409e29213b9"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("6f8c2171-f525-47fa-913b-50d14cf64a48"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("894da9d6-071f-4ff0-ba63-6c34957cd1a6"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("a08812fc-1cb8-420a-b710-8c58fe59f27c"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("ae8608bd-db77-46fd-aa85-b8a9885eca2b"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("c4f7128e-3871-418e-a07f-51e3d3f1719f"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                keyColumn: "ID_PUBLICACAO",
                keyValue: new Guid("f7901011-9590-4066-8c36-f592c68817b7"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO_SOLICITACAO",
                keyColumn: "ID_SOLICITACAO_PUBLICACAO",
                keyValue: new Guid("7c111573-c45d-4164-a207-28ac0866a764"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO_SOLICITACAO",
                keyColumn: "ID_SOLICITACAO_PUBLICACAO",
                keyValue: new Guid("ce889c3f-d827-4c0d-b647-17ce30d2ed32"));

            migrationBuilder.DeleteData(
                schema: "Fórum",
                table: "FORUM_PUBLICACAO_SOLICITACAO",
                keyColumn: "ID_SOLICITACAO_PUBLICACAO",
                keyValue: new Guid("f0367f2c-2446-444f-84c0-40e8fb6299d3"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ID_PUBLICACAO",
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_FORUM_PUBLICACAO_ID_SOLICITACAO_PUBLICACAO",
                schema: "Fórum",
                table: "FORUM_PUBLICACAO",
                column: "ID_SOLICITACAO_PUBLICACAO");

            migrationBuilder.AddForeignKey(
                name: "FK_FORUM_AVALIACAO_PUBLICACAO_FORUM_PUBLICACAO_ID_PUBLICACAO",
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                column: "ID_PUBLICACAO",
                principalSchema: "Fórum",
                principalTable: "FORUM_PUBLICACAO",
                principalColumn: "ID_PUBLICACAO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FORUM_AVALIACAO_PUBLICACAO_FORUM_PUBLICACAO_SOLICITACAO_ID_AVALIACAO",
                schema: "Fórum",
                table: "FORUM_AVALIACAO_PUBLICACAO",
                column: "ID_AVALIACAO",
                principalSchema: "Fórum",
                principalTable: "FORUM_PUBLICACAO_SOLICITACAO",
                principalColumn: "ID_SOLICITACAO_PUBLICACAO",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
