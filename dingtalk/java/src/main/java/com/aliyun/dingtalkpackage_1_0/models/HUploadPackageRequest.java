// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class HUploadPackageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>5000000002793153</p>
     */
    @NameInMap("miniAppId")
    public String miniAppId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxxx</p>
     */
    @NameInMap("ossObjectKey")
    public String ossObjectKey;

    public static HUploadPackageRequest build(java.util.Map<String, ?> map) throws Exception {
        HUploadPackageRequest self = new HUploadPackageRequest();
        return TeaModel.build(map, self);
    }

    public HUploadPackageRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public HUploadPackageRequest setOssObjectKey(String ossObjectKey) {
        this.ossObjectKey = ossObjectKey;
        return this;
    }
    public String getOssObjectKey() {
        return this.ossObjectKey;
    }

}
