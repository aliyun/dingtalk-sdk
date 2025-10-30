// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryAudioFileResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryAudioFileResponseBody body;

    public static QueryAudioFileResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAudioFileResponse self = new QueryAudioFileResponse();
        return TeaModel.build(map, self);
    }

    public QueryAudioFileResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAudioFileResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAudioFileResponse setBody(QueryAudioFileResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAudioFileResponseBody getBody() {
        return this.body;
    }

}
