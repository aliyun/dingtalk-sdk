// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class CreateIntegratedTaskRequest extends TeaModel {
    /**
     * <p>待办组ID，调用方提供自定义唯一分组标识</p>
     */
    @NameInMap("activityId")
    public String activityId;

    /**
     * <p>OA审批实例ID，通过创建实例接口获取。</p>
     * <br>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    /**
     * <p>任务列表</p>
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
        /**
         * <p>用户自定义数据，页面跳转时将通过 url 查询参数回传，格式为 customData=xxxxx</p>
         */
        @NameInMap("customData")
        public String customData;

        /**
         * <p>待办事项跳转URL。</p>
         * <p>创建审批实例接口里的url，实现的是钉钉审批应用里的审批单跳转。这个接口里的url，实现的是钉钉待办页面，对应的待办卡片的跳转。两种跳转场景不同。需要注意的是，钉钉的待办页面，也同时支持移动端和PC端，所以这个接口里传的url参数，它所对应的页面也要适配好移动端和PC端。</p>
         * <br>
         */
        @NameInMap("url")
        public String url;

        /**
         * <p>OA审批任务执行人的用户ID</p>
         */
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
