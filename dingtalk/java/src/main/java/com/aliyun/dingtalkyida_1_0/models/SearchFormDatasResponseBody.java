// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchFormDatasResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("currentPage")
    public Long currentPage;

    @NameInMap("data")
    public java.util.List<SearchFormDatasResponseBodyData> data;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static SearchFormDatasResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchFormDatasResponseBody self = new SearchFormDatasResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchFormDatasResponseBody setCurrentPage(Long currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Long getCurrentPage() {
        return this.currentPage;
    }

    public SearchFormDatasResponseBody setData(java.util.List<SearchFormDatasResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<SearchFormDatasResponseBodyData> getData() {
        return this.data;
    }

    public SearchFormDatasResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class SearchFormDatasResponseBodyDataModifyUserUserName extends TeaModel {
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

        /**
         * <strong>example:</strong>
         * <p>i18n</p>
         */
        @NameInMap("type")
        public String type;

        public static SearchFormDatasResponseBodyDataModifyUserUserName build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDatasResponseBodyDataModifyUserUserName self = new SearchFormDatasResponseBodyDataModifyUserUserName();
            return TeaModel.build(map, self);
        }

        public SearchFormDatasResponseBodyDataModifyUserUserName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

        public SearchFormDatasResponseBodyDataModifyUserUserName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

        public SearchFormDatasResponseBodyDataModifyUserUserName setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class SearchFormDatasResponseBodyDataModifyUser extends TeaModel {
        @NameInMap("userId")
        public String userId;

        @NameInMap("userName")
        public SearchFormDatasResponseBodyDataModifyUserUserName userName;

        public static SearchFormDatasResponseBodyDataModifyUser build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDatasResponseBodyDataModifyUser self = new SearchFormDatasResponseBodyDataModifyUser();
            return TeaModel.build(map, self);
        }

        public SearchFormDatasResponseBodyDataModifyUser setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public SearchFormDatasResponseBodyDataModifyUser setUserName(SearchFormDatasResponseBodyDataModifyUserUserName userName) {
            this.userName = userName;
            return this;
        }
        public SearchFormDatasResponseBodyDataModifyUserUserName getUserName() {
            return this.userName;
        }

    }

    public static class SearchFormDatasResponseBodyDataOriginatorUserName extends TeaModel {
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

        /**
         * <strong>example:</strong>
         * <p>i18n</p>
         */
        @NameInMap("type")
        public String type;

        public static SearchFormDatasResponseBodyDataOriginatorUserName build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDatasResponseBodyDataOriginatorUserName self = new SearchFormDatasResponseBodyDataOriginatorUserName();
            return TeaModel.build(map, self);
        }

        public SearchFormDatasResponseBodyDataOriginatorUserName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

        public SearchFormDatasResponseBodyDataOriginatorUserName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

        public SearchFormDatasResponseBodyDataOriginatorUserName setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class SearchFormDatasResponseBodyDataOriginator extends TeaModel {
        @NameInMap("userId")
        public String userId;

        @NameInMap("userName")
        public SearchFormDatasResponseBodyDataOriginatorUserName userName;

        public static SearchFormDatasResponseBodyDataOriginator build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDatasResponseBodyDataOriginator self = new SearchFormDatasResponseBodyDataOriginator();
            return TeaModel.build(map, self);
        }

        public SearchFormDatasResponseBodyDataOriginator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public SearchFormDatasResponseBodyDataOriginator setUserName(SearchFormDatasResponseBodyDataOriginatorUserName userName) {
            this.userName = userName;
            return this;
        }
        public SearchFormDatasResponseBodyDataOriginatorUserName getUserName() {
            return this.userName;
        }

    }

    public static class SearchFormDatasResponseBodyData extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2018-01-24 11:22:01</p>
         */
        @NameInMap("createdTimeGMT")
        public String createdTimeGMT;

        /**
         * <strong>example:</strong>
         * <p>1731234567</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

        /**
         * <strong>example:</strong>
         * <p>1002</p>
         */
        @NameInMap("dataId")
        public Long dataId;

        /**
         * <strong>example:</strong>
         * <p>{&quot;numberField_jcr0069o&quot;:1,&quot;multiSelectField_jcr0069s&quot;:[&quot;选项三&quot;,&quot;选项二&quot;],&quot;textareaField_jcr0069n&quot;:&quot;duohang&quot;,&quot;employeeField_jcr0069x&quot;:[&quot;xxxx&quot;],&quot;departmentField_jcr0069z&quot;:&quot;xxxx&quot;,&quot;cascadeDate_jcr0069u&quot;:[&quot;1514736000000&quot;,&quot;1517328000000&quot;],&quot;cascadeSelectField_jcr006a0&quot;:[&quot;part&quot;,&quot;part_b&quot;],&quot;tableField_jcr006a1&quot;:[{&quot;departmentField_jcr006ad&quot;:&quot;xxxx&quot;,&quot;cascadeDate_jcr006aa&quot;:[&quot;1514736000000&quot;,&quot;1517328000000&quot;],&quot;selectField_jcr006a6&quot;:&quot;选项三&quot;,&quot;citySelectField_jcr006ac&quot;:[&quot;天津&quot;,&quot;天津市&quot;,&quot;河东区&quot;],&quot;radioField_jcr006a5&quot;:&quot;选项二&quot;,&quot;employeeField_jcr006ab&quot;:[&quot;xxxxxx&quot;,&quot;yyyyyy&quot;],&quot;dateField_jcr006a9&quot;:1517328000000,&quot;textField_jcr006a2&quot;:&quot;明细下单行&quot;,&quot;textareaField_jcr006a3&quot;:&quot;明细下多行&quot;,&quot;cascadeSelectField_jcr006ae&quot;:[&quot;product&quot;,&quot;product_a&quot;],&quot;numberField_jcr006a4&quot;:2,&quot;checkboxField_jcr006a7&quot;:[&quot;选项一&quot;,&quot;选项三&quot;,&quot;选项二&quot;],&quot;multiSelectField_jcr006a8&quot;:[&quot;选项一&quot;,&quot;选项三&quot;,&quot;选项二&quot;]}],&quot;selectField_jcr0069q&quot;:&quot;选项一&quot;,&quot;citySelectField_jcr0069y&quot;:[&quot;北京&quot;,&quot;北京市&quot;,&quot;东城区&quot;],&quot;checkboxField_jcr0069r&quot;:[&quot;选项三&quot;,&quot;选项二&quot;],&quot;textField_jcr0069m&quot;:&quot;danhang&quot;,&quot;radioField_jcr0069p&quot;:&quot;选项一&quot;,&quot;dateField_jcr0069t&quot;:1516636800000}</p>
         */
        @NameInMap("formData")
        public java.util.Map<String, ?> formData;

        /**
         * <strong>example:</strong>
         * <p>FINST-BNKJDRF</p>
         */
        @NameInMap("formInstanceId")
        public String formInstanceId;

        /**
         * <strong>example:</strong>
         * <p>FORM-EF6Y93URN24F1SCX15VA2P918LPEIJ2H3UFORCJ1</p>
         */
        @NameInMap("formUuid")
        public String formUuid;

        /**
         * <strong>example:</strong>
         * <p>{&quot;textField&quot;:&quot;124&quot;}</p>
         */
        @NameInMap("instanceValue")
        public String instanceValue;

        @NameInMap("modelUuid")
        public String modelUuid;

        /**
         * <strong>example:</strong>
         * <p>2018-01-24 11:22:01</p>
         */
        @NameInMap("modifiedTimeGMT")
        public String modifiedTimeGMT;

        /**
         * <strong>example:</strong>
         * <p>1731234567</p>
         */
        @NameInMap("modifierUserId")
        public String modifierUserId;

        @NameInMap("modifyUser")
        public SearchFormDatasResponseBodyDataModifyUser modifyUser;

        @NameInMap("originator")
        public SearchFormDatasResponseBodyDataOriginator originator;

        /**
         * <strong>example:</strong>
         * <p>Squence-XXX</p>
         */
        @NameInMap("sequence")
        public String sequence;

        /**
         * <strong>example:</strong>
         * <p>1234</p>
         */
        @NameInMap("serialNo")
        public String serialNo;

        /**
         * <strong>example:</strong>
         * <p>张三发起的表单</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <strong>example:</strong>
         * <p>3</p>
         */
        @NameInMap("version")
        public Long version;

        public static SearchFormDatasResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDatasResponseBodyData self = new SearchFormDatasResponseBodyData();
            return TeaModel.build(map, self);
        }

        public SearchFormDatasResponseBodyData setCreatedTimeGMT(String createdTimeGMT) {
            this.createdTimeGMT = createdTimeGMT;
            return this;
        }
        public String getCreatedTimeGMT() {
            return this.createdTimeGMT;
        }

        public SearchFormDatasResponseBodyData setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public SearchFormDatasResponseBodyData setDataId(Long dataId) {
            this.dataId = dataId;
            return this;
        }
        public Long getDataId() {
            return this.dataId;
        }

        public SearchFormDatasResponseBodyData setFormData(java.util.Map<String, ?> formData) {
            this.formData = formData;
            return this;
        }
        public java.util.Map<String, ?> getFormData() {
            return this.formData;
        }

        public SearchFormDatasResponseBodyData setFormInstanceId(String formInstanceId) {
            this.formInstanceId = formInstanceId;
            return this;
        }
        public String getFormInstanceId() {
            return this.formInstanceId;
        }

        public SearchFormDatasResponseBodyData setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public SearchFormDatasResponseBodyData setInstanceValue(String instanceValue) {
            this.instanceValue = instanceValue;
            return this;
        }
        public String getInstanceValue() {
            return this.instanceValue;
        }

        public SearchFormDatasResponseBodyData setModelUuid(String modelUuid) {
            this.modelUuid = modelUuid;
            return this;
        }
        public String getModelUuid() {
            return this.modelUuid;
        }

        public SearchFormDatasResponseBodyData setModifiedTimeGMT(String modifiedTimeGMT) {
            this.modifiedTimeGMT = modifiedTimeGMT;
            return this;
        }
        public String getModifiedTimeGMT() {
            return this.modifiedTimeGMT;
        }

        public SearchFormDatasResponseBodyData setModifierUserId(String modifierUserId) {
            this.modifierUserId = modifierUserId;
            return this;
        }
        public String getModifierUserId() {
            return this.modifierUserId;
        }

        public SearchFormDatasResponseBodyData setModifyUser(SearchFormDatasResponseBodyDataModifyUser modifyUser) {
            this.modifyUser = modifyUser;
            return this;
        }
        public SearchFormDatasResponseBodyDataModifyUser getModifyUser() {
            return this.modifyUser;
        }

        public SearchFormDatasResponseBodyData setOriginator(SearchFormDatasResponseBodyDataOriginator originator) {
            this.originator = originator;
            return this;
        }
        public SearchFormDatasResponseBodyDataOriginator getOriginator() {
            return this.originator;
        }

        public SearchFormDatasResponseBodyData setSequence(String sequence) {
            this.sequence = sequence;
            return this;
        }
        public String getSequence() {
            return this.sequence;
        }

        public SearchFormDatasResponseBodyData setSerialNo(String serialNo) {
            this.serialNo = serialNo;
            return this;
        }
        public String getSerialNo() {
            return this.serialNo;
        }

        public SearchFormDatasResponseBodyData setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public SearchFormDatasResponseBodyData setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

}
