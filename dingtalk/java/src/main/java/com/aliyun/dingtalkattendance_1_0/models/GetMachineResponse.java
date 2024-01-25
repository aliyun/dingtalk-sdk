// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetMachineResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetMachineResponseBody body;

    public static GetMachineResponse build(java.util.Map<String, ?> map) throws Exception {
        GetMachineResponse self = new GetMachineResponse();
        return TeaModel.build(map, self);
    }

    public GetMachineResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetMachineResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetMachineResponse setBody(GetMachineResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMachineResponseBody getBody() {
        return this.body;
    }

}
