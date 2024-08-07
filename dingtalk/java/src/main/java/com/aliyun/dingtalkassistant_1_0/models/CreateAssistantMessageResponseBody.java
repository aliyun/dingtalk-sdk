// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class CreateAssistantMessageResponseBody extends TeaModel {
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

    public static CreateAssistantMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateAssistantMessageResponseBody self = new CreateAssistantMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateAssistantMessageResponseBody setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

    public CreateAssistantMessageResponseBody setContent(java.util.List<?> content) {
        this.content = content;
        return this;
    }
    public java.util.List<?> getContent() {
        return this.content;
    }

    public CreateAssistantMessageResponseBody setCreatedAt(Long createdAt) {
        this.createdAt = createdAt;
        return this;
    }
    public Long getCreatedAt() {
        return this.createdAt;
    }

    public CreateAssistantMessageResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public CreateAssistantMessageResponseBody setMetadata(java.util.Map<String, ?> metadata) {
        this.metadata = metadata;
        return this;
    }
    public java.util.Map<String, ?> getMetadata() {
        return this.metadata;
    }

    public CreateAssistantMessageResponseBody setObject(String object) {
        this.object = object;
        return this;
    }
    public String getObject() {
        return this.object;
    }

    public CreateAssistantMessageResponseBody setRole(String role) {
        this.role = role;
        return this;
    }
    public String getRole() {
        return this.role;
    }

    public CreateAssistantMessageResponseBody setRunId(String runId) {
        this.runId = runId;
        return this;
    }
    public String getRunId() {
        return this.runId;
    }

    public CreateAssistantMessageResponseBody setThreadId(String threadId) {
        this.threadId = threadId;
        return this;
    }
    public String getThreadId() {
        return this.threadId;
    }

}
