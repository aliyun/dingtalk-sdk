// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgPointDetailsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryOrgPointDetailsResponseBody body;

    public static QueryOrgPointDetailsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgPointDetailsResponse self = new QueryOrgPointDetailsResponse();
        return TeaModel.build(map, self);
    }

    public QueryOrgPointDetailsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOrgPointDetailsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryOrgPointDetailsResponse setBody(QueryOrgPointDetailsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOrgPointDetailsResponseBody getBody() {
        return this.body;
    }

}
