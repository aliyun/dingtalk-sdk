// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListEmpLeaveRecordsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListEmpLeaveRecordsResponseBody body;

    public static ListEmpLeaveRecordsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListEmpLeaveRecordsResponse self = new ListEmpLeaveRecordsResponse();
        return TeaModel.build(map, self);
    }

    public ListEmpLeaveRecordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListEmpLeaveRecordsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListEmpLeaveRecordsResponse setBody(ListEmpLeaveRecordsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListEmpLeaveRecordsResponseBody getBody() {
        return this.body;
    }

}
