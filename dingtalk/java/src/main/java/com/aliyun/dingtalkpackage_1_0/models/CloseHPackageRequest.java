// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class CloseHPackageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>5000000000000000</p>
     */
    @NameInMap("miniAppId")
    public String miniAppId;

    public static CloseHPackageRequest build(java.util.Map<String, ?> map) throws Exception {
        CloseHPackageRequest self = new CloseHPackageRequest();
        return TeaModel.build(map, self);
    }

    public CloseHPackageRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

}
