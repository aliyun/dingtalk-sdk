// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeletePerfEvalResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainDeletePerfEvalResponseBody body;

    public static HrbrainDeletePerfEvalResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeletePerfEvalResponse self = new HrbrainDeletePerfEvalResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainDeletePerfEvalResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainDeletePerfEvalResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainDeletePerfEvalResponse setBody(HrbrainDeletePerfEvalResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainDeletePerfEvalResponseBody getBody() {
        return this.body;
    }

}
