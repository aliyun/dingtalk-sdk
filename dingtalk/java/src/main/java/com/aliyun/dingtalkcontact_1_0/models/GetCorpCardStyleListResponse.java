// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetCorpCardStyleListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetCorpCardStyleListResponseBody body;

    public static GetCorpCardStyleListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCorpCardStyleListResponse self = new GetCorpCardStyleListResponse();
        return TeaModel.build(map, self);
    }

    public GetCorpCardStyleListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCorpCardStyleListResponse setBody(GetCorpCardStyleListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCorpCardStyleListResponseBody getBody() {
        return this.body;
    }

}
