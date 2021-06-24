// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class UpdateTodoTaskExecutorStatusRequest extends TeaModel {
    // 执行者状态列表，id需传用户的unionId
    @NameInMap("executorStatusList")
    public java.util.List<UpdateTodoTaskExecutorStatusRequestExecutorStatusList> executorStatusList;

    // 当前操作者id，需传用户的unionId
    @NameInMap("operatorId")
    public String operatorId;

    public static UpdateTodoTaskExecutorStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTodoTaskExecutorStatusRequest self = new UpdateTodoTaskExecutorStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTodoTaskExecutorStatusRequest setExecutorStatusList(java.util.List<UpdateTodoTaskExecutorStatusRequestExecutorStatusList> executorStatusList) {
        this.executorStatusList = executorStatusList;
        return this;
    }
    public java.util.List<UpdateTodoTaskExecutorStatusRequestExecutorStatusList> getExecutorStatusList() {
        return this.executorStatusList;
    }

    public UpdateTodoTaskExecutorStatusRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class UpdateTodoTaskExecutorStatusRequestExecutorStatusList extends TeaModel {
        // 执行者id，需传用户的unionId
        @NameInMap("id")
        public String id;

        // 执行者完成状态
        @NameInMap("isDone")
        public Boolean isDone;

        public static UpdateTodoTaskExecutorStatusRequestExecutorStatusList build(java.util.Map<String, ?> map) throws Exception {
            UpdateTodoTaskExecutorStatusRequestExecutorStatusList self = new UpdateTodoTaskExecutorStatusRequestExecutorStatusList();
            return TeaModel.build(map, self);
        }

        public UpdateTodoTaskExecutorStatusRequestExecutorStatusList setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public UpdateTodoTaskExecutorStatusRequestExecutorStatusList setIsDone(Boolean isDone) {
            this.isDone = isDone;
            return this;
        }
        public Boolean getIsDone() {
            return this.isDone;
        }

    }

}
