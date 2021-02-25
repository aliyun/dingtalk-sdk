// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetCorpRealnameUrlResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetCorpRealnameUrlResponseBody body;

    public static GetCorpRealnameUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCorpRealnameUrlResponse self = new GetCorpRealnameUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetCorpRealnameUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCorpRealnameUrlResponse setBody(GetCorpRealnameUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCorpRealnameUrlResponseBody getBody() {
        return this.body;
    }

}
