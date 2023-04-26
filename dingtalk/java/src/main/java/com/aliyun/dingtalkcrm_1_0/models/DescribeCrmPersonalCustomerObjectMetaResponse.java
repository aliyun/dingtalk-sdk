// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DescribeCrmPersonalCustomerObjectMetaResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DescribeCrmPersonalCustomerObjectMetaResponseBody body;

    public static DescribeCrmPersonalCustomerObjectMetaResponse build(java.util.Map<String, ?> map) throws Exception {
        DescribeCrmPersonalCustomerObjectMetaResponse self = new DescribeCrmPersonalCustomerObjectMetaResponse();
        return TeaModel.build(map, self);
    }

    public DescribeCrmPersonalCustomerObjectMetaResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DescribeCrmPersonalCustomerObjectMetaResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DescribeCrmPersonalCustomerObjectMetaResponse setBody(DescribeCrmPersonalCustomerObjectMetaResponseBody body) {
        this.body = body;
        return this;
    }
    public DescribeCrmPersonalCustomerObjectMetaResponseBody getBody() {
        return this.body;
    }

}
