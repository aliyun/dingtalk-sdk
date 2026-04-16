// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetFilterResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetFilterResponseBody body;

    public static GetFilterResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFilterResponse self = new GetFilterResponse();
        return TeaModel.build(map, self);
    }

    public GetFilterResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFilterResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFilterResponse setBody(GetFilterResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFilterResponseBody getBody() {
        return this.body;
    }

}
