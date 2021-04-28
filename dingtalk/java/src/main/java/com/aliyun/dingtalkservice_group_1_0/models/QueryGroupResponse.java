// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryGroupResponseBody body;

    public static QueryGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupResponse self = new QueryGroupResponse();
        return TeaModel.build(map, self);
    }

    public QueryGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryGroupResponse setBody(QueryGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGroupResponseBody getBody() {
        return this.body;
    }

}
