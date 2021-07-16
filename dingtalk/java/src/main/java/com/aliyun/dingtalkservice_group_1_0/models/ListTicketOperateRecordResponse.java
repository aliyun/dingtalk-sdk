// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ListTicketOperateRecordResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListTicketOperateRecordResponseBody body;

    public static ListTicketOperateRecordResponse build(java.util.Map<String, ?> map) throws Exception {
        ListTicketOperateRecordResponse self = new ListTicketOperateRecordResponse();
        return TeaModel.build(map, self);
    }

    public ListTicketOperateRecordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListTicketOperateRecordResponse setBody(ListTicketOperateRecordResponseBody body) {
        this.body = body;
        return this;
    }
    public ListTicketOperateRecordResponseBody getBody() {
        return this.body;
    }

}
