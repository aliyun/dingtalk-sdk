// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryCreateMinutesListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCreateMinutesListResponseBody body;

    public static QueryCreateMinutesListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCreateMinutesListResponse self = new QueryCreateMinutesListResponse();
        return TeaModel.build(map, self);
    }

    public QueryCreateMinutesListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCreateMinutesListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCreateMinutesListResponse setBody(QueryCreateMinutesListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCreateMinutesListResponseBody getBody() {
        return this.body;
    }

}
