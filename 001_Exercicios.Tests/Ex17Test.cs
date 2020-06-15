// <copyright file="Ex17Test.cs">Copyright ©  2020</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _001_Pilhas;

namespace _001_Pilhas.Tests
{
    /// <summary>Essa classe contém testes de unidade com parâmetros para Ex17</summary>
    [PexClass(typeof(Ex17))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class Ex17Test
    {
    }
}
