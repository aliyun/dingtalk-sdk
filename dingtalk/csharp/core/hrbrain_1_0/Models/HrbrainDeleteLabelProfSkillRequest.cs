// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainDeleteLabelProfSkillRequest : TeaModel {
        [NameInMap("params")]
        [Validation(Required=false)]
        public List<HrbrainDeleteLabelProfSkillRequestParams> Params { get; set; }
        public class HrbrainDeleteLabelProfSkillRequestParams : TeaModel {
            [NameInMap("label")]
            [Validation(Required=false)]
            public Dictionary<string, object> Label { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

    }

}
