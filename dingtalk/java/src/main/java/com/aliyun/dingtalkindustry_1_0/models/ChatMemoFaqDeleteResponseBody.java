// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoFaqDeleteResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static ChatMemoFaqDeleteResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoFaqDeleteResponseBody self = new ChatMemoFaqDeleteResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatMemoFaqDeleteResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
