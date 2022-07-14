// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class QueryEventResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryEventResponseBody body;

    public static QueryEventResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryEventResponse self = new QueryEventResponse();
        return TeaModel.build(map, self);
    }

    public QueryEventResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryEventResponse setBody(QueryEventResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryEventResponseBody getBody() {
        return this.body;
    }

}
