// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgTodoByUserResponseBody extends TeaModel {
    /**
     * <p>每页数量</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>翻页token</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>待办卡片列表</p>
     */
    @NameInMap("todoCards")
    public java.util.List<QueryOrgTodoByUserResponseBodyTodoCards> todoCards;

    public static QueryOrgTodoByUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgTodoByUserResponseBody self = new QueryOrgTodoByUserResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryOrgTodoByUserResponseBody setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryOrgTodoByUserResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryOrgTodoByUserResponseBody setTodoCards(java.util.List<QueryOrgTodoByUserResponseBodyTodoCards> todoCards) {
        this.todoCards = todoCards;
        return this;
    }
    public java.util.List<QueryOrgTodoByUserResponseBodyTodoCards> getTodoCards() {
        return this.todoCards;
    }

    public static class QueryOrgTodoByUserResponseBodyTodoCardsDetailUrl extends TeaModel {
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

        public static QueryOrgTodoByUserResponseBodyTodoCardsDetailUrl build(java.util.Map<String, ?> map) throws Exception {
            QueryOrgTodoByUserResponseBodyTodoCardsDetailUrl self = new QueryOrgTodoByUserResponseBodyTodoCardsDetailUrl();
            return TeaModel.build(map, self);
        }

        public QueryOrgTodoByUserResponseBodyTodoCardsDetailUrl setAppUrl(String appUrl) {
            this.appUrl = appUrl;
            return this;
        }
        public String getAppUrl() {
            return this.appUrl;
        }

        public QueryOrgTodoByUserResponseBodyTodoCardsDetailUrl setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

    }

    public static class QueryOrgTodoByUserResponseBodyTodoCards extends TeaModel {
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
        public QueryOrgTodoByUserResponseBodyTodoCardsDetailUrl detailUrl;

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

        public static QueryOrgTodoByUserResponseBodyTodoCards build(java.util.Map<String, ?> map) throws Exception {
            QueryOrgTodoByUserResponseBodyTodoCards self = new QueryOrgTodoByUserResponseBodyTodoCards();
            return TeaModel.build(map, self);
        }

        public QueryOrgTodoByUserResponseBodyTodoCards setBizTag(String bizTag) {
            this.bizTag = bizTag;
            return this;
        }
        public String getBizTag() {
            return this.bizTag;
        }

        public QueryOrgTodoByUserResponseBodyTodoCards setCreatedTime(Long createdTime) {
            this.createdTime = createdTime;
            return this;
        }
        public Long getCreatedTime() {
            return this.createdTime;
        }

        public QueryOrgTodoByUserResponseBodyTodoCards setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public QueryOrgTodoByUserResponseBodyTodoCards setDetailUrl(QueryOrgTodoByUserResponseBodyTodoCardsDetailUrl detailUrl) {
            this.detailUrl = detailUrl;
            return this;
        }
        public QueryOrgTodoByUserResponseBodyTodoCardsDetailUrl getDetailUrl() {
            return this.detailUrl;
        }

        public QueryOrgTodoByUserResponseBodyTodoCards setDueTime(Long dueTime) {
            this.dueTime = dueTime;
            return this;
        }
        public Long getDueTime() {
            return this.dueTime;
        }

        public QueryOrgTodoByUserResponseBodyTodoCards setIsDone(Boolean isDone) {
            this.isDone = isDone;
            return this;
        }
        public Boolean getIsDone() {
            return this.isDone;
        }

        public QueryOrgTodoByUserResponseBodyTodoCards setModifiedTime(Long modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public Long getModifiedTime() {
            return this.modifiedTime;
        }

        public QueryOrgTodoByUserResponseBodyTodoCards setPriority(Integer priority) {
            this.priority = priority;
            return this;
        }
        public Integer getPriority() {
            return this.priority;
        }

        public QueryOrgTodoByUserResponseBodyTodoCards setSourceId(String sourceId) {
            this.sourceId = sourceId;
            return this;
        }
        public String getSourceId() {
            return this.sourceId;
        }

        public QueryOrgTodoByUserResponseBodyTodoCards setSubject(String subject) {
            this.subject = subject;
            return this;
        }
        public String getSubject() {
            return this.subject;
        }

        public QueryOrgTodoByUserResponseBodyTodoCards setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
