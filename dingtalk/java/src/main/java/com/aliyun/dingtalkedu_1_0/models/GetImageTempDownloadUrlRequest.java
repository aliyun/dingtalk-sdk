// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetImageTempDownloadUrlRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("mediaId")
    public String mediaId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sourceType")
    public String sourceType;

    public static GetImageTempDownloadUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetImageTempDownloadUrlRequest self = new GetImageTempDownloadUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetImageTempDownloadUrlRequest setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

    public GetImageTempDownloadUrlRequest setSourceType(String sourceType) {
        this.sourceType = sourceType;
        return this;
    }
    public String getSourceType() {
        return this.sourceType;
    }

}
