// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class CleanFileResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CleanFileResponseBody body;

    public static CleanFileResponse build(java.util.Map<String, ?> map) throws Exception {
        CleanFileResponse self = new CleanFileResponse();
        return TeaModel.build(map, self);
    }

    public CleanFileResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CleanFileResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CleanFileResponse setBody(CleanFileResponseBody body) {
        this.body = body;
        return this;
    }
    public CleanFileResponseBody getBody() {
        return this.body;
    }

}
