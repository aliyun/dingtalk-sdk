// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchFormDatasResponseBody extends TeaModel {
    @NameInMap("currentPage")
    public Long currentPage;

    @NameInMap("data")
    public java.util.List<SearchFormDatasResponseBodyData> data;

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
        @NameInMap("nameInChinese")
        public String nameInChinese;

        @NameInMap("nameInEnglish")
        public String nameInEnglish;

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
        @NameInMap("nameInChinese")
        public String nameInChinese;

        @NameInMap("nameInEnglish")
        public String nameInEnglish;

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
        @NameInMap("createdTimeGMT")
        public String createdTimeGMT;

        @NameInMap("creatorUserId")
        public String creatorUserId;

        @NameInMap("dataId")
        public Long dataId;

        @NameInMap("formData")
        public java.util.Map<String, ?> formData;

        @NameInMap("formInstanceId")
        public String formInstanceId;

        @NameInMap("formUuid")
        public String formUuid;

        @NameInMap("instanceValue")
        public String instanceValue;

        @NameInMap("modelUuid")
        public String modelUuid;

        @NameInMap("modifiedTimeGMT")
        public String modifiedTimeGMT;

        @NameInMap("modifierUserId")
        public String modifierUserId;

        @NameInMap("modifyUser")
        public SearchFormDatasResponseBodyDataModifyUser modifyUser;

        @NameInMap("originator")
        public SearchFormDatasResponseBodyDataOriginator originator;

        @NameInMap("sequence")
        public String sequence;

        @NameInMap("serialNo")
        public String serialNo;

        @NameInMap("title")
        public String title;

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
