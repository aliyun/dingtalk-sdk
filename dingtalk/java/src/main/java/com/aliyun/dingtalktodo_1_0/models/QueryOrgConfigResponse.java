// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgConfigResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryOrgConfigResponseBody body;

    public static QueryOrgConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgConfigResponse self = new QueryOrgConfigResponse();
        return TeaModel.build(map, self);
    }

    public QueryOrgConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOrgConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryOrgConfigResponse setBody(QueryOrgConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOrgConfigResponseBody getBody() {
        return this.body;
    }

}
