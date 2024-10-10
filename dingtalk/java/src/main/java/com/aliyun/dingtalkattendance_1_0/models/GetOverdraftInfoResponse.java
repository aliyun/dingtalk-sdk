// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetOverdraftInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetOverdraftInfoResponseBody body;

    public static GetOverdraftInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOverdraftInfoResponse self = new GetOverdraftInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetOverdraftInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOverdraftInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetOverdraftInfoResponse setBody(GetOverdraftInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOverdraftInfoResponseBody getBody() {
        return this.body;
    }

}
