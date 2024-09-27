// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class OkrObjectivesBatchRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dingOKR</para>
        /// </summary>
        [NameInMap("goodsCode")]
        [Validation(Required=false)]
        public string GoodsCode { get; set; }

        [NameInMap("objectiveIds")]
        [Validation(Required=false)]
        public List<string> ObjectiveIds { get; set; }

    }

}
