// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class RetractTicketResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static RetractTicketResponse build(java.util.Map<String, ?> map) throws Exception {
        RetractTicketResponse self = new RetractTicketResponse();
        return TeaModel.build(map, self);
    }

    public RetractTicketResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
