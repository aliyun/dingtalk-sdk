// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class TalentAddPersonalityTagRequest : TeaModel {
        [NameInMap("categoryCode")]
        [Validation(Required=false)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("categoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        [NameInMap("categorySortOrder")]
        [Validation(Required=false)]
        public int? CategorySortOrder { get; set; }

        [NameInMap("sortOrder")]
        [Validation(Required=false)]
        public int? SortOrder { get; set; }

        [NameInMap("tagCode")]
        [Validation(Required=false)]
        public string TagCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("tagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

    }

}
