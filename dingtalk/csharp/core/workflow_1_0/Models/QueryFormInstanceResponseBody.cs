// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class QueryFormInstanceResponseBody : TeaModel {
        [NameInMap("appUuid")]
        [Validation(Required=false)]
        public string AppUuid { get; set; }

        [NameInMap("attributes")]
        [Validation(Required=false)]
        public Dictionary<string, object> Attributes { get; set; }

        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("formCode")]
        [Validation(Required=false)]
        public string FormCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("formInstDataList")]
        [Validation(Required=false)]
        public List<QueryFormInstanceResponseBodyFormInstDataList> FormInstDataList { get; set; }
        public class QueryFormInstanceResponseBodyFormInstDataList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("bizAlias")]
            [Validation(Required=false)]
            public string BizAlias { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("componentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("extendValue")]
            [Validation(Required=false)]
            public string ExtendValue { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("formInstanceId")]
        [Validation(Required=false)]
        public string FormInstanceId { get; set; }

        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        [NameInMap("modifyTimestamp")]
        [Validation(Required=false)]
        public long? ModifyTimestamp { get; set; }

        [NameInMap("outBizCode")]
        [Validation(Required=false)]
        public string OutBizCode { get; set; }

        [NameInMap("outInstanceId")]
        [Validation(Required=false)]
        public string OutInstanceId { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
