// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ModifyWaterMarkTemplateRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("formCode")]
        [Validation(Required=false)]
        public string FormCode { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("layoutDesignId")]
        [Validation(Required=false)]
        public string LayoutDesignId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("schemaContent")]
        [Validation(Required=false)]
        public string SchemaContent { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("waterMarkId")]
        [Validation(Required=false)]
        public string WaterMarkId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
