// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class DelLiveNoticeWidgetResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DelLiveNoticeWidgetResponseBody body;

    public static DelLiveNoticeWidgetResponse build(java.util.Map<String, ?> map) throws Exception {
        DelLiveNoticeWidgetResponse self = new DelLiveNoticeWidgetResponse();
        return TeaModel.build(map, self);
    }

    public DelLiveNoticeWidgetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DelLiveNoticeWidgetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DelLiveNoticeWidgetResponse setBody(DelLiveNoticeWidgetResponseBody body) {
        this.body = body;
        return this;
    }
    public DelLiveNoticeWidgetResponseBody getBody() {
        return this.body;
    }

}
