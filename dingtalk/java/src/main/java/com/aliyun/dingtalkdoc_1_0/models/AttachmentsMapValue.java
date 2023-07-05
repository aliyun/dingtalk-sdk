// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class AttachmentsMapValue extends TeaModel {
    @NameInMap("uploadKey")
    public String uploadKey;

    @NameInMap("name")
    public String name;

    @NameInMap("mediaType")
    public String mediaType;

    public static AttachmentsMapValue build(java.util.Map<String, ?> map) throws Exception {
        AttachmentsMapValue self = new AttachmentsMapValue();
        return TeaModel.build(map, self);
    }

    public AttachmentsMapValue setUploadKey(String uploadKey) {
        this.uploadKey = uploadKey;
        return this;
    }
    public String getUploadKey() {
        return this.uploadKey;
    }

    public AttachmentsMapValue setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public AttachmentsMapValue setMediaType(String mediaType) {
        this.mediaType = mediaType;
        return this;
    }
    public String getMediaType() {
        return this.mediaType;
    }

}
