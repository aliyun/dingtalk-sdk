// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class RetrieveAssistantRunResponseBody extends TeaModel {
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

    public static RetrieveAssistantRunResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RetrieveAssistantRunResponseBody self = new RetrieveAssistantRunResponseBody();
        return TeaModel.build(map, self);
    }

    public RetrieveAssistantRunResponseBody setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

    public RetrieveAssistantRunResponseBody setCancelledAt(Long cancelledAt) {
        this.cancelledAt = cancelledAt;
        return this;
    }
    public Long getCancelledAt() {
        return this.cancelledAt;
    }

    public RetrieveAssistantRunResponseBody setCompletedAt(Long completedAt) {
        this.completedAt = completedAt;
        return this;
    }
    public Long getCompletedAt() {
        return this.completedAt;
    }

    public RetrieveAssistantRunResponseBody setCreatedAt(Long createdAt) {
        this.createdAt = createdAt;
        return this;
    }
    public Long getCreatedAt() {
        return this.createdAt;
    }

    public RetrieveAssistantRunResponseBody setExpiresAt(Long expiresAt) {
        this.expiresAt = expiresAt;
        return this;
    }
    public Long getExpiresAt() {
        return this.expiresAt;
    }

    public RetrieveAssistantRunResponseBody setFailedAt(Long failedAt) {
        this.failedAt = failedAt;
        return this;
    }
    public Long getFailedAt() {
        return this.failedAt;
    }

    public RetrieveAssistantRunResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public RetrieveAssistantRunResponseBody setLastErrorMsg(String lastErrorMsg) {
        this.lastErrorMsg = lastErrorMsg;
        return this;
    }
    public String getLastErrorMsg() {
        return this.lastErrorMsg;
    }

    public RetrieveAssistantRunResponseBody setMetadata(java.util.Map<String, ?> metadata) {
        this.metadata = metadata;
        return this;
    }
    public java.util.Map<String, ?> getMetadata() {
        return this.metadata;
    }

    public RetrieveAssistantRunResponseBody setObject(String object) {
        this.object = object;
        return this;
    }
    public String getObject() {
        return this.object;
    }

    public RetrieveAssistantRunResponseBody setStartedAt(Long startedAt) {
        this.startedAt = startedAt;
        return this;
    }
    public Long getStartedAt() {
        return this.startedAt;
    }

    public RetrieveAssistantRunResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public RetrieveAssistantRunResponseBody setThreadId(String threadId) {
        this.threadId = threadId;
        return this;
    }
    public String getThreadId() {
        return this.threadId;
    }

}
