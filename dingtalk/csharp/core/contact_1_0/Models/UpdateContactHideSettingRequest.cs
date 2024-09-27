// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class UpdateContactHideSettingRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>description text</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("excludeDeptIds")]
        [Validation(Required=false)]
        public List<long?> ExcludeDeptIds { get; set; }

        [NameInMap("excludeStaffIds")]
        [Validation(Required=false)]
        public List<string> ExcludeStaffIds { get; set; }

        [NameInMap("excludeTagIds")]
        [Validation(Required=false)]
        public List<long?> ExcludeTagIds { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("hideInSearch")]
        [Validation(Required=false)]
        public bool? HideInSearch { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("hideInUserProfile")]
        [Validation(Required=false)]
        public bool? HideInUserProfile { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11234</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("objectDeptIds")]
        [Validation(Required=false)]
        public List<long?> ObjectDeptIds { get; set; }

        [NameInMap("objectStaffIds")]
        [Validation(Required=false)]
        public List<string> ObjectStaffIds { get; set; }

        [NameInMap("objectTagIds")]
        [Validation(Required=false)]
        public List<long?> ObjectTagIds { get; set; }

    }

}
