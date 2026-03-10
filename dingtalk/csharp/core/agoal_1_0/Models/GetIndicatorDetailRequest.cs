// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class GetIndicatorDetailRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("indicatorId")]
        [Validation(Required=false)]
        public string IndicatorId { get; set; }

        [NameInMap("monthNum")]
        [Validation(Required=false)]
        public long? MonthNum { get; set; }

    }

}
