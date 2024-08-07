// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class ListAssistantMessageResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<ListAssistantMessageResponseBodyData> data;

    @NameInMap("object")
    public String object;

    public static ListAssistantMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListAssistantMessageResponseBody self = new ListAssistantMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public ListAssistantMessageResponseBody setData(java.util.List<ListAssistantMessageResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<ListAssistantMessageResponseBodyData> getData() {
        return this.data;
    }

    public ListAssistantMessageResponseBody setObject(String object) {
        this.object = object;
        return this;
    }
    public String getObject() {
        return this.object;
    }

    public static class ListAssistantMessageResponseBodyData extends TeaModel {
        @NameInMap("assistantId")
        public String assistantId;

        @NameInMap("content")
        public java.util.List<?> content;

        @NameInMap("createdAt")
        public Long createdAt;

        @NameInMap("id")
        public String id;

        @NameInMap("metadata")
        public java.util.Map<String, ?> metadata;

        @NameInMap("object")
        public String object;

        @NameInMap("role")
        public String role;

        @NameInMap("runId")
        public String runId;

        @NameInMap("threadId")
        public String threadId;

        public static ListAssistantMessageResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            ListAssistantMessageResponseBodyData self = new ListAssistantMessageResponseBodyData();
            return TeaModel.build(map, self);
        }

        public ListAssistantMessageResponseBodyData setAssistantId(String assistantId) {
            this.assistantId = assistantId;
            return this;
        }
        public String getAssistantId() {
            return this.assistantId;
        }

        public ListAssistantMessageResponseBodyData setContent(java.util.List<?> content) {
            this.content = content;
            return this;
        }
        public java.util.List<?> getContent() {
            return this.content;
        }

        public ListAssistantMessageResponseBodyData setCreatedAt(Long createdAt) {
            this.createdAt = createdAt;
            return this;
        }
        public Long getCreatedAt() {
            return this.createdAt;
        }

        public ListAssistantMessageResponseBodyData setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListAssistantMessageResponseBodyData setMetadata(java.util.Map<String, ?> metadata) {
            this.metadata = metadata;
            return this;
        }
        public java.util.Map<String, ?> getMetadata() {
            return this.metadata;
        }

        public ListAssistantMessageResponseBodyData setObject(String object) {
            this.object = object;
            return this;
        }
        public String getObject() {
            return this.object;
        }

        public ListAssistantMessageResponseBodyData setRole(String role) {
            this.role = role;
            return this;
        }
        public String getRole() {
            return this.role;
        }

        public ListAssistantMessageResponseBodyData setRunId(String runId) {
            this.runId = runId;
            return this;
        }
        public String getRunId() {
            return this.runId;
        }

        public ListAssistantMessageResponseBodyData setThreadId(String threadId) {
            this.threadId = threadId;
            return this;
        }
        public String getThreadId() {
            return this.threadId;
        }

    }

}
