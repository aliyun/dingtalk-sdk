// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class UpdateMenuDataRequest : TeaModel {
        [NameInMap("attr")]
        [Validation(Required=false)]
        public Dictionary<string, object> Attr { get; set; }

        [NameInMap("bizTraceId")]
        [Validation(Required=false)]
        public string BizTraceId { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        [NameInMap("navData")]
        [Validation(Required=false)]
        public UpdateMenuDataRequestNavData NavData { get; set; }
        public class UpdateMenuDataRequestNavData : TeaModel {
            [NameInMap("displayStatus")]
            [Validation(Required=false)]
            public string DisplayStatus { get; set; }

            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("iconBgColor")]
            [Validation(Required=false)]
            public string IconBgColor { get; set; }

            [NameInMap("iconColor")]
            [Validation(Required=false)]
            public string IconColor { get; set; }

            [NameInMap("integrationProtocol")]
            [Validation(Required=false)]
            public string IntegrationProtocol { get; set; }

            [NameInMap("mobileNavName")]
            [Validation(Required=false)]
            public string MobileNavName { get; set; }

            [NameInMap("mobileUrl")]
            [Validation(Required=false)]
            public string MobileUrl { get; set; }

            [NameInMap("navCode")]
            [Validation(Required=false)]
            public string NavCode { get; set; }

            [NameInMap("navExtInfo")]
            [Validation(Required=false)]
            public UpdateMenuDataRequestNavDataNavExtInfo NavExtInfo { get; set; }
            public class UpdateMenuDataRequestNavDataNavExtInfo : TeaModel {
                [NameInMap("productMode")]
                [Validation(Required=false)]
                public string ProductMode { get; set; }

                [NameInMap("provider")]
                [Validation(Required=false)]
                public string Provider { get; set; }

            }

            [NameInMap("navId")]
            [Validation(Required=false)]
            public string NavId { get; set; }

            [NameInMap("navName")]
            [Validation(Required=false)]
            public string NavName { get; set; }

            [NameInMap("navStatus")]
            [Validation(Required=false)]
            public string NavStatus { get; set; }

            [NameInMap("navType")]
            [Validation(Required=false)]
            public string NavType { get; set; }

            [NameInMap("parentNavId")]
            [Validation(Required=false)]
            public string ParentNavId { get; set; }

            [NameInMap("provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            [NameInMap("sortNum")]
            [Validation(Required=false)]
            public int? SortNum { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("operateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

    }

}
