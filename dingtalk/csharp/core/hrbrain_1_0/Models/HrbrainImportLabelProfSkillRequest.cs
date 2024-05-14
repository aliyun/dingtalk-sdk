// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainImportLabelProfSkillRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<HrbrainImportLabelProfSkillRequestBody> Body { get; set; }
        public class HrbrainImportLabelProfSkillRequestBody : TeaModel {
            [NameInMap("extendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("level1")]
            [Validation(Required=false)]
            public string Level1 { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("level2")]
            [Validation(Required=false)]
            public string Level2 { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("level3")]
            [Validation(Required=false)]
            public string Level3 { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

    }

}
