// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class AddLiveNoticeWidgetResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddLiveNoticeWidgetResponseBody body;

    public static AddLiveNoticeWidgetResponse build(java.util.Map<String, ?> map) throws Exception {
        AddLiveNoticeWidgetResponse self = new AddLiveNoticeWidgetResponse();
        return TeaModel.build(map, self);
    }

    public AddLiveNoticeWidgetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddLiveNoticeWidgetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddLiveNoticeWidgetResponse setBody(AddLiveNoticeWidgetResponseBody body) {
        this.body = body;
        return this;
    }
    public AddLiveNoticeWidgetResponseBody getBody() {
        return this.body;
    }

}
