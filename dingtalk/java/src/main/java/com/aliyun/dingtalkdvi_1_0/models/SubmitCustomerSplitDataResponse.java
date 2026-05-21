// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class SubmitCustomerSplitDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SubmitCustomerSplitDataResponseBody body;

    public static SubmitCustomerSplitDataResponse build(java.util.Map<String, ?> map) throws Exception {
        SubmitCustomerSplitDataResponse self = new SubmitCustomerSplitDataResponse();
        return TeaModel.build(map, self);
    }

    public SubmitCustomerSplitDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SubmitCustomerSplitDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SubmitCustomerSplitDataResponse setBody(SubmitCustomerSplitDataResponseBody body) {
        this.body = body;
        return this;
    }
    public SubmitCustomerSplitDataResponseBody getBody() {
        return this.body;
    }

}
