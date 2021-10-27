// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryAllFormInstancesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryAllFormInstancesResponseBody body;

    public static QueryAllFormInstancesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAllFormInstancesResponse self = new QueryAllFormInstancesResponse();
        return TeaModel.build(map, self);
    }

    public QueryAllFormInstancesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAllFormInstancesResponse setBody(QueryAllFormInstancesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAllFormInstancesResponseBody getBody() {
        return this.body;
    }

}
