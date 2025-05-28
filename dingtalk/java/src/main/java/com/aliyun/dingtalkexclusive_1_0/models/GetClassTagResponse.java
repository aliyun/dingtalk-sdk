// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetClassTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetClassTagResponseBody body;

    public static GetClassTagResponse build(java.util.Map<String, ?> map) throws Exception {
        GetClassTagResponse self = new GetClassTagResponse();
        return TeaModel.build(map, self);
    }

    public GetClassTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetClassTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetClassTagResponse setBody(GetClassTagResponseBody body) {
        this.body = body;
        return this;
    }
    public GetClassTagResponseBody getBody() {
        return this.body;
    }

}
