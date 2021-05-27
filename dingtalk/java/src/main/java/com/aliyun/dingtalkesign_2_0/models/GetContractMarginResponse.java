// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetContractMarginResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetContractMarginResponseBody body;

    public static GetContractMarginResponse build(java.util.Map<String, ?> map) throws Exception {
        GetContractMarginResponse self = new GetContractMarginResponse();
        return TeaModel.build(map, self);
    }

    public GetContractMarginResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetContractMarginResponse setBody(GetContractMarginResponseBody body) {
        this.body = body;
        return this;
    }
    public GetContractMarginResponseBody getBody() {
        return this.body;
    }

}
