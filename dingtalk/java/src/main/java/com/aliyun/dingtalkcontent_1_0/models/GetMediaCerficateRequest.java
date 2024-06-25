// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class GetMediaCerficateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>D:****.mp4</p>
     */
    @NameInMap("fileName")
    public String fileName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>87712****6723412</p>
     */
    @NameInMap("mcnId")
    public String mcnId;

    /**
     * <strong>example:</strong>
     * <p>cd8b21090b6*********b78fa733</p>
     */
    @NameInMap("mediaId")
    public String mediaId;

    /**
     * <strong>example:</strong>
     * <p>视频描述。  长度不超过1024个字符。 UTF-8编码。</p>
     */
    @NameInMap("mediaIntroduction")
    public String mediaIntroduction;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>UploadTest</p>
     */
    @NameInMap("mediaTitle")
    public String mediaTitle;

    /**
     * <strong>example:</strong>
     * <p>https://<em><strong><strong>test.cn/image/D22F553</strong></strong></em>TEST.jpeg</p>
     */
    @NameInMap("thumbUrl")
    public String thumbUrl;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>edb2*****1090b66</p>
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
