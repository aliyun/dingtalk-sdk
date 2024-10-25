// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class CancelEventRequest extends TeaModel {
    @NameInMap("scope")
    public String scope;

    public static CancelEventRequest build(java.util.Map<String, ?> map) throws Exception {
        CancelEventRequest self = new CancelEventRequest();
        return TeaModel.build(map, self);
    }

    public CancelEventRequest setScope(String scope) {
        this.scope = scope;
        return this;
    }
    public String getScope() {
        return this.scope;
    }

}
