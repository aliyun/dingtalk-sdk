// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetProcessConfigRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PROC-BEFC22B7-EA64-4336-86EB-AB773AA2EB12</p>
     */
    @NameInMap("procCode")
    public String procCode;

    public static GetProcessConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        GetProcessConfigRequest self = new GetProcessConfigRequest();
        return TeaModel.build(map, self);
    }

    public GetProcessConfigRequest setProcCode(String procCode) {
        this.procCode = procCode;
        return this;
    }
    public String getProcCode() {
        return this.procCode;
    }

}
