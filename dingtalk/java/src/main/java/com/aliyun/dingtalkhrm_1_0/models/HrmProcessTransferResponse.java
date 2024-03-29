// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmProcessTransferResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrmProcessTransferResponseBody body;

    public static HrmProcessTransferResponse build(java.util.Map<String, ?> map) throws Exception {
        HrmProcessTransferResponse self = new HrmProcessTransferResponse();
        return TeaModel.build(map, self);
    }

    public HrmProcessTransferResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrmProcessTransferResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrmProcessTransferResponse setBody(HrmProcessTransferResponseBody body) {
        this.body = body;
        return this;
    }
    public HrmProcessTransferResponseBody getBody() {
        return this.body;
    }

}
