// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateDeviceCutCustomerSwitchResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static BatchUpdateDeviceCutCustomerSwitchResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateDeviceCutCustomerSwitchResponseBody self = new BatchUpdateDeviceCutCustomerSwitchResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchUpdateDeviceCutCustomerSwitchResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
