// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryUserHonorsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryUserHonorsResponseBody body;

    public static QueryUserHonorsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserHonorsResponse self = new QueryUserHonorsResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserHonorsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserHonorsResponse setBody(QueryUserHonorsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserHonorsResponseBody getBody() {
        return this.body;
    }

}
