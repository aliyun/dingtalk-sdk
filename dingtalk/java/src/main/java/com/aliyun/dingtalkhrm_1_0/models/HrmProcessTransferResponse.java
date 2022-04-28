// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmProcessTransferResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public HrmProcessTransferResponse setBody(HrmProcessTransferResponseBody body) {
        this.body = body;
        return this;
    }
    public HrmProcessTransferResponseBody getBody() {
        return this.body;
    }

}
