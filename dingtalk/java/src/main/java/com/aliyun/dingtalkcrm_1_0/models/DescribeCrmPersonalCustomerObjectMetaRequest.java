// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DescribeCrmPersonalCustomerObjectMetaRequest extends TeaModel {
    @NameInMap("relationType")
    public String relationType;

    public static DescribeCrmPersonalCustomerObjectMetaRequest build(java.util.Map<String, ?> map) throws Exception {
        DescribeCrmPersonalCustomerObjectMetaRequest self = new DescribeCrmPersonalCustomerObjectMetaRequest();
        return TeaModel.build(map, self);
    }

    public DescribeCrmPersonalCustomerObjectMetaRequest setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

}
