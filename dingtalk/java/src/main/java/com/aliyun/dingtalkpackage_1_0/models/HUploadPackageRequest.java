// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class HUploadPackageRequest extends TeaModel {
    /**
     * <p>离线包ID</p>
     */
    @NameInMap("miniAppId")
    public String miniAppId;

    /**
     * <p>离线包资源OSS Key</p>
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
