// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class PublishFileChangeNoticeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static PublishFileChangeNoticeResponse build(java.util.Map<String, ?> map) throws Exception {
        PublishFileChangeNoticeResponse self = new PublishFileChangeNoticeResponse();
        return TeaModel.build(map, self);
    }

    public PublishFileChangeNoticeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
