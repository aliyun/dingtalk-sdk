// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetCorpLevelByAccountIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetCorpLevelByAccountIdResponseBody body;

    public static GetCorpLevelByAccountIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCorpLevelByAccountIdResponse self = new GetCorpLevelByAccountIdResponse();
        return TeaModel.build(map, self);
    }

    public GetCorpLevelByAccountIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCorpLevelByAccountIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCorpLevelByAccountIdResponse setBody(GetCorpLevelByAccountIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCorpLevelByAccountIdResponseBody getBody() {
        return this.body;
    }

}
