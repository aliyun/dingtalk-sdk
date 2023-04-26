// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetMachineUserResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetMachineUserResponseBody body;

    public static GetMachineUserResponse build(java.util.Map<String, ?> map) throws Exception {
        GetMachineUserResponse self = new GetMachineUserResponse();
        return TeaModel.build(map, self);
    }

    public GetMachineUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetMachineUserResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetMachineUserResponse setBody(GetMachineUserResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMachineUserResponseBody getBody() {
        return this.body;
    }

}
