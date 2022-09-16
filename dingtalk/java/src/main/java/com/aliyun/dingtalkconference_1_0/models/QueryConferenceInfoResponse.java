// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryConferenceInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryConferenceInfoResponseBody body;

    public static QueryConferenceInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryConferenceInfoResponse self = new QueryConferenceInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryConferenceInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryConferenceInfoResponse setBody(QueryConferenceInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryConferenceInfoResponseBody getBody() {
        return this.body;
    }

}
