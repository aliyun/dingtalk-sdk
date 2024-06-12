// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AddMetaModelFieldResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizType")
    public String bizType;

    public static AddMetaModelFieldResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddMetaModelFieldResponseBody self = new AddMetaModelFieldResponseBody();
        return TeaModel.build(map, self);
    }

    public AddMetaModelFieldResponseBody setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

}
