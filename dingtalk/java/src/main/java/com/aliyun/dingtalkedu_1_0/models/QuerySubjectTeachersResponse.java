// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QuerySubjectTeachersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QuerySubjectTeachersResponseBody body;

    public static QuerySubjectTeachersResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySubjectTeachersResponse self = new QuerySubjectTeachersResponse();
        return TeaModel.build(map, self);
    }

    public QuerySubjectTeachersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySubjectTeachersResponse setBody(QuerySubjectTeachersResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySubjectTeachersResponseBody getBody() {
        return this.body;
    }

}
