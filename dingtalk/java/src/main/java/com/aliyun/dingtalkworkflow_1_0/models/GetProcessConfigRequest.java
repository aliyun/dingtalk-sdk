// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetProcessConfigRequest extends TeaModel {
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
