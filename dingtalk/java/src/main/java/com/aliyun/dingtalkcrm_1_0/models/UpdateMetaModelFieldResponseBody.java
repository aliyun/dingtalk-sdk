// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateMetaModelFieldResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizType")
    public String bizType;

    public static UpdateMetaModelFieldResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateMetaModelFieldResponseBody self = new UpdateMetaModelFieldResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateMetaModelFieldResponseBody setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

}
