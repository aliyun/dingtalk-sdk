// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetTemplateByIdRequest : TeaModel {
        /// <summary>
        /// 模版归属
        /// public_template //公共模板
        /// team_template //团队模板
        /// user_template //个人模板
        /// </summary>
        [NameInMap("belong")]
        [Validation(Required=false)]
        public string Belong { get; set; }

        /// <summary>
        /// 操作用户unionId
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
