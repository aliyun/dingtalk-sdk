// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class GetTodoTaskDetailResponseBody extends TeaModel {
    @NameInMap("bizTag")
    public String bizTag;

    @NameInMap("category")
    public String category;

    @NameInMap("createdTime")
    public Long createdTime;

    @NameInMap("creatorId")
    public String creatorId;

    @NameInMap("description")
    public String description;

    @NameInMap("detailUrl")
    public GetTodoTaskDetailResponseBodyDetailUrl detailUrl;

    @NameInMap("done")
    public Boolean done;

    @NameInMap("dueTime")
    public Long dueTime;

    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    @NameInMap("executorStatus")
    public java.util.List<GetTodoTaskDetailResponseBodyExecutorStatus> executorStatus;

    @NameInMap("finishTime")
    public Long finishTime;

    @NameInMap("id")
    public String id;

    @NameInMap("isOnlyShowExecutor")
    public Boolean isOnlyShowExecutor;

    @NameInMap("modifiedTime")
    public Long modifiedTime;

    @NameInMap("modifierId")
    public String modifierId;

    @NameInMap("orgInfo")
    public GetTodoTaskDetailResponseBodyOrgInfo orgInfo;

    @NameInMap("participantIds")
    public java.util.List<String> participantIds;

    @NameInMap("priority")
    public Integer priority;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("source")
    public String source;

    @NameInMap("sourceId")
    public String sourceId;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("subject")
    public String subject;

    @NameInMap("tenantId")
    public String tenantId;

    @NameInMap("tenantType")
    public String tenantType;

    @NameInMap("todoCardView")
    public GetTodoTaskDetailResponseBodyTodoCardView todoCardView;

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

    public GetTodoTaskDetailResponseBody setTodoCardView(GetTodoTaskDetailResponseBodyTodoCardView todoCardView) {
        this.todoCardView = todoCardView;
        return this;
    }
    public GetTodoTaskDetailResponseBodyTodoCardView getTodoCardView() {
        return this.todoCardView;
    }

    public static class GetTodoTaskDetailResponseBodyDetailUrl extends TeaModel {
        @NameInMap("appUrl")
        public String appUrl;

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
        @NameInMap("isDone")
        public Boolean isDone;

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
        @NameInMap("corpId")
        public String corpId;

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

    public static class GetTodoTaskDetailResponseBodyTodoCardViewTodoCardContentList extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        public static GetTodoTaskDetailResponseBodyTodoCardViewTodoCardContentList build(java.util.Map<String, ?> map) throws Exception {
            GetTodoTaskDetailResponseBodyTodoCardViewTodoCardContentList self = new GetTodoTaskDetailResponseBodyTodoCardViewTodoCardContentList();
            return TeaModel.build(map, self);
        }

        public GetTodoTaskDetailResponseBodyTodoCardViewTodoCardContentList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetTodoTaskDetailResponseBodyTodoCardViewTodoCardContentList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetTodoTaskDetailResponseBodyTodoCardView extends TeaModel {
        @NameInMap("actionType")
        public String actionType;

        /**
         * <strong>example:</strong>
         * <p>standard , nonStandard, 标准卡片和非标准卡片，非标准卡片由第三方接入方自定义</p>
         */
        @NameInMap("cardType")
        public String cardType;

        /**
         * <strong>example:</strong>
         * <p>是 icon, 或者checkbox 类型的</p>
         */
        @NameInMap("circleELType")
        public String circleELType;

        @NameInMap("contentType")
        public String contentType;

        @NameInMap("icon")
        public String icon;

        @NameInMap("todoCardContentList")
        public java.util.List<GetTodoTaskDetailResponseBodyTodoCardViewTodoCardContentList> todoCardContentList;

        @NameInMap("todoCardTitle")
        public String todoCardTitle;

        public static GetTodoTaskDetailResponseBodyTodoCardView build(java.util.Map<String, ?> map) throws Exception {
            GetTodoTaskDetailResponseBodyTodoCardView self = new GetTodoTaskDetailResponseBodyTodoCardView();
            return TeaModel.build(map, self);
        }

        public GetTodoTaskDetailResponseBodyTodoCardView setActionType(String actionType) {
            this.actionType = actionType;
            return this;
        }
        public String getActionType() {
            return this.actionType;
        }

        public GetTodoTaskDetailResponseBodyTodoCardView setCardType(String cardType) {
            this.cardType = cardType;
            return this;
        }
        public String getCardType() {
            return this.cardType;
        }

        public GetTodoTaskDetailResponseBodyTodoCardView setCircleELType(String circleELType) {
            this.circleELType = circleELType;
            return this;
        }
        public String getCircleELType() {
            return this.circleELType;
        }

        public GetTodoTaskDetailResponseBodyTodoCardView setContentType(String contentType) {
            this.contentType = contentType;
            return this;
        }
        public String getContentType() {
            return this.contentType;
        }

        public GetTodoTaskDetailResponseBodyTodoCardView setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public GetTodoTaskDetailResponseBodyTodoCardView setTodoCardContentList(java.util.List<GetTodoTaskDetailResponseBodyTodoCardViewTodoCardContentList> todoCardContentList) {
            this.todoCardContentList = todoCardContentList;
            return this;
        }
        public java.util.List<GetTodoTaskDetailResponseBodyTodoCardViewTodoCardContentList> getTodoCardContentList() {
            return this.todoCardContentList;
        }

        public GetTodoTaskDetailResponseBodyTodoCardView setTodoCardTitle(String todoCardTitle) {
            this.todoCardTitle = todoCardTitle;
            return this;
        }
        public String getTodoCardTitle() {
            return this.todoCardTitle;
        }

    }

}
