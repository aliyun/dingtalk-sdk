// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AddCustomerTrackResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public AddCustomerTrackResponseBody body;

    public static AddCustomerTrackResponse build(java.util.Map<String, ?> map) throws Exception {
        AddCustomerTrackResponse self = new AddCustomerTrackResponse();
        return TeaModel.build(map, self);
    }

    public AddCustomerTrackResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddCustomerTrackResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddCustomerTrackResponse setBody(AddCustomerTrackResponseBody body) {
        this.body = body;
        return this;
    }
    public AddCustomerTrackResponseBody getBody() {
        return this.body;
    }

}
