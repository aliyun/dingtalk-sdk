// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class GetTodoTaskDetailResponseBody extends TeaModel {
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
    public GetTodoTaskDetailResponseBodyDetailUrl detailUrl;

    // 业务来源id
    @NameInMap("sourceId")
    public String sourceId;

    // 业务来源
    @NameInMap("source")
    public String source;

    // 创建时间
    @NameInMap("createdTime")
    public Long createdTime;

    // 更新时间
    @NameInMap("modifiedTime")
    public Long modifiedTime;

    // 创建者id（用户的unionId）
    @NameInMap("creatorId")
    public String creatorId;

    // 更新者id（用户的unionId）
    @NameInMap("modifierId")
    public String modifierId;

    // 租户id(unionId/orgId/groupId)
    @NameInMap("tenantId")
    public String tenantId;

    // 租户类型（user/org/group）
    @NameInMap("tenantType")
    public String tenantType;

    // 接入业务应用标识
    @NameInMap("bizTag")
    public String bizTag;

    // requestId
    @NameInMap("requestId")
    public String requestId;

    // 所属分类
    @NameInMap("category")
    public String category;

    // 所属组织信息
    @NameInMap("orgInfo")
    public GetTodoTaskDetailResponseBodyOrgInfo orgInfo;

    // 执行者待办完成状态列表
    @NameInMap("executorStatus")
    public java.util.List<GetTodoTaskDetailResponseBodyExecutorStatus> executorStatus;

    public static GetTodoTaskDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTodoTaskDetailResponseBody self = new GetTodoTaskDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTodoTaskDetailResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public GetTodoTaskDetailResponseBody setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public GetTodoTaskDetailResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetTodoTaskDetailResponseBody setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public GetTodoTaskDetailResponseBody setDueTime(Long dueTime) {
        this.dueTime = dueTime;
        return this;
    }
    public Long getDueTime() {
        return this.dueTime;
    }

    public GetTodoTaskDetailResponseBody setFinishTime(Long finishTime) {
        this.finishTime = finishTime;
        return this;
    }
    public Long getFinishTime() {
        return this.finishTime;
    }

    public GetTodoTaskDetailResponseBody setDone(Boolean done) {
        this.done = done;
        return this;
    }
    public Boolean getDone() {
        return this.done;
    }

    public GetTodoTaskDetailResponseBody setExecutorIds(java.util.List<String> executorIds) {
        this.executorIds = executorIds;
        return this;
    }
    public java.util.List<String> getExecutorIds() {
        return this.executorIds;
    }

    public GetTodoTaskDetailResponseBody setParticipantIds(java.util.List<String> participantIds) {
        this.participantIds = participantIds;
        return this;
    }
    public java.util.List<String> getParticipantIds() {
        return this.participantIds;
    }

    public GetTodoTaskDetailResponseBody setDetailUrl(GetTodoTaskDetailResponseBodyDetailUrl detailUrl) {
        this.detailUrl = detailUrl;
        return this;
    }
    public GetTodoTaskDetailResponseBodyDetailUrl getDetailUrl() {
        return this.detailUrl;
    }

    public GetTodoTaskDetailResponseBody setSourceId(String sourceId) {
        this.sourceId = sourceId;
        return this;
    }
    public String getSourceId() {
        return this.sourceId;
    }

    public GetTodoTaskDetailResponseBody setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public GetTodoTaskDetailResponseBody setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public GetTodoTaskDetailResponseBody setModifiedTime(Long modifiedTime) {
        this.modifiedTime = modifiedTime;
        return this;
    }
    public Long getModifiedTime() {
        return this.modifiedTime;
    }

    public GetTodoTaskDetailResponseBody setCreatorId(String creatorId) {
        this.creatorId = creatorId;
        return this;
    }
    public String getCreatorId() {
        return this.creatorId;
    }

    public GetTodoTaskDetailResponseBody setModifierId(String modifierId) {
        this.modifierId = modifierId;
        return this;
    }
    public String getModifierId() {
        return this.modifierId;
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

    public GetTodoTaskDetailResponseBody setBizTag(String bizTag) {
        this.bizTag = bizTag;
        return this;
    }
    public String getBizTag() {
        return this.bizTag;
    }

    public GetTodoTaskDetailResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetTodoTaskDetailResponseBody setCategory(String category) {
        this.category = category;
        return this;
    }
    public String getCategory() {
        return this.category;
    }

    public GetTodoTaskDetailResponseBody setOrgInfo(GetTodoTaskDetailResponseBodyOrgInfo orgInfo) {
        this.orgInfo = orgInfo;
        return this;
    }
    public GetTodoTaskDetailResponseBodyOrgInfo getOrgInfo() {
        return this.orgInfo;
    }

    public GetTodoTaskDetailResponseBody setExecutorStatus(java.util.List<GetTodoTaskDetailResponseBodyExecutorStatus> executorStatus) {
        this.executorStatus = executorStatus;
        return this;
    }
    public java.util.List<GetTodoTaskDetailResponseBodyExecutorStatus> getExecutorStatus() {
        return this.executorStatus;
    }

    public static class GetTodoTaskDetailResponseBodyDetailUrl extends TeaModel {
        // pc端详情页地址
        @NameInMap("pcUrl")
        public String pcUrl;

        // app端详情页地址
        @NameInMap("appUrl")
        public String appUrl;

        public static GetTodoTaskDetailResponseBodyDetailUrl build(java.util.Map<String, ?> map) throws Exception {
            GetTodoTaskDetailResponseBodyDetailUrl self = new GetTodoTaskDetailResponseBodyDetailUrl();
            return TeaModel.build(map, self);
        }

        public GetTodoTaskDetailResponseBodyDetailUrl setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public GetTodoTaskDetailResponseBodyDetailUrl setAppUrl(String appUrl) {
            this.appUrl = appUrl;
            return this;
        }
        public String getAppUrl() {
            return this.appUrl;
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

    public static class GetTodoTaskDetailResponseBodyExecutorStatus extends TeaModel {
        // 执行者id（用户的unionId）
        @NameInMap("userId")
        public String userId;

        // 执行者完成状态
        @NameInMap("isDone")
        public Boolean isDone;

        public static GetTodoTaskDetailResponseBodyExecutorStatus build(java.util.Map<String, ?> map) throws Exception {
            GetTodoTaskDetailResponseBodyExecutorStatus self = new GetTodoTaskDetailResponseBodyExecutorStatus();
            return TeaModel.build(map, self);
        }

        public GetTodoTaskDetailResponseBodyExecutorStatus setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public GetTodoTaskDetailResponseBodyExecutorStatus setIsDone(Boolean isDone) {
            this.isDone = isDone;
            return this;
        }
        public Boolean getIsDone() {
            return this.isDone;
        }

    }

}
