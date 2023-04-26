// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class PageListTicketResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public PageListTicketResponseBody body;

    public static PageListTicketResponse build(java.util.Map<String, ?> map) throws Exception {
        PageListTicketResponse self = new PageListTicketResponse();
        return TeaModel.build(map, self);
    }

    public PageListTicketResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PageListTicketResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PageListTicketResponse setBody(PageListTicketResponseBody body) {
        this.body = body;
        return this;
    }
    public PageListTicketResponseBody getBody() {
        return this.body;
    }

}
