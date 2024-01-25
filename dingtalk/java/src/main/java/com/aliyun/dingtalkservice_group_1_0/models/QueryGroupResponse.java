// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryGroupResponseBody body;

    public static QueryGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupResponse self = new QueryGroupResponse();
        return TeaModel.build(map, self);
    }

    public QueryGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryGroupResponse setBody(QueryGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGroupResponseBody getBody() {
        return this.body;
    }

}
