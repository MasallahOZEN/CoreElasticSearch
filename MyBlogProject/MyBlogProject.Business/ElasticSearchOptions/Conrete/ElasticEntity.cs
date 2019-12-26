﻿using  MyBlogProject.Business.ElasticSearchOptions.Abstract;
using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace  MyBlogProject.Business.ElasticSearchOptions.Conrete
{
   
    public class ElasticEntity<TPrimaryKey> : IElasticEntity<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
        public CompletionField Suggest { get; set; }
        public string SearchableText { get; set; }

    }

    public class ElasticEntity
    {
        public CompletionField Suggest { get; set; }
    }
}
