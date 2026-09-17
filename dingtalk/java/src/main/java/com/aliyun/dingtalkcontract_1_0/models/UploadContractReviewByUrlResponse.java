// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class UploadContractReviewByUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UploadContractReviewByUrlResponseBody body;

    public static UploadContractReviewByUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        UploadContractReviewByUrlResponse self = new UploadContractReviewByUrlResponse();
        return TeaModel.build(map, self);
    }

    public UploadContractReviewByUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UploadContractReviewByUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UploadContractReviewByUrlResponse setBody(UploadContractReviewByUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public UploadContractReviewByUrlResponseBody getBody() {
        return this.body;
    }

}
