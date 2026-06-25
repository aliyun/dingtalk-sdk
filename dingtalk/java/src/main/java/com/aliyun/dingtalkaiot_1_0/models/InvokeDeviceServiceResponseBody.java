// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class InvokeDeviceServiceResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("invocationId")
    public String invocationId;

    @NameInMap("outputData")
    public java.util.Map<String, ?> outputData;

    @NameInMap("status")
    public String status;

    public static InvokeDeviceServiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InvokeDeviceServiceResponseBody self = new InvokeDeviceServiceResponseBody();
        return TeaModel.build(map, self);
    }

    public InvokeDeviceServiceResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public InvokeDeviceServiceResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public InvokeDeviceServiceResponseBody setInvocationId(String invocationId) {
        this.invocationId = invocationId;
        return this;
    }
    public String getInvocationId() {
        return this.invocationId;
    }

    public InvokeDeviceServiceResponseBody setOutputData(java.util.Map<String, ?> outputData) {
        this.outputData = outputData;
        return this;
    }
    public java.util.Map<String, ?> getOutputData() {
        return this.outputData;
    }

    public InvokeDeviceServiceResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
