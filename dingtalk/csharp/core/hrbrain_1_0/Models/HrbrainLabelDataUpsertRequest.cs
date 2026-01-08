// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainLabelDataUpsertRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public List<HrbrainLabelDataUpsertRequestParams> Params { get; set; }
        public class HrbrainLabelDataUpsertRequestParams : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("labelDatas")]
            [Validation(Required=false)]
            public List<HrbrainLabelDataUpsertRequestParamsLabelDatas> LabelDatas { get; set; }
            public class HrbrainLabelDataUpsertRequestParamsLabelDatas : TeaModel {
                [NameInMap("labelCode")]
                [Validation(Required=false)]
                public string LabelCode { get; set; }

                [NameInMap("labelValue")]
                [Validation(Required=false)]
                public List<string> LabelValue { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

    }

}
