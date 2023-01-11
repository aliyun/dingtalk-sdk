// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class GetTodoTaskBySourceIdResponseBody extends TeaModel {
    /**
     * <p>接入业务应用标识</p>
     */
    @NameInMap("bizTag")
    public String bizTag;

    /**
     * <p>创建时间</p>
     */
    @NameInMap("createdTime")
    public Long createdTime;

    /**
     * <p>创建者id（用户的unionId）</p>
     */
    @NameInMap("creatorId")
    public String creatorId;

    /**
     * <p>描述</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>自定义详情页跳转配置</p>
     */
    @NameInMap("detailUrl")
    public GetTodoTaskBySourceIdResponseBodyDetailUrl detailUrl;

    /**
     * <p>完成状态</p>
     */
    @NameInMap("done")
    public Boolean done;

    /**
     * <p>截止时间</p>
     */
    @NameInMap("dueTime")
    public Long dueTime;

    /**
     * <p>执行者列表（用户的unionId）</p>
     */
    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    /**
     * <p>完成时间</p>
     */
    @NameInMap("finishTime")
    public Long finishTime;

    /**
     * <p>id</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <p>待办是否仅展示在执行人的待办列表中</p>
     */
    @NameInMap("isOnlyShowExecutor")
    public Boolean isOnlyShowExecutor;

    /**
     * <p>更新时间</p>
     */
    @NameInMap("modifiedTime")
    public Long modifiedTime;

    /**
     * <p>更新者id（用户的unionId）</p>
     */
    @NameInMap("modifierId")
    public String modifierId;

    /**
     * <p>参与者列表（用户的unionId）</p>
     */
    @NameInMap("participantIds")
    public java.util.List<String> participantIds;

    /**
     * <p>优先级, 较低:10, 普通:20, 紧急:30, 非常紧急:40</p>
     */
    @NameInMap("priority")
    public Integer priority;

    /**
     * <p>requestId</p>
     */
    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>业务来源</p>
     */
    @NameInMap("source")
    public String source;

    /**
     * <p>业务来源id</p>
     */
    @NameInMap("sourceId")
    public String sourceId;

    /**
     * <p>开始时间</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>标题</p>
     */
    @NameInMap("subject")
    public String subject;

    /**
     * <p>租户id(unionId/orgId/groupId)</p>
     */
    @NameInMap("tenantId")
    public String tenantId;

    /**
     * <p>租户类型（user/org/group）</p>
     */
    @NameInMap("tenantType")
    public String tenantType;

    public static GetTodoTaskBySourceIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTodoTaskBySourceIdResponseBody self = new GetTodoTaskBySourceIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTodoTaskBySourceIdResponseBody setBizTag(String bizTag) {
        this.bizTag = bizTag;
        return this;
    }
    public String getBizTag() {
        return this.bizTag;
    }

    public GetTodoTaskBySourceIdResponseBody setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public GetTodoTaskBySourceIdResponseBody setCreatorId(String creatorId) {
        this.creatorId = creatorId;
        return this;
    }
    public String getCreatorId() {
        return this.creatorId;
    }

    public GetTodoTaskBySourceIdResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetTodoTaskBySourceIdResponseBody setDetailUrl(GetTodoTaskBySourceIdResponseBodyDetailUrl detailUrl) {
        this.detailUrl = detailUrl;
        return this;
    }
    public GetTodoTaskBySourceIdResponseBodyDetailUrl getDetailUrl() {
        return this.detailUrl;
    }

    public GetTodoTaskBySourceIdResponseBody setDone(Boolean done) {
        this.done = done;
        return this;
    }
    public Boolean getDone() {
        return this.done;
    }

    public GetTodoTaskBySourceIdResponseBody setDueTime(Long dueTime) {
        this.dueTime = dueTime;
        return this;
    }
    public Long getDueTime() {
        return this.dueTime;
    }

    public GetTodoTaskBySourceIdResponseBody setExecutorIds(java.util.List<String> executorIds) {
        this.executorIds = executorIds;
        return this;
    }
    public java.util.List<String> getExecutorIds() {
        return this.executorIds;
    }

    public GetTodoTaskBySourceIdResponseBody setFinishTime(Long finishTime) {
        this.finishTime = finishTime;
        return this;
    }
    public Long getFinishTime() {
        return this.finishTime;
    }

    public GetTodoTaskBySourceIdResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public GetTodoTaskBySourceIdResponseBody setIsOnlyShowExecutor(Boolean isOnlyShowExecutor) {
        this.isOnlyShowExecutor = isOnlyShowExecutor;
        return this;
    }
    public Boolean getIsOnlyShowExecutor() {
        return this.isOnlyShowExecutor;
    }

    public GetTodoTaskBySourceIdResponseBody setModifiedTime(Long modifiedTime) {
        this.modifiedTime = modifiedTime;
        return this;
    }
    public Long getModifiedTime() {
        return this.modifiedTime;
    }

    public GetTodoTaskBySourceIdResponseBody setModifierId(String modifierId) {
        this.modifierId = modifierId;
        return this;
    }
    public String getModifierId() {
        return this.modifierId;
    }

    public GetTodoTaskBySourceIdResponseBody setParticipantIds(java.util.List<String> participantIds) {
        this.participantIds = participantIds;
        return this;
    }
    public java.util.List<String> getParticipantIds() {
        return this.participantIds;
    }

    public GetTodoTaskBySourceIdResponseBody setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

    public GetTodoTaskBySourceIdResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetTodoTaskBySourceIdResponseBody setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public GetTodoTaskBySourceIdResponseBody setSourceId(String sourceId) {
        this.sourceId = sourceId;
        return this;
    }
    public String getSourceId() {
        return this.sourceId;
    }

    public GetTodoTaskBySourceIdResponseBody setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public GetTodoTaskBySourceIdResponseBody setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public GetTodoTaskBySourceIdResponseBody setTenantId(String tenantId) {
        this.tenantId = tenantId;
        return this;
    }
    public String getTenantId() {
        return this.tenantId;
    }

    public GetTodoTaskBySourceIdResponseBody setTenantType(String tenantType) {
        this.tenantType = tenantType;
        return this;
    }
    public String getTenantType() {
        return this.tenantType;
    }

    public static class GetTodoTaskBySourceIdResponseBodyDetailUrl extends TeaModel {
        /**
         * <p>app端详情页地址</p>
         */
        @NameInMap("appUrl")
        public String appUrl;

        /**
         * <p>pc端详情页地址</p>
         */
        @NameInMap("pcUrl")
        public String pcUrl;

        public static GetTodoTaskBySourceIdResponseBodyDetailUrl build(java.util.Map<String, ?> map) throws Exception {
            GetTodoTaskBySourceIdResponseBodyDetailUrl self = new GetTodoTaskBySourceIdResponseBodyDetailUrl();
            return TeaModel.build(map, self);
        }

        public GetTodoTaskBySourceIdResponseBodyDetailUrl setAppUrl(String appUrl) {
            this.appUrl = appUrl;
            return this;
        }
        public String getAppUrl() {
            return this.appUrl;
        }

        public GetTodoTaskBySourceIdResponseBodyDetailUrl setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

    }

}
