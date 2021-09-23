// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ValidateOrderBuyRequest extends TeaModel {
    @NameInMap("accessKey")
    public String accessKey;

    @NameInMap("callerUid")
    public String callerUid;

    public static ValidateOrderBuyRequest build(java.util.Map<String, ?> map) throws Exception {
        ValidateOrderBuyRequest self = new ValidateOrderBuyRequest();
        return TeaModel.build(map, self);
    }

    public ValidateOrderBuyRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

    public ValidateOrderBuyRequest setCallerUid(String callerUid) {
        this.callerUid = callerUid;
        return this;
    }
    public String getCallerUid() {
        return this.callerUid;
    }

}
