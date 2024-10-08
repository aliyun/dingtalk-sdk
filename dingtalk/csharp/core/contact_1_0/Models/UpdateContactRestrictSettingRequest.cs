// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class UpdateContactRestrictSettingRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rule description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("excludeDeptIds")]
        [Validation(Required=false)]
        public List<long?> ExcludeDeptIds { get; set; }

        [NameInMap("excludeTagIds")]
        [Validation(Required=false)]
        public List<long?> ExcludeTagIds { get; set; }

        [NameInMap("excludeUserIds")]
        [Validation(Required=false)]
        public List<string> ExcludeUserIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>contact restrict name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("restrictInSearch")]
        [Validation(Required=false)]
        public bool? RestrictInSearch { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("restrictInUserProfile")]
        [Validation(Required=false)]
        public bool? RestrictInUserProfile { get; set; }

        [NameInMap("subjectDeptIds")]
        [Validation(Required=false)]
        public List<long?> SubjectDeptIds { get; set; }

        [NameInMap("subjectTagIds")]
        [Validation(Required=false)]
        public List<long?> SubjectTagIds { get; set; }

        [NameInMap("subjectUserIds")]
        [Validation(Required=false)]
        public List<string> SubjectUserIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
