// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchFormDatasResponseBody extends TeaModel {
    // 当前页
    @NameInMap("currentPage")
    public Long currentPage;

    // 符合条件的实例总数
    @NameInMap("totalCount")
    public Long totalCount;

    // 实例详情列表
    @NameInMap("data")
    public java.util.List<SearchFormDatasResponseBodyData> data;

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

    public SearchFormDatasResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public SearchFormDatasResponseBody setData(java.util.List<SearchFormDatasResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<SearchFormDatasResponseBodyData> getData() {
        return this.data;
    }

    public static class SearchFormDatasResponseBodyDataOriginatorName extends TeaModel {
        // 中文名称
        @NameInMap("nameInChinese")
        public String nameInChinese;

        // 英文名称
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        // 国际化
        @NameInMap("type")
        public String type;

        public static SearchFormDatasResponseBodyDataOriginatorName build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDatasResponseBodyDataOriginatorName self = new SearchFormDatasResponseBodyDataOriginatorName();
            return TeaModel.build(map, self);
        }

        public SearchFormDatasResponseBodyDataOriginatorName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

        public SearchFormDatasResponseBodyDataOriginatorName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

        public SearchFormDatasResponseBodyDataOriginatorName setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class SearchFormDatasResponseBodyDataOriginator extends TeaModel {
        // 用户工号
        @NameInMap("userId")
        public String userId;

        // 用户名
        @NameInMap("name")
        public SearchFormDatasResponseBodyDataOriginatorName name;

        // 部门名称
        @NameInMap("departmentName")
        public String departmentName;

        // 邮箱
        @NameInMap("email")
        public String email;

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

        public SearchFormDatasResponseBodyDataOriginator setName(SearchFormDatasResponseBodyDataOriginatorName name) {
            this.name = name;
            return this;
        }
        public SearchFormDatasResponseBodyDataOriginatorName getName() {
            return this.name;
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

    }

    public static class SearchFormDatasResponseBodyDataModifyUserName extends TeaModel {
        // 中文名称
        @NameInMap("nameInChinese")
        public String nameInChinese;

        // 英文名称
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        // 国际化
        @NameInMap("type")
        public String type;

        public static SearchFormDatasResponseBodyDataModifyUserName build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDatasResponseBodyDataModifyUserName self = new SearchFormDatasResponseBodyDataModifyUserName();
            return TeaModel.build(map, self);
        }

        public SearchFormDatasResponseBodyDataModifyUserName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

        public SearchFormDatasResponseBodyDataModifyUserName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

        public SearchFormDatasResponseBodyDataModifyUserName setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class SearchFormDatasResponseBodyDataModifyUser extends TeaModel {
        // 用户工号
        @NameInMap("userId")
        public String userId;

        // 用户名
        @NameInMap("name")
        public SearchFormDatasResponseBodyDataModifyUserName name;

        // 部门名称
        @NameInMap("departmentName")
        public String departmentName;

        // 邮箱
        @NameInMap("email")
        public String email;

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

        public SearchFormDatasResponseBodyDataModifyUser setName(SearchFormDatasResponseBodyDataModifyUserName name) {
            this.name = name;
            return this;
        }
        public SearchFormDatasResponseBodyDataModifyUserName getName() {
            return this.name;
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

    }

    public static class SearchFormDatasResponseBodyData extends TeaModel {
        @NameInMap("id")
        public Long id;

        // 实例ID
        @NameInMap("formInstId")
        public String formInstId;

        // 数据创建时间
        @NameInMap("createdTimeGMT")
        public String createdTimeGMT;

        // 最近修改时间
        @NameInMap("modifiedTimeGMT")
        public String modifiedTimeGMT;

        // 表单id
        @NameInMap("formUuid")
        public String formUuid;

        // 模型id
        @NameInMap("modelUuid")
        public String modelUuid;

        // 发起人
        @NameInMap("originator")
        public SearchFormDatasResponseBodyDataOriginator originator;

        // 修改者
        @NameInMap("modifyUser")
        public SearchFormDatasResponseBodyDataModifyUser modifyUser;

        // 表单数据
        @NameInMap("formData")
        public java.util.Map<String, ?> formData;

        // 标题
        @NameInMap("title")
        public String title;

        // 流水号
        @NameInMap("serialNo")
        public String serialNo;

        // 表单实例原始格式值
        @NameInMap("instanceValue")
        public String instanceValue;

        // 数据版本
        @NameInMap("version")
        public Long version;

        // 创建人
        @NameInMap("creator")
        public String creator;

        // 修改人
        @NameInMap("modifier")
        public String modifier;

        // 批次号
        @NameInMap("sequence")
        public String sequence;

        public static SearchFormDatasResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDatasResponseBodyData self = new SearchFormDatasResponseBodyData();
            return TeaModel.build(map, self);
        }

        public SearchFormDatasResponseBodyData setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public SearchFormDatasResponseBodyData setFormInstId(String formInstId) {
            this.formInstId = formInstId;
            return this;
        }
        public String getFormInstId() {
            return this.formInstId;
        }

        public SearchFormDatasResponseBodyData setCreatedTimeGMT(String createdTimeGMT) {
            this.createdTimeGMT = createdTimeGMT;
            return this;
        }
        public String getCreatedTimeGMT() {
            return this.createdTimeGMT;
        }

        public SearchFormDatasResponseBodyData setModifiedTimeGMT(String modifiedTimeGMT) {
            this.modifiedTimeGMT = modifiedTimeGMT;
            return this;
        }
        public String getModifiedTimeGMT() {
            return this.modifiedTimeGMT;
        }

        public SearchFormDatasResponseBodyData setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public SearchFormDatasResponseBodyData setModelUuid(String modelUuid) {
            this.modelUuid = modelUuid;
            return this;
        }
        public String getModelUuid() {
            return this.modelUuid;
        }

        public SearchFormDatasResponseBodyData setOriginator(SearchFormDatasResponseBodyDataOriginator originator) {
            this.originator = originator;
            return this;
        }
        public SearchFormDatasResponseBodyDataOriginator getOriginator() {
            return this.originator;
        }

        public SearchFormDatasResponseBodyData setModifyUser(SearchFormDatasResponseBodyDataModifyUser modifyUser) {
            this.modifyUser = modifyUser;
            return this;
        }
        public SearchFormDatasResponseBodyDataModifyUser getModifyUser() {
            return this.modifyUser;
        }

        public SearchFormDatasResponseBodyData setFormData(java.util.Map<String, ?> formData) {
            this.formData = formData;
            return this;
        }
        public java.util.Map<String, ?> getFormData() {
            return this.formData;
        }

        public SearchFormDatasResponseBodyData setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public SearchFormDatasResponseBodyData setSerialNo(String serialNo) {
            this.serialNo = serialNo;
            return this;
        }
        public String getSerialNo() {
            return this.serialNo;
        }

        public SearchFormDatasResponseBodyData setInstanceValue(String instanceValue) {
            this.instanceValue = instanceValue;
            return this;
        }
        public String getInstanceValue() {
            return this.instanceValue;
        }

        public SearchFormDatasResponseBodyData setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

        public SearchFormDatasResponseBodyData setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public SearchFormDatasResponseBodyData setModifier(String modifier) {
            this.modifier = modifier;
            return this;
        }
        public String getModifier() {
            return this.modifier;
        }

        public SearchFormDatasResponseBodyData setSequence(String sequence) {
            this.sequence = sequence;
            return this;
        }
        public String getSequence() {
            return this.sequence;
        }

    }

}
