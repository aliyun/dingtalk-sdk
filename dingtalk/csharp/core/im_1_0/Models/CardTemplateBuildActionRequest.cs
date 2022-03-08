// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class CardTemplateBuildActionRequest : TeaModel {
        /// <summary>
        /// 模板构建的action：含create、save、deploy
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// 模板构建的dto对象
        /// </summary>
        [NameInMap("cardTemplateJson")]
        [Validation(Required=false)]
        public string CardTemplateJson { get; set; }

    }

}
