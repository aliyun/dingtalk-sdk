// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class CreateIntegratedTaskRequest extends TeaModel {
    @NameInMap("activityId")
    public String activityId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tasks")
    public java.util.List<CreateIntegratedTaskRequestTasks> tasks;

    public static CreateIntegratedTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateIntegratedTaskRequest self = new CreateIntegratedTaskRequest();
        return TeaModel.build(map, self);
    }

    public CreateIntegratedTaskRequest setActivityId(String activityId) {
        this.activityId = activityId;
        return this;
    }
    public String getActivityId() {
        return this.activityId;
    }

    public CreateIntegratedTaskRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public CreateIntegratedTaskRequest setTasks(java.util.List<CreateIntegratedTaskRequestTasks> tasks) {
        this.tasks = tasks;
        return this;
    }
    public java.util.List<CreateIntegratedTaskRequestTasks> getTasks() {
        return this.tasks;
    }

    public static class CreateIntegratedTaskRequestTasks extends TeaModel {
        @NameInMap("customData")
        public String customData;

        @NameInMap("url")
        public String url;

        @NameInMap("userId")
        public String userId;

        public static CreateIntegratedTaskRequestTasks build(java.util.Map<String, ?> map) throws Exception {
            CreateIntegratedTaskRequestTasks self = new CreateIntegratedTaskRequestTasks();
            return TeaModel.build(map, self);
        }

        public CreateIntegratedTaskRequestTasks setCustomData(String customData) {
            this.customData = customData;
            return this;
        }
        public String getCustomData() {
            return this.customData;
        }

        public CreateIntegratedTaskRequestTasks setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public CreateIntegratedTaskRequestTasks setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
