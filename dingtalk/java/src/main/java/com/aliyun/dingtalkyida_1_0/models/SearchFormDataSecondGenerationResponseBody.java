// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchFormDataSecondGenerationResponseBody extends TeaModel {
    /**
     * <p>表单实例数据</p>
     */
    @NameInMap("data")
    public java.util.List<SearchFormDataSecondGenerationResponseBodyData> data;

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
         * <p>中文名称</p>
         */
        @NameInMap("nameInChinese")
        public String nameInChinese;

        /**
         * <p>英文名称</p>
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
        /**
         * <p>名称</p>
         */
        @NameInMap("name")
        public SearchFormDataSecondGenerationResponseBodyDataModifyUserName name;

        /**
         * <p>钉钉userId</p>
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
         * <p>中文名称</p>
         */
        @NameInMap("nameInChinese")
        public String nameInChinese;

        /**
         * <p>英文名称</p>
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
        /**
         * <p>名称</p>
         */
        @NameInMap("name")
        public SearchFormDataSecondGenerationResponseBodyDataOriginatorName name;

        /**
         * <p>钉钉userId</p>
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
         * <p>表单实例数据以Map结构展示。结构说明参考  https://www.yuque.com/yida/support/agb8im#jksEx</p>
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
         * <p>数据库表记录主键id</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <p>表单实例数据以宜搭组件值格式展示</p>
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
        public SearchFormDataSecondGenerationResponseBodyDataModifyUser modifyUser;

        /**
         * <p>发起人</p>
         */
        @NameInMap("originator")
        public SearchFormDataSecondGenerationResponseBodyDataOriginator originator;

        /**
         * <p>此表单实例所对应的批量导入批次号(如果该表单实例是通过批量导入创建的)</p>
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
         * <p>表单实例对应的表单schema版本</p>
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
