// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class AlignObjectiveResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public AlignObjectiveResponseBody body;

    public static AlignObjectiveResponse build(java.util.Map<String, ?> map) throws Exception {
        AlignObjectiveResponse self = new AlignObjectiveResponse();
        return TeaModel.build(map, self);
    }

    public AlignObjectiveResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AlignObjectiveResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AlignObjectiveResponse setBody(AlignObjectiveResponseBody body) {
        this.body = body;
        return this;
    }
    public AlignObjectiveResponseBody getBody() {
        return this.body;
    }

}
