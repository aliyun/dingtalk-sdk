// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryUserMinutesPermissionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryUserMinutesPermissionResponseBody body;

    public static QueryUserMinutesPermissionResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserMinutesPermissionResponse self = new QueryUserMinutesPermissionResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserMinutesPermissionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserMinutesPermissionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUserMinutesPermissionResponse setBody(QueryUserMinutesPermissionResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserMinutesPermissionResponseBody getBody() {
        return this.body;
    }

}
