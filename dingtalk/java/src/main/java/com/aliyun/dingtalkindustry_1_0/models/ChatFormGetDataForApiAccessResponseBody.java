// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatFormGetDataForApiAccessResponseBody extends TeaModel {
    @NameInMap("data")
    public String data;

    public static ChatFormGetDataForApiAccessResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatFormGetDataForApiAccessResponseBody self = new ChatFormGetDataForApiAccessResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatFormGetDataForApiAccessResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

}
