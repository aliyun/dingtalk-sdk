// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetContractMarginResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetContractMarginResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetContractMarginResponse setBody(GetContractMarginResponseBody body) {
        this.body = body;
        return this;
    }
    public GetContractMarginResponseBody getBody() {
        return this.body;
    }

}
