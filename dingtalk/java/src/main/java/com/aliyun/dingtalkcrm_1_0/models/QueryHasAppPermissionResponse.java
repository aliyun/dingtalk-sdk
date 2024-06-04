// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryHasAppPermissionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryHasAppPermissionResponseBody body;

    public static QueryHasAppPermissionResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryHasAppPermissionResponse self = new QueryHasAppPermissionResponse();
        return TeaModel.build(map, self);
    }

    public QueryHasAppPermissionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryHasAppPermissionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryHasAppPermissionResponse setBody(QueryHasAppPermissionResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryHasAppPermissionResponseBody getBody() {
        return this.body;
    }

}
