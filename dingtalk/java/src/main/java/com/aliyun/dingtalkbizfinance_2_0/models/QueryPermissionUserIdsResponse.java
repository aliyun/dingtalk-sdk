// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryPermissionUserIdsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryPermissionUserIdsResponseBody body;

    public static QueryPermissionUserIdsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryPermissionUserIdsResponse self = new QueryPermissionUserIdsResponse();
        return TeaModel.build(map, self);
    }

    public QueryPermissionUserIdsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryPermissionUserIdsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryPermissionUserIdsResponse setBody(QueryPermissionUserIdsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPermissionUserIdsResponseBody getBody() {
        return this.body;
    }

}
