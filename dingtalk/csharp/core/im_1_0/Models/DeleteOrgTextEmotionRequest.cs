// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class DeleteOrgTextEmotionRequest : TeaModel {
        /// <summary>
        /// 表情所属部门Id：
        /// -1：当文字表情属于企业层面时使用-1
        /// 一级部门Id：当文字表情属于一级部门层面时使用一级部门Id
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        /// <summary>
        /// 要删除的表情Id列表。请注意，该列表中的所有表情Id一定要同属于deptId
        /// </summary>
        [NameInMap("emotionIds")]
        [Validation(Required=false)]
        public List<string> EmotionIds { get; set; }

    }

}
