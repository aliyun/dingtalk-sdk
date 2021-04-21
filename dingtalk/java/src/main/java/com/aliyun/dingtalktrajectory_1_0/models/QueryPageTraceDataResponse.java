// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrajectory_1_0.models;

import com.aliyun.tea.*;

public class QueryPageTraceDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryPageTraceDataResponseBody body;

    public static QueryPageTraceDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryPageTraceDataResponse self = new QueryPageTraceDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryPageTraceDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryPageTraceDataResponse setBody(QueryPageTraceDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPageTraceDataResponseBody getBody() {
        return this.body;
    }

}
