// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class OpenProgressDTO : TeaModel {
        /// <summary>
        /// 创建时间戳
        /// </summary>
        [NameInMap("created")]
        [Validation(Required=false)]
        public long? Created { get; set; }

        /// <summary>
        /// 创建人信息
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public OpenUserDTO Creator { get; set; }

        /// <summary>
        /// 进展内容
        /// </summary>
        [NameInMap("htmlContent")]
        [Validation(Required=false)]
        public string HtmlContent { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// 更新人信息
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public OpenUserDTO Modifier { get; set; }

        /// <summary>
        /// 更新时间戳
        /// </summary>
        [NameInMap("updated")]
        [Validation(Required=false)]
        public long? Updated { get; set; }

    }

}
