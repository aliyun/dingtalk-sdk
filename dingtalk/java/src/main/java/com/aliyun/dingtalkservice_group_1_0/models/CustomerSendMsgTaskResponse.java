// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CustomerSendMsgTaskResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CustomerSendMsgTaskResponseBody body;

    public static CustomerSendMsgTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        CustomerSendMsgTaskResponse self = new CustomerSendMsgTaskResponse();
        return TeaModel.build(map, self);
    }

    public CustomerSendMsgTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CustomerSendMsgTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CustomerSendMsgTaskResponse setBody(CustomerSendMsgTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public CustomerSendMsgTaskResponseBody getBody() {
        return this.body;
    }

}
