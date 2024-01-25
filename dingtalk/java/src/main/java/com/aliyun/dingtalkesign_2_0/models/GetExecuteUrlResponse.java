// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetExecuteUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetExecuteUrlResponseBody body;

    public static GetExecuteUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetExecuteUrlResponse self = new GetExecuteUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetExecuteUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetExecuteUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetExecuteUrlResponse setBody(GetExecuteUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetExecuteUrlResponseBody getBody() {
        return this.body;
    }

}
