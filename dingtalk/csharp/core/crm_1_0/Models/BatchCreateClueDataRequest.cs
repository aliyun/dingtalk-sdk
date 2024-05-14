// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchCreateClueDataRequest : TeaModel {
        [NameInMap("dataList")]
        [Validation(Required=false)]
        public List<BatchCreateClueDataRequestDataList> DataList { get; set; }
        public class BatchCreateClueDataRequestDataList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("contactList")]
            [Validation(Required=false)]
            public List<BatchCreateClueDataRequestDataListContactList> ContactList { get; set; }
            public class BatchCreateClueDataRequestDataListContactList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                [NameInMap("qq")]
                [Validation(Required=false)]
                public string Qq { get; set; }

                [NameInMap("wangWang")]
                [Validation(Required=false)]
                public string WangWang { get; set; }

                [NameInMap("weChat")]
                [Validation(Required=false)]
                public string WeChat { get; set; }

            }

            [NameInMap("enterprise")]
            [Validation(Required=false)]
            public BatchCreateClueDataRequestDataListEnterprise Enterprise { get; set; }
            public class BatchCreateClueDataRequestDataListEnterprise : TeaModel {
                [NameInMap("address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("industryCode")]
                [Validation(Required=false)]
                public string IndustryCode { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("unifiedSocialCreditCode")]
                [Validation(Required=false)]
                public string UnifiedSocialCreditCode { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("tagIdList")]
            [Validation(Required=false)]
            public List<BatchCreateClueDataRequestDataListTagIdList> TagIdList { get; set; }
            public class BatchCreateClueDataRequestDataListTagIdList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("tagId")]
                [Validation(Required=false)]
                public string TagId { get; set; }

                [NameInMap("tagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

        }

        [NameInMap("privateSeas")]
        [Validation(Required=false)]
        public bool? PrivateSeas { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
