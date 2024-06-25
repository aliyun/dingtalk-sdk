// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class TwoPhaseCommitInventoryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TwoPhaseCommitInventoryResponseBody body;

    public static TwoPhaseCommitInventoryResponse build(java.util.Map<String, ?> map) throws Exception {
        TwoPhaseCommitInventoryResponse self = new TwoPhaseCommitInventoryResponse();
        return TeaModel.build(map, self);
    }

    public TwoPhaseCommitInventoryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TwoPhaseCommitInventoryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TwoPhaseCommitInventoryResponse setBody(TwoPhaseCommitInventoryResponseBody body) {
        this.body = body;
        return this;
    }
    public TwoPhaseCommitInventoryResponseBody getBody() {
        return this.body;
    }

}
