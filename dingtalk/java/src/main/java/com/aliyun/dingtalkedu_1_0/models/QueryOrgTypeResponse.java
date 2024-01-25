// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgTypeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryOrgTypeResponseBody body;

    public static QueryOrgTypeResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgTypeResponse self = new QueryOrgTypeResponse();
        return TeaModel.build(map, self);
    }

    public QueryOrgTypeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOrgTypeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryOrgTypeResponse setBody(QueryOrgTypeResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOrgTypeResponseBody getBody() {
        return this.body;
    }

}
