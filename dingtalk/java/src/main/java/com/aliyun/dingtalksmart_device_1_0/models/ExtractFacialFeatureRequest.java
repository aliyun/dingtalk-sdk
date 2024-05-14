// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class ExtractFacialFeatureRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("mediaId")
    public String mediaId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userid")
    public String userid;

    public static ExtractFacialFeatureRequest build(java.util.Map<String, ?> map) throws Exception {
        ExtractFacialFeatureRequest self = new ExtractFacialFeatureRequest();
        return TeaModel.build(map, self);
    }

    public ExtractFacialFeatureRequest setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

    public ExtractFacialFeatureRequest setUserid(String userid) {
        this.userid = userid;
        return this;
    }
    public String getUserid() {
        return this.userid;
    }

}
