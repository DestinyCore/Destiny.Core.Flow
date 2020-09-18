﻿using System;
using System.ComponentModel;

namespace Destiny.Core.Flow.IdentityServer.Entities
{
    /// <summary>
    /// 身份资源属性
    /// </summary>
    public class IdentityResourceProperty : Property
    {
        /// <summary>
        /// 身份资源id
        /// </summary>
        [DisplayName("身份资源id")]
        public Guid IdentityResourceId { get; set; }

        /// <summary>
        /// 身份资源
        /// </summary>
        [DisplayName("身份资源")]
        public IdentityResource IdentityResource { get; set; }
    }
}