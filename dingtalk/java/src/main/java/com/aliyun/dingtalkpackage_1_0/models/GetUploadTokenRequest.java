// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class GetUploadTokenRequest extends TeaModel {
    /**
     * <p>离线包ID</p>
     */
    @NameInMap("miniAppId")
    public String miniAppId;

    public static GetUploadTokenRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUploadTokenRequest self = new GetUploadTokenRequest();
        return TeaModel.build(map, self);
    }

    public GetUploadTokenRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

}
