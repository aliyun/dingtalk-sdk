// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_2_0.Models
{
    public class SearchFormDatasResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<SearchFormDatasResponseBodyData> Data { get; set; }
        public class SearchFormDatasResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-01-24 11:22:01</para>
            /// </summary>
            [NameInMap("createdTimeGMT")]
            [Validation(Required=false)]
            public string CreatedTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1731234567</para>
            /// </summary>
            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1002</para>
            /// </summary>
            [NameInMap("dataId")]
            [Validation(Required=false)]
            public long? DataId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;numberField_jcr0069o&quot;:1,&quot;multiSelectField_jcr0069s&quot;:[&quot;选项三&quot;,&quot;选项二&quot;],&quot;textareaField_jcr0069n&quot;:&quot;duohang&quot;,&quot;employeeField_jcr0069x&quot;:[&quot;xxxx&quot;],&quot;departmentField_jcr0069z&quot;:&quot;xxxx&quot;,&quot;cascadeDate_jcr0069u&quot;:[&quot;1514736000000&quot;,&quot;1517328000000&quot;],&quot;cascadeSelectField_jcr006a0&quot;:[&quot;part&quot;,&quot;part_b&quot;],&quot;tableField_jcr006a1&quot;:[{&quot;departmentField_jcr006ad&quot;:&quot;xxxx&quot;,&quot;cascadeDate_jcr006aa&quot;:[&quot;1514736000000&quot;,&quot;1517328000000&quot;],&quot;selectField_jcr006a6&quot;:&quot;选项三&quot;,&quot;citySelectField_jcr006ac&quot;:[&quot;天津&quot;,&quot;天津市&quot;,&quot;河东区&quot;],&quot;radioField_jcr006a5&quot;:&quot;选项二&quot;,&quot;employeeField_jcr006ab&quot;:[&quot;xxxxxx&quot;,&quot;yyyyyy&quot;],&quot;dateField_jcr006a9&quot;:1517328000000,&quot;textField_jcr006a2&quot;:&quot;明细下单行&quot;,&quot;textareaField_jcr006a3&quot;:&quot;明细下多行&quot;,&quot;cascadeSelectField_jcr006ae&quot;:[&quot;product&quot;,&quot;product_a&quot;],&quot;numberField_jcr006a4&quot;:2,&quot;checkboxField_jcr006a7&quot;:[&quot;选项一&quot;,&quot;选项三&quot;,&quot;选项二&quot;],&quot;multiSelectField_jcr006a8&quot;:[&quot;选项一&quot;,&quot;选项三&quot;,&quot;选项二&quot;]}],&quot;selectField_jcr0069q&quot;:&quot;选项一&quot;,&quot;citySelectField_jcr0069y&quot;:[&quot;北京&quot;,&quot;北京市&quot;,&quot;东城区&quot;],&quot;checkboxField_jcr0069r&quot;:[&quot;选项三&quot;,&quot;选项二&quot;],&quot;textField_jcr0069m&quot;:&quot;danhang&quot;,&quot;radioField_jcr0069p&quot;:&quot;选项一&quot;,&quot;dateField_jcr0069t&quot;:1516636800000}</para>
            /// </summary>
            [NameInMap("formData")]
            [Validation(Required=false)]
            public Dictionary<string, object> FormData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FINST-BNKJDRF</para>
            /// </summary>
            [NameInMap("formInstanceId")]
            [Validation(Required=false)]
            public string FormInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FORM-EF6Y93URN24F1SCX15VA2P918LPEIJ2H3UFORCJ1</para>
            /// </summary>
            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;textField&quot;:&quot;124&quot;}</para>
            /// </summary>
            [NameInMap("instanceValue")]
            [Validation(Required=false)]
            public string InstanceValue { get; set; }

            [NameInMap("modelUuid")]
            [Validation(Required=false)]
            public string ModelUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-01-24 11:22:01</para>
            /// </summary>
            [NameInMap("modifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1731234567</para>
            /// </summary>
            [NameInMap("modifierUserId")]
            [Validation(Required=false)]
            public string ModifierUserId { get; set; }

            [NameInMap("modifyUser")]
            [Validation(Required=false)]
            public SearchFormDatasResponseBodyDataModifyUser ModifyUser { get; set; }
            public class SearchFormDatasResponseBodyDataModifyUser : TeaModel {
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("userName")]
                [Validation(Required=false)]
                public SearchFormDatasResponseBodyDataModifyUserUserName UserName { get; set; }
                public class SearchFormDatasResponseBodyDataModifyUserUserName : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("nameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ZhangSan</para>
                    /// </summary>
                    [NameInMap("nameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>i18n</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("originator")]
            [Validation(Required=false)]
            public SearchFormDatasResponseBodyDataOriginator Originator { get; set; }
            public class SearchFormDatasResponseBodyDataOriginator : TeaModel {
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("userName")]
                [Validation(Required=false)]
                public SearchFormDatasResponseBodyDataOriginatorUserName UserName { get; set; }
                public class SearchFormDatasResponseBodyDataOriginatorUserName : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("nameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ZhangSan</para>
                    /// </summary>
                    [NameInMap("nameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>i18n</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Squence-XXX</para>
            /// </summary>
            [NameInMap("sequence")]
            [Validation(Required=false)]
            public string Sequence { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("serialNo")]
            [Validation(Required=false)]
            public string SerialNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三发起的表单</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
