// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class GetTodoTaskResponseBody extends TeaModel {
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
    public GetTodoTaskResponseBodyDetailUrl detailUrl;

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

    // 待办卡片类型id
    @NameInMap("cardTypeId")
    public String cardTypeId;

    // 内容区表单字段配置
    @NameInMap("contentFieldList")
    public java.util.List<GetTodoTaskResponseBodyContentFieldList> contentFieldList;

    // 待办是否仅展示在执行人的待办列表中
    @NameInMap("isOnlyShowExecutor")
    public Boolean isOnlyShowExecutor;

    // 优先级, 较低:10, 普通:20, 紧急:30, 非常紧急:40
    @NameInMap("priority")
    public Integer priority;

    // 业务来源展示名称
    @NameInMap("sourceTitle")
    public String sourceTitle;

    public static GetTodoTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTodoTaskResponseBody self = new GetTodoTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTodoTaskResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public GetTodoTaskResponseBody setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public GetTodoTaskResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetTodoTaskResponseBody setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public GetTodoTaskResponseBody setDueTime(Long dueTime) {
        this.dueTime = dueTime;
        return this;
    }
    public Long getDueTime() {
        return this.dueTime;
    }

    public GetTodoTaskResponseBody setFinishTime(Long finishTime) {
        this.finishTime = finishTime;
        return this;
    }
    public Long getFinishTime() {
        return this.finishTime;
    }

    public GetTodoTaskResponseBody setDone(Boolean done) {
        this.done = done;
        return this;
    }
    public Boolean getDone() {
        return this.done;
    }

    public GetTodoTaskResponseBody setExecutorIds(java.util.List<String> executorIds) {
        this.executorIds = executorIds;
        return this;
    }
    public java.util.List<String> getExecutorIds() {
        return this.executorIds;
    }

    public GetTodoTaskResponseBody setParticipantIds(java.util.List<String> participantIds) {
        this.participantIds = participantIds;
        return this;
    }
    public java.util.List<String> getParticipantIds() {
        return this.participantIds;
    }

    public GetTodoTaskResponseBody setDetailUrl(GetTodoTaskResponseBodyDetailUrl detailUrl) {
        this.detailUrl = detailUrl;
        return this;
    }
    public GetTodoTaskResponseBodyDetailUrl getDetailUrl() {
        return this.detailUrl;
    }

    public GetTodoTaskResponseBody setSourceId(String sourceId) {
        this.sourceId = sourceId;
        return this;
    }
    public String getSourceId() {
        return this.sourceId;
    }

    public GetTodoTaskResponseBody setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public GetTodoTaskResponseBody setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public GetTodoTaskResponseBody setModifiedTime(Long modifiedTime) {
        this.modifiedTime = modifiedTime;
        return this;
    }
    public Long getModifiedTime() {
        return this.modifiedTime;
    }

    public GetTodoTaskResponseBody setCreatorId(String creatorId) {
        this.creatorId = creatorId;
        return this;
    }
    public String getCreatorId() {
        return this.creatorId;
    }

    public GetTodoTaskResponseBody setModifierId(String modifierId) {
        this.modifierId = modifierId;
        return this;
    }
    public String getModifierId() {
        return this.modifierId;
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

    public GetTodoTaskResponseBody setBizTag(String bizTag) {
        this.bizTag = bizTag;
        return this;
    }
    public String getBizTag() {
        return this.bizTag;
    }

    public GetTodoTaskResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetTodoTaskResponseBody setCardTypeId(String cardTypeId) {
        this.cardTypeId = cardTypeId;
        return this;
    }
    public String getCardTypeId() {
        return this.cardTypeId;
    }

    public GetTodoTaskResponseBody setContentFieldList(java.util.List<GetTodoTaskResponseBodyContentFieldList> contentFieldList) {
        this.contentFieldList = contentFieldList;
        return this;
    }
    public java.util.List<GetTodoTaskResponseBodyContentFieldList> getContentFieldList() {
        return this.contentFieldList;
    }

    public GetTodoTaskResponseBody setIsOnlyShowExecutor(Boolean isOnlyShowExecutor) {
        this.isOnlyShowExecutor = isOnlyShowExecutor;
        return this;
    }
    public Boolean getIsOnlyShowExecutor() {
        return this.isOnlyShowExecutor;
    }

    public GetTodoTaskResponseBody setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

    public GetTodoTaskResponseBody setSourceTitle(String sourceTitle) {
        this.sourceTitle = sourceTitle;
        return this;
    }
    public String getSourceTitle() {
        return this.sourceTitle;
    }

    public static class GetTodoTaskResponseBodyDetailUrl extends TeaModel {
        // pc端详情页地址
        @NameInMap("pcUrl")
        public String pcUrl;

        // app端详情页地址
        @NameInMap("appUrl")
        public String appUrl;

        public static GetTodoTaskResponseBodyDetailUrl build(java.util.Map<String, ?> map) throws Exception {
            GetTodoTaskResponseBodyDetailUrl self = new GetTodoTaskResponseBodyDetailUrl();
            return TeaModel.build(map, self);
        }

        public GetTodoTaskResponseBodyDetailUrl setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public GetTodoTaskResponseBodyDetailUrl setAppUrl(String appUrl) {
            this.appUrl = appUrl;
            return this;
        }
        public String getAppUrl() {
            return this.appUrl;
        }

    }

    public static class GetTodoTaskResponseBodyContentFieldList extends TeaModel {
        // 字段唯一标识
        @NameInMap("fieldKey")
        public String fieldKey;

        // 字段值
        @NameInMap("fieldValue")
        public String fieldValue;

        public static GetTodoTaskResponseBodyContentFieldList build(java.util.Map<String, ?> map) throws Exception {
            GetTodoTaskResponseBodyContentFieldList self = new GetTodoTaskResponseBodyContentFieldList();
            return TeaModel.build(map, self);
        }

        public GetTodoTaskResponseBodyContentFieldList setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public GetTodoTaskResponseBodyContentFieldList setFieldValue(String fieldValue) {
            this.fieldValue = fieldValue;
            return this;
        }
        public String getFieldValue() {
            return this.fieldValue;
        }

    }

}
