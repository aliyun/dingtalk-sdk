// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgTodoTasksResponseBody extends TeaModel {
    /**
     * <p>翻页token</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>待办卡片列表</p>
     */
    @NameInMap("todoCards")
    public java.util.List<QueryOrgTodoTasksResponseBodyTodoCards> todoCards;

    public static QueryOrgTodoTasksResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgTodoTasksResponseBody self = new QueryOrgTodoTasksResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryOrgTodoTasksResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryOrgTodoTasksResponseBody setTodoCards(java.util.List<QueryOrgTodoTasksResponseBodyTodoCards> todoCards) {
        this.todoCards = todoCards;
        return this;
    }
    public java.util.List<QueryOrgTodoTasksResponseBodyTodoCards> getTodoCards() {
        return this.todoCards;
    }

    public static class QueryOrgTodoTasksResponseBodyTodoCardsDetailUrl extends TeaModel {
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

        public static QueryOrgTodoTasksResponseBodyTodoCardsDetailUrl build(java.util.Map<String, ?> map) throws Exception {
            QueryOrgTodoTasksResponseBodyTodoCardsDetailUrl self = new QueryOrgTodoTasksResponseBodyTodoCardsDetailUrl();
            return TeaModel.build(map, self);
        }

        public QueryOrgTodoTasksResponseBodyTodoCardsDetailUrl setAppUrl(String appUrl) {
            this.appUrl = appUrl;
            return this;
        }
        public String getAppUrl() {
            return this.appUrl;
        }

        public QueryOrgTodoTasksResponseBodyTodoCardsDetailUrl setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

    }

    public static class QueryOrgTodoTasksResponseBodyTodoCards extends TeaModel {
        /**
         * <p>所属应用</p>
         */
        @NameInMap("bizTag")
        public String bizTag;

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
        public QueryOrgTodoTasksResponseBodyTodoCardsDetailUrl detailUrl;

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

        public static QueryOrgTodoTasksResponseBodyTodoCards build(java.util.Map<String, ?> map) throws Exception {
            QueryOrgTodoTasksResponseBodyTodoCards self = new QueryOrgTodoTasksResponseBodyTodoCards();
            return TeaModel.build(map, self);
        }

        public QueryOrgTodoTasksResponseBodyTodoCards setBizTag(String bizTag) {
            this.bizTag = bizTag;
            return this;
        }
        public String getBizTag() {
            return this.bizTag;
        }

        public QueryOrgTodoTasksResponseBodyTodoCards setCreatedTime(Long createdTime) {
            this.createdTime = createdTime;
            return this;
        }
        public Long getCreatedTime() {
            return this.createdTime;
        }

        public QueryOrgTodoTasksResponseBodyTodoCards setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public QueryOrgTodoTasksResponseBodyTodoCards setDetailUrl(QueryOrgTodoTasksResponseBodyTodoCardsDetailUrl detailUrl) {
            this.detailUrl = detailUrl;
            return this;
        }
        public QueryOrgTodoTasksResponseBodyTodoCardsDetailUrl getDetailUrl() {
            return this.detailUrl;
        }

        public QueryOrgTodoTasksResponseBodyTodoCards setDueTime(Long dueTime) {
            this.dueTime = dueTime;
            return this;
        }
        public Long getDueTime() {
            return this.dueTime;
        }

        public QueryOrgTodoTasksResponseBodyTodoCards setIsDone(Boolean isDone) {
            this.isDone = isDone;
            return this;
        }
        public Boolean getIsDone() {
            return this.isDone;
        }

        public QueryOrgTodoTasksResponseBodyTodoCards setModifiedTime(Long modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public Long getModifiedTime() {
            return this.modifiedTime;
        }

        public QueryOrgTodoTasksResponseBodyTodoCards setPriority(Integer priority) {
            this.priority = priority;
            return this;
        }
        public Integer getPriority() {
            return this.priority;
        }

        public QueryOrgTodoTasksResponseBodyTodoCards setSourceId(String sourceId) {
            this.sourceId = sourceId;
            return this;
        }
        public String getSourceId() {
            return this.sourceId;
        }

        public QueryOrgTodoTasksResponseBodyTodoCards setSubject(String subject) {
            this.subject = subject;
            return this;
        }
        public String getSubject() {
            return this.subject;
        }

        public QueryOrgTodoTasksResponseBodyTodoCards setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
