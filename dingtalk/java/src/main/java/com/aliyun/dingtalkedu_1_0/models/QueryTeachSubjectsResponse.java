// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryTeachSubjectsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryTeachSubjectsResponseBody body;

    public static QueryTeachSubjectsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryTeachSubjectsResponse self = new QueryTeachSubjectsResponse();
        return TeaModel.build(map, self);
    }

    public QueryTeachSubjectsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryTeachSubjectsResponse setBody(QueryTeachSubjectsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryTeachSubjectsResponseBody getBody() {
        return this.body;
    }

}
