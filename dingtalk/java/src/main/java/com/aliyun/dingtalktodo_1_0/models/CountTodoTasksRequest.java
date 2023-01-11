// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class CountTodoTasksRequest extends TeaModel {
    /**
     * <p>所属分类</p>
     */
    @NameInMap("category")
    public String category;

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
     * <p>待办回收状态</p>
     */
    @NameInMap("isRecycled")
    public Boolean isRecycled;

    /**
     * <p>查询目标用户角色类型，执行人 | 创建人 | 参与人，可以同时传多个值。如：[["executor"], ["creator"],["participant"]] 或 [["executor", "creator"]]</p>
     */
    @NameInMap("roleTypes")
    public java.util.List<java.util.List<String>> roleTypes;

    /**
     * <p>查询到计划完成时间结束</p>
     */
    @NameInMap("toDueTime")
    public Long toDueTime;

    public static CountTodoTasksRequest build(java.util.Map<String, ?> map) throws Exception {
        CountTodoTasksRequest self = new CountTodoTasksRequest();
        return TeaModel.build(map, self);
    }

    public CountTodoTasksRequest setCategory(String category) {
        this.category = category;
        return this;
    }
    public String getCategory() {
        return this.category;
    }

    public CountTodoTasksRequest setFromDueTime(Long fromDueTime) {
        this.fromDueTime = fromDueTime;
        return this;
    }
    public Long getFromDueTime() {
        return this.fromDueTime;
    }

    public CountTodoTasksRequest setIsDone(Boolean isDone) {
        this.isDone = isDone;
        return this;
    }
    public Boolean getIsDone() {
        return this.isDone;
    }

    public CountTodoTasksRequest setIsRecycled(Boolean isRecycled) {
        this.isRecycled = isRecycled;
        return this;
    }
    public Boolean getIsRecycled() {
        return this.isRecycled;
    }

    public CountTodoTasksRequest setRoleTypes(java.util.List<java.util.List<String>> roleTypes) {
        this.roleTypes = roleTypes;
        return this;
    }
    public java.util.List<java.util.List<String>> getRoleTypes() {
        return this.roleTypes;
    }

    public CountTodoTasksRequest setToDueTime(Long toDueTime) {
        this.toDueTime = toDueTime;
        return this;
    }
    public Long getToDueTime() {
        return this.toDueTime;
    }

}
