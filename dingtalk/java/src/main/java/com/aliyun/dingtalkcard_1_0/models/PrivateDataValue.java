// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class PrivateDataValue extends TeaModel {
    /**
     * <p>卡片模板-文本内容参数</p>
     */
    @NameInMap("cardParamMap")
    public java.util.Map<String, String> cardParamMap;

    public static PrivateDataValue build(java.util.Map<String, ?> map) throws Exception {
        PrivateDataValue self = new PrivateDataValue();
        return TeaModel.build(map, self);
    }

    public PrivateDataValue setCardParamMap(java.util.Map<String, String> cardParamMap) {
        this.cardParamMap = cardParamMap;
        return this;
    }
    public java.util.Map<String, String> getCardParamMap() {
        return this.cardParamMap;
    }

}
