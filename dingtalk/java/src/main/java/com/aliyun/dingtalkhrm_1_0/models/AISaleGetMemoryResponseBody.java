// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleGetMemoryResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public AISaleGetMemoryResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static AISaleGetMemoryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AISaleGetMemoryResponseBody self = new AISaleGetMemoryResponseBody();
        return TeaModel.build(map, self);
    }

    public AISaleGetMemoryResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public AISaleGetMemoryResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public AISaleGetMemoryResponseBody setResult(AISaleGetMemoryResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AISaleGetMemoryResponseBodyResult getResult() {
        return this.result;
    }

    public AISaleGetMemoryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AISaleGetMemoryResponseBodyResultData extends TeaModel {
        @NameInMap("contactId")
        public String contactId;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("customerId")
        public String customerId;

        @NameInMap("entityId")
        public String entityId;

        @NameInMap("entityType")
        public String entityType;

        @NameInMap("extInfo")
        public String extInfo;

        @NameInMap("gmtCreate")
        public Long gmtCreate;

        @NameInMap("gmtModified")
        public Long gmtModified;

        @NameInMap("happenedAt")
        public Long happenedAt;

        @NameInMap("importance")
        public Integer importance;

        @NameInMap("memoryCategory")
        public String memoryCategory;

        @NameInMap("memoryContent")
        public String memoryContent;

        @NameInMap("memoryId")
        public String memoryId;

        @NameInMap("memoryTitle")
        public String memoryTitle;

        @NameInMap("sourceActivityId")
        public String sourceActivityId;

        @NameInMap("tags")
        public java.util.List<String> tags;

        public static AISaleGetMemoryResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            AISaleGetMemoryResponseBodyResultData self = new AISaleGetMemoryResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public AISaleGetMemoryResponseBodyResultData setContactId(String contactId) {
            this.contactId = contactId;
            return this;
        }
        public String getContactId() {
            return this.contactId;
        }

        public AISaleGetMemoryResponseBodyResultData setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public AISaleGetMemoryResponseBodyResultData setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public AISaleGetMemoryResponseBodyResultData setCustomerId(String customerId) {
            this.customerId = customerId;
            return this;
        }
        public String getCustomerId() {
            return this.customerId;
        }

        public AISaleGetMemoryResponseBodyResultData setEntityId(String entityId) {
            this.entityId = entityId;
            return this;
        }
        public String getEntityId() {
            return this.entityId;
        }

        public AISaleGetMemoryResponseBodyResultData setEntityType(String entityType) {
            this.entityType = entityType;
            return this;
        }
        public String getEntityType() {
            return this.entityType;
        }

        public AISaleGetMemoryResponseBodyResultData setExtInfo(String extInfo) {
            this.extInfo = extInfo;
            return this;
        }
        public String getExtInfo() {
            return this.extInfo;
        }

        public AISaleGetMemoryResponseBodyResultData setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public AISaleGetMemoryResponseBodyResultData setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public AISaleGetMemoryResponseBodyResultData setHappenedAt(Long happenedAt) {
            this.happenedAt = happenedAt;
            return this;
        }
        public Long getHappenedAt() {
            return this.happenedAt;
        }

        public AISaleGetMemoryResponseBodyResultData setImportance(Integer importance) {
            this.importance = importance;
            return this;
        }
        public Integer getImportance() {
            return this.importance;
        }

        public AISaleGetMemoryResponseBodyResultData setMemoryCategory(String memoryCategory) {
            this.memoryCategory = memoryCategory;
            return this;
        }
        public String getMemoryCategory() {
            return this.memoryCategory;
        }

        public AISaleGetMemoryResponseBodyResultData setMemoryContent(String memoryContent) {
            this.memoryContent = memoryContent;
            return this;
        }
        public String getMemoryContent() {
            return this.memoryContent;
        }

        public AISaleGetMemoryResponseBodyResultData setMemoryId(String memoryId) {
            this.memoryId = memoryId;
            return this;
        }
        public String getMemoryId() {
            return this.memoryId;
        }

        public AISaleGetMemoryResponseBodyResultData setMemoryTitle(String memoryTitle) {
            this.memoryTitle = memoryTitle;
            return this;
        }
        public String getMemoryTitle() {
            return this.memoryTitle;
        }

        public AISaleGetMemoryResponseBodyResultData setSourceActivityId(String sourceActivityId) {
            this.sourceActivityId = sourceActivityId;
            return this;
        }
        public String getSourceActivityId() {
            return this.sourceActivityId;
        }

        public AISaleGetMemoryResponseBodyResultData setTags(java.util.List<String> tags) {
            this.tags = tags;
            return this;
        }
        public java.util.List<String> getTags() {
            return this.tags;
        }

    }

    public static class AISaleGetMemoryResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public java.util.List<AISaleGetMemoryResponseBodyResultData> data;

        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("nextCursor")
        public String nextCursor;

        @NameInMap("pageSize")
        public Integer pageSize;

        @NameInMap("total")
        public Integer total;

        public static AISaleGetMemoryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AISaleGetMemoryResponseBodyResult self = new AISaleGetMemoryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AISaleGetMemoryResponseBodyResult setData(java.util.List<AISaleGetMemoryResponseBodyResultData> data) {
            this.data = data;
            return this;
        }
        public java.util.List<AISaleGetMemoryResponseBodyResultData> getData() {
            return this.data;
        }

        public AISaleGetMemoryResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public AISaleGetMemoryResponseBodyResult setNextCursor(String nextCursor) {
            this.nextCursor = nextCursor;
            return this;
        }
        public String getNextCursor() {
            return this.nextCursor;
        }

        public AISaleGetMemoryResponseBodyResult setPageSize(Integer pageSize) {
            this.pageSize = pageSize;
            return this;
        }
        public Integer getPageSize() {
            return this.pageSize;
        }

        public AISaleGetMemoryResponseBodyResult setTotal(Integer total) {
            this.total = total;
            return this;
        }
        public Integer getTotal() {
            return this.total;
        }

    }

}
