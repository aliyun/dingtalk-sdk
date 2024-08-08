// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetProcessInstanceWithExtraRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>a171de6c-8bxxxx</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    public static GetProcessInstanceWithExtraRequest build(java.util.Map<String, ?> map) throws Exception {
        GetProcessInstanceWithExtraRequest self = new GetProcessInstanceWithExtraRequest();
        return TeaModel.build(map, self);
    }

    public GetProcessInstanceWithExtraRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

}
