// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class QueryNotableInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryNotableInfoResponseBody body;

    public static QueryNotableInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryNotableInfoResponse self = new QueryNotableInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryNotableInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryNotableInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryNotableInfoResponse setBody(QueryNotableInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryNotableInfoResponseBody getBody() {
        return this.body;
    }

}
