// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class ContractMarginResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ContractMarginResponseBody body;

    public static ContractMarginResponse build(java.util.Map<String, ?> map) throws Exception {
        ContractMarginResponse self = new ContractMarginResponse();
        return TeaModel.build(map, self);
    }

    public ContractMarginResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ContractMarginResponse setBody(ContractMarginResponseBody body) {
        this.body = body;
        return this;
    }
    public ContractMarginResponseBody getBody() {
        return this.body;
    }

}
