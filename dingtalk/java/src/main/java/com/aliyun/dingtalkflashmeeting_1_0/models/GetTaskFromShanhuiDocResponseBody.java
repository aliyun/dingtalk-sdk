// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class GetTaskFromShanhuiDocResponseBody extends TeaModel {
    @NameInMap("result")
    public GetTaskFromShanhuiDocResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetTaskFromShanhuiDocResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTaskFromShanhuiDocResponseBody self = new GetTaskFromShanhuiDocResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTaskFromShanhuiDocResponseBody setResult(GetTaskFromShanhuiDocResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetTaskFromShanhuiDocResponseBodyResult getResult() {
        return this.result;
    }

    public GetTaskFromShanhuiDocResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetTaskFromShanhuiDocResponseBodyResultItems extends TeaModel {
        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("deadline")
        public Long deadline;

        @NameInMap("deleted")
        public Boolean deleted;

        @NameInMap("priority")
        public Long priority;

        @NameInMap("taskKey")
        public String taskKey;

        @NameInMap("taskStatus")
        public String taskStatus;

        @NameInMap("taskType")
        public String taskType;

        @NameInMap("title")
        public String title;

        @NameInMap("updateTime")
        public Long updateTime;

        public static GetTaskFromShanhuiDocResponseBodyResultItems build(java.util.Map<String, ?> map) throws Exception {
            GetTaskFromShanhuiDocResponseBodyResultItems self = new GetTaskFromShanhuiDocResponseBodyResultItems();
            return TeaModel.build(map, self);
        }

        public GetTaskFromShanhuiDocResponseBodyResultItems setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public GetTaskFromShanhuiDocResponseBodyResultItems setDeadline(Long deadline) {
            this.deadline = deadline;
            return this;
        }
        public Long getDeadline() {
            return this.deadline;
        }

        public GetTaskFromShanhuiDocResponseBodyResultItems setDeleted(Boolean deleted) {
            this.deleted = deleted;
            return this;
        }
        public Boolean getDeleted() {
            return this.deleted;
        }

        public GetTaskFromShanhuiDocResponseBodyResultItems setPriority(Long priority) {
            this.priority = priority;
            return this;
        }
        public Long getPriority() {
            return this.priority;
        }

        public GetTaskFromShanhuiDocResponseBodyResultItems setTaskKey(String taskKey) {
            this.taskKey = taskKey;
            return this;
        }
        public String getTaskKey() {
            return this.taskKey;
        }

        public GetTaskFromShanhuiDocResponseBodyResultItems setTaskStatus(String taskStatus) {
            this.taskStatus = taskStatus;
            return this;
        }
        public String getTaskStatus() {
            return this.taskStatus;
        }

        public GetTaskFromShanhuiDocResponseBodyResultItems setTaskType(String taskType) {
            this.taskType = taskType;
            return this;
        }
        public String getTaskType() {
            return this.taskType;
        }

        public GetTaskFromShanhuiDocResponseBodyResultItems setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetTaskFromShanhuiDocResponseBodyResultItems setUpdateTime(Long updateTime) {
            this.updateTime = updateTime;
            return this;
        }
        public Long getUpdateTime() {
            return this.updateTime;
        }

    }

    public static class GetTaskFromShanhuiDocResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("items")
        public java.util.List<GetTaskFromShanhuiDocResponseBodyResultItems> items;

        @NameInMap("nextToken")
        public String nextToken;

        @NameInMap("total")
        public Long total;

        public static GetTaskFromShanhuiDocResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetTaskFromShanhuiDocResponseBodyResult self = new GetTaskFromShanhuiDocResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetTaskFromShanhuiDocResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public GetTaskFromShanhuiDocResponseBodyResult setItems(java.util.List<GetTaskFromShanhuiDocResponseBodyResultItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<GetTaskFromShanhuiDocResponseBodyResultItems> getItems() {
            return this.items;
        }

        public GetTaskFromShanhuiDocResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public GetTaskFromShanhuiDocResponseBodyResult setTotal(Long total) {
            this.total = total;
            return this;
        }
        public Long getTotal() {
            return this.total;
        }

    }

}
