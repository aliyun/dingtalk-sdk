// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class GetSwitchResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSwitchResponseBody body;

    public static GetSwitchResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSwitchResponse self = new GetSwitchResponse();
        return TeaModel.build(map, self);
    }

    public GetSwitchResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSwitchResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSwitchResponse setBody(GetSwitchResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSwitchResponseBody getBody() {
        return this.body;
    }

}
