// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class GetMediaUrlsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("mediaIds")
    public java.util.List<String> mediaIds;

    /**
     * <strong>example:</strong>
     * <p>86399</p>
     */
    @NameInMap("urlExpireTime")
    public Integer urlExpireTime;

    public static GetMediaUrlsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetMediaUrlsRequest self = new GetMediaUrlsRequest();
        return TeaModel.build(map, self);
    }

    public GetMediaUrlsRequest setMediaIds(java.util.List<String> mediaIds) {
        this.mediaIds = mediaIds;
        return this;
    }
    public java.util.List<String> getMediaIds() {
        return this.mediaIds;
    }

    public GetMediaUrlsRequest setUrlExpireTime(Integer urlExpireTime) {
        this.urlExpireTime = urlExpireTime;
        return this;
    }
    public Integer getUrlExpireTime() {
        return this.urlExpireTime;
    }

}
