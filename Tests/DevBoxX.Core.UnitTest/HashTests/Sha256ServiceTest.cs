using DevBoxX.Core.Services.HashServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBoxX.Core.UnitTest.HashTests
{
    public class Sha256ServiceTest
    {
        private string? message;
        private string hashString;
        public Sha256ServiceTest() {
            message = "test hash";
            hashString = "54a6483b8aca55c9df2a35baf71d9965ddfd623468d81d51229bd5eb7d1e1c1b";
        } //end con
        [Fact]
        public void test_hash_should_be_throw_argumentNullException_when_params_is_empty()
        {
//arrange
            var service = new Sha256Service();
            //act
            // act
            var result = Assert.Throws < ArgumentNullException>(() =>
            {
                service.Hash("");
            });
        } //end method

        [Fact]
        public void test_hash_should_be_pass_when_two_hash_equal()
        {
//arrange
            var service = new Sha256Service();
            //act
            var result = service.Hash(message);
            //assert
            Assert.Equal(hashString, result);
        } //end method

        [Fact]
        public void test_hash_should_be_not_empty_when_valid_input()
        {
            //arrange
            var service = new Sha256Service();
            //act
            var result = service.Hash(message);
            //assert
            Assert.NotEmpty(result);
        } //end method
    }
}
