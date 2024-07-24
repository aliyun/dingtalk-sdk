// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryUnfurlingRegisterInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryUnfurlingRegisterInfoResponseBody body;

    public static QueryUnfurlingRegisterInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUnfurlingRegisterInfoResponse self = new QueryUnfurlingRegisterInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryUnfurlingRegisterInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUnfurlingRegisterInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUnfurlingRegisterInfoResponse setBody(QueryUnfurlingRegisterInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUnfurlingRegisterInfoResponseBody getBody() {
        return this.body;
    }

}
