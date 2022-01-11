// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class QueryTodoTasksRequest extends TeaModel {
    // 所属分类
    @NameInMap("category")
    public String category;

    // 查询从计划完成时间开始
    @NameInMap("fromDueTime")
    public Long fromDueTime;

    // 待办完成状态。
    @NameInMap("isDone")
    public Boolean isDone;

    // 待办回收状态
    @NameInMap("isRecycled")
    public Boolean isRecycled;

    // 分页游标。如果一个查询条件一次无法全部返回结果，会返回分页token，下次查询带上该token后会返回后续数据，直到分页token为null表示数据已经全部查询完毕。
    @NameInMap("nextToken")
    public String nextToken;

    // 排序字段。枚举值 默认为截止时间 dueTime。created | modified | finished | startTime | dueTime 创建时间 | 更新时间 | 完成时间 | 开始时间 | 截止时间
    @NameInMap("orderBy")
    public String orderBy;

    // 排序方向。枚举值asc | desc 默认 asc
    @NameInMap("orderDirection")
    public String orderDirection;

    // 查询目标用户角色类型，执行人 | 创建人 | 参与人，可以同时传多个值。如：[["executor"], ["creator"],["participant"]] 或 [["executor", "creator"]]
    @NameInMap("roleTypes")
    public java.util.List<java.util.List<String>> roleTypes;

    // 查询到计划完成时间结束
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
