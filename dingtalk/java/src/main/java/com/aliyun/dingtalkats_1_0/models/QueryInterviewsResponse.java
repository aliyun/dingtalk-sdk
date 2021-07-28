// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class QueryInterviewsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryInterviewsResponseBody body;

    public static QueryInterviewsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryInterviewsResponse self = new QueryInterviewsResponse();
        return TeaModel.build(map, self);
    }

    public QueryInterviewsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryInterviewsResponse setBody(QueryInterviewsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryInterviewsResponseBody getBody() {
        return this.body;
    }

}
