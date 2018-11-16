// <auto-generated>
// Code generated by LUISGen todo.luis -cs Luis.ToDo -o ../../Dialogs/Shared/Resources
// Tool github: https://github.com/microsoft/botbuilder-tools
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>
using Newtonsoft.Json;
using System.Collections.Generic;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.AI.Luis;
namespace Luis
{
    public class ToDo: IRecognizerConvert
    {
        public string Text;
        public string AlteredText;
        public enum Intent {
            AddToDo, 
            DeleteToDo, 
            MarkToDo, 
            None, 
            ShowToDo
        };
        public virtual Dictionary<Intent, IntentScore> Intents { get; set; }

        public class _Entities
        {
            // Simple entities
            public string[] ContainsAll;
            public string[] ListType;
            public string[] TaskContentML;

            // Built-in entities
            public double[] ordinal;

            // Lists
            public string[][] FoodOfGrocery;
            public string[][] ShopVerb;

            // Pattern.any
            public string[] ShopContent;
            public string[] TaskContentPattern;

            // Instance
            public class _Instance
            {
                public InstanceData[] ContainsAll;
                public InstanceData[] ListType;
                public InstanceData[] TaskContentML;
                public InstanceData[] ordinal;
                public InstanceData[] FoodOfGrocery;
                public InstanceData[] ShopVerb;
                public InstanceData[] ShopContent;
                public InstanceData[] TaskContentPattern;
            }
            [JsonProperty("$instance")]
            public _Instance _instance;
        }
        public virtual _Entities Entities { get; set; }

        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> Properties {get; set; }

        public void Convert(dynamic result)
        {
            var app = JsonConvert.DeserializeObject<ToDo>(JsonConvert.SerializeObject(result));
            Text = app.Text;
            AlteredText = app.AlteredText;
            Intents = app.Intents;
            Entities = app.Entities;
            Properties = app.Properties;
        }

        public virtual (Intent intent, double score) TopIntent()
        {
            Intent maxIntent = Intent.None;
            var max = 0.0;
            foreach (var entry in Intents)
            {
                if (entry.Value.Score > max)
                {
                    maxIntent = entry.Key;
                    max = entry.Value.Score.Value;
                }
            }
            return (maxIntent, max);
        }
    }
}
