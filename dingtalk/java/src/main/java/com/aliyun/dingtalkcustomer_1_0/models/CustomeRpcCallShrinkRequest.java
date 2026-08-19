// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_1_0.models;

import com.aliyun.tea.*;

public class CustomeRpcCallShrinkRequest extends TeaModel {
    @NameInMap("methodName")
    public String methodName;

    @NameInMap("params")
    public String paramsShrink;

    public static CustomeRpcCallShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        CustomeRpcCallShrinkRequest self = new CustomeRpcCallShrinkRequest();
        return TeaModel.build(map, self);
    }

    public CustomeRpcCallShrinkRequest setMethodName(String methodName) {
        this.methodName = methodName;
        return this;
    }
    public String getMethodName() {
        return this.methodName;
    }

    public CustomeRpcCallShrinkRequest setParamsShrink(String paramsShrink) {
        this.paramsShrink = paramsShrink;
        return this;
    }
    public String getParamsShrink() {
        return this.paramsShrink;
    }

}
