// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class BankGatewayInvokeResponseBody extends TeaModel {
    @NameInMap("outputData")
    public String outputData;

    public static BankGatewayInvokeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BankGatewayInvokeResponseBody self = new BankGatewayInvokeResponseBody();
        return TeaModel.build(map, self);
    }

    public BankGatewayInvokeResponseBody setOutputData(String outputData) {
        this.outputData = outputData;
        return this;
    }
    public String getOutputData() {
        return this.outputData;
    }

}
