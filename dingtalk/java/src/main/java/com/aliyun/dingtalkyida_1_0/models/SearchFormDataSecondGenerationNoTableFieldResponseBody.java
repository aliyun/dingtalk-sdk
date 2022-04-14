// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchFormDataSecondGenerationNoTableFieldResponseBody extends TeaModel {
    // 数据
    @NameInMap("data")
    public java.util.List<SearchFormDataSecondGenerationNoTableFieldResponseBodyData> data;

    // 当前第几页
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 总数量
    @NameInMap("totalCount")
    public Long totalCount;

    public static SearchFormDataSecondGenerationNoTableFieldResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchFormDataSecondGenerationNoTableFieldResponseBody self = new SearchFormDataSecondGenerationNoTableFieldResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchFormDataSecondGenerationNoTableFieldResponseBody setData(java.util.List<SearchFormDataSecondGenerationNoTableFieldResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<SearchFormDataSecondGenerationNoTableFieldResponseBodyData> getData() {
        return this.data;
    }

    public SearchFormDataSecondGenerationNoTableFieldResponseBody setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public SearchFormDataSecondGenerationNoTableFieldResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUserName extends TeaModel {
        // 中文名称
        @NameInMap("nameInChinese")
        public String nameInChinese;

        // 英文名称
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        public static SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUserName build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUserName self = new SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUserName();
            return TeaModel.build(map, self);
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUserName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUserName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

    }

    public static class SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUser extends TeaModel {
        // 部门名称
        @NameInMap("departmentName")
        public String departmentName;

        // 电子邮箱
        @NameInMap("email")
        public String email;

        // 名称
        @NameInMap("name")
        public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUserName name;

        // 钉钉userId
        @NameInMap("userId")
        public String userId;

        public static SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUser build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUser self = new SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUser();
            return TeaModel.build(map, self);
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUser setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUser setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUser setName(SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUserName name) {
            this.name = name;
            return this;
        }
        public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUserName getName() {
            return this.name;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUser setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginatorName extends TeaModel {
        // 中文名称
        @NameInMap("nameInChinese")
        public String nameInChinese;

        // 英文名称
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        public static SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginatorName build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginatorName self = new SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginatorName();
            return TeaModel.build(map, self);
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginatorName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginatorName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

    }

    public static class SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginator extends TeaModel {
        // 部门名称
        @NameInMap("departmentName")
        public String departmentName;

        // 电子邮箱
        @NameInMap("email")
        public String email;

        // 名称
        @NameInMap("name")
        public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginatorName name;

        // 钉钉userId
        @NameInMap("userId")
        public String userId;

        public static SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginator build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginator self = new SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginator();
            return TeaModel.build(map, self);
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginator setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginator setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginator setName(SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginatorName name) {
            this.name = name;
            return this;
        }
        public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginatorName getName() {
            return this.name;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class SearchFormDataSecondGenerationNoTableFieldResponseBodyData extends TeaModel {
        // 创建时间
        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        // 创建者的userId
        @NameInMap("creatorUserId")
        public String creatorUserId;

        // 表单实例数据。结构说明参考 https://www.yuque.com/yida/support/agb8im#jksEx
        @NameInMap("formData")
        public java.util.Map<String, ?> formData;

        // 表单实例id
        @NameInMap("formInstanceId")
        public String formInstanceId;

        // 表单编码
        @NameInMap("formUuid")
        public String formUuid;

        // 数据库表记录主键id
        @NameInMap("id")
        public Long id;

        // 表单实例数据
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
        public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUser modifyUser;

        // 表单实例提交人
        @NameInMap("originator")
        public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginator originator;

        // 此表单实例所对应的批量导入批次号(如果该表单实例是通过批量导入创建的)
        @NameInMap("sequence")
        public String sequence;

        // 流水号
        @NameInMap("serialNumber")
        public String serialNumber;

        // 标题
        @NameInMap("title")
        public String title;

        // 该表单实例对应的表单schema版本
        @NameInMap("version")
        public Long version;

        public static SearchFormDataSecondGenerationNoTableFieldResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            SearchFormDataSecondGenerationNoTableFieldResponseBodyData self = new SearchFormDataSecondGenerationNoTableFieldResponseBodyData();
            return TeaModel.build(map, self);
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyData setCreateTimeGMT(String createTimeGMT) {
            this.createTimeGMT = createTimeGMT;
            return this;
        }
        public String getCreateTimeGMT() {
            return this.createTimeGMT;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyData setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyData setFormData(java.util.Map<String, ?> formData) {
            this.formData = formData;
            return this;
        }
        public java.util.Map<String, ?> getFormData() {
            return this.formData;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyData setFormInstanceId(String formInstanceId) {
            this.formInstanceId = formInstanceId;
            return this;
        }
        public String getFormInstanceId() {
            return this.formInstanceId;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyData setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyData setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyData setInstanceValue(String instanceValue) {
            this.instanceValue = instanceValue;
            return this;
        }
        public String getInstanceValue() {
            return this.instanceValue;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyData setModifiedTimeGMT(String modifiedTimeGMT) {
            this.modifiedTimeGMT = modifiedTimeGMT;
            return this;
        }
        public String getModifiedTimeGMT() {
            return this.modifiedTimeGMT;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyData setModifier(String modifier) {
            this.modifier = modifier;
            return this;
        }
        public String getModifier() {
            return this.modifier;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyData setModifyUser(SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUser modifyUser) {
            this.modifyUser = modifyUser;
            return this;
        }
        public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUser getModifyUser() {
            return this.modifyUser;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyData setOriginator(SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginator originator) {
            this.originator = originator;
            return this;
        }
        public SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginator getOriginator() {
            return this.originator;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyData setSequence(String sequence) {
            this.sequence = sequence;
            return this;
        }
        public String getSequence() {
            return this.sequence;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyData setSerialNumber(String serialNumber) {
            this.serialNumber = serialNumber;
            return this;
        }
        public String getSerialNumber() {
            return this.serialNumber;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyData setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public SearchFormDataSecondGenerationNoTableFieldResponseBodyData setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

}
