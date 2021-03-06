using System;
using System.Collections.Generic;
using System.ComponentModel;
using DestinyCore.Entity;
using Destiny.Core.Flow.Entities;
using DestinyCore.Mapping;
namespace Destiny.Core.Flow.Dtos
{
    /// <summary>
    /// 文档类型
    /// </summary>
    [AutoMapping(typeof(DocumentType))]
    public partial class DocumentTypeOutputDto : OutputDto<Guid>
    {
        /// <summary>
        /// 获取或设置 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 获取或设置 排序
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        /// 获取或设置 父级
        /// </summary>
        public Guid? ParentId { get; set; }
        /// <summary>
        /// 获取或设置 描述
        /// </summary>
        public string Description { get; set; }

    }

}
