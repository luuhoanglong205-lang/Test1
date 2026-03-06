using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;
namespace TestTest
{
    internal class TinhTongTest
    {
        TinhTong tinhTong;
        [SetUp]
        public void Setup()
        {
            tinhTong = new TinhTong();
        }
        [Test]
        public void TinhTong_True()
        {
            Assert.That(tinhTong.TinhTongChan(), Is.EqualTo(482));
        }
        [Test]
        public void TinhTong_False()
        {
            Assert.That(tinhTong.TinhTongChan(), Is.Not.EqualTo(601));
        }
        [Test]
        public void TinhTong_Negative()
        {
            Assert.That(tinhTong.TinhTongChan(), Is.GreaterThan(0));
        }
        [Test]
        public void TinhTong_LessThan()
        {
            Assert.That(tinhTong.TinhTongChan(), Is.LessThan(700));
        }
        [Test]
        public void TinhTong_NotZero()
        {
            Assert.That(tinhTong.TinhTongChan(), Is.Not.EqualTo(0));
        }
    }
}
