// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetProcessInstanceRequest extends TeaModel {
    /**
     * <p>审批实例ID企业内部应用可通过获取审批实例ID列表接口获取。钉钉三方企业应用可以通过推送的审批事件中获取，参考biz_type=22。</p>
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
