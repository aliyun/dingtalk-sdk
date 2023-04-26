// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgSecretKeyResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryOrgSecretKeyResponseBody body;

    public static QueryOrgSecretKeyResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgSecretKeyResponse self = new QueryOrgSecretKeyResponse();
        return TeaModel.build(map, self);
    }

    public QueryOrgSecretKeyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOrgSecretKeyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryOrgSecretKeyResponse setBody(QueryOrgSecretKeyResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOrgSecretKeyResponseBody getBody() {
        return this.body;
    }

}
