// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class GetTodoTaskResponseBody extends TeaModel {
    // 接入业务应用标识
    @NameInMap("bizTag")
    public String bizTag;

    // 待办卡片类型id
    @NameInMap("cardTypeId")
    public String cardTypeId;

    // 创建时间
    @NameInMap("createdTime")
    public Long createdTime;

    // 创建者id（用户的unionId）
    @NameInMap("creatorId")
    public String creatorId;

    // 描述
    @NameInMap("description")
    public String description;

    // 自定义详情页跳转配置
    @NameInMap("detailUrl")
    public GetTodoTaskResponseBodyDetailUrl detailUrl;

    // 完成状态
    @NameInMap("done")
    public Boolean done;

    // 截止时间
    @NameInMap("dueTime")
    public Long dueTime;

    // 执行者列表（用户的unionId）
    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    // 完成时间
    @NameInMap("finishTime")
    public Long finishTime;

    // id
    @NameInMap("id")
    public String id;

    // 待办是否仅展示在执行人的待办列表中
    @NameInMap("isOnlyShowExecutor")
    public Boolean isOnlyShowExecutor;

    // 更新时间
    @NameInMap("modifiedTime")
    public Long modifiedTime;

    // 更新者id（用户的unionId）
    @NameInMap("modifierId")
    public String modifierId;

    // 参与者列表（用户的unionId）
    @NameInMap("participantIds")
    public java.util.List<String> participantIds;

    // 优先级, 较低:10, 普通:20, 紧急:30, 非常紧急:40
    @NameInMap("priority")
    public Integer priority;

    // requestId
    @NameInMap("requestId")
    public String requestId;

    // 业务来源
    @NameInMap("source")
    public String source;

    // 业务来源id
    @NameInMap("sourceId")
    public String sourceId;

    // 开始时间
    @NameInMap("startTime")
    public Long startTime;

    // 标题
    @NameInMap("subject")
    public String subject;

    // 租户id(unionId/orgId/groupId)
    @NameInMap("tenantId")
    public String tenantId;

    // 租户类型（user/org/group）
    @NameInMap("tenantType")
    public String tenantType;

    public static GetTodoTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTodoTaskResponseBody self = new GetTodoTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTodoTaskResponseBody setBizTag(String bizTag) {
        this.bizTag = bizTag;
        return this;
    }
    public String getBizTag() {
        return this.bizTag;
    }

    public GetTodoTaskResponseBody setCardTypeId(String cardTypeId) {
        this.cardTypeId = cardTypeId;
        return this;
    }
    public String getCardTypeId() {
        return this.cardTypeId;
    }

    public GetTodoTaskResponseBody setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public GetTodoTaskResponseBody setCreatorId(String creatorId) {
        this.creatorId = creatorId;
        return this;
    }
    public String getCreatorId() {
        return this.creatorId;
    }

    public GetTodoTaskResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetTodoTaskResponseBody setDetailUrl(GetTodoTaskResponseBodyDetailUrl detailUrl) {
        this.detailUrl = detailUrl;
        return this;
    }
    public GetTodoTaskResponseBodyDetailUrl getDetailUrl() {
        return this.detailUrl;
    }

    public GetTodoTaskResponseBody setDone(Boolean done) {
        this.done = done;
        return this;
    }
    public Boolean getDone() {
        return this.done;
    }

    public GetTodoTaskResponseBody setDueTime(Long dueTime) {
        this.dueTime = dueTime;
        return this;
    }
    public Long getDueTime() {
        return this.dueTime;
    }

    public GetTodoTaskResponseBody setExecutorIds(java.util.List<String> executorIds) {
        this.executorIds = executorIds;
        return this;
    }
    public java.util.List<String> getExecutorIds() {
        return this.executorIds;
    }

    public GetTodoTaskResponseBody setFinishTime(Long finishTime) {
        this.finishTime = finishTime;
        return this;
    }
    public Long getFinishTime() {
        return this.finishTime;
    }

    public GetTodoTaskResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public GetTodoTaskResponseBody setIsOnlyShowExecutor(Boolean isOnlyShowExecutor) {
        this.isOnlyShowExecutor = isOnlyShowExecutor;
        return this;
    }
    public Boolean getIsOnlyShowExecutor() {
        return this.isOnlyShowExecutor;
    }

    public GetTodoTaskResponseBody setModifiedTime(Long modifiedTime) {
        this.modifiedTime = modifiedTime;
        return this;
    }
    public Long getModifiedTime() {
        return this.modifiedTime;
    }

    public GetTodoTaskResponseBody setModifierId(String modifierId) {
        this.modifierId = modifierId;
        return this;
    }
    public String getModifierId() {
        return this.modifierId;
    }

    public GetTodoTaskResponseBody setParticipantIds(java.util.List<String> participantIds) {
        this.participantIds = participantIds;
        return this;
    }
    public java.util.List<String> getParticipantIds() {
        return this.participantIds;
    }

    public GetTodoTaskResponseBody setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

    public GetTodoTaskResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetTodoTaskResponseBody setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public GetTodoTaskResponseBody setSourceId(String sourceId) {
        this.sourceId = sourceId;
        return this;
    }
    public String getSourceId() {
        return this.sourceId;
    }

    public GetTodoTaskResponseBody setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public GetTodoTaskResponseBody setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public GetTodoTaskResponseBody setTenantId(String tenantId) {
        this.tenantId = tenantId;
        return this;
    }
    public String getTenantId() {
        return this.tenantId;
    }

    public GetTodoTaskResponseBody setTenantType(String tenantType) {
        this.tenantType = tenantType;
        return this;
    }
    public String getTenantType() {
        return this.tenantType;
    }

    public static class GetTodoTaskResponseBodyDetailUrl extends TeaModel {
        // app端详情页地址
        @NameInMap("appUrl")
        public String appUrl;

        // pc端详情页地址
        @NameInMap("pcUrl")
        public String pcUrl;

        public static GetTodoTaskResponseBodyDetailUrl build(java.util.Map<String, ?> map) throws Exception {
            GetTodoTaskResponseBodyDetailUrl self = new GetTodoTaskResponseBodyDetailUrl();
            return TeaModel.build(map, self);
        }

        public GetTodoTaskResponseBodyDetailUrl setAppUrl(String appUrl) {
            this.appUrl = appUrl;
            return this;
        }
        public String getAppUrl() {
            return this.appUrl;
        }

        public GetTodoTaskResponseBodyDetailUrl setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

    }

}
