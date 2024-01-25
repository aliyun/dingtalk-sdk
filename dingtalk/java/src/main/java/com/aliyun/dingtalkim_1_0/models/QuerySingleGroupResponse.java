// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QuerySingleGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QuerySingleGroupResponseBody body;

    public static QuerySingleGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySingleGroupResponse self = new QuerySingleGroupResponse();
        return TeaModel.build(map, self);
    }

    public QuerySingleGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySingleGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QuerySingleGroupResponse setBody(QuerySingleGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySingleGroupResponseBody getBody() {
        return this.body;
    }

}
