// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class GetTodoTaskBySourceIdResponseBody extends TeaModel {
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
    public GetTodoTaskBySourceIdResponseBodyDetailUrl detailUrl;

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

    public static GetTodoTaskBySourceIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTodoTaskBySourceIdResponseBody self = new GetTodoTaskBySourceIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTodoTaskBySourceIdResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public GetTodoTaskBySourceIdResponseBody setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public GetTodoTaskBySourceIdResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetTodoTaskBySourceIdResponseBody setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public GetTodoTaskBySourceIdResponseBody setDueTime(Long dueTime) {
        this.dueTime = dueTime;
        return this;
    }
    public Long getDueTime() {
        return this.dueTime;
    }

    public GetTodoTaskBySourceIdResponseBody setFinishTime(Long finishTime) {
        this.finishTime = finishTime;
        return this;
    }
    public Long getFinishTime() {
        return this.finishTime;
    }

    public GetTodoTaskBySourceIdResponseBody setDone(Boolean done) {
        this.done = done;
        return this;
    }
    public Boolean getDone() {
        return this.done;
    }

    public GetTodoTaskBySourceIdResponseBody setExecutorIds(java.util.List<String> executorIds) {
        this.executorIds = executorIds;
        return this;
    }
    public java.util.List<String> getExecutorIds() {
        return this.executorIds;
    }

    public GetTodoTaskBySourceIdResponseBody setParticipantIds(java.util.List<String> participantIds) {
        this.participantIds = participantIds;
        return this;
    }
    public java.util.List<String> getParticipantIds() {
        return this.participantIds;
    }

    public GetTodoTaskBySourceIdResponseBody setDetailUrl(GetTodoTaskBySourceIdResponseBodyDetailUrl detailUrl) {
        this.detailUrl = detailUrl;
        return this;
    }
    public GetTodoTaskBySourceIdResponseBodyDetailUrl getDetailUrl() {
        return this.detailUrl;
    }

    public GetTodoTaskBySourceIdResponseBody setSourceId(String sourceId) {
        this.sourceId = sourceId;
        return this;
    }
    public String getSourceId() {
        return this.sourceId;
    }

    public GetTodoTaskBySourceIdResponseBody setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public GetTodoTaskBySourceIdResponseBody setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public GetTodoTaskBySourceIdResponseBody setModifiedTime(Long modifiedTime) {
        this.modifiedTime = modifiedTime;
        return this;
    }
    public Long getModifiedTime() {
        return this.modifiedTime;
    }

    public GetTodoTaskBySourceIdResponseBody setCreatorId(String creatorId) {
        this.creatorId = creatorId;
        return this;
    }
    public String getCreatorId() {
        return this.creatorId;
    }

    public GetTodoTaskBySourceIdResponseBody setModifierId(String modifierId) {
        this.modifierId = modifierId;
        return this;
    }
    public String getModifierId() {
        return this.modifierId;
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

    public GetTodoTaskBySourceIdResponseBody setBizTag(String bizTag) {
        this.bizTag = bizTag;
        return this;
    }
    public String getBizTag() {
        return this.bizTag;
    }

    public GetTodoTaskBySourceIdResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public static class GetTodoTaskBySourceIdResponseBodyDetailUrl extends TeaModel {
        // pc端详情页地址
        @NameInMap("pcUrl")
        public String pcUrl;

        // app端详情页地址
        @NameInMap("appUrl")
        public String appUrl;

        public static GetTodoTaskBySourceIdResponseBodyDetailUrl build(java.util.Map<String, ?> map) throws Exception {
            GetTodoTaskBySourceIdResponseBodyDetailUrl self = new GetTodoTaskBySourceIdResponseBodyDetailUrl();
            return TeaModel.build(map, self);
        }

        public GetTodoTaskBySourceIdResponseBodyDetailUrl setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public GetTodoTaskBySourceIdResponseBodyDetailUrl setAppUrl(String appUrl) {
            this.appUrl = appUrl;
            return this;
        }
        public String getAppUrl() {
            return this.appUrl;
        }

    }

}
