// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class GetMediaUrlRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("mediaId")
    public String mediaId;

    @NameInMap("urlExpireTime")
    public Integer urlExpireTime;

    public static GetMediaUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetMediaUrlRequest self = new GetMediaUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetMediaUrlRequest setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

    public GetMediaUrlRequest setUrlExpireTime(Integer urlExpireTime) {
        this.urlExpireTime = urlExpireTime;
        return this;
    }
    public Integer getUrlExpireTime() {
        return this.urlExpireTime;
    }

}
