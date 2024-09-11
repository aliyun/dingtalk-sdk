// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class AttachmentsMapValue extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>upload_key</p>
     */
    @NameInMap("uploadKey")
    public String uploadKey;

    /**
     * <strong>example:</strong>
     * <p>name</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>media_type</p>
     */
    @NameInMap("mediaType")
    public String mediaType;

    @NameInMap("resourceId")
    public String resourceId;

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

    public AttachmentsMapValue setResourceId(String resourceId) {
        this.resourceId = resourceId;
        return this;
    }
    public String getResourceId() {
        return this.resourceId;
    }

}
