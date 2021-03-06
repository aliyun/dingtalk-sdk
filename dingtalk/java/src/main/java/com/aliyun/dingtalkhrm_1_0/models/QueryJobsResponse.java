// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryJobsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryJobsResponseBody body;

    public static QueryJobsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryJobsResponse self = new QueryJobsResponse();
        return TeaModel.build(map, self);
    }

    public QueryJobsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryJobsResponse setBody(QueryJobsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryJobsResponseBody getBody() {
        return this.body;
    }

}
