// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetRangeResponseBody : TeaModel {
        [NameInMap("displayValues")]
        [Validation(Required=false)]
        public List<string> DisplayValues { get; set; }

        [NameInMap("formulas")]
        [Validation(Required=false)]
        public List<string> Formulas { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [NameInMap("values")]
        [Validation(Required=false)]
        public List<string> Values { get; set; }

    }

}
