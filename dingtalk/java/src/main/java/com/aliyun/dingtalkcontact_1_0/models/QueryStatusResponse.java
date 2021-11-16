// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryStatusResponseBody body;

    public static QueryStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryStatusResponse self = new QueryStatusResponse();
        return TeaModel.build(map, self);
    }

    public QueryStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryStatusResponse setBody(QueryStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryStatusResponseBody getBody() {
        return this.body;
    }

}
