// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class CorpRealnameResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public CorpRealnameResponse setBody(CorpRealnameResponseBody body) {
        this.body = body;
        return this;
    }
    public CorpRealnameResponseBody getBody() {
        return this.body;
    }

}
