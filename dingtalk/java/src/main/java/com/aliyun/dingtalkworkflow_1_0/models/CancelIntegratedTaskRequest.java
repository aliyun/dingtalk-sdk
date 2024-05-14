// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class CancelIntegratedTaskRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("activityId")
    public String activityId;

    @NameInMap("activityIds")
    public java.util.List<String> activityIds;

    /**
     * <p>This parameter is required.</p>
     */
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
