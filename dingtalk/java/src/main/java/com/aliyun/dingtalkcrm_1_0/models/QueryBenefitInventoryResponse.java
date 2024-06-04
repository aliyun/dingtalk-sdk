// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryBenefitInventoryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryBenefitInventoryResponseBody body;

    public static QueryBenefitInventoryResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryBenefitInventoryResponse self = new QueryBenefitInventoryResponse();
        return TeaModel.build(map, self);
    }

    public QueryBenefitInventoryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryBenefitInventoryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryBenefitInventoryResponse setBody(QueryBenefitInventoryResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryBenefitInventoryResponseBody getBody() {
        return this.body;
    }

}
