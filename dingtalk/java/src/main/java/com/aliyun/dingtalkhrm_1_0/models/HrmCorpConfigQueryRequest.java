// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmCorpConfigQueryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>policy</p>
     */
    @NameInMap("subType")
    public String subType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>hrm_ai</p>
     */
    @NameInMap("type")
    public String type;

    public static HrmCorpConfigQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        HrmCorpConfigQueryRequest self = new HrmCorpConfigQueryRequest();
        return TeaModel.build(map, self);
    }

    public HrmCorpConfigQueryRequest setSubType(String subType) {
        this.subType = subType;
        return this;
    }
    public String getSubType() {
        return this.subType;
    }

    public HrmCorpConfigQueryRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
