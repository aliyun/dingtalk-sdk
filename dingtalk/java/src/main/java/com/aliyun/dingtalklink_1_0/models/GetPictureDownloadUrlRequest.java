// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class GetPictureDownloadUrlRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>UgIzXXo+Rp3Rqcts7BE08y49Jr6iu6xW4iQ</p>
     */
    @NameInMap("downloadCode")
    public String downloadCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>sid001234</p>
     */
    @NameInMap("sessionId")
    public String sessionId;

    public static GetPictureDownloadUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPictureDownloadUrlRequest self = new GetPictureDownloadUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetPictureDownloadUrlRequest setDownloadCode(String downloadCode) {
        this.downloadCode = downloadCode;
        return this;
    }
    public String getDownloadCode() {
        return this.downloadCode;
    }

    public GetPictureDownloadUrlRequest setSessionId(String sessionId) {
        this.sessionId = sessionId;
        return this;
    }
    public String getSessionId() {
        return this.sessionId;
    }

}
