// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetFinanceAccountResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetFinanceAccountResponseBody body;

    public static GetFinanceAccountResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFinanceAccountResponse self = new GetFinanceAccountResponse();
        return TeaModel.build(map, self);
    }

    public GetFinanceAccountResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFinanceAccountResponse setBody(GetFinanceAccountResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFinanceAccountResponseBody getBody() {
        return this.body;
    }

}
