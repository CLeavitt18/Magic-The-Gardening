using System;

[Serializable] public enum CardType
{
    Instant,
    Sorrcery,
    Creature,
    Enchantment,
    Artifact,
    Land
}

[Serializable] public enum ColorType
{
    Green,
    Black,
    Red,
    White,
    Blue,
    Colorless
}