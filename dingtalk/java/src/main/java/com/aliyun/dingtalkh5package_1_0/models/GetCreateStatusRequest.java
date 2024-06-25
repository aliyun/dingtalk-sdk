// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh5package_1_0.models;

import com.aliyun.tea.*;

public class GetCreateStatusRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1663748308644pjpF</p>
     */
    @NameInMap("taskId")
    public String taskId;

    public static GetCreateStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCreateStatusRequest self = new GetCreateStatusRequest();
        return TeaModel.build(map, self);
    }

    public GetCreateStatusRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
