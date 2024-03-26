// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportPromEvalResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainImportPromEvalResponseBody body;

    public static HrbrainImportPromEvalResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportPromEvalResponse self = new HrbrainImportPromEvalResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainImportPromEvalResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainImportPromEvalResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainImportPromEvalResponse setBody(HrbrainImportPromEvalResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainImportPromEvalResponseBody getBody() {
        return this.body;
    }

}
