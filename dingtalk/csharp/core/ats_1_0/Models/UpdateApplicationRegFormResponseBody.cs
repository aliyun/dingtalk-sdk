// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class UpdateApplicationRegFormResponseBody : TeaModel {
        /// <summary>
        /// 邀填人员工标识
        /// </summary>
        [NameInMap("creatorUserId")]
        [Validation(Required=false)]
        public string CreatorUserId { get; set; }

        /// <summary>
        /// 表单标识
        /// </summary>
        [NameInMap("formId")]
        [Validation(Required=false)]
        public string FormId { get; set; }

        /// <summary>
        /// 创建时间（邀填时间，单位：毫秒）
        /// </summary>
        [NameInMap("gmtCreateMillis")]
        [Validation(Required=false)]
        public long? GmtCreateMillis { get; set; }

        /// <summary>
        /// 更新时间（填写时间，单位：毫秒），仅当表单状态为已填写时有效
        /// </summary>
        [NameInMap("gmtModifiedMillis")]
        [Validation(Required=false)]
        public long? GmtModifiedMillis { get; set; }

        /// <summary>
        /// 表单状态（0表示未填写，1表示已填写）
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// 模板标识
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板版本
        /// </summary>
        [NameInMap("templateVersion")]
        [Validation(Required=false)]
        public int? TemplateVersion { get; set; }

    }

}
