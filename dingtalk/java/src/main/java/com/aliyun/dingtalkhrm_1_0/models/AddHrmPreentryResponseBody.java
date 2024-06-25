// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AddHrmPreentryResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>manager123</p>
     */
    @NameInMap("tmpUserId")
    public String tmpUserId;

    public static AddHrmPreentryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddHrmPreentryResponseBody self = new AddHrmPreentryResponseBody();
        return TeaModel.build(map, self);
    }

    public AddHrmPreentryResponseBody setTmpUserId(String tmpUserId) {
        this.tmpUserId = tmpUserId;
        return this;
    }
    public String getTmpUserId() {
        return this.tmpUserId;
    }

}
