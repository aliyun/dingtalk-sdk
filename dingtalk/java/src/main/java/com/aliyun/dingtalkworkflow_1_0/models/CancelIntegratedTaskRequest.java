// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class CancelIntegratedTaskRequest extends TeaModel {
    // 待办组ID，需要在调用创建待办接口时，主动设置该值。
    @NameInMap("activityId")
    public String activityId;

    // 待办组ID列表，用于批量取消。
    @NameInMap("activityIds")
    public java.util.List<String> activityIds;

    // OA审批流程实例ID
    @NameInMap("processInstanceId")
    public String processInstanceId;

    public static CancelIntegratedTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CancelIntegratedTaskRequest self = new CancelIntegratedTaskRequest();
        return TeaModel.build(map, self);
    }

    public CancelIntegratedTaskRequest setActivityId(String activityId) {
        this.activityId = activityId;
        return this;
    }
    public String getActivityId() {
        return this.activityId;
    }

    public CancelIntegratedTaskRequest setActivityIds(java.util.List<String> activityIds) {
        this.activityIds = activityIds;
        return this;
    }
    public java.util.List<String> getActivityIds() {
        return this.activityIds;
    }

    public CancelIntegratedTaskRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

}
