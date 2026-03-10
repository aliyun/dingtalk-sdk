// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class PutMsgCardTopByIntelligentResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PutMsgCardTopByIntelligentResponseBody body;

    public static PutMsgCardTopByIntelligentResponse build(java.util.Map<String, ?> map) throws Exception {
        PutMsgCardTopByIntelligentResponse self = new PutMsgCardTopByIntelligentResponse();
        return TeaModel.build(map, self);
    }

    public PutMsgCardTopByIntelligentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PutMsgCardTopByIntelligentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PutMsgCardTopByIntelligentResponse setBody(PutMsgCardTopByIntelligentResponseBody body) {
        this.body = body;
        return this;
    }
    public PutMsgCardTopByIntelligentResponseBody getBody() {
        return this.body;
    }

}
