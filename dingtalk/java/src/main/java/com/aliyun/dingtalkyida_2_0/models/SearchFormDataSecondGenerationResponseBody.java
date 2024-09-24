// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class SearchFormDataSecondGenerationResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<SearchFormDataSecondGenerationResponseBodyData> data;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static SearchFormDataSecondGenerationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchFormDataSecondGenerationResponseBody self = new SearchFormDataSecondGenerationResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchFormDataSecondGenerationResponseBody setData(java.util.List<SearchFormDataSecondGenerationResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<SearchFormDataSecondGenerationResponseBodyData> getData() {
        return this.data;
    }

    public SearchFormDataSecondGenerationResponseBody setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public SearchFormDataSecondGenerationResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class SearchFormDataSecondGenerationResponseBodyDataModifyUserName extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("nameInChinese")
        public String nameInChinese;

        /**
         * <strong>example:</strong>
         * <p>ZhangSan</p>
         */
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        public static SearchFormDataSecondGenerationResponseBodyDataModifyUserName build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDataSecondGenerationResponseBodyDataModifyUserName self = new SearchFormDataSecondGenerationResponseBodyDataModifyUserName();
            return TeaModel.build(map, self);
        }

        public SearchFormDataSecondGenerationResponseBodyDataModifyUserName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

        public SearchFormDataSecondGenerationResponseBodyDataModifyUserName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

    }

    public static class SearchFormDataSecondGenerationResponseBodyDataModifyUser extends TeaModel {
        @NameInMap("name")
        public SearchFormDataSecondGenerationResponseBodyDataModifyUserName name;

        /**
         * <strong>example:</strong>
         * <p>ding173982232112232</p>
         */
        @NameInMap("userId")
        public String userId;

        public static SearchFormDataSecondGenerationResponseBodyDataModifyUser build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDataSecondGenerationResponseBodyDataModifyUser self = new SearchFormDataSecondGenerationResponseBodyDataModifyUser();
            return TeaModel.build(map, self);
        }

        public SearchFormDataSecondGenerationResponseBodyDataModifyUser setName(SearchFormDataSecondGenerationResponseBodyDataModifyUserName name) {
            this.name = name;
            return this;
        }
        public SearchFormDataSecondGenerationResponseBodyDataModifyUserName getName() {
            return this.name;
        }

        public SearchFormDataSecondGenerationResponseBodyDataModifyUser setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class SearchFormDataSecondGenerationResponseBodyDataOriginatorName extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("nameInChinese")
        public String nameInChinese;

        /**
         * <strong>example:</strong>
         * <p>ZhangSan</p>
         */
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        public static SearchFormDataSecondGenerationResponseBodyDataOriginatorName build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDataSecondGenerationResponseBodyDataOriginatorName self = new SearchFormDataSecondGenerationResponseBodyDataOriginatorName();
            return TeaModel.build(map, self);
        }

        public SearchFormDataSecondGenerationResponseBodyDataOriginatorName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

        public SearchFormDataSecondGenerationResponseBodyDataOriginatorName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

    }

    public static class SearchFormDataSecondGenerationResponseBodyDataOriginator extends TeaModel {
        @NameInMap("name")
        public SearchFormDataSecondGenerationResponseBodyDataOriginatorName name;

        /**
         * <strong>example:</strong>
         * <p>ding173982232112232</p>
         */
        @NameInMap("userId")
        public String userId;

        public static SearchFormDataSecondGenerationResponseBodyDataOriginator build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDataSecondGenerationResponseBodyDataOriginator self = new SearchFormDataSecondGenerationResponseBodyDataOriginator();
            return TeaModel.build(map, self);
        }

        public SearchFormDataSecondGenerationResponseBodyDataOriginator setName(SearchFormDataSecondGenerationResponseBodyDataOriginatorName name) {
            this.name = name;
            return this;
        }
        public SearchFormDataSecondGenerationResponseBodyDataOriginatorName getName() {
            return this.name;
        }

        public SearchFormDataSecondGenerationResponseBodyDataOriginator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class SearchFormDataSecondGenerationResponseBodyData extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2021-05-01</p>
         */
        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        /**
         * <strong>example:</strong>
         * <p>ding12345</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

        /**
         * <strong>example:</strong>
         * <p>{&quot;addressField_l0c1cwiy_id&quot;:&quot;&quot;海南省/469027/国营红岗农场/111&quot;&quot;,&quot;associationFormField_l0c1hdz4_id&quot;:&quot;&quot;[{\&quot;formType\&quot;:\&quot;receipt\&quot;,\&quot;formUuid\&quot;:\&quot;FORM-QQ866JB1QW8YM5XZZZ64VQB61OGM1MLWE1C0LG\&quot;,\&quot;instanceId\&quot;:\&quot;FINST-CC666Y6198RY0LAN39XGND212MSX3TFT95S0LN31\&quot;,\&quot;subTitle\&quot;:\&quot;{\\\&quot;type\\\&quot;:\\\&quot;div\\\&quot;,\\\&quot;props\\\&quot;:{\\\&quot;children\\\&quot;:{\\\&quot;type\\\&quot;:\\\&quot;a\\\&quot;,\\\&quot;props\\\&quot;:{\\\&quot;children\\\&quot;:\\\&quot;查看签名\\\&quot;,\\\&quot;className\\\&quot;:\\\&quot;inst-cell-item-link\\\&quot;,\\\&quot;style\\\&quot;:{\\\&quot;cursor\\\&quot;:\\\&quot;pointer\\\&quot;,\\\&quot;color\\\&quot;:\\\&quot;#0068ff\\\&quot;}}},\\\&quot;className\\\&quot;:\\\&quot;inst-cell-item\\\&quot;}}\&quot;,\&quot;appType\&quot;:\&quot;APP_K6IGJJ6PFAARLPDSWKXQ\&quot;,\&quot;title\&quot;:\&quot;1\&quot;}]&quot;&quot;,&quot;countrySelectField_l0c1cwiu_id&quot;:[&quot;PG&quot;],&quot;imageField_l0c1cwit&quot;:&quot;[{&quot;previewUrl&quot;:&quot;/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&amp;fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&amp;instId=&amp;type=open&amp;process=image/resize,m_fill,w_200,h_200,limit_0/quality,q_80&quot;,&quot;size&quot;:2610734,&quot;name&quot;:&quot;Bts2Z0e6oxA.jpg&quot;,&quot;downloadUrl&quot;:&quot;/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&amp;fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&amp;instId=&amp;type=download&quot;,&quot;url&quot;:&quot;/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&amp;fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&amp;instId=&amp;type=download&quot;}]&quot;,&quot;rateField_l0c1cwis_value&quot;:&quot;3&quot;,&quot;editorField_l0c1cwiz&quot;:&quot;<div><strong>你好，这是测试</strong></div>\r\n<div>&lt;span style=&quot;font-family: kaiti;background-color: #ff0000;color: #ffff00;&quot;&gt;<em><strong>测试</strong></em></span></div>\r\n<div>&nbsp;</div>&quot;,&quot;rateField_l0c1cwis&quot;:3,&quot;countrySelectField_l0c1cwiu&quot;:[],&quot;attachmentField_l0ghkwv3&quot;:&quot;[{&quot;downloadUrl&quot;:&quot;/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&amp;fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&amp;instId=&amp;type=download&quot;,&quot;name&quot;:&quot;Bts2Z0e6oxA.jpg&quot;,&quot;previewUrl&quot;:&quot;/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&amp;fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&amp;instId=&amp;type=open&amp;process=image/resize,m_fill,w_200,h_200,limit_0/quality,q_80&quot;,&quot;size&quot;:2610734,&quot;url&quot;:&quot;/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&amp;fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&amp;instId=&amp;type=download&quot;}]&quot;,&quot;addressField_l0c1cwiy&quot;:&quot;{&quot;address&quot;:&quot;111&quot;,&quot;regionIds&quot;:[460000,469027,469023401],&quot;regionText&quot;:[{&quot;en_US&quot;:&quot;hai+nan+sheng&quot;,&quot;zh_CN&quot;:&quot;海南省&quot;},{&quot;en_US&quot;:&quot;cheng+mai+xian&quot;,&quot;zh_CN&quot;:&quot;澄迈县&quot;},{&quot;en_US&quot;:&quot;guo+ying+hong+gang+nong+chang&quot;,&quot;zh_CN&quot;:&quot;国营红岗农场&quot;}]}&quot;}</p>
         */
        @NameInMap("formData")
        public java.util.Map<String, ?> formData;

        /**
         * <strong>example:</strong>
         * <p>FINST-J8766S91O2UYN87ZX3XOF1MY8MBA2912BSV0L24</p>
         */
        @NameInMap("formInstanceId")
        public String formInstanceId;

        /**
         * <strong>example:</strong>
         * <p>FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA</p>
         */
        @NameInMap("formUuid")
        public String formUuid;

        /**
         * <strong>example:</strong>
         * <p>12345</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <strong>example:</strong>
         * <p>[{&quot;componentName&quot;:&quot;CountrySelectField&quot;,&quot;dateType&quot;:null,&quot;fieldData&quot;:{&quot;value&quot;:[{&quot;text&quot;:{&quot;en_US&quot;:&quot;Papua New Guinea&quot;,&quot;zh_CN&quot;:&quot;巴布亚新几内亚&quot;,&quot;type&quot;:&quot;i18n&quot;},&quot;value&quot;:&quot;PG&quot;}]},&quot;fieldDataUpdated&quot;:false,&quot;fieldId&quot;:&quot;countrySelectField_l0c1cwiu&quot;,&quot;format&quot;:null,&quot;formatControls&quot;:null,&quot;listNum&quot;:null,&quot;options&quot;:[{&quot;label&quot;:{&quot;$ref&quot;:&quot;$[0].fieldData.value[0].text&quot;},&quot;value&quot;:&quot;PG&quot;}],&quot;rowId&quot;:null},{&quot;componentName&quot;:&quot;AssociationFormField&quot;,&quot;dateType&quot;:null,&quot;fieldData&quot;:{&quot;value&quot;:[{&quot;formType&quot;:&quot;receipt&quot;,&quot;formUuid&quot;:&quot;FORM-QQ866JB1QW8YM5XZZZ64VQB61OGM1MLWE1C0LG&quot;,&quot;instanceId&quot;:&quot;FINST-CC666Y6198RY0LAN39XGND212MSX3TFT95S0LN31&quot;,&quot;subTitle&quot;:&quot;{&quot;type&quot;:&quot;div&quot;,&quot;props&quot;:{&quot;children&quot;:{&quot;type&quot;:&quot;a&quot;,&quot;props&quot;:{&quot;children&quot;:&quot;查看签名&quot;,&quot;className&quot;:&quot;inst-cell-item-link&quot;,&quot;style&quot;:{&quot;cursor&quot;:&quot;pointer&quot;,&quot;color&quot;:&quot;#0068ff&quot;}}},&quot;className&quot;:&quot;inst-cell-item&quot;}}&quot;,&quot;appType&quot;:&quot;APP_K6IGJJ6PFAARLPDSWKXQ&quot;,&quot;title&quot;:&quot;1&quot;}]},&quot;fieldDataUpdated&quot;:false,&quot;fieldId&quot;:&quot;associationFormField_l0c1hdz4&quot;,&quot;format&quot;:null,&quot;formatControls&quot;:null,&quot;listNum&quot;:null,&quot;options&quot;:[],&quot;rowId&quot;:null},{&quot;componentName&quot;:&quot;ImageField&quot;,&quot;dateType&quot;:null,&quot;fieldData&quot;:{&quot;value&quot;:[{&quot;previewUrl&quot;:&quot;/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&amp;fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&amp;instId=&amp;type=open&amp;process=image/resize,m_fill,w_200,h_200,limit_0/quality,q_80&quot;,&quot;size&quot;:2610734,&quot;name&quot;:&quot;Bts2Z0e6oxA.jpg&quot;,&quot;downloadUrl&quot;:&quot;/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&amp;fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&amp;instId=&amp;type=download&quot;,&quot;url&quot;:&quot;/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&amp;fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&amp;instId=&amp;type=download&quot;}]},&quot;fieldDataUpdated&quot;:false,&quot;fieldId&quot;:&quot;imageField_l0c1cwit&quot;,&quot;format&quot;:null,&quot;formatControls&quot;:null,&quot;listNum&quot;:null,&quot;options&quot;:[],&quot;rowId&quot;:null},{&quot;componentName&quot;:&quot;AddressField&quot;,&quot;dateType&quot;:null,&quot;fieldData&quot;:{&quot;value&quot;:{&quot;address&quot;:&quot;111&quot;,&quot;regionIds&quot;:[460000,469027,469023401],&quot;regionText&quot;:[{&quot;en_US&quot;:&quot;hai+nan+sheng&quot;,&quot;zh_CN&quot;:&quot;海南省&quot;},{&quot;en_US&quot;:&quot;cheng+mai+xian&quot;,&quot;zh_CN&quot;:&quot;澄迈县&quot;},{&quot;en_US&quot;:&quot;guo+ying+hong+gang+nong+chang&quot;,&quot;zh_CN&quot;:&quot;国营红岗农场&quot;}]}},&quot;fieldDataUpdated&quot;:false,&quot;fieldId&quot;:&quot;addressField_l0c1cwiy&quot;,&quot;format&quot;:null,&quot;formatControls&quot;:null,&quot;listNum&quot;:null,&quot;options&quot;:[{&quot;label&quot;:{&quot;pureEn_US&quot;:&quot;hai+nan+sheng&quot;,&quot;en_US&quot;:&quot;hai+nan+sheng&quot;,&quot;zh_CN&quot;:&quot;海南省&quot;,&quot;type&quot;:&quot;i18n&quot;,&quot;key&quot;:null},&quot;value&quot;:460000},{&quot;label&quot;:{&quot;pureEn_US&quot;:&quot;cheng+mai+xian&quot;,&quot;en_US&quot;:&quot;cheng+mai+xian&quot;,&quot;zh_CN&quot;:&quot;澄迈县&quot;,&quot;type&quot;:&quot;i18n&quot;,&quot;key&quot;:null},&quot;value&quot;:469027},{&quot;label&quot;:{&quot;pureEn_US&quot;:&quot;guo+ying+hong+gang+nong+chang&quot;,&quot;en_US&quot;:&quot;guo+ying+hong+gang+nong+chang&quot;,&quot;zh_CN&quot;:&quot;国营红岗农场&quot;,&quot;type&quot;:&quot;i18n&quot;,&quot;key&quot;:null},&quot;value&quot;:469023401}],&quot;rowId&quot;:null},{&quot;componentName&quot;:&quot;EditorField&quot;,&quot;dateType&quot;:null,&quot;fieldData&quot;:{&quot;value&quot;:&quot;<div><strong>你好，这是测试</strong></div>\r\n<div>&lt;span style=&quot;font-family: kaiti;background-color: #ff0000;color: #ffff00;&quot;&gt;<em><strong>测试</strong></em></span></div>\r\n<div>&nbsp;</div>&quot;},&quot;fieldDataUpdated&quot;:false,&quot;fieldId&quot;:&quot;editorField_l0c1cwiz&quot;,&quot;format&quot;:null,&quot;formatControls&quot;:null,&quot;listNum&quot;:null,&quot;options&quot;:[],&quot;rowId&quot;:null},{&quot;componentName&quot;:&quot;RateField&quot;,&quot;dateType&quot;:null,&quot;fieldData&quot;:{&quot;value&quot;:&quot;3&quot;},&quot;fieldDataUpdated&quot;:false,&quot;fieldId&quot;:&quot;rateField_l0c1cwis&quot;,&quot;format&quot;:null,&quot;formatControls&quot;:null,&quot;listNum&quot;:null,&quot;options&quot;:[],&quot;rowId&quot;:null},{&quot;componentName&quot;:&quot;AttachmentField&quot;,&quot;dateType&quot;:null,&quot;fieldData&quot;:{&quot;value&quot;:[{&quot;previewUrl&quot;:&quot;/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&amp;fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&amp;instId=&amp;type=open&amp;process=image/resize,m_fill,w_200,h_200,limit_0/quality,q_80&quot;,&quot;size&quot;:2610734,&quot;name&quot;:&quot;Bts2Z0e6oxA.jpg&quot;,&quot;downloadUrl&quot;:&quot;/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&amp;fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&amp;instId=&amp;type=download&quot;,&quot;url&quot;:&quot;/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&amp;fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&amp;instId=&amp;type=download&quot;}]},&quot;fieldDataUpdated&quot;:false,&quot;fieldId&quot;:&quot;attachmentField_l0ghkwv3&quot;,&quot;format&quot;:null,&quot;formatControls&quot;:null,&quot;listNum&quot;:null,&quot;options&quot;:[],&quot;rowId&quot;:null}]</p>
         */
        @NameInMap("instanceValue")
        public String instanceValue;

        /**
         * <strong>example:</strong>
         * <p>2021-05-01</p>
         */
        @NameInMap("modifiedTimeGMT")
        public String modifiedTimeGMT;

        /**
         * <strong>example:</strong>
         * <p>manager123</p>
         */
        @NameInMap("modifier")
        public String modifier;

        @NameInMap("modifyUser")
        public SearchFormDataSecondGenerationResponseBodyDataModifyUser modifyUser;

        @NameInMap("originator")
        public SearchFormDataSecondGenerationResponseBodyDataOriginator originator;

        /**
         * <strong>example:</strong>
         * <p>IMPORT-388664B1BAUVB3AYZE1RIUE88TDM1QI9WIOWK2</p>
         */
        @NameInMap("sequence")
        public String sequence;

        /**
         * <strong>example:</strong>
         * <p>YIDA909202202250027</p>
         */
        @NameInMap("serialNumber")
        public String serialNumber;

        /**
         * <strong>example:</strong>
         * <p>李四发起的请购单</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <strong>example:</strong>
         * <p>1.0</p>
         */
        @NameInMap("version")
        public Long version;

        public static SearchFormDataSecondGenerationResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDataSecondGenerationResponseBodyData self = new SearchFormDataSecondGenerationResponseBodyData();
            return TeaModel.build(map, self);
        }

        public SearchFormDataSecondGenerationResponseBodyData setCreateTimeGMT(String createTimeGMT) {
            this.createTimeGMT = createTimeGMT;
            return this;
        }
        public String getCreateTimeGMT() {
            return this.createTimeGMT;
        }

        public SearchFormDataSecondGenerationResponseBodyData setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public SearchFormDataSecondGenerationResponseBodyData setFormData(java.util.Map<String, ?> formData) {
            this.formData = formData;
            return this;
        }
        public java.util.Map<String, ?> getFormData() {
            return this.formData;
        }

        public SearchFormDataSecondGenerationResponseBodyData setFormInstanceId(String formInstanceId) {
            this.formInstanceId = formInstanceId;
            return this;
        }
        public String getFormInstanceId() {
            return this.formInstanceId;
        }

        public SearchFormDataSecondGenerationResponseBodyData setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public SearchFormDataSecondGenerationResponseBodyData setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public SearchFormDataSecondGenerationResponseBodyData setInstanceValue(String instanceValue) {
            this.instanceValue = instanceValue;
            return this;
        }
        public String getInstanceValue() {
            return this.instanceValue;
        }

        public SearchFormDataSecondGenerationResponseBodyData setModifiedTimeGMT(String modifiedTimeGMT) {
            this.modifiedTimeGMT = modifiedTimeGMT;
            return this;
        }
        public String getModifiedTimeGMT() {
            return this.modifiedTimeGMT;
        }

        public SearchFormDataSecondGenerationResponseBodyData setModifier(String modifier) {
            this.modifier = modifier;
            return this;
        }
        public String getModifier() {
            return this.modifier;
        }

        public SearchFormDataSecondGenerationResponseBodyData setModifyUser(SearchFormDataSecondGenerationResponseBodyDataModifyUser modifyUser) {
            this.modifyUser = modifyUser;
            return this;
        }
        public SearchFormDataSecondGenerationResponseBodyDataModifyUser getModifyUser() {
            return this.modifyUser;
        }

        public SearchFormDataSecondGenerationResponseBodyData setOriginator(SearchFormDataSecondGenerationResponseBodyDataOriginator originator) {
            this.originator = originator;
            return this;
        }
        public SearchFormDataSecondGenerationResponseBodyDataOriginator getOriginator() {
            return this.originator;
        }

        public SearchFormDataSecondGenerationResponseBodyData setSequence(String sequence) {
            this.sequence = sequence;
            return this;
        }
        public String getSequence() {
            return this.sequence;
        }

        public SearchFormDataSecondGenerationResponseBodyData setSerialNumber(String serialNumber) {
            this.serialNumber = serialNumber;
            return this;
        }
        public String getSerialNumber() {
            return this.serialNumber;
        }

        public SearchFormDataSecondGenerationResponseBodyData setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public SearchFormDataSecondGenerationResponseBodyData setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

}
