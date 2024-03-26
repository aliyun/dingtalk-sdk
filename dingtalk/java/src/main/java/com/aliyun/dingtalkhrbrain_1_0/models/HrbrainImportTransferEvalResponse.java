// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportTransferEvalResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainImportTransferEvalResponseBody body;

    public static HrbrainImportTransferEvalResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportTransferEvalResponse self = new HrbrainImportTransferEvalResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainImportTransferEvalResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainImportTransferEvalResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainImportTransferEvalResponse setBody(HrbrainImportTransferEvalResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainImportTransferEvalResponseBody getBody() {
        return this.body;
    }

}
