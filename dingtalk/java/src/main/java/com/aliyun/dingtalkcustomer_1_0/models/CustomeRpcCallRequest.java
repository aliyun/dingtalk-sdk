// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_1_0.models;

import com.aliyun.tea.*;

public class CustomeRpcCallRequest extends TeaModel {
    @NameInMap("methodName")
    public String methodName;

    @NameInMap("params")
    public java.util.Map<String, ?> params;

    public static CustomeRpcCallRequest build(java.util.Map<String, ?> map) throws Exception {
        CustomeRpcCallRequest self = new CustomeRpcCallRequest();
        return TeaModel.build(map, self);
    }

    public CustomeRpcCallRequest setMethodName(String methodName) {
        this.methodName = methodName;
        return this;
    }
    public String getMethodName() {
        return this.methodName;
    }

    public CustomeRpcCallRequest setParams(java.util.Map<String, ?> params) {
        this.params = params;
        return this;
    }
    public java.util.Map<String, ?> getParams() {
        return this.params;
    }

}
