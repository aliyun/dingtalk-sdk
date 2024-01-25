// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListContactRestrictSettingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListContactRestrictSettingResponseBody body;

    public static ListContactRestrictSettingResponse build(java.util.Map<String, ?> map) throws Exception {
        ListContactRestrictSettingResponse self = new ListContactRestrictSettingResponse();
        return TeaModel.build(map, self);
    }

    public ListContactRestrictSettingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListContactRestrictSettingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListContactRestrictSettingResponse setBody(ListContactRestrictSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public ListContactRestrictSettingResponseBody getBody() {
        return this.body;
    }

}
