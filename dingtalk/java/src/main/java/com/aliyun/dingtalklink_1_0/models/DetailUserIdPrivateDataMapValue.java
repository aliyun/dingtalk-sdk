// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class DetailUserIdPrivateDataMapValue extends TeaModel {
    /**
     * <p>卡片模板的文本内容参数。</p>
     */
    @NameInMap("cardParamMap")
    public java.util.Map<String, ?> cardParamMap;

    /**
     * <p>卡片模板的图片内容参数。</p>
     */
    @NameInMap("cardMediaIdParamMap")
    public java.util.Map<String, ?> cardMediaIdParamMap;

    public static DetailUserIdPrivateDataMapValue build(java.util.Map<String, ?> map) throws Exception {
        DetailUserIdPrivateDataMapValue self = new DetailUserIdPrivateDataMapValue();
        return TeaModel.build(map, self);
    }

    public DetailUserIdPrivateDataMapValue setCardParamMap(java.util.Map<String, ?> cardParamMap) {
        this.cardParamMap = cardParamMap;
        return this;
    }
    public java.util.Map<String, ?> getCardParamMap() {
        return this.cardParamMap;
    }

    public DetailUserIdPrivateDataMapValue setCardMediaIdParamMap(java.util.Map<String, ?> cardMediaIdParamMap) {
        this.cardMediaIdParamMap = cardMediaIdParamMap;
        return this;
    }
    public java.util.Map<String, ?> getCardMediaIdParamMap() {
        return this.cardMediaIdParamMap;
    }

}
