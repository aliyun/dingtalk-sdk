// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryPermissionByUserIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryPermissionByUserIdResponse setBody(QueryPermissionByUserIdResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPermissionByUserIdResponseBody getBody() {
        return this.body;
    }

}
