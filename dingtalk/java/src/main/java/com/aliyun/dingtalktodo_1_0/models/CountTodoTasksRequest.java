// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class CountTodoTasksRequest extends TeaModel {
    // 待办完成状态。
    @NameInMap("isDone")
    public Boolean isDone;

    // 查询目标用户角色类型，执行人 | 创建人 | 参与人，可以同时传多个值。如：[["executor"], ["creator"],["participant"]] 或 [["executor", "creator"]]
    @NameInMap("roleTypes")
    public java.util.List<java.util.List<String>> roleTypes;

    // 查询从计划完成时间开始
    @NameInMap("fromDueTime")
    public Long fromDueTime;

    // 查询到计划完成时间结束
    @NameInMap("toDueTime")
    public Long toDueTime;

    // 所属分类
    @NameInMap("category")
    public String category;

    // 待办回收状态
    @NameInMap("isRecycled")
    public Boolean isRecycled;

    public static CountTodoTasksRequest build(java.util.Map<String, ?> map) throws Exception {
        CountTodoTasksRequest self = new CountTodoTasksRequest();
        return TeaModel.build(map, self);
    }

    public CountTodoTasksRequest setIsDone(Boolean isDone) {
        this.isDone = isDone;
        return this;
    }
    public Boolean getIsDone() {
        return this.isDone;
    }

    public CountTodoTasksRequest setRoleTypes(java.util.List<java.util.List<String>> roleTypes) {
        this.roleTypes = roleTypes;
        return this;
    }
    public java.util.List<java.util.List<String>> getRoleTypes() {
        return this.roleTypes;
    }

    public CountTodoTasksRequest setFromDueTime(Long fromDueTime) {
        this.fromDueTime = fromDueTime;
        return this;
    }
    public Long getFromDueTime() {
        return this.fromDueTime;
    }

    public CountTodoTasksRequest setToDueTime(Long toDueTime) {
        this.toDueTime = toDueTime;
        return this;
    }
    public Long getToDueTime() {
        return this.toDueTime;
    }

    public CountTodoTasksRequest setCategory(String category) {
        this.category = category;
        return this;
    }
    public String getCategory() {
        return this.category;
    }

    public CountTodoTasksRequest setIsRecycled(Boolean isRecycled) {
        this.isRecycled = isRecycled;
        return this;
    }
    public Boolean getIsRecycled() {
        return this.isRecycled;
    }

}
