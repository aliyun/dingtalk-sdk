// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetVillageOrgInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetVillageOrgInfoResponseBody body;

    public static GetVillageOrgInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetVillageOrgInfoResponse self = new GetVillageOrgInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetVillageOrgInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetVillageOrgInfoResponse setBody(GetVillageOrgInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetVillageOrgInfoResponseBody getBody() {
        return this.body;
    }

}
