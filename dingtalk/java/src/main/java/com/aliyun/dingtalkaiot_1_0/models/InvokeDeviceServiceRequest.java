// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class InvokeDeviceServiceRequest extends TeaModel {
    @NameInMap("args")
    public java.util.Map<String, ?> args;

    @NameInMap("timeoutSeconds")
    public Long timeoutSeconds;

    public static InvokeDeviceServiceRequest build(java.util.Map<String, ?> map) throws Exception {
        InvokeDeviceServiceRequest self = new InvokeDeviceServiceRequest();
        return TeaModel.build(map, self);
    }

    public InvokeDeviceServiceRequest setArgs(java.util.Map<String, ?> args) {
        this.args = args;
        return this;
    }
    public java.util.Map<String, ?> getArgs() {
        return this.args;
    }

    public InvokeDeviceServiceRequest setTimeoutSeconds(Long timeoutSeconds) {
        this.timeoutSeconds = timeoutSeconds;
        return this;
    }
    public Long getTimeoutSeconds() {
        return this.timeoutSeconds;
    }

}
