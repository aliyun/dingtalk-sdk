// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class UploadFileResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>$csvsvsdvsvdscs</p>
     */
    @NameInMap("mediaId")
    public String mediaId;

    public static UploadFileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UploadFileResponseBody self = new UploadFileResponseBody();
        return TeaModel.build(map, self);
    }

    public UploadFileResponseBody setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

}
