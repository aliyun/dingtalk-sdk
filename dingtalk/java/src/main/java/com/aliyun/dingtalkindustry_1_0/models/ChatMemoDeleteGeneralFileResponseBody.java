// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoDeleteGeneralFileResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static ChatMemoDeleteGeneralFileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoDeleteGeneralFileResponseBody self = new ChatMemoDeleteGeneralFileResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatMemoDeleteGeneralFileResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
