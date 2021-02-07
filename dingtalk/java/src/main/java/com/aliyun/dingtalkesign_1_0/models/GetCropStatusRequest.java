// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetCropStatusRequest extends TeaModel {
    @NameInMap("appId")
    public Long appId;

    public static GetCropStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCropStatusRequest self = new GetCropStatusRequest();
        return TeaModel.build(map, self);
    }

    public GetCropStatusRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

}
