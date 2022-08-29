// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetHolderInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetHolderInfoResponse setBody(GetHolderInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetHolderInfoResponseBody getBody() {
        return this.body;
    }

}
