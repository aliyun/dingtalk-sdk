// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class SearchFormDataSecondGenerationNoTableFieldResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<SearchFormDataSecondGenerationNoTableFieldResponseBodyData> Data { get; set; }
        public class SearchFormDataSecondGenerationNoTableFieldResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-05-01</para>
            /// </summary>
            [NameInMap("createTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding12345</para>
            /// </summary>
            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;addressField_l0c1cwiy_id&quot;:&quot;&quot;海南省/469027/国营红岗农场/111&quot;&quot;,&quot;associationFormField_l0c1hdz4_id&quot;:&quot;&quot;[{\&quot;formType\&quot;:\&quot;receipt\&quot;,\&quot;formUuid\&quot;:\&quot;FORM-QQ866JB1QW8YM5XZZZ64VQB61OGM1MLWE1C0LG\&quot;,\&quot;instanceId\&quot;:\&quot;FINST-CC666Y6198RY0LAN39XGND212MSX3TFT95S0LN31\&quot;,\&quot;subTitle\&quot;:\&quot;{\\\&quot;type\\\&quot;:\\\&quot;div\\\&quot;,\\\&quot;props\\\&quot;:{\\\&quot;children\\\&quot;:{\\\&quot;type\\\&quot;:\\\&quot;a\\\&quot;,\\\&quot;props\\\&quot;:{\\\&quot;children\\\&quot;:\\\&quot;查看签名\\\&quot;,\\\&quot;className\\\&quot;:\\\&quot;inst-cell-item-link\\\&quot;,\\\&quot;style\\\&quot;:{\\\&quot;cursor\\\&quot;:\\\&quot;pointer\\\&quot;,\\\&quot;color\\\&quot;:\\\&quot;#0068ff\\\&quot;}}},\\\&quot;className\\\&quot;:\\\&quot;inst-cell-item\\\&quot;}}\&quot;,\&quot;appType\&quot;:\&quot;APP_K6IGJJ6PFAARLPDSWKXQ\&quot;,\&quot;title\&quot;:\&quot;1\&quot;}]&quot;&quot;,&quot;countrySelectField_l0c1cwiu_id&quot;:[&quot;PG&quot;],&quot;imageField_l0c1cwit&quot;:&quot;[{&quot;previewUrl&quot;:&quot;/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&amp;fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&amp;instId=&amp;type=open&amp;process=image/resize,m_fill,w_200,h_200,limit_0/quality,q_80&quot;,&quot;size&quot;:2610734,&quot;name&quot;:&quot;Bts2Z0e6oxA.jpg&quot;,&quot;downloadUrl&quot;:&quot;/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&amp;fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&amp;instId=&amp;type=download&quot;,&quot;url&quot;:&quot;/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&amp;fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&amp;instId=&amp;type=download&quot;}]&quot;,&quot;rateField_l0c1cwis_value&quot;:&quot;3&quot;,&quot;editorField_l0c1cwiz&quot;:&quot;<div><b>你好，这是测试</b></div>\r\n<div>&lt;span style=&quot;font-family: kaiti;background-color: #ff0000;color: #ffff00;&quot;&gt;<em><b>测试</b></em></span></div>\r\n<div>&nbsp;</div>&quot;,&quot;rateField_l0c1cwis&quot;:3,&quot;countrySelectField_l0c1cwiu&quot;:[],&quot;attachmentField_l0ghkwv3&quot;:&quot;[{&quot;downloadUrl&quot;:&quot;/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&amp;fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&amp;instId=&amp;type=download&quot;,&quot;name&quot;:&quot;Bts2Z0e6oxA.jpg&quot;,&quot;previewUrl&quot;:&quot;/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&amp;fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&amp;instId=&amp;type=open&amp;process=image/resize,m_fill,w_200,h_200,limit_0/quality,q_80&quot;,&quot;size&quot;:2610734,&quot;url&quot;:&quot;/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&amp;fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&amp;instId=&amp;type=download&quot;}]&quot;,&quot;addressField_l0c1cwiy&quot;:&quot;{&quot;address&quot;:&quot;111&quot;,&quot;regionIds&quot;:[460000,469027,469023401],&quot;regionText&quot;:[{&quot;en_US&quot;:&quot;hai+nan+sheng&quot;,&quot;zh_CN&quot;:&quot;海南省&quot;},{&quot;en_US&quot;:&quot;cheng+mai+xian&quot;,&quot;zh_CN&quot;:&quot;澄迈县&quot;},{&quot;en_US&quot;:&quot;guo+ying+hong+gang+nong+chang&quot;,&quot;zh_CN&quot;:&quot;国营红岗农场&quot;}]}&quot;}</para>
            /// </summary>
            [NameInMap("formData")]
            [Validation(Required=false)]
            public Dictionary<string, object> FormData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FINST-J8766S91O2UYN87ZX3XOF1MY8MBA2912BSV0L24</para>
            /// </summary>
            [NameInMap("formInstanceId")]
            [Validation(Required=false)]
            public string FormInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA</para>
            /// </summary>
            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{&quot;componentName&quot;:&quot;AddressField&quot;,&quot;dateType&quot;:null,&quot;fieldData&quot;:{&quot;value&quot;:{&quot;address&quot;:&quot;白帝城&quot;,&quot;regionIds&quot;:[340000,340800,340803,340803401],&quot;regionText&quot;:[{&quot;en_US&quot;:&quot;an hui sheng&quot;,&quot;zh_CN&quot;:&quot;安徽省&quot;},{&quot;en_US&quot;:&quot;an qing shi&quot;,&quot;zh_CN&quot;:&quot;安庆市&quot;},{&quot;en_US&quot;:&quot;da guan qu&quot;,&quot;zh_CN&quot;:&quot;大观区&quot;},{&quot;en_US&quot;:&quot;an hui an qing hai kou jing ji kai fa qu&quot;,&quot;zh_CN&quot;:&quot;安徽安庆海口经济开发区&quot;}]}},&quot;fieldDataUpdated&quot;:false,&quot;fieldId&quot;:&quot;addressField_kwod1oza&quot;,&quot;format&quot;:null,&quot;formatControls&quot;:null,&quot;listNum&quot;:null,&quot;options&quot;:[{&quot;label&quot;:{&quot;pureEn_US&quot;:&quot;an hui sheng&quot;,&quot;en_US&quot;:&quot;an hui sheng&quot;,&quot;zh_CN&quot;:&quot;安徽省&quot;,&quot;type&quot;:&quot;i18n&quot;,&quot;key&quot;:null},&quot;value&quot;:340000},{&quot;label&quot;:{&quot;pureEn_US&quot;:&quot;an qing shi&quot;,&quot;en_US&quot;:&quot;an qing shi&quot;,&quot;zh_CN&quot;:&quot;安庆市&quot;,&quot;type&quot;:&quot;i18n&quot;,&quot;key&quot;:null},&quot;value&quot;:340800},{&quot;label&quot;:{&quot;pureEn_US&quot;:&quot;da guan qu&quot;,&quot;en_US&quot;:&quot;da guan qu&quot;,&quot;zh_CN&quot;:&quot;大观区&quot;,&quot;type&quot;:&quot;i18n&quot;,&quot;key&quot;:null},&quot;value&quot;:340803},{&quot;label&quot;:{&quot;pureEn_US&quot;:&quot;an hui an qing hai kou jing ji kai fa qu&quot;,&quot;en_US&quot;:&quot;an hui an qing hai kou jing ji kai fa qu&quot;,&quot;zh_CN&quot;:&quot;安徽安庆海口经济开发区&quot;,&quot;type&quot;:&quot;i18n&quot;,&quot;key&quot;:null},&quot;value&quot;:340803401}],&quot;rowId&quot;:null}]</para>
            /// </summary>
            [NameInMap("instanceValue")]
            [Validation(Required=false)]
            public string InstanceValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-05-01</para>
            /// </summary>
            [NameInMap("modifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>manager123</para>
            /// </summary>
            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            [NameInMap("modifyUser")]
            [Validation(Required=false)]
            public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUser ModifyUser { get; set; }
            public class SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUser : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUserName Name { get; set; }
                public class SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUserName : TeaModel {
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

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ding173982232112232</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("originator")]
            [Validation(Required=false)]
            public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginator Originator { get; set; }
            public class SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginator : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginatorName Name { get; set; }
                public class SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginatorName : TeaModel {
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

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ding173982232112232</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IMPORT-388664B1BAUVB3AYZE1RIUE88TDM1QI9WIOWK2</para>
            /// </summary>
            [NameInMap("sequence")]
            [Validation(Required=false)]
            public string Sequence { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>YIDA909202202250027</para>
            /// </summary>
            [NameInMap("serialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>李四发起的请购单</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
