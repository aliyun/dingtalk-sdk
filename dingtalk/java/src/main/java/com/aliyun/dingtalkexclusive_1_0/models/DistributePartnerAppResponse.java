// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class DistributePartnerAppResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public DistributePartnerAppResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DistributePartnerAppResponse setBody(DistributePartnerAppResponseBody body) {
        this.body = body;
        return this;
    }
    public DistributePartnerAppResponseBody getBody() {
        return this.body;
    }

}
