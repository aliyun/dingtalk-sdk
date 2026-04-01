// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class RegenerateChaptersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RegenerateChaptersResponseBody body;

    public static RegenerateChaptersResponse build(java.util.Map<String, ?> map) throws Exception {
        RegenerateChaptersResponse self = new RegenerateChaptersResponse();
        return TeaModel.build(map, self);
    }

    public RegenerateChaptersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RegenerateChaptersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RegenerateChaptersResponse setBody(RegenerateChaptersResponseBody body) {
        this.body = body;
        return this;
    }
    public RegenerateChaptersResponseBody getBody() {
        return this.body;
    }

}
