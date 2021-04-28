// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryServiceGroupMessageReadStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryServiceGroupMessageReadStatusResponseBody body;

    public static QueryServiceGroupMessageReadStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryServiceGroupMessageReadStatusResponse self = new QueryServiceGroupMessageReadStatusResponse();
        return TeaModel.build(map, self);
    }

    public QueryServiceGroupMessageReadStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryServiceGroupMessageReadStatusResponse setBody(QueryServiceGroupMessageReadStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryServiceGroupMessageReadStatusResponseBody getBody() {
        return this.body;
    }

}
