// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class CreateTodoTypeConfigRequest : TeaModel {
        [NameInMap("actionList")]
        [Validation(Required=false)]
        public List<CreateTodoTypeConfigRequestActionList> ActionList { get; set; }
        public class CreateTodoTypeConfigRequestActionList : TeaModel {
            [NameInMap("actionKey")]
            [Validation(Required=false)]
            public string ActionKey { get; set; }

            [NameInMap("actionType")]
            [Validation(Required=false)]
            public int? ActionType { get; set; }

            [NameInMap("buttonStyleType")]
            [Validation(Required=false)]
            public int? ButtonStyleType { get; set; }

            [NameInMap("nameI18n")]
            [Validation(Required=false)]
            public Dictionary<string, object> NameI18n { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("cardType")]
        [Validation(Required=false)]
        public int? CardType { get; set; }

        [NameInMap("contentFieldList")]
        [Validation(Required=false)]
        public List<CreateTodoTypeConfigRequestContentFieldList> ContentFieldList { get; set; }
        public class CreateTodoTypeConfigRequestContentFieldList : TeaModel {
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

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("pcDetailUrlOpenMode")]
        [Validation(Required=false)]
        public string PcDetailUrlOpenMode { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
