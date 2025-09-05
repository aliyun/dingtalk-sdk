// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class AiRetailProductImgUploadRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    public static AiRetailProductImgUploadRequest build(java.util.Map<String, ?> map) throws Exception {
        AiRetailProductImgUploadRequest self = new AiRetailProductImgUploadRequest();
        return TeaModel.build(map, self);
    }

    public AiRetailProductImgUploadRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

}
