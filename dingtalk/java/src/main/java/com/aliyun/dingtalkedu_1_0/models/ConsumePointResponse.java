// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ConsumePointResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ConsumePointResponseBody body;

    public static ConsumePointResponse build(java.util.Map<String, ?> map) throws Exception {
        ConsumePointResponse self = new ConsumePointResponse();
        return TeaModel.build(map, self);
    }

    public ConsumePointResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ConsumePointResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ConsumePointResponse setBody(ConsumePointResponseBody body) {
        this.body = body;
        return this;
    }
    public ConsumePointResponseBody getBody() {
        return this.body;
    }

}
