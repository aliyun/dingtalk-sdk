// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetVersionInfoResponseBody extends TeaModel {
    @NameInMap("arguments")
    public java.util.List<String> arguments;

    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static GetVersionInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetVersionInfoResponseBody self = new GetVersionInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetVersionInfoResponseBody setArguments(java.util.List<String> arguments) {
        this.arguments = arguments;
        return this;
    }
    public java.util.List<String> getArguments() {
        return this.arguments;
    }

    public GetVersionInfoResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public GetVersionInfoResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public GetVersionInfoResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public GetVersionInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
