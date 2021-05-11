// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class ExtractFacialFeatureRequest extends TeaModel {
    @NameInMap("userid")
    public String userid;

    @NameInMap("mediaId")
    public String mediaId;

    public static ExtractFacialFeatureRequest build(java.util.Map<String, ?> map) throws Exception {
        ExtractFacialFeatureRequest self = new ExtractFacialFeatureRequest();
        return TeaModel.build(map, self);
    }

    public ExtractFacialFeatureRequest setUserid(String userid) {
        this.userid = userid;
        return this;
    }
    public String getUserid() {
        return this.userid;
    }

    public ExtractFacialFeatureRequest setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

}
