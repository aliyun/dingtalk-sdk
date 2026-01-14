// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CirclePostRecordResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CirclePostRecordResponseBody body;

    public static CirclePostRecordResponse build(java.util.Map<String, ?> map) throws Exception {
        CirclePostRecordResponse self = new CirclePostRecordResponse();
        return TeaModel.build(map, self);
    }

    public CirclePostRecordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CirclePostRecordResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CirclePostRecordResponse setBody(CirclePostRecordResponseBody body) {
        this.body = body;
        return this;
    }
    public CirclePostRecordResponseBody getBody() {
        return this.body;
    }

}
