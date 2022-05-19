// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupBanWordsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static GroupBanWordsResponse build(java.util.Map<String, ?> map) throws Exception {
        GroupBanWordsResponse self = new GroupBanWordsResponse();
        return TeaModel.build(map, self);
    }

    public GroupBanWordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
