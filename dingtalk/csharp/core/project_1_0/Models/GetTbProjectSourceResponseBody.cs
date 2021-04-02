// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetTbProjectSourceResponseBody : TeaModel {
        /// <summary>
        /// 应用安装来源，"0"：来自应用中心，”6“：预安装
        /// </summary>
        [NameInMap("installSource")]
        [Validation(Required=false)]
        public string InstallSource { get; set; }

    }

}
