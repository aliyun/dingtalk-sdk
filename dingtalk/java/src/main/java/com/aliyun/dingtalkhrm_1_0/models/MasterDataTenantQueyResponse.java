// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDataTenantQueyResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public MasterDataTenantQueyResponseBody body;

    public static MasterDataTenantQueyResponse build(java.util.Map<String, ?> map) throws Exception {
        MasterDataTenantQueyResponse self = new MasterDataTenantQueyResponse();
        return TeaModel.build(map, self);
    }

    public MasterDataTenantQueyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public MasterDataTenantQueyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public MasterDataTenantQueyResponse setBody(MasterDataTenantQueyResponseBody body) {
        this.body = body;
        return this;
    }
    public MasterDataTenantQueyResponseBody getBody() {
        return this.body;
    }

}
