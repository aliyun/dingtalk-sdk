// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class DistributePartnerAppResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DistributePartnerAppResponseBody body;

    public static DistributePartnerAppResponse build(java.util.Map<String, ?> map) throws Exception {
        DistributePartnerAppResponse self = new DistributePartnerAppResponse();
        return TeaModel.build(map, self);
    }

    public DistributePartnerAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DistributePartnerAppResponse setBody(DistributePartnerAppResponseBody body) {
        this.body = body;
        return this;
    }
    public DistributePartnerAppResponseBody getBody() {
        return this.body;
    }

}
