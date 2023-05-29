// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class ManagerGetDefaultHandOverUserResponseBody extends TeaModel {
    @NameInMap("defaultHandoverUserId")
    public String defaultHandoverUserId;

    public static ManagerGetDefaultHandOverUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ManagerGetDefaultHandOverUserResponseBody self = new ManagerGetDefaultHandOverUserResponseBody();
        return TeaModel.build(map, self);
    }

    public ManagerGetDefaultHandOverUserResponseBody setDefaultHandoverUserId(String defaultHandoverUserId) {
        this.defaultHandoverUserId = defaultHandoverUserId;
        return this;
    }
    public String getDefaultHandoverUserId() {
        return this.defaultHandoverUserId;
    }

}
