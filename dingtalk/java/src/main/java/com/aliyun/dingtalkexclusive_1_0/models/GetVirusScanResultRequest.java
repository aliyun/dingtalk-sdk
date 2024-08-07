// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetVirusScanResultRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskId")
    public String taskId;

    public static GetVirusScanResultRequest build(java.util.Map<String, ?> map) throws Exception {
        GetVirusScanResultRequest self = new GetVirusScanResultRequest();
        return TeaModel.build(map, self);
    }

    public GetVirusScanResultRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
