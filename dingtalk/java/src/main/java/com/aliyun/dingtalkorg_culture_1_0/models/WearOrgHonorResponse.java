// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class WearOrgHonorResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public WearOrgHonorResponseBody body;

    public static WearOrgHonorResponse build(java.util.Map<String, ?> map) throws Exception {
        WearOrgHonorResponse self = new WearOrgHonorResponse();
        return TeaModel.build(map, self);
    }

    public WearOrgHonorResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public WearOrgHonorResponse setBody(WearOrgHonorResponseBody body) {
        this.body = body;
        return this;
    }
    public WearOrgHonorResponseBody getBody() {
        return this.body;
    }

}
