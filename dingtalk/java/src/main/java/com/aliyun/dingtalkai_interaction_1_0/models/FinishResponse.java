// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_interaction_1_0.models;

import com.aliyun.tea.*;

public class FinishResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public FinishResponseBody body;

    public static FinishResponse build(java.util.Map<String, ?> map) throws Exception {
        FinishResponse self = new FinishResponse();
        return TeaModel.build(map, self);
    }

    public FinishResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public FinishResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public FinishResponse setBody(FinishResponseBody body) {
        this.body = body;
        return this;
    }
    public FinishResponseBody getBody() {
        return this.body;
    }

}
