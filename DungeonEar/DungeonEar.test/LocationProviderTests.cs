using Xunit;

namespace DungeonEar.test {
    public class LocationProviderTests {
        [Fact]
        public void GetLocation0DoesNotReturnNull() {

            var world = new LocationProvider();
            var location = world.GetLocationWithId(0);
            Assert.NotNull(location);

        }

        [Fact]
        public void Location0HasValidDescription() {

            var world = new LocationProvider();
            var location = world.GetLocationWithId(0);
            Assert.NotNull(location.Description);
            Assert.NotNull(location.Name);
            Assert.True(location.Description.Length>0);
            Assert.True(location.Name.Length>0);


        }

        [Fact]
        public void Location0IsNotTheSameAsLocation1() {

            var world = new LocationProvider();
            var location0 = world.GetLocationWithId(0);
            var location1 = world.GetLocationWithId(1);



            Assert.True(location0.Name != location1.Name);


        }





    }
}