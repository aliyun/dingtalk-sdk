// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreStoreInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("storeId")
    public Long storeId;

    public static DigitalStoreStoreInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreStoreInfoRequest self = new DigitalStoreStoreInfoRequest();
        return TeaModel.build(map, self);
    }

    public DigitalStoreStoreInfoRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public DigitalStoreStoreInfoRequest setStoreId(Long storeId) {
        this.storeId = storeId;
        return this;
    }
    public Long getStoreId() {
        return this.storeId;
    }

}
