// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ModifyWaterMarkTemplateRequest : TeaModel {
        /// <summary>
        /// 模板的表单Code。
        /// </summary>
        [NameInMap("formCode")]
        [Validation(Required=false)]
        public string FormCode { get; set; }

        /// <summary>
        /// 模板的预览图片。
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// 模板的布局ID。
        /// </summary>
        [NameInMap("layoutDesignId")]
        [Validation(Required=false)]
        public string LayoutDesignId { get; set; }

        /// <summary>
        /// 模板的内容。
        /// </summary>
        [NameInMap("schemaContent")]
        [Validation(Required=false)]
        public string SchemaContent { get; set; }

        /// <summary>
        /// 模板的标题。
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 模板的水印ID。
        /// </summary>
        [NameInMap("waterMarkId")]
        [Validation(Required=false)]
        public string WaterMarkId { get; set; }

        /// <summary>
        /// 群会话ID。
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 用户的userid。
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
