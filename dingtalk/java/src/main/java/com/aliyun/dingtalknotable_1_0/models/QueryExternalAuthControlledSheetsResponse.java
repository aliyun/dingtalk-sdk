// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class QueryExternalAuthControlledSheetsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryExternalAuthControlledSheetsResponseBody body;

    public static QueryExternalAuthControlledSheetsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryExternalAuthControlledSheetsResponse self = new QueryExternalAuthControlledSheetsResponse();
        return TeaModel.build(map, self);
    }

    public QueryExternalAuthControlledSheetsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryExternalAuthControlledSheetsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryExternalAuthControlledSheetsResponse setBody(QueryExternalAuthControlledSheetsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryExternalAuthControlledSheetsResponseBody getBody() {
        return this.body;
    }

}
