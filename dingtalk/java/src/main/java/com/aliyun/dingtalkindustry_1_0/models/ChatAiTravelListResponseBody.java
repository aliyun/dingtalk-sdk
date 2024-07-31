// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatAiTravelListResponseBody extends TeaModel {
    @NameInMap("content")
    public String content;

    public static ChatAiTravelListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatAiTravelListResponseBody self = new ChatAiTravelListResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatAiTravelListResponseBody setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

}
