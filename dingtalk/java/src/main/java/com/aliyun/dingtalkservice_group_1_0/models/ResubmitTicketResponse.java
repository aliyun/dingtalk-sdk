// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ResubmitTicketResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static ResubmitTicketResponse build(java.util.Map<String, ?> map) throws Exception {
        ResubmitTicketResponse self = new ResubmitTicketResponse();
        return TeaModel.build(map, self);
    }

    public ResubmitTicketResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
