// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesMeetingResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryMinutesMeetingResultResponseBody body;

    public static QueryMinutesMeetingResultResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesMeetingResultResponse self = new QueryMinutesMeetingResultResponse();
        return TeaModel.build(map, self);
    }

    public QueryMinutesMeetingResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMinutesMeetingResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMinutesMeetingResultResponse setBody(QueryMinutesMeetingResultResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMinutesMeetingResultResponseBody getBody() {
        return this.body;
    }

}
