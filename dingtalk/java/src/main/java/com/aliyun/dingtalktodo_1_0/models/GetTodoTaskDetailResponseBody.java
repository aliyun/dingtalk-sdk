// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class GetTodoTaskDetailResponseBody extends TeaModel {
    // 接入业务应用标识
    @NameInMap("bizTag")
    public String bizTag;

    // 所属分类
    @NameInMap("category")
    public String category;

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
    public GetTodoTaskDetailResponseBodyDetailUrl detailUrl;

    // 完成状态
    @NameInMap("done")
    public Boolean done;

    // 截止时间
    @NameInMap("dueTime")
    public Long dueTime;

    // 执行者列表（用户的unionId）
    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    // 执行者待办完成状态列表
    @NameInMap("executorStatus")
    public java.util.List<GetTodoTaskDetailResponseBodyExecutorStatus> executorStatus;

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

    // 所属组织信息
    @NameInMap("orgInfo")
    public GetTodoTaskDetailResponseBodyOrgInfo orgInfo;

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

    public static GetTodoTaskDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTodoTaskDetailResponseBody self = new GetTodoTaskDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTodoTaskDetailResponseBody setBizTag(String bizTag) {
        this.bizTag = bizTag;
        return this;
    }
    public String getBizTag() {
        return this.bizTag;
    }

    public GetTodoTaskDetailResponseBody setCategory(String category) {
        this.category = category;
        return this;
    }
    public String getCategory() {
        return this.category;
    }

    public GetTodoTaskDetailResponseBody setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public GetTodoTaskDetailResponseBody setCreatorId(String creatorId) {
        this.creatorId = creatorId;
        return this;
    }
    public String getCreatorId() {
        return this.creatorId;
    }

    public GetTodoTaskDetailResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetTodoTaskDetailResponseBody setDetailUrl(GetTodoTaskDetailResponseBodyDetailUrl detailUrl) {
        this.detailUrl = detailUrl;
        return this;
    }
    public GetTodoTaskDetailResponseBodyDetailUrl getDetailUrl() {
        return this.detailUrl;
    }

    public GetTodoTaskDetailResponseBody setDone(Boolean done) {
        this.done = done;
        return this;
    }
    public Boolean getDone() {
        return this.done;
    }

    public GetTodoTaskDetailResponseBody setDueTime(Long dueTime) {
        this.dueTime = dueTime;
        return this;
    }
    public Long getDueTime() {
        return this.dueTime;
    }

    public GetTodoTaskDetailResponseBody setExecutorIds(java.util.List<String> executorIds) {
        this.executorIds = executorIds;
        return this;
    }
    public java.util.List<String> getExecutorIds() {
        return this.executorIds;
    }

    public GetTodoTaskDetailResponseBody setExecutorStatus(java.util.List<GetTodoTaskDetailResponseBodyExecutorStatus> executorStatus) {
        this.executorStatus = executorStatus;
        return this;
    }
    public java.util.List<GetTodoTaskDetailResponseBodyExecutorStatus> getExecutorStatus() {
        return this.executorStatus;
    }

    public GetTodoTaskDetailResponseBody setFinishTime(Long finishTime) {
        this.finishTime = finishTime;
        return this;
    }
    public Long getFinishTime() {
        return this.finishTime;
    }

    public GetTodoTaskDetailResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public GetTodoTaskDetailResponseBody setIsOnlyShowExecutor(Boolean isOnlyShowExecutor) {
        this.isOnlyShowExecutor = isOnlyShowExecutor;
        return this;
    }
    public Boolean getIsOnlyShowExecutor() {
        return this.isOnlyShowExecutor;
    }

    public GetTodoTaskDetailResponseBody setModifiedTime(Long modifiedTime) {
        this.modifiedTime = modifiedTime;
        return this;
    }
    public Long getModifiedTime() {
        return this.modifiedTime;
    }

    public GetTodoTaskDetailResponseBody setModifierId(String modifierId) {
        this.modifierId = modifierId;
        return this;
    }
    public String getModifierId() {
        return this.modifierId;
    }

    public GetTodoTaskDetailResponseBody setOrgInfo(GetTodoTaskDetailResponseBodyOrgInfo orgInfo) {
        this.orgInfo = orgInfo;
        return this;
    }
    public GetTodoTaskDetailResponseBodyOrgInfo getOrgInfo() {
        return this.orgInfo;
    }

    public GetTodoTaskDetailResponseBody setParticipantIds(java.util.List<String> participantIds) {
        this.participantIds = participantIds;
        return this;
    }
    public java.util.List<String> getParticipantIds() {
        return this.participantIds;
    }

    public GetTodoTaskDetailResponseBody setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

    public GetTodoTaskDetailResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetTodoTaskDetailResponseBody setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public GetTodoTaskDetailResponseBody setSourceId(String sourceId) {
        this.sourceId = sourceId;
        return this;
    }
    public String getSourceId() {
        return this.sourceId;
    }

    public GetTodoTaskDetailResponseBody setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public GetTodoTaskDetailResponseBody setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public GetTodoTaskDetailResponseBody setTenantId(String tenantId) {
        this.tenantId = tenantId;
        return this;
    }
    public String getTenantId() {
        return this.tenantId;
    }

    public GetTodoTaskDetailResponseBody setTenantType(String tenantType) {
        this.tenantType = tenantType;
        return this;
    }
    public String getTenantType() {
        return this.tenantType;
    }

    public static class GetTodoTaskDetailResponseBodyDetailUrl extends TeaModel {
        // app端详情页地址
        @NameInMap("appUrl")
        public String appUrl;

        // pc端详情页地址
        @NameInMap("pcUrl")
        public String pcUrl;

        public static GetTodoTaskDetailResponseBodyDetailUrl build(java.util.Map<String, ?> map) throws Exception {
            GetTodoTaskDetailResponseBodyDetailUrl self = new GetTodoTaskDetailResponseBodyDetailUrl();
            return TeaModel.build(map, self);
        }

        public GetTodoTaskDetailResponseBodyDetailUrl setAppUrl(String appUrl) {
            this.appUrl = appUrl;
            return this;
        }
        public String getAppUrl() {
            return this.appUrl;
        }

        public GetTodoTaskDetailResponseBodyDetailUrl setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

    }

    public static class GetTodoTaskDetailResponseBodyExecutorStatus extends TeaModel {
        // 执行者完成状态
        @NameInMap("isDone")
        public Boolean isDone;

        // 执行者id（用户的unionId）
        @NameInMap("userId")
        public String userId;

        public static GetTodoTaskDetailResponseBodyExecutorStatus build(java.util.Map<String, ?> map) throws Exception {
            GetTodoTaskDetailResponseBodyExecutorStatus self = new GetTodoTaskDetailResponseBodyExecutorStatus();
            return TeaModel.build(map, self);
        }

        public GetTodoTaskDetailResponseBodyExecutorStatus setIsDone(Boolean isDone) {
            this.isDone = isDone;
            return this;
        }
        public Boolean getIsDone() {
            return this.isDone;
        }

        public GetTodoTaskDetailResponseBodyExecutorStatus setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class GetTodoTaskDetailResponseBodyOrgInfo extends TeaModel {
        // 组织corpId
        @NameInMap("corpId")
        public String corpId;

        // 组织名称
        @NameInMap("name")
        public String name;

        public static GetTodoTaskDetailResponseBodyOrgInfo build(java.util.Map<String, ?> map) throws Exception {
            GetTodoTaskDetailResponseBodyOrgInfo self = new GetTodoTaskDetailResponseBodyOrgInfo();
            return TeaModel.build(map, self);
        }

        public GetTodoTaskDetailResponseBodyOrgInfo setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetTodoTaskDetailResponseBodyOrgInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
