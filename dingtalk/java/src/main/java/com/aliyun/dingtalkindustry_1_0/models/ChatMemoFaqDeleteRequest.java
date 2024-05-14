// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoFaqDeleteRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("datasetId")
    public Long datasetId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("mediaId")
    public String mediaId;

    public static ChatMemoFaqDeleteRequest build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoFaqDeleteRequest self = new ChatMemoFaqDeleteRequest();
        return TeaModel.build(map, self);
    }

    public ChatMemoFaqDeleteRequest setDatasetId(Long datasetId) {
        this.datasetId = datasetId;
        return this;
    }
    public Long getDatasetId() {
        return this.datasetId;
    }

    public ChatMemoFaqDeleteRequest setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

}
