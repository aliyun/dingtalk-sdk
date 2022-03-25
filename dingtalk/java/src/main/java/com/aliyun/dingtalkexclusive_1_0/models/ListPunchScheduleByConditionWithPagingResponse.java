// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListPunchScheduleByConditionWithPagingResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListPunchScheduleByConditionWithPagingResponseBody body;

    public static ListPunchScheduleByConditionWithPagingResponse build(java.util.Map<String, ?> map) throws Exception {
        ListPunchScheduleByConditionWithPagingResponse self = new ListPunchScheduleByConditionWithPagingResponse();
        return TeaModel.build(map, self);
    }

    public ListPunchScheduleByConditionWithPagingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListPunchScheduleByConditionWithPagingResponse setBody(ListPunchScheduleByConditionWithPagingResponseBody body) {
        this.body = body;
        return this;
    }
    public ListPunchScheduleByConditionWithPagingResponseBody getBody() {
        return this.body;
    }

}
