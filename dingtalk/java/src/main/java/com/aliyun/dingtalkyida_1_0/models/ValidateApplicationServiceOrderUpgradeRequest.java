// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ValidateApplicationServiceOrderUpgradeRequest extends TeaModel {
    /**
     * <p>accessKey</p>
     */
    @NameInMap("accessKey")
    public String accessKey;

    public static ValidateApplicationServiceOrderUpgradeRequest build(java.util.Map<String, ?> map) throws Exception {
        ValidateApplicationServiceOrderUpgradeRequest self = new ValidateApplicationServiceOrderUpgradeRequest();
        return TeaModel.build(map, self);
    }

    public ValidateApplicationServiceOrderUpgradeRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

}
