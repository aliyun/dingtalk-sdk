// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetConversationUrlResponseBody extends TeaModel {
    /**
     * <p>会话url</p>
     */
    @NameInMap("url")
    public String url;

    public static GetConversationUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetConversationUrlResponseBody self = new GetConversationUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetConversationUrlResponseBody setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
