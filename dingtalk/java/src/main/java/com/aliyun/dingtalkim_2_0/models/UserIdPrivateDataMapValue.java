// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_2_0.models;

import com.aliyun.tea.*;

public class UserIdPrivateDataMapValue extends TeaModel {
    @NameInMap("cardParamMap")
    public java.util.Map<String, String> cardParamMap;

    public static UserIdPrivateDataMapValue build(java.util.Map<String, ?> map) throws Exception {
        UserIdPrivateDataMapValue self = new UserIdPrivateDataMapValue();
        return TeaModel.build(map, self);
    }

    public UserIdPrivateDataMapValue setCardParamMap(java.util.Map<String, String> cardParamMap) {
        this.cardParamMap = cardParamMap;
        return this;
    }
    public java.util.Map<String, String> getCardParamMap() {
        return this.cardParamMap;
    }

}
