// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesAudioResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryMinutesAudioResponseBody body;

    public static QueryMinutesAudioResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesAudioResponse self = new QueryMinutesAudioResponse();
        return TeaModel.build(map, self);
    }

    public QueryMinutesAudioResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMinutesAudioResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMinutesAudioResponse setBody(QueryMinutesAudioResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMinutesAudioResponseBody getBody() {
        return this.body;
    }

}
