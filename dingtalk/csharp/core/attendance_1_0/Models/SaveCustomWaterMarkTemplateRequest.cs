// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class SaveCustomWaterMarkTemplateRequest : TeaModel {
        /// <summary>
        /// 模板的业务码：
        /// - water_mark_checkin
        /// 
        /// 
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

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
        /// 模板的场景码：
        /// - water_mark_checkin_h3yun 开放场景码
        /// 
        /// 
        /// </summary>
        [NameInMap("sceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

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
