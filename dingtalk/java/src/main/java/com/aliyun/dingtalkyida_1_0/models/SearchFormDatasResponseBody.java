// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchFormDatasResponseBody extends TeaModel {
    /**
     * <p>当前页</p>
     */
    @NameInMap("currentPage")
    public Long currentPage;

    /**
     * <p>实例详情列表</p>
     */
    @NameInMap("data")
    public java.util.List<SearchFormDatasResponseBodyData> data;

    /**
     * <p>符合条件的实例总数</p>
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
         * <p>中文名称</p>
         */
        @NameInMap("nameInChinese")
        public String nameInChinese;

        /**
         * <p>英文名称</p>
         */
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        /**
         * <p>国际化</p>
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
        /**
         * <p>部门名称</p>
         */
        @NameInMap("departmentName")
        public String departmentName;

        /**
         * <p>邮箱</p>
         */
        @NameInMap("email")
        public String email;

        /**
         * <p>用户工号</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <p>用户名</p>
         */
        @NameInMap("userName")
        public SearchFormDatasResponseBodyDataModifyUserUserName userName;

        public static SearchFormDatasResponseBodyDataModifyUser build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDatasResponseBodyDataModifyUser self = new SearchFormDatasResponseBodyDataModifyUser();
            return TeaModel.build(map, self);
        }

        public SearchFormDatasResponseBodyDataModifyUser setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public SearchFormDatasResponseBodyDataModifyUser setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
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
         * <p>中文名称</p>
         */
        @NameInMap("nameInChinese")
        public String nameInChinese;

        /**
         * <p>英文名称</p>
         */
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        /**
         * <p>国际化</p>
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
        /**
         * <p>部门名称</p>
         */
        @NameInMap("departmentName")
        public String departmentName;

        /**
         * <p>邮箱</p>
         */
        @NameInMap("email")
        public String email;

        /**
         * <p>用户工号</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <p>用户名</p>
         */
        @NameInMap("userName")
        public SearchFormDatasResponseBodyDataOriginatorUserName userName;

        public static SearchFormDatasResponseBodyDataOriginator build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDatasResponseBodyDataOriginator self = new SearchFormDatasResponseBodyDataOriginator();
            return TeaModel.build(map, self);
        }

        public SearchFormDatasResponseBodyDataOriginator setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public SearchFormDatasResponseBodyDataOriginator setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
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
         * <p>数据创建时间</p>
         */
        @NameInMap("createdTimeGMT")
        public String createdTimeGMT;

        /**
         * <p>创建人</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

        /**
         * <p>实体主键id</p>
         */
        @NameInMap("dataId")
        public Long dataId;

        /**
         * <p>表单数据</p>
         */
        @NameInMap("formData")
        public java.util.Map<String, ?> formData;

        /**
         * <p>表单实例ID</p>
         */
        @NameInMap("formInstanceId")
        public String formInstanceId;

        /**
         * <p>表单id</p>
         */
        @NameInMap("formUuid")
        public String formUuid;

        /**
         * <p>表单实例原始格式值</p>
         */
        @NameInMap("instanceValue")
        public String instanceValue;

        /**
         * <p>模型id</p>
         */
        @NameInMap("modelUuid")
        public String modelUuid;

        /**
         * <p>最近修改时间</p>
         */
        @NameInMap("modifiedTimeGMT")
        public String modifiedTimeGMT;

        /**
         * <p>修改人</p>
         */
        @NameInMap("modifierUserId")
        public String modifierUserId;

        /**
         * <p>修改者</p>
         */
        @NameInMap("modifyUser")
        public SearchFormDatasResponseBodyDataModifyUser modifyUser;

        /**
         * <p>发起人</p>
         */
        @NameInMap("originator")
        public SearchFormDatasResponseBodyDataOriginator originator;

        /**
         * <p>批次号</p>
         */
        @NameInMap("sequence")
        public String sequence;

        /**
         * <p>流水号</p>
         */
        @NameInMap("serialNo")
        public String serialNo;

        /**
         * <p>标题</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>数据版本</p>
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
