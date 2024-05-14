// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureMesTeamMgmtRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("baseDataName")]
        [Validation(Required=false)]
        public string BaseDataName { get; set; }

        [NameInMap("events")]
        [Validation(Required=false)]
        public List<string> Events { get; set; }

        [NameInMap("extendData")]
        [Validation(Required=false)]
        public List<IndustryManufactureMesTeamMgmtRequestExtendData> ExtendData { get; set; }
        public class IndustryManufactureMesTeamMgmtRequestExtendData : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("valueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

        [NameInMap("groupConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> GroupConfig { get; set; }

        [NameInMap("groupPlugins")]
        [Validation(Required=false)]
        public List<IndustryManufactureMesTeamMgmtRequestGroupPlugins> GroupPlugins { get; set; }
        public class IndustryManufactureMesTeamMgmtRequestGroupPlugins : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("leaders")]
        [Validation(Required=false)]
        public List<IndustryManufactureMesTeamMgmtRequestLeaders> Leaders { get; set; }
        public class IndustryManufactureMesTeamMgmtRequestLeaders : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("members")]
        [Validation(Required=false)]
        public List<IndustryManufactureMesTeamMgmtRequestMembers> Members { get; set; }
        public class IndustryManufactureMesTeamMgmtRequestMembers : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("processIds")]
        [Validation(Required=false)]
        public List<string> ProcessIds { get; set; }

        [NameInMap("tagKey")]
        [Validation(Required=false)]
        public string TagKey { get; set; }

        [NameInMap("tagValues")]
        [Validation(Required=false)]
        public List<string> TagValues { get; set; }

    }

}
