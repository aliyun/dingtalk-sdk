// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class QueryTodoTasksRequest extends TeaModel {
    @NameInMap("category")
    public String category;

    @NameInMap("fromDueTime")
    public Long fromDueTime;

    @NameInMap("isDone")
    public Boolean isDone;

    @NameInMap("isRecycled")
    public Boolean isRecycled;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("orderBy")
    public String orderBy;

    @NameInMap("orderDirection")
    public String orderDirection;

    @NameInMap("roleTypes")
    public java.util.List<java.util.List<String>> roleTypes;

    @NameInMap("toDueTime")
    public Long toDueTime;

    public static QueryTodoTasksRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryTodoTasksRequest self = new QueryTodoTasksRequest();
        return TeaModel.build(map, self);
    }

    public QueryTodoTasksRequest setCategory(String category) {
        this.category = category;
        return this;
    }
    public String getCategory() {
        return this.category;
    }

    public QueryTodoTasksRequest setFromDueTime(Long fromDueTime) {
        this.fromDueTime = fromDueTime;
        return this;
    }
    public Long getFromDueTime() {
        return this.fromDueTime;
    }

    public QueryTodoTasksRequest setIsDone(Boolean isDone) {
        this.isDone = isDone;
        return this;
    }
    public Boolean getIsDone() {
        return this.isDone;
    }

    public QueryTodoTasksRequest setIsRecycled(Boolean isRecycled) {
        this.isRecycled = isRecycled;
        return this;
    }
    public Boolean getIsRecycled() {
        return this.isRecycled;
    }

    public QueryTodoTasksRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryTodoTasksRequest setOrderBy(String orderBy) {
        this.orderBy = orderBy;
        return this;
    }
    public String getOrderBy() {
        return this.orderBy;
    }

    public QueryTodoTasksRequest setOrderDirection(String orderDirection) {
        this.orderDirection = orderDirection;
        return this;
    }
    public String getOrderDirection() {
        return this.orderDirection;
    }

    public QueryTodoTasksRequest setRoleTypes(java.util.List<java.util.List<String>> roleTypes) {
        this.roleTypes = roleTypes;
        return this;
    }
    public java.util.List<java.util.List<String>> getRoleTypes() {
        return this.roleTypes;
    }

    public QueryTodoTasksRequest setToDueTime(Long toDueTime) {
        this.toDueTime = toDueTime;
        return this;
    }
    public Long getToDueTime() {
        return this.toDueTime;
    }

}
