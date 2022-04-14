// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchFormDataRemovalTableDataResponseBody extends TeaModel {
    // 数据
    @NameInMap("data")
    public java.util.List<SearchFormDataRemovalTableDataResponseBodyData> data;

    // 是否还有数据
    @NameInMap("hasMoreData")
    public Boolean hasMoreData;

    // 当前第几页
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 总数量
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
        // 中文名称
        @NameInMap("nameInChinese")
        public String nameInChinese;

        // 英文名称
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
        // 部门名称
        @NameInMap("departmentName")
        public String departmentName;

        // 电子邮箱
        @NameInMap("email")
        public String email;

        // 名称
        @NameInMap("name")
        public SearchFormDataRemovalTableDataResponseBodyDataModifyUserName name;

        // 钉钉userId
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
        // 中文名称
        @NameInMap("nameInChinese")
        public String nameInChinese;

        // 英文名称
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
        // 部门名称
        @NameInMap("departmentName")
        public String departmentName;

        // 电子邮箱
        @NameInMap("email")
        public String email;

        // 名称
        @NameInMap("name")
        public SearchFormDataRemovalTableDataResponseBodyDataOriginatorName name;

        // 钉钉userId
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
        // 创建时间
        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        // 创建者的userId
        @NameInMap("creatorUserId")
        public String creatorUserId;

        // 表单实例数据。结构说明参考  https://www.yuque.com/yida/support/agb8im#jksEx
        @NameInMap("formData")
        public java.util.Map<String, ?> formData;

        // 表单实例id
        @NameInMap("formInstanceId")
        public String formInstanceId;

        // 表单编码
        @NameInMap("formUuid")
        public String formUuid;

        // 数据库表记录的主键id
        @NameInMap("id")
        public Long id;

        // 实例数据
        @NameInMap("instanceValue")
        public String instanceValue;

        // 修改时间
        @NameInMap("modifiedTimeGMT")
        public String modifiedTimeGMT;

        // 修改者的钉钉userId
        @NameInMap("modifier")
        public String modifier;

        // 修改者
        @NameInMap("modifyUser")
        public SearchFormDataRemovalTableDataResponseBodyDataModifyUser modifyUser;

        // 发起人
        @NameInMap("originator")
        public SearchFormDataRemovalTableDataResponseBodyDataOriginator originator;

        // 一次批量导入对应的批次号
        @NameInMap("sequence")
        public String sequence;

        // 流水号
        @NameInMap("serialNumber")
        public String serialNumber;

        // 标题
        @NameInMap("title")
        public String title;

        // 该实例对应的表单schema版本
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
