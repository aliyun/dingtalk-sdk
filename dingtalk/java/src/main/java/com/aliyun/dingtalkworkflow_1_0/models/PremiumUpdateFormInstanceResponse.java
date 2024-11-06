// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumUpdateFormInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumUpdateFormInstanceResponseBody body;

    public static PremiumUpdateFormInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumUpdateFormInstanceResponse self = new PremiumUpdateFormInstanceResponse();
        return TeaModel.build(map, self);
    }

    public PremiumUpdateFormInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumUpdateFormInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumUpdateFormInstanceResponse setBody(PremiumUpdateFormInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumUpdateFormInstanceResponseBody getBody() {
        return this.body;
    }

}
