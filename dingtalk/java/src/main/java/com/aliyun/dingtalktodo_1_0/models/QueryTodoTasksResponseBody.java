// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class QueryTodoTasksResponseBody extends TeaModel {
    /**
     * <p>翻页token</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>待办卡片列表</p>
     */
    @NameInMap("todoCards")
    public java.util.List<QueryTodoTasksResponseBodyTodoCards> todoCards;

    /**
     * <p>数据总量</p>
     */
    @NameInMap("totalCount")
    public Integer totalCount;

    public static QueryTodoTasksResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryTodoTasksResponseBody self = new QueryTodoTasksResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryTodoTasksResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryTodoTasksResponseBody setTodoCards(java.util.List<QueryTodoTasksResponseBodyTodoCards> todoCards) {
        this.todoCards = todoCards;
        return this;
    }
    public java.util.List<QueryTodoTasksResponseBodyTodoCards> getTodoCards() {
        return this.todoCards;
    }

    public QueryTodoTasksResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class QueryTodoTasksResponseBodyTodoCardsDetailUrl extends TeaModel {
        /**
         * <p>移动端url地址</p>
         */
        @NameInMap("appUrl")
        public String appUrl;

        /**
         * <p>pc端url地址</p>
         */
        @NameInMap("pcUrl")
        public String pcUrl;

        public static QueryTodoTasksResponseBodyTodoCardsDetailUrl build(java.util.Map<String, ?> map) throws Exception {
            QueryTodoTasksResponseBodyTodoCardsDetailUrl self = new QueryTodoTasksResponseBodyTodoCardsDetailUrl();
            return TeaModel.build(map, self);
        }

        public QueryTodoTasksResponseBodyTodoCardsDetailUrl setAppUrl(String appUrl) {
            this.appUrl = appUrl;
            return this;
        }
        public String getAppUrl() {
            return this.appUrl;
        }

        public QueryTodoTasksResponseBodyTodoCardsDetailUrl setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

    }

    public static class QueryTodoTasksResponseBodyTodoCardsOrgInfo extends TeaModel {
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

        public static QueryTodoTasksResponseBodyTodoCardsOrgInfo build(java.util.Map<String, ?> map) throws Exception {
            QueryTodoTasksResponseBodyTodoCardsOrgInfo self = new QueryTodoTasksResponseBodyTodoCardsOrgInfo();
            return TeaModel.build(map, self);
        }

        public QueryTodoTasksResponseBodyTodoCardsOrgInfo setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryTodoTasksResponseBodyTodoCardsOrgInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class QueryTodoTasksResponseBodyTodoCardsOriginalSource extends TeaModel {
        /**
         * <p>业务来源展示名称</p>
         */
        @NameInMap("sourceTitle")
        public String sourceTitle;

        public static QueryTodoTasksResponseBodyTodoCardsOriginalSource build(java.util.Map<String, ?> map) throws Exception {
            QueryTodoTasksResponseBodyTodoCardsOriginalSource self = new QueryTodoTasksResponseBodyTodoCardsOriginalSource();
            return TeaModel.build(map, self);
        }

        public QueryTodoTasksResponseBodyTodoCardsOriginalSource setSourceTitle(String sourceTitle) {
            this.sourceTitle = sourceTitle;
            return this;
        }
        public String getSourceTitle() {
            return this.sourceTitle;
        }

    }

    public static class QueryTodoTasksResponseBodyTodoCardsTodoCardViewTodoCardContentList extends TeaModel {
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

        public static QueryTodoTasksResponseBodyTodoCardsTodoCardViewTodoCardContentList build(java.util.Map<String, ?> map) throws Exception {
            QueryTodoTasksResponseBodyTodoCardsTodoCardViewTodoCardContentList self = new QueryTodoTasksResponseBodyTodoCardsTodoCardViewTodoCardContentList();
            return TeaModel.build(map, self);
        }

        public QueryTodoTasksResponseBodyTodoCardsTodoCardViewTodoCardContentList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryTodoTasksResponseBodyTodoCardsTodoCardViewTodoCardContentList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class QueryTodoTasksResponseBodyTodoCardsTodoCardView extends TeaModel {
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
        public java.util.List<QueryTodoTasksResponseBodyTodoCardsTodoCardViewTodoCardContentList> todoCardContentList;

        /**
         * <p>卡片标题</p>
         */
        @NameInMap("todoCardTitle")
        public String todoCardTitle;

        public static QueryTodoTasksResponseBodyTodoCardsTodoCardView build(java.util.Map<String, ?> map) throws Exception {
            QueryTodoTasksResponseBodyTodoCardsTodoCardView self = new QueryTodoTasksResponseBodyTodoCardsTodoCardView();
            return TeaModel.build(map, self);
        }

        public QueryTodoTasksResponseBodyTodoCardsTodoCardView setActionType(String actionType) {
            this.actionType = actionType;
            return this;
        }
        public String getActionType() {
            return this.actionType;
        }

        public QueryTodoTasksResponseBodyTodoCardsTodoCardView setCardType(String cardType) {
            this.cardType = cardType;
            return this;
        }
        public String getCardType() {
            return this.cardType;
        }

        public QueryTodoTasksResponseBodyTodoCardsTodoCardView setCircleELType(String circleELType) {
            this.circleELType = circleELType;
            return this;
        }
        public String getCircleELType() {
            return this.circleELType;
        }

        public QueryTodoTasksResponseBodyTodoCardsTodoCardView setContentType(String contentType) {
            this.contentType = contentType;
            return this;
        }
        public String getContentType() {
            return this.contentType;
        }

        public QueryTodoTasksResponseBodyTodoCardsTodoCardView setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public QueryTodoTasksResponseBodyTodoCardsTodoCardView setTodoCardContentList(java.util.List<QueryTodoTasksResponseBodyTodoCardsTodoCardViewTodoCardContentList> todoCardContentList) {
            this.todoCardContentList = todoCardContentList;
            return this;
        }
        public java.util.List<QueryTodoTasksResponseBodyTodoCardsTodoCardViewTodoCardContentList> getTodoCardContentList() {
            return this.todoCardContentList;
        }

        public QueryTodoTasksResponseBodyTodoCardsTodoCardView setTodoCardTitle(String todoCardTitle) {
            this.todoCardTitle = todoCardTitle;
            return this;
        }
        public String getTodoCardTitle() {
            return this.todoCardTitle;
        }

    }

    public static class QueryTodoTasksResponseBodyTodoCards extends TeaModel {
        /**
         * <p>所属应用</p>
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
         * <p>创建者id</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <p>详情页链接</p>
         */
        @NameInMap("detailUrl")
        public QueryTodoTasksResponseBodyTodoCardsDetailUrl detailUrl;

        /**
         * <p>待办截止时间</p>
         */
        @NameInMap("dueTime")
        public Long dueTime;

        /**
         * <p>待办完成状态</p>
         */
        @NameInMap("isDone")
        public Boolean isDone;

        /**
         * <p>更新时间</p>
         */
        @NameInMap("modifiedTime")
        public Long modifiedTime;

        /**
         * <p>所属组织信息</p>
         */
        @NameInMap("orgInfo")
        public QueryTodoTasksResponseBodyTodoCardsOrgInfo orgInfo;

        /**
         * <p>业务来源信息</p>
         */
        @NameInMap("originalSource")
        public QueryTodoTasksResponseBodyTodoCardsOriginalSource originalSource;

        /**
         * <p>优先级</p>
         */
        @NameInMap("priority")
        public Integer priority;

        /**
         * <p>来源id</p>
         */
        @NameInMap("sourceId")
        public String sourceId;

        /**
         * <p>待办标题</p>
         */
        @NameInMap("subject")
        public String subject;

        /**
         * <p>待办id</p>
         */
        @NameInMap("taskId")
        public String taskId;

        /**
         * <p>待办卡片视图模型</p>
         */
        @NameInMap("todoCardView")
        public QueryTodoTasksResponseBodyTodoCardsTodoCardView todoCardView;

        /**
         * <p>待办状态</p>
         */
        @NameInMap("todoStatus")
        public String todoStatus;

        public static QueryTodoTasksResponseBodyTodoCards build(java.util.Map<String, ?> map) throws Exception {
            QueryTodoTasksResponseBodyTodoCards self = new QueryTodoTasksResponseBodyTodoCards();
            return TeaModel.build(map, self);
        }

        public QueryTodoTasksResponseBodyTodoCards setBizTag(String bizTag) {
            this.bizTag = bizTag;
            return this;
        }
        public String getBizTag() {
            return this.bizTag;
        }

        public QueryTodoTasksResponseBodyTodoCards setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QueryTodoTasksResponseBodyTodoCards setCreatedTime(Long createdTime) {
            this.createdTime = createdTime;
            return this;
        }
        public Long getCreatedTime() {
            return this.createdTime;
        }

        public QueryTodoTasksResponseBodyTodoCards setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public QueryTodoTasksResponseBodyTodoCards setDetailUrl(QueryTodoTasksResponseBodyTodoCardsDetailUrl detailUrl) {
            this.detailUrl = detailUrl;
            return this;
        }
        public QueryTodoTasksResponseBodyTodoCardsDetailUrl getDetailUrl() {
            return this.detailUrl;
        }

        public QueryTodoTasksResponseBodyTodoCards setDueTime(Long dueTime) {
            this.dueTime = dueTime;
            return this;
        }
        public Long getDueTime() {
            return this.dueTime;
        }

        public QueryTodoTasksResponseBodyTodoCards setIsDone(Boolean isDone) {
            this.isDone = isDone;
            return this;
        }
        public Boolean getIsDone() {
            return this.isDone;
        }

        public QueryTodoTasksResponseBodyTodoCards setModifiedTime(Long modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public Long getModifiedTime() {
            return this.modifiedTime;
        }

        public QueryTodoTasksResponseBodyTodoCards setOrgInfo(QueryTodoTasksResponseBodyTodoCardsOrgInfo orgInfo) {
            this.orgInfo = orgInfo;
            return this;
        }
        public QueryTodoTasksResponseBodyTodoCardsOrgInfo getOrgInfo() {
            return this.orgInfo;
        }

        public QueryTodoTasksResponseBodyTodoCards setOriginalSource(QueryTodoTasksResponseBodyTodoCardsOriginalSource originalSource) {
            this.originalSource = originalSource;
            return this;
        }
        public QueryTodoTasksResponseBodyTodoCardsOriginalSource getOriginalSource() {
            return this.originalSource;
        }

        public QueryTodoTasksResponseBodyTodoCards setPriority(Integer priority) {
            this.priority = priority;
            return this;
        }
        public Integer getPriority() {
            return this.priority;
        }

        public QueryTodoTasksResponseBodyTodoCards setSourceId(String sourceId) {
            this.sourceId = sourceId;
            return this;
        }
        public String getSourceId() {
            return this.sourceId;
        }

        public QueryTodoTasksResponseBodyTodoCards setSubject(String subject) {
            this.subject = subject;
            return this;
        }
        public String getSubject() {
            return this.subject;
        }

        public QueryTodoTasksResponseBodyTodoCards setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public QueryTodoTasksResponseBodyTodoCards setTodoCardView(QueryTodoTasksResponseBodyTodoCardsTodoCardView todoCardView) {
            this.todoCardView = todoCardView;
            return this;
        }
        public QueryTodoTasksResponseBodyTodoCardsTodoCardView getTodoCardView() {
            return this.todoCardView;
        }

        public QueryTodoTasksResponseBodyTodoCards setTodoStatus(String todoStatus) {
            this.todoStatus = todoStatus;
            return this;
        }
        public String getTodoStatus() {
            return this.todoStatus;
        }

    }

}
