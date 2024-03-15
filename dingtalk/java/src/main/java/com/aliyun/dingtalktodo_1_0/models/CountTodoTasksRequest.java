// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class CountTodoTasksRequest extends TeaModel {
    @NameInMap("fromDueTime")
    public Long fromDueTime;

    @NameInMap("isDone")
    public Boolean isDone;

    @NameInMap("isRecycled")
    public Boolean isRecycled;

    @NameInMap("roleTypes")
    public java.util.List<java.util.List<String>> roleTypes;

    @NameInMap("toDueTime")
    public Long toDueTime;

    public static CountTodoTasksRequest build(java.util.Map<String, ?> map) throws Exception {
        CountTodoTasksRequest self = new CountTodoTasksRequest();
        return TeaModel.build(map, self);
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
