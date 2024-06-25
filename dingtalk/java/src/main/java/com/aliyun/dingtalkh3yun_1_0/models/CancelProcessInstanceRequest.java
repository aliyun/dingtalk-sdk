// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class CancelProcessInstanceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>76fa1ccd-cc8a-48ca-b4e5-634fdc7af78c</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    public static CancelProcessInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        CancelProcessInstanceRequest self = new CancelProcessInstanceRequest();
        return TeaModel.build(map, self);
    }

    public CancelProcessInstanceRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

}
