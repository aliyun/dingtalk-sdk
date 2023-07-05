// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkevent_1_0.models;

import com.aliyun.tea.*;

public class RePushSuiteTicketResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public RePushSuiteTicketResponseBody body;

    public static RePushSuiteTicketResponse build(java.util.Map<String, ?> map) throws Exception {
        RePushSuiteTicketResponse self = new RePushSuiteTicketResponse();
        return TeaModel.build(map, self);
    }

    public RePushSuiteTicketResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RePushSuiteTicketResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RePushSuiteTicketResponse setBody(RePushSuiteTicketResponseBody body) {
        this.body = body;
        return this;
    }
    public RePushSuiteTicketResponseBody getBody() {
        return this.body;
    }

}
