// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureMesProcessRequest : TeaModel {
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("baseDataName")]
        [Validation(Required=false)]
        public string BaseDataName { get; set; }

        [NameInMap("extendData")]
        [Validation(Required=false)]
        public List<IndustryManufactureMesProcessRequestExtendData> ExtendData { get; set; }
        public class IndustryManufactureMesProcessRequestExtendData : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("valueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("needDispatch")]
        [Validation(Required=false)]
        public string NeedDispatch { get; set; }

        [NameInMap("needQualityTest")]
        [Validation(Required=false)]
        public string NeedQualityTest { get; set; }

        [NameInMap("no")]
        [Validation(Required=false)]
        public string No { get; set; }

        [NameInMap("price")]
        [Validation(Required=false)]
        public string Price { get; set; }

        [NameInMap("prop")]
        [Validation(Required=false)]
        public string Prop { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("sop")]
        [Validation(Required=false)]
        public string Sop { get; set; }

        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
