// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryPermissionByUserIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryPermissionByUserIdResponseBody body;

    public static QueryPermissionByUserIdResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryPermissionByUserIdResponse self = new QueryPermissionByUserIdResponse();
        return TeaModel.build(map, self);
    }

    public QueryPermissionByUserIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryPermissionByUserIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryPermissionByUserIdResponse setBody(QueryPermissionByUserIdResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPermissionByUserIdResponseBody getBody() {
        return this.body;
    }

}
