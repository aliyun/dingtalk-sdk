// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleAttachmentPermissonRequest extends TeaModel {
    @NameInMap("fileId")
    public String fileId;

    @NameInMap("spaceId")
    public String spaceId;

    @NameInMap("userId")
    public String userId;

    public static AISaleAttachmentPermissonRequest build(java.util.Map<String, ?> map) throws Exception {
        AISaleAttachmentPermissonRequest self = new AISaleAttachmentPermissonRequest();
        return TeaModel.build(map, self);
    }

    public AISaleAttachmentPermissonRequest setFileId(String fileId) {
        this.fileId = fileId;
        return this;
    }
    public String getFileId() {
        return this.fileId;
    }

    public AISaleAttachmentPermissonRequest setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

    public AISaleAttachmentPermissonRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
