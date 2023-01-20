// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetPatentInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetPatentInfoResponseBody body;

    public static GetPatentInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPatentInfoResponse self = new GetPatentInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetPatentInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPatentInfoResponse setBody(GetPatentInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPatentInfoResponseBody getBody() {
        return this.body;
    }

}
