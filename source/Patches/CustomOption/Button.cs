using System;

namespace TownOfSushi.CustomOption
{
    public class CustomButtonOption : CustomOption
    {
        protected internal Action Do;

        protected internal CustomButtonOption(int id, MultiMenu menu, string name, Action toDo = null) : base(id, menu, name,
            CustomOptionType.Button, 0)
        {
            Do = toDo ?? BaseToDo;
        }

        public static void BaseToDo()
        {
        }


        public override void OptionCreated()
        {
            base.OptionCreated();
            Setting.Cast<ToggleOption>().TitleText.text = Name;
        }
    }
}