// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class ListAssistantRunResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<ListAssistantRunResponseBodyData> data;

    @NameInMap("object")
    public String object;

    public static ListAssistantRunResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListAssistantRunResponseBody self = new ListAssistantRunResponseBody();
        return TeaModel.build(map, self);
    }

    public ListAssistantRunResponseBody setData(java.util.List<ListAssistantRunResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<ListAssistantRunResponseBodyData> getData() {
        return this.data;
    }

    public ListAssistantRunResponseBody setObject(String object) {
        this.object = object;
        return this;
    }
    public String getObject() {
        return this.object;
    }

    public static class ListAssistantRunResponseBodyData extends TeaModel {
        @NameInMap("assistantId")
        public String assistantId;

        @NameInMap("cancelledAt")
        public Long cancelledAt;

        @NameInMap("completedAt")
        public Long completedAt;

        @NameInMap("createdAt")
        public Long createdAt;

        @NameInMap("expiresAt")
        public Long expiresAt;

        @NameInMap("failedAt")
        public Long failedAt;

        @NameInMap("id")
        public String id;

        @NameInMap("lastErrorMsg")
        public String lastErrorMsg;

        @NameInMap("metadata")
        public java.util.Map<String, ?> metadata;

        @NameInMap("object")
        public String object;

        @NameInMap("startedAt")
        public Long startedAt;

        @NameInMap("status")
        public String status;

        @NameInMap("threadId")
        public String threadId;

        public static ListAssistantRunResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            ListAssistantRunResponseBodyData self = new ListAssistantRunResponseBodyData();
            return TeaModel.build(map, self);
        }

        public ListAssistantRunResponseBodyData setAssistantId(String assistantId) {
            this.assistantId = assistantId;
            return this;
        }
        public String getAssistantId() {
            return this.assistantId;
        }

        public ListAssistantRunResponseBodyData setCancelledAt(Long cancelledAt) {
            this.cancelledAt = cancelledAt;
            return this;
        }
        public Long getCancelledAt() {
            return this.cancelledAt;
        }

        public ListAssistantRunResponseBodyData setCompletedAt(Long completedAt) {
            this.completedAt = completedAt;
            return this;
        }
        public Long getCompletedAt() {
            return this.completedAt;
        }

        public ListAssistantRunResponseBodyData setCreatedAt(Long createdAt) {
            this.createdAt = createdAt;
            return this;
        }
        public Long getCreatedAt() {
            return this.createdAt;
        }

        public ListAssistantRunResponseBodyData setExpiresAt(Long expiresAt) {
            this.expiresAt = expiresAt;
            return this;
        }
        public Long getExpiresAt() {
            return this.expiresAt;
        }

        public ListAssistantRunResponseBodyData setFailedAt(Long failedAt) {
            this.failedAt = failedAt;
            return this;
        }
        public Long getFailedAt() {
            return this.failedAt;
        }

        public ListAssistantRunResponseBodyData setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListAssistantRunResponseBodyData setLastErrorMsg(String lastErrorMsg) {
            this.lastErrorMsg = lastErrorMsg;
            return this;
        }
        public String getLastErrorMsg() {
            return this.lastErrorMsg;
        }

        public ListAssistantRunResponseBodyData setMetadata(java.util.Map<String, ?> metadata) {
            this.metadata = metadata;
            return this;
        }
        public java.util.Map<String, ?> getMetadata() {
            return this.metadata;
        }

        public ListAssistantRunResponseBodyData setObject(String object) {
            this.object = object;
            return this;
        }
        public String getObject() {
            return this.object;
        }

        public ListAssistantRunResponseBodyData setStartedAt(Long startedAt) {
            this.startedAt = startedAt;
            return this;
        }
        public Long getStartedAt() {
            return this.startedAt;
        }

        public ListAssistantRunResponseBodyData setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public ListAssistantRunResponseBodyData setThreadId(String threadId) {
            this.threadId = threadId;
            return this;
        }
        public String getThreadId() {
            return this.threadId;
        }

    }

}
