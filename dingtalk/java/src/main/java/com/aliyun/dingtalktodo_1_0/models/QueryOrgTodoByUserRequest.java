// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgTodoByUserRequest extends TeaModel {
    /**
     * <p>查询从计划完成时间开始</p>
     */
    @NameInMap("fromDueTime")
    public Long fromDueTime;

    /**
     * <p>待办完成状态。</p>
     */
    @NameInMap("isDone")
    public Boolean isDone;

    /**
     * <p>每页数量。</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>分页游标。如果一个查询条件一次无法全部返回结果，会返回分页token，下次查询带上该token后会返回后续数据，直到分页token为null表示数据已经全部查询完毕。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>查询目标用户角色类型，执行人 | 创建人 | 参与人，可以同时传多个值。如：[["executor"], ["creator"],["participant"]] 或 [["executor", "creator"]]</p>
     */
    @NameInMap("roleTypes")
    public java.util.List<java.util.List<String>> roleTypes;

    /**
     * <p>待办标题</p>
     */
    @NameInMap("subject")
    public String subject;

    /**
     * <p>查询到计划完成时间结束</p>
     */
    @NameInMap("toDueTime")
    public Long toDueTime;

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

}
