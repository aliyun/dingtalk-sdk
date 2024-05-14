// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class GetMediaCerficateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fileName")
    public String fileName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("mcnId")
    public String mcnId;

    @NameInMap("mediaId")
    public String mediaId;

    @NameInMap("mediaIntroduction")
    public String mediaIntroduction;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("mediaTitle")
    public String mediaTitle;

    @NameInMap("thumbUrl")
    public String thumbUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetMediaCerficateRequest build(java.util.Map<String, ?> map) throws Exception {
        GetMediaCerficateRequest self = new GetMediaCerficateRequest();
        return TeaModel.build(map, self);
    }

    public GetMediaCerficateRequest setFileName(String fileName) {
        this.fileName = fileName;
        return this;
    }
    public String getFileName() {
        return this.fileName;
    }

    public GetMediaCerficateRequest setMcnId(String mcnId) {
        this.mcnId = mcnId;
        return this;
    }
    public String getMcnId() {
        return this.mcnId;
    }

    public GetMediaCerficateRequest setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

    public GetMediaCerficateRequest setMediaIntroduction(String mediaIntroduction) {
        this.mediaIntroduction = mediaIntroduction;
        return this;
    }
    public String getMediaIntroduction() {
        return this.mediaIntroduction;
    }

    public GetMediaCerficateRequest setMediaTitle(String mediaTitle) {
        this.mediaTitle = mediaTitle;
        return this;
    }
    public String getMediaTitle() {
        return this.mediaTitle;
    }

    public GetMediaCerficateRequest setThumbUrl(String thumbUrl) {
        this.thumbUrl = thumbUrl;
        return this;
    }
    public String getThumbUrl() {
        return this.thumbUrl;
    }

    public GetMediaCerficateRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
