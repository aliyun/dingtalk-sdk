// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PreDialResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public PreDialResponseBody body;

    public static PreDialResponse build(java.util.Map<String, ?> map) throws Exception {
        PreDialResponse self = new PreDialResponse();
        return TeaModel.build(map, self);
    }

    public PreDialResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PreDialResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PreDialResponse setBody(PreDialResponseBody body) {
        this.body = body;
        return this;
    }
    public PreDialResponseBody getBody() {
        return this.body;
    }

}
