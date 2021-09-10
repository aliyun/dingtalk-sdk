// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class CreateTodoTaskResponseBody extends TeaModel {
    // id
    @NameInMap("id")
    public String id;

    // 标题
    @NameInMap("subject")
    public String subject;

    // 描述
    @NameInMap("description")
    public String description;

    // 开始时间
    @NameInMap("startTime")
    public Long startTime;

    // 截止时间
    @NameInMap("dueTime")
    public Long dueTime;

    // 完成时间
    @NameInMap("finishTime")
    public Long finishTime;

    // 完成状态
    @NameInMap("done")
    public Boolean done;

    // 执行者列表（用户的unionId）
    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    // 参与者列表（用户的unionId）
    @NameInMap("participantIds")
    public java.util.List<String> participantIds;

    // 自定义详情页跳转配置
    @NameInMap("detailUrl")
    public CreateTodoTaskResponseBodyDetailUrl detailUrl;

    // 业务来源
    @NameInMap("source")
    public String source;

    // 业务来源id
    @NameInMap("sourceId")
    public String sourceId;

    // 创建时间
    @NameInMap("createdTime")
    public Long createdTime;

    // 更新时间
    @NameInMap("modifiedTime")
    public Long modifiedTime;

    // 创建者（用户的unionId）
    @NameInMap("creatorId")
    public String creatorId;

    // 更新者（用户的unionId）
    @NameInMap("modifierId")
    public String modifierId;

    // 接入应用标识
    @NameInMap("bizTag")
    public String bizTag;

    // requestId
    @NameInMap("requestId")
    public String requestId;

    // 生成的待办是否仅展示在执行者的待办列表中
    @NameInMap("isOnlyShowExecutor")
    public Boolean isOnlyShowExecutor;

    // 优先级, 较低:10, 普通:20, 紧急:30, 非常紧急:40
    @NameInMap("priority")
    public Integer priority;

    public static CreateTodoTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateTodoTaskResponseBody self = new CreateTodoTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateTodoTaskResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public CreateTodoTaskResponseBody setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public CreateTodoTaskResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateTodoTaskResponseBody setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public CreateTodoTaskResponseBody setDueTime(Long dueTime) {
        this.dueTime = dueTime;
        return this;
    }
    public Long getDueTime() {
        return this.dueTime;
    }

    public CreateTodoTaskResponseBody setFinishTime(Long finishTime) {
        this.finishTime = finishTime;
        return this;
    }
    public Long getFinishTime() {
        return this.finishTime;
    }

    public CreateTodoTaskResponseBody setDone(Boolean done) {
        this.done = done;
        return this;
    }
    public Boolean getDone() {
        return this.done;
    }

    public CreateTodoTaskResponseBody setExecutorIds(java.util.List<String> executorIds) {
        this.executorIds = executorIds;
        return this;
    }
    public java.util.List<String> getExecutorIds() {
        return this.executorIds;
    }

    public CreateTodoTaskResponseBody setParticipantIds(java.util.List<String> participantIds) {
        this.participantIds = participantIds;
        return this;
    }
    public java.util.List<String> getParticipantIds() {
        return this.participantIds;
    }

    public CreateTodoTaskResponseBody setDetailUrl(CreateTodoTaskResponseBodyDetailUrl detailUrl) {
        this.detailUrl = detailUrl;
        return this;
    }
    public CreateTodoTaskResponseBodyDetailUrl getDetailUrl() {
        return this.detailUrl;
    }

    public CreateTodoTaskResponseBody setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public CreateTodoTaskResponseBody setSourceId(String sourceId) {
        this.sourceId = sourceId;
        return this;
    }
    public String getSourceId() {
        return this.sourceId;
    }

    public CreateTodoTaskResponseBody setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public CreateTodoTaskResponseBody setModifiedTime(Long modifiedTime) {
        this.modifiedTime = modifiedTime;
        return this;
    }
    public Long getModifiedTime() {
        return this.modifiedTime;
    }

    public CreateTodoTaskResponseBody setCreatorId(String creatorId) {
        this.creatorId = creatorId;
        return this;
    }
    public String getCreatorId() {
        return this.creatorId;
    }

    public CreateTodoTaskResponseBody setModifierId(String modifierId) {
        this.modifierId = modifierId;
        return this;
    }
    public String getModifierId() {
        return this.modifierId;
    }

    public CreateTodoTaskResponseBody setBizTag(String bizTag) {
        this.bizTag = bizTag;
        return this;
    }
    public String getBizTag() {
        return this.bizTag;
    }

    public CreateTodoTaskResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public CreateTodoTaskResponseBody setIsOnlyShowExecutor(Boolean isOnlyShowExecutor) {
        this.isOnlyShowExecutor = isOnlyShowExecutor;
        return this;
    }
    public Boolean getIsOnlyShowExecutor() {
        return this.isOnlyShowExecutor;
    }

    public CreateTodoTaskResponseBody setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

    public static class CreateTodoTaskResponseBodyDetailUrl extends TeaModel {
        // pc端详情页地址
        @NameInMap("pcUrl")
        public String pcUrl;

        // app端详情页地址
        @NameInMap("appUrl")
        public String appUrl;

        public static CreateTodoTaskResponseBodyDetailUrl build(java.util.Map<String, ?> map) throws Exception {
            CreateTodoTaskResponseBodyDetailUrl self = new CreateTodoTaskResponseBodyDetailUrl();
            return TeaModel.build(map, self);
        }

        public CreateTodoTaskResponseBodyDetailUrl setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public CreateTodoTaskResponseBodyDetailUrl setAppUrl(String appUrl) {
            this.appUrl = appUrl;
            return this;
        }
        public String getAppUrl() {
            return this.appUrl;
        }

    }

}
