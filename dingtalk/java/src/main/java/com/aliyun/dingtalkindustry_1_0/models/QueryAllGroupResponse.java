// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryAllGroupResponseBody body;

    public static QueryAllGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAllGroupResponse self = new QueryAllGroupResponse();
        return TeaModel.build(map, self);
    }

    public QueryAllGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAllGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAllGroupResponse setBody(QueryAllGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAllGroupResponseBody getBody() {
        return this.body;
    }

}
