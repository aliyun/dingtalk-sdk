// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetDefaultChildResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetDefaultChildResponseBody body;

    public static GetDefaultChildResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDefaultChildResponse self = new GetDefaultChildResponse();
        return TeaModel.build(map, self);
    }

    public GetDefaultChildResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDefaultChildResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDefaultChildResponse setBody(GetDefaultChildResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDefaultChildResponseBody getBody() {
        return this.body;
    }

}
