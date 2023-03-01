// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkblackboard_1_0.models;

import com.aliyun.tea.*;

public class QueryBlackboardSpaceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryBlackboardSpaceResponseBody body;

    public static QueryBlackboardSpaceResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryBlackboardSpaceResponse self = new QueryBlackboardSpaceResponse();
        return TeaModel.build(map, self);
    }

    public QueryBlackboardSpaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryBlackboardSpaceResponse setBody(QueryBlackboardSpaceResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryBlackboardSpaceResponseBody getBody() {
        return this.body;
    }

}
