// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalIndicatorBatchQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalIndicatorBatchQueryResponseBody body;

    public static AgoalIndicatorBatchQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalIndicatorBatchQueryResponse self = new AgoalIndicatorBatchQueryResponse();
        return TeaModel.build(map, self);
    }

    public AgoalIndicatorBatchQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalIndicatorBatchQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalIndicatorBatchQueryResponse setBody(AgoalIndicatorBatchQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalIndicatorBatchQueryResponseBody getBody() {
        return this.body;
    }

}
