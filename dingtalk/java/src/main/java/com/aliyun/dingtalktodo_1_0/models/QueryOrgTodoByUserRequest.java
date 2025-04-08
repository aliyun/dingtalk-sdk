// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgTodoByUserRequest extends TeaModel {
    @NameInMap("fromDueTime")
    public Long fromDueTime;

    @NameInMap("isDone")
    public Boolean isDone;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("orderBy")
    public String orderBy;

    @NameInMap("orderDirection")
    public String orderDirection;

    @NameInMap("roleTypes")
    public java.util.List<java.util.List<String>> roleTypes;

    @NameInMap("subject")
    public String subject;

    @NameInMap("toDueTime")
    public Long toDueTime;

    /**
     * <strong>example:</strong>
     * <p>TODO</p>
     */
    @NameInMap("todoType")
    public String todoType;

    public static QueryOrgTodoByUserRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgTodoByUserRequest self = new QueryOrgTodoByUserRequest();
        return TeaModel.build(map, self);
    }

    public QueryOrgTodoByUserRequest setFromDueTime(Long fromDueTime) {
        this.fromDueTime = fromDueTime;
        return this;
    }
    public Long getFromDueTime() {
        return this.fromDueTime;
    }

    public QueryOrgTodoByUserRequest setIsDone(Boolean isDone) {
        this.isDone = isDone;
        return this;
    }
    public Boolean getIsDone() {
        return this.isDone;
    }

    public QueryOrgTodoByUserRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryOrgTodoByUserRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryOrgTodoByUserRequest setOrderBy(String orderBy) {
        this.orderBy = orderBy;
        return this;
    }
    public String getOrderBy() {
        return this.orderBy;
    }

    public QueryOrgTodoByUserRequest setOrderDirection(String orderDirection) {
        this.orderDirection = orderDirection;
        return this;
    }
    public String getOrderDirection() {
        return this.orderDirection;
    }

    public QueryOrgTodoByUserRequest setRoleTypes(java.util.List<java.util.List<String>> roleTypes) {
        this.roleTypes = roleTypes;
        return this;
    }
    public java.util.List<java.util.List<String>> getRoleTypes() {
        return this.roleTypes;
    }

    public QueryOrgTodoByUserRequest setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public QueryOrgTodoByUserRequest setToDueTime(Long toDueTime) {
        this.toDueTime = toDueTime;
        return this;
    }
    public Long getToDueTime() {
        return this.toDueTime;
    }

    public QueryOrgTodoByUserRequest setTodoType(String todoType) {
        this.todoType = todoType;
        return this;
    }
    public String getTodoType() {
        return this.todoType;
    }

}
