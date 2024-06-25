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
        /**
         * <strong>example:</strong>
         * <p>1001</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <strong>example:</strong>
         * <p>8ef16170b6e24d8fb77b832d7603b835</p>
         */
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
