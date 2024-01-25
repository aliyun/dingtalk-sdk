// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QueryDocContentResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryDocContentResponseBody body;

    public static QueryDocContentResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDocContentResponse self = new QueryDocContentResponse();
        return TeaModel.build(map, self);
    }

    public QueryDocContentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDocContentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryDocContentResponse setBody(QueryDocContentResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDocContentResponseBody getBody() {
        return this.body;
    }

}
