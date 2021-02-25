// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class CorpInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CorpInfoResponseBody body;

    public static CorpInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        CorpInfoResponse self = new CorpInfoResponse();
        return TeaModel.build(map, self);
    }

    public CorpInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CorpInfoResponse setBody(CorpInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public CorpInfoResponseBody getBody() {
        return this.body;
    }

}
