// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetProcessInstanceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    public static GetProcessInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        GetProcessInstanceRequest self = new GetProcessInstanceRequest();
        return TeaModel.build(map, self);
    }

    public GetProcessInstanceRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

}
