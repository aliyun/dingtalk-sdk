// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class QueryDeviceCustomTemplateListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryDeviceCustomTemplateListResponseBodyResult Result { get; set; }
        public class QueryDeviceCustomTemplateListResponseBodyResult : TeaModel {
            [NameInMap("deviceCustomTemplates")]
            [Validation(Required=false)]
            public List<QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates> DeviceCustomTemplates { get; set; }
            public class QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates : TeaModel {
                [NameInMap("bgImageList")]
                [Validation(Required=false)]
                public List<string> BgImageList { get; set; }

                [NameInMap("bgType")]
                [Validation(Required=false)]
                public int? BgType { get; set; }

                [NameInMap("bgUrl")]
                [Validation(Required=false)]
                public string BgUrl { get; set; }

                [NameInMap("confSubType")]
                [Validation(Required=false)]
                public int? ConfSubType { get; set; }

                [NameInMap("confType")]
                [Validation(Required=false)]
                public int? ConfType { get; set; }

                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("customDoc")]
                [Validation(Required=false)]
                public string CustomDoc { get; set; }

                [NameInMap("desensitizeUserName")]
                [Validation(Required=false)]
                public bool? DesensitizeUserName { get; set; }

                [NameInMap("hideServerCodeWhenProjecting")]
                [Validation(Required=false)]
                public bool? HideServerCodeWhenProjecting { get; set; }

                [NameInMap("instruction")]
                [Validation(Required=false)]
                public bool? Instruction { get; set; }

                [NameInMap("isPicTop")]
                [Validation(Required=false)]
                public int? IsPicTop { get; set; }

                [NameInMap("logo")]
                [Validation(Required=false)]
                public string Logo { get; set; }

                [NameInMap("orgName")]
                [Validation(Required=false)]
                public string OrgName { get; set; }

                [NameInMap("picturePlayInterval")]
                [Validation(Required=false)]
                public int? PicturePlayInterval { get; set; }

                [NameInMap("showCalendarCard")]
                [Validation(Required=false)]
                public bool? ShowCalendarCard { get; set; }

                [NameInMap("showCalendarTitle")]
                [Validation(Required=false)]
                public bool? ShowCalendarTitle { get; set; }

                [NameInMap("showFunctionCard")]
                [Validation(Required=false)]
                public bool? ShowFunctionCard { get; set; }

                [NameInMap("templateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

                [NameInMap("templateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

            [NameInMap("deviceTemplateMap")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> DeviceTemplateMap { get; set; }

            [NameInMap("groupIdTemplateMap")]
            [Validation(Required=false)]
            public Dictionary<string, List<long?>> GroupIdTemplateMap { get; set; }

            [NameInMap("roomIdTemplateMap")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> RoomIdTemplateMap { get; set; }

        }

    }

}
