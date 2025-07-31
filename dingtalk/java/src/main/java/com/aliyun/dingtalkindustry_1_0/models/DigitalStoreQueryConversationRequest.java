// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreQueryConversationRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>F1342222</p>
     */
    @NameInMap("storeCode")
    public String storeCode;

    public static DigitalStoreQueryConversationRequest build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreQueryConversationRequest self = new DigitalStoreQueryConversationRequest();
        return TeaModel.build(map, self);
    }

    public DigitalStoreQueryConversationRequest setStoreCode(String storeCode) {
        this.storeCode = storeCode;
        return this;
    }
    public String getStoreCode() {
        return this.storeCode;
    }

}
