// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetDomainInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetDomainInfoResponseBody body;

    public static GetDomainInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDomainInfoResponse self = new GetDomainInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetDomainInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDomainInfoResponse setBody(GetDomainInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDomainInfoResponseBody getBody() {
        return this.body;
    }

}
