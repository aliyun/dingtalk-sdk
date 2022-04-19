// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgTodoByUserResponseBody extends TeaModel {
    // 每页数量
    @NameInMap("maxResults")
    public Integer maxResults;

    // 翻页token
    @NameInMap("nextToken")
    public String nextToken;

    // 待办卡片列表
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
        // 移动端url地址
        @NameInMap("appUrl")
        public String appUrl;

        // pc端url地址
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
        // 所属应用
        @NameInMap("bizTag")
        public String bizTag;

        // 创建时间
        @NameInMap("createdTime")
        public Long createdTime;

        // 创建者id
        @NameInMap("creatorId")
        public String creatorId;

        // 详情页链接
        @NameInMap("detailUrl")
        public QueryOrgTodoByUserResponseBodyTodoCardsDetailUrl detailUrl;

        // 待办截止时间
        @NameInMap("dueTime")
        public Long dueTime;

        // 待办完成状态
        @NameInMap("isDone")
        public Boolean isDone;

        // 更新时间
        @NameInMap("modifiedTime")
        public Long modifiedTime;

        // 优先级
        @NameInMap("priority")
        public Integer priority;

        // 来源id
        @NameInMap("sourceId")
        public String sourceId;

        // 待办标题
        @NameInMap("subject")
        public String subject;

        // 待办id
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
