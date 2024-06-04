// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class ListAvailableBenefitResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListAvailableBenefitResponseBody body;

    public static ListAvailableBenefitResponse build(java.util.Map<String, ?> map) throws Exception {
        ListAvailableBenefitResponse self = new ListAvailableBenefitResponse();
        return TeaModel.build(map, self);
    }

    public ListAvailableBenefitResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListAvailableBenefitResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListAvailableBenefitResponse setBody(ListAvailableBenefitResponseBody body) {
        this.body = body;
        return this;
    }
    public ListAvailableBenefitResponseBody getBody() {
        return this.body;
    }

}
