// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalgo_1_0.models;

import com.aliyun.tea.*;

public class NlpWordDistinguishResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public NlpWordDistinguishResponseBody body;

    public static NlpWordDistinguishResponse build(java.util.Map<String, ?> map) throws Exception {
        NlpWordDistinguishResponse self = new NlpWordDistinguishResponse();
        return TeaModel.build(map, self);
    }

    public NlpWordDistinguishResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public NlpWordDistinguishResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public NlpWordDistinguishResponse setBody(NlpWordDistinguishResponseBody body) {
        this.body = body;
        return this;
    }
    public NlpWordDistinguishResponseBody getBody() {
        return this.body;
    }

}
