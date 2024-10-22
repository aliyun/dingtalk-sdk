// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class UpdateUserTaskStatusRequest extends TeaModel {
    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("userTaskStatuses")
    public java.util.List<UpdateUserTaskStatusRequestUserTaskStatuses> userTaskStatuses;

    public static UpdateUserTaskStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateUserTaskStatusRequest self = new UpdateUserTaskStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateUserTaskStatusRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public UpdateUserTaskStatusRequest setUserTaskStatuses(java.util.List<UpdateUserTaskStatusRequestUserTaskStatuses> userTaskStatuses) {
        this.userTaskStatuses = userTaskStatuses;
        return this;
    }
    public java.util.List<UpdateUserTaskStatusRequestUserTaskStatuses> getUserTaskStatuses() {
        return this.userTaskStatuses;
    }

    public static class UpdateUserTaskStatusRequestUserTaskStatuses extends TeaModel {
        @NameInMap("done")
        public Boolean done;

        @NameInMap("taskId")
        public String taskId;

        public static UpdateUserTaskStatusRequestUserTaskStatuses build(java.util.Map<String, ?> map) throws Exception {
            UpdateUserTaskStatusRequestUserTaskStatuses self = new UpdateUserTaskStatusRequestUserTaskStatuses();
            return TeaModel.build(map, self);
        }

        public UpdateUserTaskStatusRequestUserTaskStatuses setDone(Boolean done) {
            this.done = done;
            return this;
        }
        public Boolean getDone() {
            return this.done;
        }

        public UpdateUserTaskStatusRequestUserTaskStatuses setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
