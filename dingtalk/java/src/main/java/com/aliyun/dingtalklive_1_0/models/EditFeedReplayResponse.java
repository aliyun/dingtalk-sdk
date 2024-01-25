// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class EditFeedReplayResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EditFeedReplayResponseBody body;

    public static EditFeedReplayResponse build(java.util.Map<String, ?> map) throws Exception {
        EditFeedReplayResponse self = new EditFeedReplayResponse();
        return TeaModel.build(map, self);
    }

    public EditFeedReplayResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EditFeedReplayResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EditFeedReplayResponse setBody(EditFeedReplayResponseBody body) {
        this.body = body;
        return this;
    }
    public EditFeedReplayResponseBody getBody() {
        return this.body;
    }

}
