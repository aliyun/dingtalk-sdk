// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class AddResidentUsersRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>美好社区创景街道万通公寓</para>
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("departmentId")]
        [Validation(Required=false)]
        public long? DepartmentId { get; set; }

        [NameInMap("extField")]
        [Validation(Required=false)]
        public List<AddResidentUsersRequestExtField> ExtField { get; set; }
        public class AddResidentUsersRequestExtField : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>性别</para>
            /// </summary>
            [NameInMap("itemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>女</para>
            /// </summary>
            [NameInMap("itemValue")]
            [Validation(Required=false)]
            public string ItemValue { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isLeaseholder")]
        [Validation(Required=false)]
        public bool? IsLeaseholder { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15612345678</para>
        /// </summary>
        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SELF</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("relateType")]
        [Validation(Required=false)]
        public string RelateType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>王建国</para>
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
