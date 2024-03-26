// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportPerfEvalResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainImportPerfEvalResponseBody body;

    public static HrbrainImportPerfEvalResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportPerfEvalResponse self = new HrbrainImportPerfEvalResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainImportPerfEvalResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainImportPerfEvalResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainImportPerfEvalResponse setBody(HrbrainImportPerfEvalResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainImportPerfEvalResponseBody getBody() {
        return this.body;
    }

}
