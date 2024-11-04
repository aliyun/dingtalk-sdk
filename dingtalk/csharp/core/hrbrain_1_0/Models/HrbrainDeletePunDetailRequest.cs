// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainDeletePunDetailRequest : TeaModel {
        [NameInMap("params")]
        [Validation(Required=false)]
        public List<HrbrainDeletePunDetailRequestParams> Params { get; set; }
        public class HrbrainDeletePunDetailRequestParams : TeaModel {
            [NameInMap("effectiveDate")]
            [Validation(Required=false)]
            public string EffectiveDate { get; set; }

            [NameInMap("punName")]
            [Validation(Required=false)]
            public string PunName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

    }

}
