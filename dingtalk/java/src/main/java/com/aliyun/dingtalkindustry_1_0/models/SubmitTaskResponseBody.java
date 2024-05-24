// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SubmitTaskResponseBody extends TeaModel {
    @NameInMap("tasks")
    public java.util.List<SubmitTaskResponseBodyTasks> tasks;

    public static SubmitTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SubmitTaskResponseBody self = new SubmitTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public SubmitTaskResponseBody setTasks(java.util.List<SubmitTaskResponseBodyTasks> tasks) {
        this.tasks = tasks;
        return this;
    }
    public java.util.List<SubmitTaskResponseBodyTasks> getTasks() {
        return this.tasks;
    }

    public static class SubmitTaskResponseBodyTasks extends TeaModel {
        @NameInMap("id")
        public Long id;

        @NameInMap("taskId")
        public String taskId;

        public static SubmitTaskResponseBodyTasks build(java.util.Map<String, ?> map) throws Exception {
            SubmitTaskResponseBodyTasks self = new SubmitTaskResponseBodyTasks();
            return TeaModel.build(map, self);
        }

        public SubmitTaskResponseBodyTasks setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public SubmitTaskResponseBodyTasks setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
