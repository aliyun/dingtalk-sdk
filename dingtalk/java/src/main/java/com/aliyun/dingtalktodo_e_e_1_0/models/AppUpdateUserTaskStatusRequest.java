// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class AppUpdateUserTaskStatusRequest extends TeaModel {
    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("userTaskStatuses")
    public java.util.List<AppUpdateUserTaskStatusRequestUserTaskStatuses> userTaskStatuses;

    public static AppUpdateUserTaskStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        AppUpdateUserTaskStatusRequest self = new AppUpdateUserTaskStatusRequest();
        return TeaModel.build(map, self);
    }

    public AppUpdateUserTaskStatusRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public AppUpdateUserTaskStatusRequest setUserTaskStatuses(java.util.List<AppUpdateUserTaskStatusRequestUserTaskStatuses> userTaskStatuses) {
        this.userTaskStatuses = userTaskStatuses;
        return this;
    }
    public java.util.List<AppUpdateUserTaskStatusRequestUserTaskStatuses> getUserTaskStatuses() {
        return this.userTaskStatuses;
    }

    public static class AppUpdateUserTaskStatusRequestUserTaskStatuses extends TeaModel {
        @NameInMap("done")
        public Boolean done;

        /**
         * <strong>if can be null:</strong>
         * <p>false</p>
         */
        @NameInMap("taskId")
        public String taskId;

        public static AppUpdateUserTaskStatusRequestUserTaskStatuses build(java.util.Map<String, ?> map) throws Exception {
            AppUpdateUserTaskStatusRequestUserTaskStatuses self = new AppUpdateUserTaskStatusRequestUserTaskStatuses();
            return TeaModel.build(map, self);
        }

        public AppUpdateUserTaskStatusRequestUserTaskStatuses setDone(Boolean done) {
            this.done = done;
            return this;
        }
        public Boolean getDone() {
            return this.done;
        }

        public AppUpdateUserTaskStatusRequestUserTaskStatuses setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
