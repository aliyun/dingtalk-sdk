// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class PrivateDataValue extends TeaModel {
    /**
     * <p>卡片模板内容替换参数-普通文本类型</p>
     */
    @NameInMap("cardParamMap")
    public java.util.Map<String, String> cardParamMap;

    /**
     * <p>卡片模板内容替换参数-多媒体类型</p>
     */
    @NameInMap("cardMediaIdParamMap")
    public java.util.Map<String, String> cardMediaIdParamMap;

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

    public PrivateDataValue setCardMediaIdParamMap(java.util.Map<String, String> cardMediaIdParamMap) {
        this.cardMediaIdParamMap = cardMediaIdParamMap;
        return this;
    }
    public java.util.Map<String, String> getCardMediaIdParamMap() {
        return this.cardMediaIdParamMap;
    }

}
