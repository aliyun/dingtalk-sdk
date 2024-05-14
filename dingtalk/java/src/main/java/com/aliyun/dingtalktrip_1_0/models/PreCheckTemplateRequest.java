// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class PreCheckTemplateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("customerCorpId")
    public String customerCorpId;

    public static PreCheckTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        PreCheckTemplateRequest self = new PreCheckTemplateRequest();
        return TeaModel.build(map, self);
    }

    public PreCheckTemplateRequest setCustomerCorpId(String customerCorpId) {
        this.customerCorpId = customerCorpId;
        return this;
    }
    public String getCustomerCorpId() {
        return this.customerCorpId;
    }

}
