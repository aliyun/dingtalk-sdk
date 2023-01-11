// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class GetTodoTaskDetailResponseBody extends TeaModel {
    /**
     * <p>接入业务应用标识</p>
     */
    @NameInMap("bizTag")
    public String bizTag;

    /**
     * <p>所属分类</p>
     */
    @NameInMap("category")
    public String category;

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
    public GetTodoTaskDetailResponseBodyDetailUrl detailUrl;

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
     * <p>执行者待办完成状态列表</p>
     */
    @NameInMap("executorStatus")
    public java.util.List<GetTodoTaskDetailResponseBodyExecutorStatus> executorStatus;

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
     * <p>所属组织信息</p>
     */
    @NameInMap("orgInfo")
    public GetTodoTaskDetailResponseBodyOrgInfo orgInfo;

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

    /**
     * <p>待办卡片视图模型</p>
     */
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
        /**
         * <p>执行者完成状态</p>
         */
        @NameInMap("isDone")
        public Boolean isDone;

        /**
         * <p>执行者id（用户的unionId）</p>
         */
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
        /**
         * <p>组织corpId</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>组织名称</p>
         */
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
        /**
         * <p>自定义表单内容名字</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>自定义表单内容值</p>
         */
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
        /**
         * <p>link, button, 操作区类型，是链接类型，或者按钮类型</p>
         */
        @NameInMap("actionType")
        public String actionType;

        /**
         * <p>卡片类型</p>
         */
        @NameInMap("cardType")
        public String cardType;

        /**
         * <p>卡片左上角 区域类型是 icon, 或者checkbox 类型的</p>
         */
        @NameInMap("circleELType")
        public String circleELType;

        /**
         * <p>icon, name ,内容区域类型是 icon+value, 或者name+value 类型的</p>
         */
        @NameInMap("contentType")
        public String contentType;

        /**
         * <p>卡片icon</p>
         */
        @NameInMap("icon")
        public String icon;

        @NameInMap("todoCardContentList")
        public java.util.List<GetTodoTaskDetailResponseBodyTodoCardViewTodoCardContentList> todoCardContentList;

        /**
         * <p>卡片标题</p>
         */
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
