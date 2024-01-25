// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryCrmGroupContactResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCrmGroupContactResponseBody body;

    public static QueryCrmGroupContactResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCrmGroupContactResponse self = new QueryCrmGroupContactResponse();
        return TeaModel.build(map, self);
    }

    public QueryCrmGroupContactResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCrmGroupContactResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCrmGroupContactResponse setBody(QueryCrmGroupContactResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCrmGroupContactResponseBody getBody() {
        return this.body;
    }

}
