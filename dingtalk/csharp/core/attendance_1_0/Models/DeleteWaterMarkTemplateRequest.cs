// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class DeleteWaterMarkTemplateRequest : TeaModel {
        /// <summary>
        /// 模板的表单Code。
        /// </summary>
        [NameInMap("formCode")]
        [Validation(Required=false)]
        public string FormCode { get; set; }

        /// <summary>
        /// 模板的内容。
        /// </summary>
        [NameInMap("formContent")]
        [Validation(Required=false)]
        public string FormContent { get; set; }

        /// <summary>
        /// 群会话ID。
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 是否是系统模板。
        /// - true：是
        /// - false：否
        /// 
        /// 
        /// </summary>
        [NameInMap("systemTemplate")]
        [Validation(Required=false)]
        public bool? SystemTemplate { get; set; }

        /// <summary>
        /// 用户的userid。
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
