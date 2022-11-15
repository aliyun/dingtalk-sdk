// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class UpdateRobotInOrgRequest : TeaModel {
        /// <summary>
        /// 简介
        /// </summary>
        [NameInMap("brief")]
        [Validation(Required=false)]
        public string Brief { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 机器人meidaId
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// 机器人名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 消息回调验证token
        /// </summary>
        [NameInMap("outgoingToken")]
        [Validation(Required=false)]
        public string OutgoingToken { get; set; }

        /// <summary>
        /// 消息回调地址
        /// </summary>
        [NameInMap("outgoingUrl")]
        [Validation(Required=false)]
        public string OutgoingUrl { get; set; }

        /// <summary>
        /// 预览图mediaId
        /// </summary>
        [NameInMap("previewMediaId")]
        [Validation(Required=false)]
        public string PreviewMediaId { get; set; }

        /// <summary>
        /// 机器人编码
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

    }

}
