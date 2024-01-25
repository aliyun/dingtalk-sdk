// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class CorpRealnameResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CorpRealnameResponseBody body;

    public static CorpRealnameResponse build(java.util.Map<String, ?> map) throws Exception {
        CorpRealnameResponse self = new CorpRealnameResponse();
        return TeaModel.build(map, self);
    }

    public CorpRealnameResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CorpRealnameResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CorpRealnameResponse setBody(CorpRealnameResponseBody body) {
        this.body = body;
        return this;
    }
    public CorpRealnameResponseBody getBody() {
        return this.body;
    }

}
