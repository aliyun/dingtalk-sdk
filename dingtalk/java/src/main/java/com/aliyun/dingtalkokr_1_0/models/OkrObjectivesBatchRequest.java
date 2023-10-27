// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class OkrObjectivesBatchRequest extends TeaModel {
    @NameInMap("goodsCode")
    public String goodsCode;

    @NameInMap("objectiveIds")
    public java.util.List<String> objectiveIds;

    public static OkrObjectivesBatchRequest build(java.util.Map<String, ?> map) throws Exception {
        OkrObjectivesBatchRequest self = new OkrObjectivesBatchRequest();
        return TeaModel.build(map, self);
    }

    public OkrObjectivesBatchRequest setGoodsCode(String goodsCode) {
        this.goodsCode = goodsCode;
        return this;
    }
    public String getGoodsCode() {
        return this.goodsCode;
    }

    public OkrObjectivesBatchRequest setObjectiveIds(java.util.List<String> objectiveIds) {
        this.objectiveIds = objectiveIds;
        return this;
    }
    public java.util.List<String> getObjectiveIds() {
        return this.objectiveIds;
    }

}
