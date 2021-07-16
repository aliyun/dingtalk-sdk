// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddTicketMemoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static AddTicketMemoResponse build(java.util.Map<String, ?> map) throws Exception {
        AddTicketMemoResponse self = new AddTicketMemoResponse();
        return TeaModel.build(map, self);
    }

    public AddTicketMemoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
