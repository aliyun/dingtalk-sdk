// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class QueryBusinessCodeInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryBusinessCodeInfoResponseBody body;

    public static QueryBusinessCodeInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryBusinessCodeInfoResponse self = new QueryBusinessCodeInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryBusinessCodeInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryBusinessCodeInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryBusinessCodeInfoResponse setBody(QueryBusinessCodeInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryBusinessCodeInfoResponseBody getBody() {
        return this.body;
    }

}
