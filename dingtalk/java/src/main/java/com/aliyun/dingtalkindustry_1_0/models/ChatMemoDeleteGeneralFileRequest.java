// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoDeleteGeneralFileRequest extends TeaModel {
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

    public static ChatMemoDeleteGeneralFileRequest build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoDeleteGeneralFileRequest self = new ChatMemoDeleteGeneralFileRequest();
        return TeaModel.build(map, self);
    }

    public ChatMemoDeleteGeneralFileRequest setDatasetId(Long datasetId) {
        this.datasetId = datasetId;
        return this;
    }
    public Long getDatasetId() {
        return this.datasetId;
    }

    public ChatMemoDeleteGeneralFileRequest setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

}
