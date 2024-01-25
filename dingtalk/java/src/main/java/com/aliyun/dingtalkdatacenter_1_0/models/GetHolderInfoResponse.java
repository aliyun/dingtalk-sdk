// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetHolderInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetHolderInfoResponseBody body;

    public static GetHolderInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetHolderInfoResponse self = new GetHolderInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetHolderInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetHolderInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetHolderInfoResponse setBody(GetHolderInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetHolderInfoResponseBody getBody() {
        return this.body;
    }

}
