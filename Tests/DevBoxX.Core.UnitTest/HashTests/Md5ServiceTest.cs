using DevBoxX.Core.Services.HashServices;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBoxX.Core.UnitTest.HashTests
{
    public class Md5ServiceTest
    {
        private string message;
        private string md5Hash;
        public Md5ServiceTest()
        {
            message = "test hash";
            md5Hash = "76dea970d89477ed03dc5289f297443c";
        } //end con
        [Fact]
        public void test_hash_should_be_throw_exception_when_argument_is_empty()
        {
//arrange
            var service = new Md5Service();
            //act
            var result = Assert.Throws<ArgumentNullException>(() =>
            {
                service.Hash("");
            });
        } //end method
        [Fact]
        public void test_hash_should_be_pass_when_two_hash_equal()
        {
            //arrange
            var service = new Md5Service();
            //act
            var result = service.Hash(message);
            //assert
            Assert.Equal(md5Hash, result);
        } //end method
        [Fact]
        public void Test_Hash_MD5_should_not_be_empty()
        {
            //arrange
            var service = new Md5Service();
            //act
            var result = service.Hash(message);
            //assert
            Assert.NotEmpty(result);
        } //end method
    }
}
