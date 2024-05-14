// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class GetTodoTypeConfigResponseBody : TeaModel {
        [NameInMap("actionList")]
        [Validation(Required=false)]
        public List<GetTodoTypeConfigResponseBodyActionList> ActionList { get; set; }
        public class GetTodoTypeConfigResponseBodyActionList : TeaModel {
            [NameInMap("actionKey")]
            [Validation(Required=false)]
            public string ActionKey { get; set; }

            [NameInMap("actionType")]
            [Validation(Required=false)]
            public int? ActionType { get; set; }

            [NameInMap("buttonStyleType")]
            [Validation(Required=false)]
            public int? ButtonStyleType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("nameI18n")]
            [Validation(Required=false)]
            public Dictionary<string, object> NameI18n { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("bizTag")]
        [Validation(Required=false)]
        public string BizTag { get; set; }

        [NameInMap("cardType")]
        [Validation(Required=false)]
        public int? CardType { get; set; }

        [NameInMap("contentFieldList")]
        [Validation(Required=false)]
        public List<GetTodoTypeConfigResponseBodyContentFieldList> ContentFieldList { get; set; }
        public class GetTodoTypeConfigResponseBodyContentFieldList : TeaModel {
            [NameInMap("fieldKey")]
            [Validation(Required=false)]
            public string FieldKey { get; set; }

            [NameInMap("fieldType")]
            [Validation(Required=false)]
            public string FieldType { get; set; }

            [NameInMap("nameI18n")]
            [Validation(Required=false)]
            public Dictionary<string, object> NameI18n { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public long? CreatedTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("creatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("modifiedTime")]
        [Validation(Required=false)]
        public long? ModifiedTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("modifierId")]
        [Validation(Required=false)]
        public string ModifierId { get; set; }

        [NameInMap("pcDetailUrlOpenMode")]
        [Validation(Required=false)]
        public string PcDetailUrlOpenMode { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
