// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchFormDataRemovalTableDataResponseBody extends TeaModel {
    /**
     * <p>数据</p>
     */
    @NameInMap("data")
    public java.util.List<SearchFormDataRemovalTableDataResponseBodyData> data;

    /**
     * <p>是否还有数据</p>
     */
    @NameInMap("hasMoreData")
    public Boolean hasMoreData;

    /**
     * <p>当前第几页</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>总数量</p>
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
         * <p>中文名称</p>
         */
        @NameInMap("nameInChinese")
        public String nameInChinese;

        /**
         * <p>英文名称</p>
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
         * <p>部门名称</p>
         */
        @NameInMap("departmentName")
        public String departmentName;

        /**
         * <p>电子邮箱</p>
         */
        @NameInMap("email")
        public String email;

        /**
         * <p>名称</p>
         */
        @NameInMap("name")
        public SearchFormDataRemovalTableDataResponseBodyDataModifyUserName name;

        /**
         * <p>钉钉userId</p>
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
         * <p>中文名称</p>
         */
        @NameInMap("nameInChinese")
        public String nameInChinese;

        /**
         * <p>英文名称</p>
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
         * <p>部门名称</p>
         */
        @NameInMap("departmentName")
        public String departmentName;

        /**
         * <p>电子邮箱</p>
         */
        @NameInMap("email")
        public String email;

        /**
         * <p>名称</p>
         */
        @NameInMap("name")
        public SearchFormDataRemovalTableDataResponseBodyDataOriginatorName name;

        /**
         * <p>钉钉userId</p>
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
         * <p>创建时间</p>
         */
        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        /**
         * <p>创建者的userId</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

        /**
         * <p>表单实例数据。结构说明参考  https://www.yuque.com/yida/support/agb8im#jksEx</p>
         */
        @NameInMap("formData")
        public java.util.Map<String, ?> formData;

        /**
         * <p>表单实例id</p>
         */
        @NameInMap("formInstanceId")
        public String formInstanceId;

        /**
         * <p>表单编码</p>
         */
        @NameInMap("formUuid")
        public String formUuid;

        /**
         * <p>数据库表记录的主键id</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <p>实例数据</p>
         */
        @NameInMap("instanceValue")
        public String instanceValue;

        /**
         * <p>修改时间</p>
         */
        @NameInMap("modifiedTimeGMT")
        public String modifiedTimeGMT;

        /**
         * <p>修改者的钉钉userId</p>
         */
        @NameInMap("modifier")
        public String modifier;

        /**
         * <p>修改者</p>
         */
        @NameInMap("modifyUser")
        public SearchFormDataRemovalTableDataResponseBodyDataModifyUser modifyUser;

        /**
         * <p>发起人</p>
         */
        @NameInMap("originator")
        public SearchFormDataRemovalTableDataResponseBodyDataOriginator originator;

        /**
         * <p>一次批量导入对应的批次号</p>
         */
        @NameInMap("sequence")
        public String sequence;

        /**
         * <p>流水号</p>
         */
        @NameInMap("serialNumber")
        public String serialNumber;

        /**
         * <p>标题</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>该实例对应的表单schema版本</p>
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
