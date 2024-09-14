// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class UploadAttachmentRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>@dsa8d87y7c8d8c</p>
     */
    @NameInMap("mediaId")
    public String mediaId;

    /**
     * <strong>example:</strong>
     * <p>16768800278994283</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UploadAttachmentRequest build(java.util.Map<String, ?> map) throws Exception {
        UploadAttachmentRequest self = new UploadAttachmentRequest();
        return TeaModel.build(map, self);
    }

    public UploadAttachmentRequest setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

    public UploadAttachmentRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
