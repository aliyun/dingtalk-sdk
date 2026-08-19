// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_1_0.models;

import com.aliyun.tea.*;

public class CustomeRpcCallResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public java.util.List<java.util.Map<String, ?>> result;

    @NameInMap("success")
    public String success;

    public static CustomeRpcCallResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CustomeRpcCallResponseBody self = new CustomeRpcCallResponseBody();
        return TeaModel.build(map, self);
    }

    public CustomeRpcCallResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public CustomeRpcCallResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public CustomeRpcCallResponseBody setResult(java.util.List<java.util.Map<String, ?>> result) {
        this.result = result;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getResult() {
        return this.result;
    }

    public CustomeRpcCallResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

}
