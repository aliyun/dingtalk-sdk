// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchFormDataRemovalTableDataResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<SearchFormDataRemovalTableDataResponseBodyData> data;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("hasMoreData")
    public Boolean hasMoreData;

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

    public static SearchFormDataRemovalTableDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchFormDataRemovalTableDataResponseBody self = new SearchFormDataRemovalTableDataResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchFormDataRemovalTableDataResponseBody setData(java.util.List<SearchFormDataRemovalTableDataResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<SearchFormDataRemovalTableDataResponseBodyData> getData() {
        return this.data;
    }

    public SearchFormDataRemovalTableDataResponseBody setHasMoreData(Boolean hasMoreData) {
        this.hasMoreData = hasMoreData;
        return this;
    }
    public Boolean getHasMoreData() {
        return this.hasMoreData;
    }

    public SearchFormDataRemovalTableDataResponseBody setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public SearchFormDataRemovalTableDataResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class SearchFormDataRemovalTableDataResponseBodyDataModifyUserName extends TeaModel {
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

        public static SearchFormDataRemovalTableDataResponseBodyDataModifyUserName build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDataRemovalTableDataResponseBodyDataModifyUserName self = new SearchFormDataRemovalTableDataResponseBodyDataModifyUserName();
            return TeaModel.build(map, self);
        }

        public SearchFormDataRemovalTableDataResponseBodyDataModifyUserName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

        public SearchFormDataRemovalTableDataResponseBodyDataModifyUserName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

    }

    public static class SearchFormDataRemovalTableDataResponseBodyDataModifyUser extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>开发部</p>
         */
        @NameInMap("departmentName")
        public String departmentName;

        /**
         * <strong>example:</strong>
         * <p><a href="mailto:abc@alimail.com">abc@alimail.com</a></p>
         */
        @NameInMap("email")
        public String email;

        @NameInMap("name")
        public SearchFormDataRemovalTableDataResponseBodyDataModifyUserName name;

        /**
         * <strong>example:</strong>
         * <p>ding173982232112232</p>
         */
        @NameInMap("userId")
        public String userId;

        public static SearchFormDataRemovalTableDataResponseBodyDataModifyUser build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDataRemovalTableDataResponseBodyDataModifyUser self = new SearchFormDataRemovalTableDataResponseBodyDataModifyUser();
            return TeaModel.build(map, self);
        }

        public SearchFormDataRemovalTableDataResponseBodyDataModifyUser setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public SearchFormDataRemovalTableDataResponseBodyDataModifyUser setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

        public SearchFormDataRemovalTableDataResponseBodyDataModifyUser setName(SearchFormDataRemovalTableDataResponseBodyDataModifyUserName name) {
            this.name = name;
            return this;
        }
        public SearchFormDataRemovalTableDataResponseBodyDataModifyUserName getName() {
            return this.name;
        }

        public SearchFormDataRemovalTableDataResponseBodyDataModifyUser setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class SearchFormDataRemovalTableDataResponseBodyDataOriginatorName extends TeaModel {
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

        public static SearchFormDataRemovalTableDataResponseBodyDataOriginatorName build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDataRemovalTableDataResponseBodyDataOriginatorName self = new SearchFormDataRemovalTableDataResponseBodyDataOriginatorName();
            return TeaModel.build(map, self);
        }

        public SearchFormDataRemovalTableDataResponseBodyDataOriginatorName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

        public SearchFormDataRemovalTableDataResponseBodyDataOriginatorName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

    }

    public static class SearchFormDataRemovalTableDataResponseBodyDataOriginator extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>开发部</p>
         */
        @NameInMap("departmentName")
        public String departmentName;

        /**
         * <strong>example:</strong>
         * <p><a href="mailto:abc@alimail.com">abc@alimail.com</a></p>
         */
        @NameInMap("email")
        public String email;

        @NameInMap("name")
        public SearchFormDataRemovalTableDataResponseBodyDataOriginatorName name;

        /**
         * <strong>example:</strong>
         * <p>ding173982232112232</p>
         */
        @NameInMap("userId")
        public String userId;

        public static SearchFormDataRemovalTableDataResponseBodyDataOriginator build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDataRemovalTableDataResponseBodyDataOriginator self = new SearchFormDataRemovalTableDataResponseBodyDataOriginator();
            return TeaModel.build(map, self);
        }

        public SearchFormDataRemovalTableDataResponseBodyDataOriginator setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public SearchFormDataRemovalTableDataResponseBodyDataOriginator setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

        public SearchFormDataRemovalTableDataResponseBodyDataOriginator setName(SearchFormDataRemovalTableDataResponseBodyDataOriginatorName name) {
            this.name = name;
            return this;
        }
        public SearchFormDataRemovalTableDataResponseBodyDataOriginatorName getName() {
            return this.name;
        }

        public SearchFormDataRemovalTableDataResponseBodyDataOriginator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class SearchFormDataRemovalTableDataResponseBodyData extends TeaModel {
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
         * <p>{&quot;countrySelectField_l0c1cwiu&quot;:[{&quot;value&quot;:&quot;US&quot;}]}</p>
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
         * <p>符合宜搭表单实例格式的json数据</p>
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
        public SearchFormDataRemovalTableDataResponseBodyDataModifyUser modifyUser;

        @NameInMap("originator")
        public SearchFormDataRemovalTableDataResponseBodyDataOriginator originator;

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

        public static SearchFormDataRemovalTableDataResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDataRemovalTableDataResponseBodyData self = new SearchFormDataRemovalTableDataResponseBodyData();
            return TeaModel.build(map, self);
        }

        public SearchFormDataRemovalTableDataResponseBodyData setCreateTimeGMT(String createTimeGMT) {
            this.createTimeGMT = createTimeGMT;
            return this;
        }
        public String getCreateTimeGMT() {
            return this.createTimeGMT;
        }

        public SearchFormDataRemovalTableDataResponseBodyData setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public SearchFormDataRemovalTableDataResponseBodyData setFormData(java.util.Map<String, ?> formData) {
            this.formData = formData;
            return this;
        }
        public java.util.Map<String, ?> getFormData() {
            return this.formData;
        }

        public SearchFormDataRemovalTableDataResponseBodyData setFormInstanceId(String formInstanceId) {
            this.formInstanceId = formInstanceId;
            return this;
        }
        public String getFormInstanceId() {
            return this.formInstanceId;
        }

        public SearchFormDataRemovalTableDataResponseBodyData setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public SearchFormDataRemovalTableDataResponseBodyData setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public SearchFormDataRemovalTableDataResponseBodyData setInstanceValue(String instanceValue) {
            this.instanceValue = instanceValue;
            return this;
        }
        public String getInstanceValue() {
            return this.instanceValue;
        }

        public SearchFormDataRemovalTableDataResponseBodyData setModifiedTimeGMT(String modifiedTimeGMT) {
            this.modifiedTimeGMT = modifiedTimeGMT;
            return this;
        }
        public String getModifiedTimeGMT() {
            return this.modifiedTimeGMT;
        }

        public SearchFormDataRemovalTableDataResponseBodyData setModifier(String modifier) {
            this.modifier = modifier;
            return this;
        }
        public String getModifier() {
            return this.modifier;
        }

        public SearchFormDataRemovalTableDataResponseBodyData setModifyUser(SearchFormDataRemovalTableDataResponseBodyDataModifyUser modifyUser) {
            this.modifyUser = modifyUser;
            return this;
        }
        public SearchFormDataRemovalTableDataResponseBodyDataModifyUser getModifyUser() {
            return this.modifyUser;
        }

        public SearchFormDataRemovalTableDataResponseBodyData setOriginator(SearchFormDataRemovalTableDataResponseBodyDataOriginator originator) {
            this.originator = originator;
            return this;
        }
        public SearchFormDataRemovalTableDataResponseBodyDataOriginator getOriginator() {
            return this.originator;
        }

        public SearchFormDataRemovalTableDataResponseBodyData setSequence(String sequence) {
            this.sequence = sequence;
            return this;
        }
        public String getSequence() {
            return this.sequence;
        }

        public SearchFormDataRemovalTableDataResponseBodyData setSerialNumber(String serialNumber) {
            this.serialNumber = serialNumber;
            return this;
        }
        public String getSerialNumber() {
            return this.serialNumber;
        }

        public SearchFormDataRemovalTableDataResponseBodyData setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public SearchFormDataRemovalTableDataResponseBodyData setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

}
