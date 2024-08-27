// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class TransferExclusiveAccountOrgResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TransferExclusiveAccountOrgResponseBody body;

    public static TransferExclusiveAccountOrgResponse build(java.util.Map<String, ?> map) throws Exception {
        TransferExclusiveAccountOrgResponse self = new TransferExclusiveAccountOrgResponse();
        return TeaModel.build(map, self);
    }

    public TransferExclusiveAccountOrgResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TransferExclusiveAccountOrgResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TransferExclusiveAccountOrgResponse setBody(TransferExclusiveAccountOrgResponseBody body) {
        this.body = body;
        return this;
    }
    public TransferExclusiveAccountOrgResponseBody getBody() {
        return this.body;
    }

}
