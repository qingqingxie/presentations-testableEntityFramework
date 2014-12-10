﻿using System.Collections.Generic;
using System.Linq;
using Data.Entities;
using Data.Queries;
using Highway.Data;
using Machine.Specifications;
using Moq;
using Web.Models;
using It = Machine.Specifications.It;

// ReSharper disable CheckNamespace
// ReSharper disable UnusedMember.Local
// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToLambdaExpression
namespace WebTestsMspec
{
    public class when_mocking_dbcontext
    {
        Establish context = () =>
        {
        };

        Because of = () =>
        {
        };

        It should_return_accepted_talks = () => _talks.AcceptedTalks.Count().ShouldEqual(1);
        It should_return_submitted_talks = () => _talks.SubmittedTalks.Count().ShouldEqual(1);

        static TalkModel _model;
        static TalkViewModel _talks;
    }
}
