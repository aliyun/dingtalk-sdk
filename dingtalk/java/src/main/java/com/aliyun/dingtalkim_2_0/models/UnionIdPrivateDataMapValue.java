// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_2_0.models;

import com.aliyun.tea.*;

public class UnionIdPrivateDataMapValue extends TeaModel {
    @NameInMap("cardParamMap")
    public java.util.Map<String, String> cardParamMap;

    public static UnionIdPrivateDataMapValue build(java.util.Map<String, ?> map) throws Exception {
        UnionIdPrivateDataMapValue self = new UnionIdPrivateDataMapValue();
        return TeaModel.build(map, self);
    }

    public UnionIdPrivateDataMapValue setCardParamMap(java.util.Map<String, String> cardParamMap) {
        this.cardParamMap = cardParamMap;
        return this;
    }
    public java.util.Map<String, String> getCardParamMap() {
        return this.cardParamMap;
    }

}
