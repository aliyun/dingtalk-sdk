// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainLabelMetaUpdateRequest : TeaModel {
        [NameInMap("categoryCode")]
        [Validation(Required=false)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("importantLevel")]
        [Validation(Required=false)]
        public string ImportantLevel { get; set; }

        [NameInMap("isSensitive")]
        [Validation(Required=false)]
        public bool? IsSensitive { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("options")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Options { get; set; }

        [NameInMap("permission")]
        [Validation(Required=false)]
        public Dictionary<string, object> Permission { get; set; }

        [NameInMap("required")]
        [Validation(Required=false)]
        public bool? Required { get; set; }

    }

}
