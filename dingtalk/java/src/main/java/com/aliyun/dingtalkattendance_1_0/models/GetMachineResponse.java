// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetMachineResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetMachineResponse setBody(GetMachineResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMachineResponseBody getBody() {
        return this.body;
    }

}
