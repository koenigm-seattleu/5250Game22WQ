
using NUnit.Framework;

using Game.Engine.EngineGame;
using Game.Models;

namespace UnitTests.Engine.EngineGame
{
    [TestFixture]
    public class TurnEngineGameTests
    {
        #region TestSetup
        BattleEngine Engine;

        [SetUp]
        public void Setup()
        {
            Engine = new BattleEngine();
            Engine.Round = new RoundEngine();
            Engine.Round.Turn = new TurnEngine();
            //Engine.StartBattle(true);   // Start engine in auto battle mode
        }

        [TearDown]
        public void TearDown()
        {
        }
        #endregion TestSetup

        #region Constructor
        [Test]
        public void TurnEngine_Constructor_Valid_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = Engine;

            // Reset

            // Assert
            Assert.IsNotNull(result);
        }
        #endregion Constructor

        #region MoveAsTurn
        [Test]
        public void RoundEngine_MoveAsTurn_Valid_Default_Should_Pass()
        {
            // Arrange 

            // Act
            var result = Engine.Round.Turn.MoveAsTurn(new PlayerInfoModel());

            // Reset

            // Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void RoundEngine_MoveAsTurn_Valid_Monster_Default_Should_Pass()
        {
            // Arrange 

            // Act
            var result = Engine.Round.Turn.MoveAsTurn(new PlayerInfoModel(new MonsterModel()));

            // Reset

            // Assert
            Assert.AreEqual(false, result);
        }
        #endregion MoveAsTurn

        #region ApplyDamage
        [Test]
        public void RoundEngine_ApplyDamage_Valid_Default_Should_Pass()
        {
            // Arrange 

            // Act
            var result = Engine.Round.Turn.ApplyDamage(new PlayerInfoModel(new MonsterModel()));

            // Reset

            // Assert
            Assert.AreEqual(true, result);
        }
        #endregion ApplyDamage

        #region Attack
        [Test]
        public void RoundEngine_Attack_Valid_Default_Should_Pass()
        {
            // Arrange 

            // Act
            var result = Engine.Round.Turn.Attack(new PlayerInfoModel());

            // Reset

            // Assert
            Assert.AreEqual(false, result);
        }
        #endregion Attack

        #region AttackChoice
        [Test]
        public void RoundEngine_AttackChoice_Valid_Default_Should_Pass()
        {
            // Arrange 

            // Act
            var result = Engine.Round.Turn.AttackChoice(new PlayerInfoModel());

            // Reset

            // Assert
            Assert.AreEqual(null, result);
        }
        #endregion AttackChoice

        #region SelectCharacterToAttack
        [Test]
        public void RoundEngine_SelectCharacterToAttack_Valid_Default_Should_Pass()
        {
            // Arrange 

            // Act
            var result = Engine.Round.Turn.SelectCharacterToAttack();

            // Reset

            // Assert
            Assert.AreEqual(null, result);
        }
        #endregion SelectCharacterToAttack

        #region UseAbility
        [Test]
        public void RoundEngine_UseAbility_Valid_Default_Should_Pass()
        {
            // Arrange 

            // Act
            var result = Engine.Round.Turn.UseAbility(null);

            // Reset

            // Assert
            Assert.AreEqual(false, result);
        }
        #endregion UseAbility

        #region BattleSettingsOverrideHitStatusEnum
        [Test]
        public void RoundEngine_BattleSettingsOverrideHitStatusEnum_Valid_Default_Should_Pass()
        {
            // Arrange 

            // Act
            var result = Engine.Round.Turn.BattleSettingsOverrideHitStatusEnum(HitStatusEnum.Unknown);

            // Reset

            // Assert
            Assert.AreEqual(HitStatusEnum.Unknown, result);
        }
        #endregion BattleSettingsOverrideHitStatusEnum

        #region BattleSettingsOverride
        [Test]
        public void RoundEngine_BattleSettingsOverride_Valid_Default_Should_Pass()
        {
            // Arrange 

            // Act
            var result = Engine.Round.Turn.BattleSettingsOverride(new PlayerInfoModel());

            // Reset

            // Assert
            Assert.AreEqual(HitStatusEnum.Unknown, result);
        }
        #endregion BattleSettingsOverride
    }
}