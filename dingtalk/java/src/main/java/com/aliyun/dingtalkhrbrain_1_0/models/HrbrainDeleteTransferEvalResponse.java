// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteTransferEvalResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainDeleteTransferEvalResponseBody body;

    public static HrbrainDeleteTransferEvalResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteTransferEvalResponse self = new HrbrainDeleteTransferEvalResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteTransferEvalResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainDeleteTransferEvalResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainDeleteTransferEvalResponse setBody(HrbrainDeleteTransferEvalResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainDeleteTransferEvalResponseBody getBody() {
        return this.body;
    }

}
