using MilkApi.Models;

namespace MilkApi.Data;

public class SeedDatabase
{
    public void PrePopulation(IApplicationBuilder app)
    {
        using (var serviceScope = app.ApplicationServices.CreateScope())
        {
            SeedData(serviceScope.ServiceProvider.GetService<MilkDbContext>());
        }
    }

    private void SeedData(MilkDbContext context)
    {
        if (!context.Milk.Any())
        {
            addMilk(context);
        }
        context.SaveChanges();
    }

    private void addMilk(MilkDbContext context)
    {
        context.Milk.AddRange(
            new Milk
            {
                name = "Dillion's unequaled cashew milk",
                type = "Cashew milk",
                storage = 99,
                id = new Guid("301d5dcf-a2a8-4a34-b26b-efcaa103963c")
            },
            new Milk
            {
                name = "Monet's powerful cashew milk",
                type = "Cashew milk",
                storage = 27,
                id = new Guid("1277e861-b33b-485d-b86f-400769d25a82")
            },
            new Milk
            {
                name = "Julianne's relevant pea milk",
                type = "Pea milk",
                storage = 33,
                id = new Guid("210aeed2-413b-4e53-98e7-62c9f6fd31ba")
            },
    new Milk
    {
        name = "Macie's broad walnut milk",
        type = "Walnut milk",
        storage = 23,
        id = new Guid("72204ea0-29e2-4da8-bf57-648b37268b71")
    },
    new Milk
    {
        name = "Christa's fearful rice milk",
        type = "Rice milk",
        storage = 46,
        id = new Guid("06d60157-e9c7-4bd9-b2a6-00fd63bb2033")
    },
    new Milk
    {
        name = "Shakayla's loose coconut milk",
        type = "Coconut milk",
        storage = 82,
        id = new Guid("6905f2f6-e80c-4601-8ae6-5408485ef9c5")
    },
    new Milk
    {
        name = "Duane's salty soy milk",
        type = "Soy milk",
        storage = 24,
        id = new Guid("10aed344-837d-4621-873e-aeac9394c99f")
    },
    new Milk
    {
        name = "Deangelo's rotten hemp milk",
        type = "Hemp milk",
        storage = 59,
        id = new Guid("2ceec543-8fd9-4c7c-855a-c1388a68ca78")
    },
    new Milk
    {
        name = "Gaven's numberless walnut milk",
        type = "Walnut milk",
        storage = 89,
        id = new Guid("dd9140c5-af1d-4861-9736-e0b4f4a81bb7")
    },
    new Milk
    {
        name = "Tea's scientific rice milk",
        type = "Rice milk",
        storage = 15,
        id = new Guid("0798ae22-c922-4b47-adc5-23feac38020f")
    },
    new Milk
    {
        name = "Cora's early almond milk",
        type = "Almond milk",
        storage = 58,
        id = new Guid("3dbf9e44-fb2f-487b-8b34-7e6e6700e17e")
    },
    new Milk
    {
        name = "Jonah's aware cashew milk",
        type = "Cashew milk",
        storage = 79,
        id = new Guid("ea1aadc3-bd1e-4f43-a46d-e035e7a96282")
    },
    new Milk
    {
        name = "Catrina's fallacious almond milk",
        type = "Almond milk",
        storage = 62,
        id = new Guid("1bba8dfc-07af-414d-b85d-663443612e5b")
    },
    new Milk
    {
        name = "Kristian's quickest oat milk",
        type = "Oat milk",
        storage = 37,
        id = new Guid("2534898d-223e-49f8-9a4f-2993458fc5f2")
    },
    new Milk
    {
        name = "Jessi's unbiased almond milk",
        type = "Almond milk",
        storage = 76,
        id = new Guid("3989e76f-0546-4b01-bad6-5d52535e8136")
    },
    new Milk
    {
        name = "Jean's wide hemp milk",
        type = "Hemp milk",
        storage = 90,
        id = new Guid("fe7c5123-4141-427e-92ed-e9b41bf88c2a")
    },
    new Milk
    {
        name = "Stephen's torpid walnut milk",
        type = "Walnut milk",
        storage = 26,
        id = new Guid("b3a8ed8d-be54-40b7-9880-5e7df192b981")
    },
    new Milk
    {
        name = "Christa's squealing cashew milk",
        type = "Cashew milk",
        storage = 100,
        id = new Guid("d6e96a38-ce76-42d9-95a4-7247ea4dcb7a")
    },
    new Milk
    {
        name = "Dominik's fearful oat milk",
        type = "Oat milk",
        storage = 25,
        id = new Guid("b48a9bbd-ef6b-4205-8c06-014e891a9faf")
    },
    new Milk
    {
        name = "Joshua's full macadamia milk",
        type = "Macadamia milk",
        storage = 44,
        id = new Guid("352139db-6f31-4856-83eb-4142c92a3c44")
    },
    new Milk
    {
        name = "Judith's orange cashew milk",
        type = "Cashew milk",
        storage = 85,
        id = new Guid("3e437e24-8d75-4063-acbf-827d3c833d90")
    },
    new Milk
    {
        name = "Kentrell's unequaled whole milk",
        type = "Whole milk",
        storage = 51,
        id = new Guid("283ff036-d83d-403c-8a67-b25f1c096682")
    },
    new Milk
    {
        name = "Kristian's wealthy cashew milk",
        type = "Cashew milk",
        storage = 11,
        id = new Guid("7786da9f-efb9-4e4d-828b-3cf85f1e63c6")
    },
    new Milk
    {
        name = "Dominik's alive whole milk",
        type = "Whole milk",
        storage = 97,
        id = new Guid("e554d358-ec1c-4b9b-97a3-97fa999abb64")
    },
    new Milk
    {
        name = "Jean's scared coconut milk",
        type = "Coconut milk",
        storage = 25,
        id = new Guid("3f2a611a-4d0b-41e1-8165-2f8f9a1f66aa")
    },
    new Milk
    {
        name = "Sheldon's tasteless cashew milk",
        type = "Cashew milk",
        storage = 80,
        id = new Guid("fd2349a0-3d48-4d9b-ac22-6290d1053495")
    },
    new Milk
    {
        name = "Jocelyn's rough soy milk",
        type = "Soy milk",
        storage = 25,
        id = new Guid("e80064ce-5599-46f6-a2d9-6bc7a1aca872")
    },
    new Milk
    {
        name = "Chandler's full oat milk",
        type = "Oat milk",
        storage = 32,
        id = new Guid("9466032f-db34-49d3-9ae3-7385cc0082f7")
    },
    new Milk
    {
        name = "Tea's wide pea milk",
        type = "Pea milk",
        storage = 40,
        id = new Guid("d84696a9-600d-4912-914d-bbb7f6a5e744")
    },
    new Milk
    {
        name = "Dillion's taboo hemp milk",
        type = "Hemp milk",
        storage = 58,
        id = new Guid("50045980-f3c9-408b-83bf-a98db403d42d")
    },
    new Milk
    {
        name = "Korbin's open pea milk",
        type = "Pea milk",
        storage = 94,
        id = new Guid("81bd9a68-5599-4018-990a-694b519a9bdb")
    },
    new Milk
    {
        name = "Stephen's fearful macadamia milk",
        type = "Macadamia milk",
        storage = 100,
        id = new Guid("7be33cd3-311a-4418-a24d-a501c8d31465")
    },
    new Milk
    {
        name = "Jessalyn's fallacious almond milk",
        type = "Almond milk",
        storage = 65,
        id = new Guid("d2f12e7b-f096-4391-ad72-b4517deb24cf")
    },
    new Milk
    {
        name = "Jaeden's cooing cashew milk",
        type = "Cashew milk",
        storage = 33,
        id = new Guid("50a70194-f239-43f6-81de-25628b27ea5a")
    },
    new Milk
    {
        name = "Christa's wealthy whole milk",
        type = "Whole milk",
        storage = 84,
        id = new Guid("0ac95b83-bdce-497c-b0c3-7c0071419324")
    },
    new Milk
    {
        name = "Judith's bumpy almond milk",
        type = "Almond milk",
        storage = 66,
        id = new Guid("ff6524a8-ab9c-4320-8c41-17e3a8da268e")
    },
    new Milk
    {
        name = "Jaquez's unequaled hemp milk",
        type = "Hemp milk",
        storage = 76,
        id = new Guid("9001c051-305d-462c-aefb-be220eadae6b")
    },
    new Milk
    {
        name = "Elliot's recent almond milk",
        type = "Almond milk",
        storage = 50,
        id = new Guid("0037a064-7ce1-4c97-b8a0-51848775a7a9")
    },
    new Milk
    {
        name = "Brittney's unbiased coconut milk",
        type = "Coconut milk",
        storage = 96,
        id = new Guid("9811f876-ebc9-44f0-88ae-1d087cb940db")
    },
    new Milk
    {
        name = "Dillion's rough rice milk",
        type = "Rice milk",
        storage = 56,
        id = new Guid("179670c3-e49f-4655-ab71-12a90b912cc5")
    },
    new Milk
    {
        name = "Lucero's wholesale whole milk",
        type = "Whole milk",
        storage = 46,
        id = new Guid("602d410e-46e1-4744-9b82-cfc7dd5d0940")
    },
    new Milk
    {
        name = "Jedidiah's early almond milk",
        type = "Almond milk",
        storage = 49,
        id = new Guid("aa5ce91a-67e6-4349-b1c2-4c4050efb49e")
    },
    new Milk
    {
        name = "Kasey's quickest hemp milk",
        type = "Hemp milk",
        storage = 4,
        id = new Guid("78b2fb8e-4c91-439e-a479-f8c1e9595343")
    },
    new Milk
    {
        name = "Kasey's wide rice milk",
        type = "Rice milk",
        storage = 54,
        id = new Guid("1d52f5a1-4c39-4352-85df-168320fb3575")
    },
    new Milk
    {
        name = "Judith's steady pea milk",
        type = "Pea milk",
        storage = 32,
        id = new Guid("2f1ce24b-9536-4988-a8b5-c7d9334b74ce")
    },
    new Milk
    {
        name = "Benjamin's taboo soy milk",
        type = "Soy milk",
        storage = 87,
        id = new Guid("d3ba0a73-29a1-4802-b284-a498df060c42")
    },
    new Milk
    {
        name = "Gaven's early cashew milk",
        type = "Cashew milk",
        storage = 36,
        id = new Guid("1dda5869-263d-460c-8275-3b131e17c601")
    },
    new Milk
    {
        name = "Kentrell's loose hemp milk",
        type = "Hemp milk",
        storage = 79,
        id = new Guid("7d1d6d3d-160c-4461-9b93-385041a224a2")
    },
    new Milk
    {
        name = "Johnny's second whole milk",
        type = "Whole milk",
        storage = 54,
        id = new Guid("a3df7049-9b81-476d-a803-e8ed8aca161a")
    },
    new Milk
    {
        name = "Quincy's whole soy milk",
        type = "Soy milk",
        storage = 10,
        id = new Guid("2356a84e-0fbb-4b5b-993c-0bc6c70586e2")
    },
    new Milk
    {
        name = "Kasey's painful pea milk",
        type = "Pea milk",
        storage = 62,
        id = new Guid("b1b4f84b-57f2-420a-9506-ac0636935ab0")
    },
    new Milk
    {
        name = "Nehemiah's salty hemp milk",
        type = "Hemp milk",
        storage = 4,
        id = new Guid("99370f4e-7b31-4d0f-94ab-bd6dae094ddb")
    },
    new Milk
    {
        name = "Jonah's second hemp milk",
        type = "Hemp milk",
        storage = 26,
        id = new Guid("27ebf833-e1ba-40a6-b101-da4eb71313d8")
    },
    new Milk
    {
        name = "Korbin's fearful walnut milk",
        type = "Walnut milk",
        storage = 27,
        id = new Guid("264a505c-4d88-4a61-966c-471d5233d8d1")
    },
    new Milk
    {
        name = "Deangelo's onerous walnut milk",
        type = "Walnut milk",
        storage = 57,
        id = new Guid("62603a88-f96f-4beb-a0ed-98358826974a")
    },
    new Milk
    {
        name = "Joshua's existing rice milk",
        type = "Rice milk",
        storage = 73,
        id = new Guid("697a783b-43e4-478e-bd1b-253676e43c0b")
    },
    new Milk
    {
        name = "Lincoln's scared walnut milk",
        type = "Walnut milk",
        storage = 71,
        id = new Guid("1fcb5bbb-0fa4-40d5-92ae-0e751c18d704")
    },
    new Milk
    {
        name = "Kentrell's rough almond milk",
        type = "Almond milk",
        storage = 40,
        id = new Guid("ad3bf06b-9c2d-4c3e-8fdd-d0fec4ef99b6")
    },
    new Milk
    {
        name = "Kentrell's scientific macadamia milk",
        type = "Macadamia milk",
        storage = 1,
        id = new Guid("1627d6d8-1a96-4011-8294-49b9f1e90ba8")
    },
    new Milk
    {
        name = "Catrina's aware macadamia milk",
        type = "Macadamia milk",
        storage = 64,
        id = new Guid("886fa2ee-e61f-42e8-8f90-80d46f792924")
    },
    new Milk
    {
        name = "Marion's torpid soy milk",
        type = "Soy milk",
        storage = 41,
        id = new Guid("0597329f-b2fb-49a9-a5fd-13797fa1d7ce")
    },
    new Milk
    {
        name = "Harlie's squealing pea milk",
        type = "Pea milk",
        storage = 47,
        id = new Guid("63937d8a-aaf5-46b4-a997-f78eda7b6157")
    },
    new Milk
    {
        name = "Elliot's unbiased pea milk",
        type = "Pea milk",
        storage = 48,
        id = new Guid("95992ab8-183a-4e19-b404-970e24d5300a")
    },
    new Milk
    {
        name = "Tea's strong hemp milk",
        type = "Hemp milk",
        storage = 19,
        id = new Guid("df679bb2-a8b0-41af-a291-02b28c10c4ff")
    },
    new Milk
    {
        name = "Nehemiah's wealthy cashew milk",
        type = "Cashew milk",
        storage = 35,
        id = new Guid("ce87d24d-e70d-4b21-961c-addc7162f792")
    },
    new Milk
    {
        name = "Judith's quickest oat milk",
        type = "Oat milk",
        storage = 84,
        id = new Guid("38730f3c-009e-4873-995e-7a023a8f759f")
    },
    new Milk
    {
        name = "Karlee's painful rice milk",
        type = "Rice milk",
        storage = 55,
        id = new Guid("77afcf09-4b31-445d-b33d-66e197dcbdd0")
    },
    new Milk
    {
        name = "Joshua's rotten oat milk",
        type = "Oat milk",
        storage = 15,
        id = new Guid("e250de50-a606-49d9-afa7-fa118c9a3184")
    },
    new Milk
    {
        name = "Kristian's bumpy pea milk",
        type = "Pea milk",
        storage = 33,
        id = new Guid("52c82b59-042b-4b40-8c12-6475156cc87e")
    },
    new Milk
    {
        name = "Jonah's early hemp milk",
        type = "Hemp milk",
        storage = 44,
        id = new Guid("ba46543f-2bd3-449e-8e62-ee6f269bfc10")
    },
    new Milk
    {
        name = "Stephen's wealthy hemp milk",
        type = "Hemp milk",
        storage = 34,
        id = new Guid("9373d575-0d21-4e11-80d6-e7e35a836f28")
    },
    new Milk
    {
        name = "Felicity's second cashew milk",
        type = "Cashew milk",
        storage = 76,
        id = new Guid("9a2bfc2f-2a8f-4a62-92b0-dcdcca37bba2")
    },
    new Milk
    {
        name = "Elliot's voiceless cashew milk",
        type = "Cashew milk",
        storage = 87,
        id = new Guid("a83d309f-ebe5-4bed-9555-bc18869d98ca")
    },
    new Milk
    {
        name = "Zain's wealthy cashew milk",
        type = "Cashew milk",
        storage = 71,
        id = new Guid("41916cd4-9d74-4222-9fa8-114a2d3a64ce")
    },
    new Milk
    {
        name = "Dominik's rough whole milk",
        type = "Whole milk",
        storage = 83,
        id = new Guid("48029d08-8dcb-486e-8cc8-86961f8658dc")
    },
    new Milk
    {
        name = "Karlee's rough soy milk",
        type = "Soy milk",
        storage = 99,
        id = new Guid("34a5ceb6-0c67-4794-936b-db67c5ff9109")
    },
    new Milk
    {
        name = "Tyquan's wholesale almond milk",
        type = "Almond milk",
        storage = 21,
        id = new Guid("7cb2ff70-98b4-4735-8cc0-25bc2d37ad44")
    },
    new Milk
    {
        name = "Cora's loose pea milk",
        type = "Pea milk",
        storage = 70,
        id = new Guid("ffd3b484-ede9-43da-aad8-d4d318438d7d")
    },
    new Milk
    {
        name = "Catrina's fallacious coconut milk",
        type = "Coconut milk",
        storage = 54,
        id = new Guid("2ce0972a-915a-4f42-afe9-09e9364c9668")
    },
    new Milk
    {
        name = "Judith's rotten rice milk",
        type = "Rice milk",
        storage = 43,
        id = new Guid("6774d933-12ec-4db4-ac3e-215e817a4a56")
    },
    new Milk
    {
        name = "Jedidiah's cumbersome oat milk",
        type = "Oat milk",
        storage = 16,
        id = new Guid("2ef1b9a2-870b-4b78-87c1-1d73070c4cd4")
    },
    new Milk
    {
        name = "Karlee's tan oat milk",
        type = "Oat milk",
        storage = 39,
        id = new Guid("b6679277-32a8-4d7c-9e19-2799aa9a3fb3")
    },
    new Milk
    {
        name = "Johnny's quickest rice milk",
        type = "Rice milk",
        storage = 41,
        id = new Guid("4f183948-3744-4e9e-8907-c6f10644cfbf")
    },
    new Milk
    {
        name = "Samuel's broad soy milk",
        type = "Soy milk",
        storage = 33,
        id = new Guid("f6e801ff-336e-4aa7-879b-13b16bef285f")
    },
    new Milk
    {
        name = "Rodney's relevant hemp milk",
        type = "Hemp milk",
        storage = 56,
        id = new Guid("663da2d8-bde6-4eb6-94a3-01bf4c3f8c4f")
    },
    new Milk
    {
        name = "Joan's numberless soy milk",
        type = "Soy milk",
        storage = 98,
        id = new Guid("4e46d68b-cd90-4549-8f49-644fd4fe7a61")
    },
    new Milk
    {
        name = "Tea's alive almond milk",
        type = "Almond milk",
        storage = 55,
        id = new Guid("4500a34b-e06e-4a5f-89fd-7804611e9e51")
    },
    new Milk
    {
        name = "Duane's typical walnut milk",
        type = "Walnut milk",
        storage = 89,
        id = new Guid("33f05a1b-de2e-4319-b279-2313478dd891")
    },
    new Milk
    {
        name = "Benjamin's scared whole milk",
        type = "Whole milk",
        storage = 4,
        id = new Guid("85a307d1-3af5-410a-8cfa-31489fdc9df1")
    },
    new Milk
    {
        name = "Jaquez's whole oat milk",
        type = "Oat milk",
        storage = 50,
        id = new Guid("87704f41-8529-4268-aaad-5c20023d0db6")
    },
    new Milk
    {
        name = "Kerry's unbiased whole milk",
        type = "Whole milk",
        storage = 21,
        id = new Guid("f8021d2c-c37a-4e62-afe6-02487057cc3b")
    },
    new Milk
    {
        name = "Nehemiah's open almond milk",
        type = "Almond milk",
        storage = 23,
        id = new Guid("e0041dbf-13bf-4371-9b2c-ff575492411e")
    },
    new Milk
    {
        name = "Jonah's bumpy hemp milk",
        type = "Hemp milk",
        storage = 72,
        id = new Guid("7fb4ac10-d5ba-4403-85d1-236ccc76b378")
    },
    new Milk
    {
        name = "Michele's alive walnut milk",
        type = "Walnut milk",
        storage = 25,
        id = new Guid("cc96a41f-bb3a-450c-ae76-683edc71be52")
    },
    new Milk
    {
        name = "Kristian's divergent soy milk",
        type = "Soy milk",
        storage = 24,
        id = new Guid("28327307-f377-4fc4-b497-d85e09552449")
    },
    new Milk
    {
        name = "Joan's full pea milk",
        type = "Pea milk",
        storage = 67,
        id = new Guid("2702fab9-db1c-44bf-a43f-9107cf21e499")
    },
    new Milk
    {
        name = "Lance's steady walnut milk",
        type = "Walnut milk",
        storage = 59,
        id = new Guid("d407b372-2624-4e7b-8e8b-d6b2c1641e5a")
    },
    new Milk
    {
        name = "Sheldon's tasteless hemp milk",
        type = "Hemp milk",
        storage = 4,
        id = new Guid("396937ec-6ae7-4a16-977b-de9544c152b1")
    },
    new Milk
    {
        name = "Kristian's early coconut milk",
        type = "Coconut milk",
        storage = 35,
        id = new Guid("cf5a5299-c4dd-4699-a8d7-1eed6382888b")
    }
        );
    }
}