// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryUserOnGoingConferenceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryUserOnGoingConferenceResponseBody body;

    public static QueryUserOnGoingConferenceResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserOnGoingConferenceResponse self = new QueryUserOnGoingConferenceResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserOnGoingConferenceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserOnGoingConferenceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUserOnGoingConferenceResponse setBody(QueryUserOnGoingConferenceResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserOnGoingConferenceResponseBody getBody() {
        return this.body;
    }

}
