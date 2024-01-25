// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryAllTracksResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryAllTracksResponseBody body;

    public static QueryAllTracksResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAllTracksResponse self = new QueryAllTracksResponse();
        return TeaModel.build(map, self);
    }

    public QueryAllTracksResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAllTracksResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAllTracksResponse setBody(QueryAllTracksResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAllTracksResponseBody getBody() {
        return this.body;
    }

}
