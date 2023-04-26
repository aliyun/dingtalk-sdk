// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListPunchScheduleByConditionWithPagingResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

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

    public ListPunchScheduleByConditionWithPagingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListPunchScheduleByConditionWithPagingResponse setBody(ListPunchScheduleByConditionWithPagingResponseBody body) {
        this.body = body;
        return this;
    }
    public ListPunchScheduleByConditionWithPagingResponseBody getBody() {
        return this.body;
    }

}
