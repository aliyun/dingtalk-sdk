// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class CopyDentryRequest : TeaModel {
        /// <summary>
        /// 拷贝后的文档名称，长度不能超过50。
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 操作人unionId。
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 需要移动到的知识库id。
        /// </summary>
        [NameInMap("targetSpaceId")]
        [Validation(Required=false)]
        public string TargetSpaceId { get; set; }

        /// <summary>
        /// 移动到目标位置的后置节点id。不为空时，需要是归属于 toParentDentryId 的子节点。
        /// </summary>
        [NameInMap("toNextDentryId")]
        [Validation(Required=false)]
        public string ToNextDentryId { get; set; }

        /// <summary>
        /// 需要移动到目标位置的父节点id。如果为根目录，则不传；如果为非根目录，则需要传对应的id。
        /// </summary>
        [NameInMap("toParentDentryId")]
        [Validation(Required=false)]
        public string ToParentDentryId { get; set; }

        /// <summary>
        /// 移动到目标位置的前置节点id。不为空时，需要是归属于 toParentDentryId 的子节点。
        /// </summary>
        [NameInMap("toPrevDentryId")]
        [Validation(Required=false)]
        public string ToPrevDentryId { get; set; }

    }

}
