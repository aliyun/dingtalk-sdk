// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllMemberByGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryAllMemberByGroupResponseBody body;

    public static QueryAllMemberByGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAllMemberByGroupResponse self = new QueryAllMemberByGroupResponse();
        return TeaModel.build(map, self);
    }

    public QueryAllMemberByGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAllMemberByGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAllMemberByGroupResponse setBody(QueryAllMemberByGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAllMemberByGroupResponseBody getBody() {
        return this.body;
    }

}
