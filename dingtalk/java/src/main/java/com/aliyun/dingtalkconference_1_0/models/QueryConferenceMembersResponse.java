// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryConferenceMembersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryConferenceMembersResponseBody body;

    public static QueryConferenceMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryConferenceMembersResponse self = new QueryConferenceMembersResponse();
        return TeaModel.build(map, self);
    }

    public QueryConferenceMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryConferenceMembersResponse setBody(QueryConferenceMembersResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryConferenceMembersResponseBody getBody() {
        return this.body;
    }

}
