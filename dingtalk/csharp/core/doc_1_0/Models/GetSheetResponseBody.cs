// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetSheetResponseBody : TeaModel {
        /// <summary>
        /// 工作表名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public List<string> Name { get; set; }

        /// <summary>
        /// 工作表可见性
        /// </summary>
        [NameInMap("visibility")]
        [Validation(Required=false)]
        public List<string> Visibility { get; set; }

    }

}
