// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainImportTrainingRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<HrbrainImportTrainingRequestBody> Body { get; set; }
        public class HrbrainImportTrainingRequestBody : TeaModel {
            [NameInMap("certifCnt")]
            [Validation(Required=false)]
            public string CertifCnt { get; set; }

            [NameInMap("creditScore")]
            [Validation(Required=false)]
            public string CreditScore { get; set; }

            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("deptNo")]
            [Validation(Required=false)]
            public string DeptNo { get; set; }

            [NameInMap("extendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            [NameInMap("jobCodeName")]
            [Validation(Required=false)]
            public string JobCodeName { get; set; }

            [NameInMap("jobLevel")]
            [Validation(Required=false)]
            public string JobLevel { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("postName")]
            [Validation(Required=false)]
            public string PostName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("trainEndDate")]
            [Validation(Required=false)]
            public string TrainEndDate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("trainName")]
            [Validation(Required=false)]
            public string TrainName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("trainStartDate")]
            [Validation(Required=false)]
            public string TrainStartDate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

    }

}
