// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetFloatImageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetFloatImageResponseBody body;

    public static GetFloatImageResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFloatImageResponse self = new GetFloatImageResponse();
        return TeaModel.build(map, self);
    }

    public GetFloatImageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFloatImageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFloatImageResponse setBody(GetFloatImageResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFloatImageResponseBody getBody() {
        return this.body;
    }

}
