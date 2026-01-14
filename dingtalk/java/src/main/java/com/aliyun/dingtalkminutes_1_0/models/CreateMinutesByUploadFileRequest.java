// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class CreateMinutesByUploadFileRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizId")
    public String bizId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>lJcRnm39OsU4jlFVmRGXXXXX</p>
     */
    @NameInMap("creatorId")
    public String creatorId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="https://media.source/audiotominutes.ogg">https://media.source/audiotominutes.ogg</a></p>
     */
    @NameInMap("mediaFileUrl")
    public String mediaFileUrl;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>audio</p>
     */
    @NameInMap("mediaType")
    public String mediaType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>11-20 录音</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>lJcRnm39OsU4jlFVmRGXXXXX</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static CreateMinutesByUploadFileRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateMinutesByUploadFileRequest self = new CreateMinutesByUploadFileRequest();
        return TeaModel.build(map, self);
    }

    public CreateMinutesByUploadFileRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public CreateMinutesByUploadFileRequest setCreatorId(String creatorId) {
        this.creatorId = creatorId;
        return this;
    }
    public String getCreatorId() {
        return this.creatorId;
    }

    public CreateMinutesByUploadFileRequest setMediaFileUrl(String mediaFileUrl) {
        this.mediaFileUrl = mediaFileUrl;
        return this;
    }
    public String getMediaFileUrl() {
        return this.mediaFileUrl;
    }

    public CreateMinutesByUploadFileRequest setMediaType(String mediaType) {
        this.mediaType = mediaType;
        return this;
    }
    public String getMediaType() {
        return this.mediaType;
    }

    public CreateMinutesByUploadFileRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public CreateMinutesByUploadFileRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
