// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class RosterMetaFieldOptionsUpdateRequest : TeaModel {
        [NameInMap("appAgentId")]
        [Validation(Required=false)]
        public long? AppAgentId { get; set; }

        /// <summary>
        /// 字段fieldCode
        /// </summary>
        [NameInMap("fieldCode")]
        [Validation(Required=false)]
        public string FieldCode { get; set; }

        /// <summary>
        /// 花名册分组id
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// 需要修改的选项值
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public List<string> Labels { get; set; }

        /// <summary>
        /// 修改类型，OPTIONS_ADD选项添加，OPTIONS_DELETE选项删除
        /// </summary>
        [NameInMap("modifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

    }

}
