﻿using Destiny.Core.Flow.Audit;
using Destiny.Core.Flow.Entity;
using Destiny.Core.Flow.Mapping;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Destiny.Core.Flow.Dtos.Audits
{
    /// <summary>
    /// 实体输出Dto
    /// </summary>
    [DisplayName("日志实体输出")]
    [AutoMapping(typeof(AuditEntry))]
    public class AuditEntryOutputDto : OutputDto<ObjectId>
    {
        /// <summary>
        /// 实体名称
        /// </summary>
        [DisplayName("实体名称")]
        public string EntityAllName { get; set; }

        /// <summary>
        /// 功能名称
        /// </summary>
        [DisplayName("实体显示名称")]
        public string EntityDisplayName { get; set; }



        /// <summary>
        /// 主键
        /// </summary>
        [DisplayName("主键")]
        public Dictionary<string, object> KeyValues { get; set; } = new Dictionary<string, object>();

        /// <summary>
        /// 操作类型
        /// </summary>
        [DisplayName("操作类型")]
        public DataOperationType OperationType { get; set; }

        [DisplayName("用户名")]
        /// <summary>
        /// 获取或设置 操作用户名
        /// </summary>
        public string UserName { get; set; }

        [DisplayName("昵称")]
        /// <summary>
        /// 获取或设置 操作昵称
        /// </summary>
        public string NickName { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime? CreatedTime { get; set; }
    }
}