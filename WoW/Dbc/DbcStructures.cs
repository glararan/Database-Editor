﻿namespace DatabaseEditor.Dbc
{
    public class AreaDbc
    {
        [DbcRecordPosition(0)]
        [DbcRecordDetails("ID")]
        uint ID;                  // 0
        [DbcRecordPosition(1)]
        [DbcRecordDetails("Map ID")]
        uint mapid;               // 1
        [DbcRecordPosition(2)]
        [DbcRecordDetails("Zone ID")]
        uint zone;                // 2 if 0 then it's zone, else it's zone id of this area
        [DbcRecordPosition(3)]
        [DbcRecordDetails("Explore flag")]
        uint exploreFlag;         // 3
        [DbcRecordPosition(4)]
        [DbcRecordDetails("Flags")]
        uint flags;               // 4,
        [DbcRecordPosition(5)]
        [DbcRecordDetails("Unknown")]
        uint unk5;                // 5,
        [DbcRecordPosition(6)]
        [DbcRecordDetails("Unknown")]
        uint unk6;                // 6,
        [DbcRecordPosition(7)]
        [DbcRecordDetails("Unknown")]
        uint unk7;                // 7,
        [DbcRecordPosition(8)]
        [DbcRecordDetails("Unknown")]
        uint unk8;                // 8,
        [DbcRecordPosition(9)]
        [DbcRecordDetails("Unknown")]
        uint unk9;                // 9,
        [DbcRecordPosition(10)]
        [DbcRecordDetails("Area level")]
        int area_level;           // 10
        [DbcRecordPosition(11)]
        [DbcRecordDetails("Area name")]
        string area_name;         // 11
        [DbcRecordPosition(12)]
        [DbcRecordDetails("Team")]
        uint team;                // 12
        [DbcRecordPosition(13)]
        [DbcRecordDetails("Liquid type")]
        uint LiquidTypeOverride;  // 13-16 liquid override by type
        [DbcRecordPosition(14)]
        [DbcRecordDetails("2")]
        uint LiquidTypeOverride1;
        [DbcRecordPosition(15)]
        [DbcRecordDetails("3")]
        uint LiquidTypeOverride2;
        [DbcRecordPosition(16)]
        [DbcRecordDetails("4")]
        uint LiquidTypeOverride3;
        [DbcRecordPosition(17)]
        [DbcRecordDetails("Max depth")]
        float MaxDepth;           // 17,
        [DbcRecordPosition(18)]
        [DbcRecordDetails("Ambiemt multiplier")]
        float AmbientMultiplier;  // 18 client only?
        [DbcRecordPosition(19)]
        [DbcRecordDetails("Light ID")]
        uint LightId;             // 19
        [DbcRecordPosition(20)]
        [DbcRecordDetails("Unknown")]
        uint unk20;               // 20 4.0.0 - Mounting related
        [DbcRecordPosition(21)]
        [DbcRecordDetails("Unknown")]
        uint unk21;               // 21 4.0.0
        [DbcRecordPosition(22)]
        [DbcRecordDetails("Unknown")]
        uint unk22;               // 22 4.0.0
        [DbcRecordPosition(23)]
        [DbcRecordDetails("Unknown")]
        uint unk23;               // 23 4.0.0
        [DbcRecordPosition(24)]
        [DbcRecordDetails("Unknown")]
        uint unk24;               // 24 - worldStateId
        [DbcRecordPosition(25)]
        [DbcRecordDetails("Unknown")]
        uint unk25;               // 25
    }

    public class EmoteDbc
    {
        [DbcRecordPosition(0)]
        [DbcRecordDetails("ID")]
        uint Id;             // 0
        [DbcRecordPosition(1)]
        [DbcRecordDetails("Name")]
        string Name;         // 1, internal name
        [DbcRecordPosition(2)]
        [DbcRecordDetails("Animation ID")]
        uint AnimationId;    // 2, ref to animationData
        [DbcRecordPosition(3)]
        [DbcRecordDetails("Flags")]
        uint Flags;          // 3, bitmask, may be unit_flags
        [DbcRecordPosition(4)]
        [DbcRecordDetails("Type")]
        uint EmoteType;      // 4, Can be 0, 1 or 2 (determine how emote are shown)
        [DbcRecordPosition(5)]
        [DbcRecordDetails("Stand state")]
        uint UnitStandState; // 5, uncomfirmed, may be enum UnitStandStateType
        [DbcRecordPosition(6)]
        [DbcRecordDetails("Sound ID")]
        uint SoundId;        // 6, ref to soundEntries
        [DbcRecordPosition(7)]
        [DbcRecordDetails("Unknown")]
        uint unk7;           // 7
    }

    public class FactionDbc
    {
        [DbcRecordPosition(0)]
        [DbcRecordDetails("ID")]
        uint ID;                // 0        m_ID
        [DbcRecordPosition(1)]
        [DbcRecordDetails("Reputation index")]
        int reputationListID;   // 1        m_reputationIndex
        [DbcRecordPosition(2)]
        [DbcRecordDetails("Reputation race mask")]
        uint BaseRepRaceMask;   // 2-5      m_reputationRaceMask
        [DbcRecordPosition(3)]
        [DbcRecordDetails("2")]
        uint BaseRepRaceMask2;
        [DbcRecordPosition(4)]
        [DbcRecordDetails("3")]
        uint BaseRepRaceMask3;
        [DbcRecordPosition(5)]
        [DbcRecordDetails("4")]
        uint BaseRepRaceMask4;
        [DbcRecordPosition(6)]
        [DbcRecordDetails("Reputation class mask")]
        uint BaseRepClassMask;  // 6-9      m_reputationClassMask
        [DbcRecordPosition(7)]
        [DbcRecordDetails("2")]
        uint BaseRepClassMask2;
        [DbcRecordPosition(8)]
        [DbcRecordDetails("3")]
        uint BaseRepClassMask3;
        [DbcRecordPosition(9)]
        [DbcRecordDetails("4")]
        uint BaseRepClassMask4;
        [DbcRecordPosition(10)]
        [DbcRecordDetails("Base reputation value")]
        int BaseRepValue;       // 10-13    m_reputationBase
        [DbcRecordPosition(11)]
        [DbcRecordDetails("2")]
        int BaseRepValue2;
        [DbcRecordPosition(12)]
        [DbcRecordDetails("3")]
        int BaseRepValue3;
        [DbcRecordPosition(13)]
        [DbcRecordDetails("4")]
        int BaseRepValue4;
        [DbcRecordPosition(14)]
        [DbcRecordDetails("Reputation flags")]
        uint ReputationFlags;    // 14-17    m_reputationFlags
        [DbcRecordPosition(15)]
        [DbcRecordDetails("2")]
        uint ReputationFlags2;
        [DbcRecordPosition(16)]
        [DbcRecordDetails("3")]
        uint ReputationFlags3;
        [DbcRecordPosition(17)]
        [DbcRecordDetails("4")]
        uint ReputationFlags4;
        [DbcRecordPosition(18)]
        [DbcRecordDetails("Team")]
        uint team;               // 18       m_parentFactionID
        [DbcRecordPosition(19)]
        [DbcRecordDetails("Rate in")]
        float spilloverRateIn;   // 19       Faction gains incoming rep * spilloverRateIn
        [DbcRecordPosition(20)]
        [DbcRecordDetails("Rate out")]
        float spilloverRateOut;  // 20       Faction outputs rep * spilloverRateOut as spillover reputation
        [DbcRecordPosition(21)]
        [DbcRecordDetails("Max rank in")]
        uint spilloverMaxRankIn; // 21       The highest rank the faction will profit from incoming spillover
        [DbcRecordPosition(22)]
        [DbcRecordDetails("Unknown")]
        uint spilloverRank_unk;  // 22       It does not seem to be the max standing at which a faction outputs spillover ...so no idea
        [DbcRecordPosition(23)]
        [DbcRecordDetails("Name")]
        string name;             // 23       m_name_lang
        [DbcRecordPosition(24)]
        [DbcRecordDetails("Description")]
        string description;      // 24       m_description_lang
        [DbcRecordPosition(25)]
        [DbcRecordDetails("Expansion group")]
        uint GroupExpansion;     // 25       m_factionGroupExpansion
    }

    public class FamilyDbc
    {
        [DbcRecordPosition(0)]
        [DbcRecordDetails("ID")]
        uint ID;            // 0        m_ID
        [DbcRecordPosition(1)]
        [DbcRecordDetails("Min scale")]
        float minScale;     // 1        m_minScale
        [DbcRecordPosition(2)]
        [DbcRecordDetails("Min scale level")]
        uint minScaleLevel; // 2        m_minScaleLevel
        [DbcRecordPosition(3)]
        [DbcRecordDetails("Max scale")]
        float maxScale;     // 3        m_maxScale
        [DbcRecordPosition(4)]
        [DbcRecordDetails("Max scale level")]
        uint maxScaleLevel; // 4        m_maxScaleLevel
        [DbcRecordPosition(5)]
        [DbcRecordDetails("Skill line")]
        uint skillLine;     // 5-6      m_skillLine
        [DbcRecordPosition(6)]
        [DbcRecordDetails("2")]
        uint skillLine2;
        [DbcRecordPosition(7)]
        [DbcRecordDetails("Pet food mask")]
        uint petFoodMask;   // 7        m_petFoodMask
        [DbcRecordPosition(8)]
        [DbcRecordDetails("Pet talent type")]
        int petTalentType;  // 8        m_petTalentType
        [DbcRecordPosition(9)]
        [DbcRecordDetails("Category ID")]
        int categoryID;     // 9        m_categoryEnumID
        [DbcRecordPosition(10)]
        [DbcRecordDetails("Name")]
        string Name;        // 10       m_name_lang
        [DbcRecordPosition(11)]
        [DbcRecordDetails("Icon file")]
        string iconFile;    // 11       m_iconFile
    }

    public class MapDbc
    {
        [DbcRecordPosition(0)]
        [DbcRecordDetails("Map ID")]
        uint MapID;                    // 0
        [DbcRecordPosition(1)]
        [DbcRecordDetails("Internal name")]
        string internalname;           // 1 unused
        [DbcRecordPosition(2)]
        [DbcRecordDetails("Map type")]
        uint map_type;                 // 2
        [DbcRecordPosition(3)]
        [DbcRecordDetails("Flags")]
        uint Flags;                    // 3
        [DbcRecordPosition(4)]
        [DbcRecordDetails("Unknown")]
        uint unk4;                     // 4 4.0.1
        [DbcRecordPosition(5)]
        [DbcRecordDetails("PvP")]
        uint isPvP;                    // 5        m_PVP 0 or 1 for battlegrounds (not arenas)
        [DbcRecordPosition(6)]
        [DbcRecordDetails("Map name")]
        string name;                   // 6        m_MapName_lang
        [DbcRecordPosition(7)]
        [DbcRecordDetails("Linked zone (AreaTable)")]
        uint linked_zone;              // 7        m_areaTableID
        [DbcRecordPosition(8)]
        [DbcRecordDetails("Horde intro")]
        string hordeIntro;             // 8        m_MapDescription0_lang
        [DbcRecordPosition(9)]
        [DbcRecordDetails("Alliance intro")]
        string allianceIntro;          // 9        m_MapDescription1_lang
        [DbcRecordPosition(10)]
        [DbcRecordDetails("Loading screen ID")]
        uint multimap_id;              // 10       m_LoadingScreenID (LoadingScreens.dbc)
        [DbcRecordPosition(11)]
        [DbcRecordDetails("Minimap icon scale")]
        float BattlefieldMapIconScale; // 11       m_minimapIconScale
        [DbcRecordPosition(12)]
        [DbcRecordDetails("Entrance map ID")]
        int entrance_map;              // 12       m_corpseMapID map_id of entrance map in ghost mode (continent always and in most cases = normal entrance)
        [DbcRecordPosition(13)]
        [DbcRecordDetails("Entrace X")]
        float entrance_x;              // 13       m_corpseX entrance x coordinate in ghost mode  (in most cases = normal entrance)
        [DbcRecordPosition(14)]
        [DbcRecordDetails("Entrance Y")]
        float entrance_y;              // 14       m_corpseY entrance y coordinate in ghost mode  (in most cases = normal entrance)
        [DbcRecordPosition(15)]
        [DbcRecordDetails("Time of day")]
        uint timeOfDayOverride;        // 15       m_timeOfDayOverride
        [DbcRecordPosition(16)]
        [DbcRecordDetails("Expansion ID")]
        uint addon;                    // 16       m_expansionID
        [DbcRecordPosition(17)]
        [DbcRecordDetails("Raid offset")]
        uint expireTime;               // 17       m_raidOffset
        [DbcRecordPosition(18)]
        [DbcRecordDetails("Max players")]
        uint maxPlayers;               // 18       m_maxPlayers
        [DbcRecordPosition(19)]
        [DbcRecordDetails("Root phase map")]
        int rootPhaseMap;              // 19 new 4.0.0, mapid, related to phasing
    }

    public class SpellDbc
    {
        [DbcRecordPosition(0)][DbcRecordDetails("ID")]
        public uint Id;                          // 0        m_ID
        [DbcRecordPosition(1)][DbcRecordDetails("Attribute")]
        public uint Attributes;                  // 1        m_attribute
        [DbcRecordPosition(2)]
        [DbcRecordDetails("Attribute Ex")]
        public uint AttributesEx;                // 2        m_attributesEx
        [DbcRecordPosition(3)]
        [DbcRecordDetails("Attribute Ex 2")]
        public uint AttributesEx2;               // 3        m_attributesExB
        [DbcRecordPosition(4)]
        [DbcRecordDetails("Attribute Ex 3")]
        public uint AttributesEx3;               // 4        m_attributesExC
        [DbcRecordPosition(5)]
        [DbcRecordDetails("Attribute Ex 4")]
        public uint AttributesEx4;               // 5        m_attributesExD
        [DbcRecordPosition(6)]
        [DbcRecordDetails("Attribute Ex 5")]
        public uint AttributesEx5;               // 6        m_attributesExE
        [DbcRecordPosition(7)]
        [DbcRecordDetails("Attribute Ex 6")]
        public uint AttributesEx6;               // 7        m_attributesExF
        [DbcRecordPosition(8)]
        [DbcRecordDetails("Attribute Ex 7")]
        public uint AttributesEx7;               // 8        m_attributesExG
        [DbcRecordPosition(9)]
        [DbcRecordDetails("Attribute Ex 8")]
        public uint AttributesEx8;               // 9        m_attributesExH
        [DbcRecordPosition(10)]
        [DbcRecordDetails("Attribute Ex 9")]
        public uint AttributesEx9;               // 10       m_attributesExI
        [DbcRecordPosition(11)]
        [DbcRecordDetails("Attribute Ex 10")]
        public uint AttributesEx10;              // 11       m_attributesExJ
        [DbcRecordPosition(12)]
        [DbcRecordDetails("Casting time index")]
        public uint CastingTimeIndex;            // 12       m_castingTimeIndex
        [DbcRecordPosition(13)]
        [DbcRecordDetails("Duration index")]
        public uint DurationIndex;               // 13       m_durationIndex
        [DbcRecordPosition(14)]
        [DbcRecordDetails("Power type")]
        public uint powerType;                   // 14       m_powerType
        [DbcRecordPosition(15)]
        [DbcRecordDetails("Range index")]
        public uint rangeIndex;                  // 15       m_rangeIndex
        [DbcRecordPosition(16)]
        [DbcRecordDetails("Speed")]
        public float speed;                      // 16       m_speed
        /*[DbcRecordPosition(17, 2)]
        public uint[] SpellVisual;*/               // 17-18    m_spellVisualID
        [DbcRecordPosition(17)]
        [DbcRecordDetails("Spell visual")]
        public uint SpellVisual;
        [DbcRecordPosition(18)]
        [DbcRecordDetails("Spell visual 2")]
        public uint SpellVisual2;
        [DbcRecordPosition(19)]
        [DbcRecordDetails("Spell icon ID")]
        public uint SpellIconID;                 // 19       m_spellIconID
        [DbcRecordPosition(20)]
        [DbcRecordDetails("Active icon ID")]
        public uint activeIconID;                // 20       m_activeIconID
        [DbcRecordPosition(21)]
        [DbcRecordDetails("Spell name")]
        public string SpellName;                 // 21       m_name_lang
        [DbcRecordPosition(22)]
        [DbcRecordDetails("Rank")]
        public string Rank;                      // 22       m_nameSubtext_lang
        [DbcRecordPosition(23)]
        [DbcRecordDetails("Description")]
        public string Description;               // 23       m_description_lang not used
        [DbcRecordPosition(24)]
        [DbcRecordDetails("Tooltip")]
        public string ToolTip;                   // 24       m_auraDescription_lang not used
        [DbcRecordPosition(25)]
        [DbcRecordDetails("School mask")]
        public uint SchoolMask;                  // 25       m_schoolMask
        [DbcRecordPosition(26)]
        [DbcRecordDetails("Rune cost ID")]
        public uint runeCostID;                  // 26       m_runeCostID
        [DbcRecordPosition(27)]
        [DbcRecordDetails("Missile ID")]
        public uint spellMissileID;              // 27       m_spellMissileID not used
        [DbcRecordPosition(28)]
        [DbcRecordDetails("Description variable")]
        public uint spellDescriptionVariableID;  // 28       m_spellDescriptionVariableID, 3.2.0
        [DbcRecordPosition(29)]
        [DbcRecordDetails("difficulty")]
        public uint SpellDifficultyId;           // 29       m_spellDifficultyID - id from SpellDifficulty.dbc
        [DbcRecordPosition(30)]
        [DbcRecordDetails("Coef")]
        public float SpellCoef;                  // 30
        [DbcRecordPosition(31)]
        [DbcRecordDetails("Scaling")]
        public uint SpellScalingId;              // 31       SpellScaling.dbc
        [DbcRecordPosition(32)]
        [DbcRecordDetails("Aura options")]
        public uint SpellAuraOptionsId;          // 32       SpellAuraOptions.dbc
        [DbcRecordPosition(33)]
        [DbcRecordDetails("Aura restrictions")]
        public uint SpellAuraRestrictionsId;     // 33       SpellAuraRestrictions.dbc
        [DbcRecordPosition(34)]
        [DbcRecordDetails("Requirements")]
        public uint SpellCastingRequirementsId;  // 34       SpellCastingRequirements.dbc
        [DbcRecordPosition(35)]
        [DbcRecordDetails("Categories")]
        public uint SpellCategoriesId;           // 35       SpellCategories.dbc
        [DbcRecordPosition(36)]
        [DbcRecordDetails("Class options")]
        public uint SpellClassOptionsId;         // 36       SpellClassOptions.dbc
        [DbcRecordPosition(37)]
        [DbcRecordDetails("cooldown ID")]
        public uint SpellCooldownsId;            // 37       SpellCooldowns.dbc
        [DbcRecordPosition(38)]
        [DbcRecordDetails("Unknown")]
        public uint unkIndex7;                   // 38       all zeros...
        [DbcRecordPosition(39)]
        [DbcRecordDetails("Equipped items ID")]
        public uint SpellEquippedItemsId;        // 39       SpellEquippedItems.dbc
        [DbcRecordPosition(40)]
        [DbcRecordDetails("Uinterrupts ID")]
        public uint SpelluinterruptsId;           // 40       Spelluinterrupts.dbc
        [DbcRecordPosition(41)]
        [DbcRecordDetails("Levels ID")]
        public uint SpellLevelsId;               // 41       SpellLevels.dbc
        [DbcRecordPosition(42)]
        [DbcRecordDetails("Power ID")]
        public uint SpellPowerId;                // 42       SpellPower.dbc
        [DbcRecordPosition(43)]
        [DbcRecordDetails("Reagents")]
        public uint SpellReagentsId;             // 43       SpellReagents.dbc
        [DbcRecordPosition(44)]
        [DbcRecordDetails("Shapeshift")]
        public uint SpellShapeshiftId;           // 44       SpellShapeshift.dbc
        [DbcRecordPosition(45)]
        [DbcRecordDetails("Target restriction")]
        public uint SpellTargetRestrictionsId;   // 45       SpellTargetRestrictions.dbc
        [DbcRecordPosition(46)]
        [DbcRecordDetails("Totems")]
        public uint SpellTotemsId;               // 46       SpellTotems.dbc
        [DbcRecordPosition(47)]
        [DbcRecordDetails("Research project")]
        public uint ResearchProject;             // 47       ResearchProject.dbc
    }
}
