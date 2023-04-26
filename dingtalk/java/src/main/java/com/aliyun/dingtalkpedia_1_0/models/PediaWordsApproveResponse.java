// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsApproveResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public PediaWordsApproveResponseBody body;

    public static PediaWordsApproveResponse build(java.util.Map<String, ?> map) throws Exception {
        PediaWordsApproveResponse self = new PediaWordsApproveResponse();
        return TeaModel.build(map, self);
    }

    public PediaWordsApproveResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PediaWordsApproveResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PediaWordsApproveResponse setBody(PediaWordsApproveResponseBody body) {
        this.body = body;
        return this;
    }
    public PediaWordsApproveResponseBody getBody() {
        return this.body;
    }

}
