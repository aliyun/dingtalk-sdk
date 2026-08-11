// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleEntityUpdateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AISaleEntityUpdateResponseBody body;

    public static AISaleEntityUpdateResponse build(java.util.Map<String, ?> map) throws Exception {
        AISaleEntityUpdateResponse self = new AISaleEntityUpdateResponse();
        return TeaModel.build(map, self);
    }

    public AISaleEntityUpdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AISaleEntityUpdateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AISaleEntityUpdateResponse setBody(AISaleEntityUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public AISaleEntityUpdateResponseBody getBody() {
        return this.body;
    }

}
