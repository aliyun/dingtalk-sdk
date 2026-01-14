// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_2_0.models;

import com.aliyun.tea.*;

public class CreateAssistantRunResponseBody extends TeaModel {
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

    @NameInMap("object")
    public String object;

    @NameInMap("startedAt")
    public Long startedAt;

    @NameInMap("status")
    public String status;

    @NameInMap("threadId")
    public String threadId;

    public static CreateAssistantRunResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateAssistantRunResponseBody self = new CreateAssistantRunResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateAssistantRunResponseBody setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

    public CreateAssistantRunResponseBody setCancelledAt(Long cancelledAt) {
        this.cancelledAt = cancelledAt;
        return this;
    }
    public Long getCancelledAt() {
        return this.cancelledAt;
    }

    public CreateAssistantRunResponseBody setCompletedAt(Long completedAt) {
        this.completedAt = completedAt;
        return this;
    }
    public Long getCompletedAt() {
        return this.completedAt;
    }

    public CreateAssistantRunResponseBody setCreatedAt(Long createdAt) {
        this.createdAt = createdAt;
        return this;
    }
    public Long getCreatedAt() {
        return this.createdAt;
    }

    public CreateAssistantRunResponseBody setExpiresAt(Long expiresAt) {
        this.expiresAt = expiresAt;
        return this;
    }
    public Long getExpiresAt() {
        return this.expiresAt;
    }

    public CreateAssistantRunResponseBody setFailedAt(Long failedAt) {
        this.failedAt = failedAt;
        return this;
    }
    public Long getFailedAt() {
        return this.failedAt;
    }

    public CreateAssistantRunResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public CreateAssistantRunResponseBody setLastErrorMsg(String lastErrorMsg) {
        this.lastErrorMsg = lastErrorMsg;
        return this;
    }
    public String getLastErrorMsg() {
        return this.lastErrorMsg;
    }

    public CreateAssistantRunResponseBody setObject(String object) {
        this.object = object;
        return this;
    }
    public String getObject() {
        return this.object;
    }

    public CreateAssistantRunResponseBody setStartedAt(Long startedAt) {
        this.startedAt = startedAt;
        return this;
    }
    public Long getStartedAt() {
        return this.startedAt;
    }

    public CreateAssistantRunResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public CreateAssistantRunResponseBody setThreadId(String threadId) {
        this.threadId = threadId;
        return this;
    }
    public String getThreadId() {
        return this.threadId;
    }

}
