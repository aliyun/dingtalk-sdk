// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateProjectCustomfieldStatusRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>63a5301e420637003f5dxxxx</para>
        /// </summary>
        [NameInMap("customFieldId")]
        [Validation(Required=false)]
        public string CustomFieldId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>64a5301e420637003f5dxxxx</para>
        /// </summary>
        [NameInMap("customFieldInstanceId")]
        [Validation(Required=false)]
        public string CustomFieldInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>项目进度</para>
        /// </summary>
        [NameInMap("customFieldName")]
        [Validation(Required=false)]
        public string CustomFieldName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public List<CreateProjectCustomfieldStatusRequestValue> Value { get; set; }
        public class CreateProjectCustomfieldStatusRequestValue : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>63a5301e420637003f5dxxxx</para>
            /// </summary>
            [NameInMap("customFieldValueId")]
            [Validation(Required=false)]
            public string CustomFieldValueId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("metaString")]
            [Validation(Required=false)]
            public string MetaString { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>进行中</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
