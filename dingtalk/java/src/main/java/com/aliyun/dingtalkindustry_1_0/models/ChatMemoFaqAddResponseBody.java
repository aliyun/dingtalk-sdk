// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoFaqAddResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>xxxxx</p>
     */
    @NameInMap("bizId")
    public String bizId;

    /**
     * <strong>example:</strong>
     * <p>aaaa.doc</p>
     */
    @NameInMap("mediaId")
    public String mediaId;

    public static ChatMemoFaqAddResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoFaqAddResponseBody self = new ChatMemoFaqAddResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatMemoFaqAddResponseBody setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public ChatMemoFaqAddResponseBody setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

}
