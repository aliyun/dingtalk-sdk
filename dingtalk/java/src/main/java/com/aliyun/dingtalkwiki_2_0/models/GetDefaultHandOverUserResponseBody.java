// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class GetDefaultHandOverUserResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>staff_id</p>
     */
    @NameInMap("defaultHandoverUserId")
    public String defaultHandoverUserId;

    public static GetDefaultHandOverUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDefaultHandOverUserResponseBody self = new GetDefaultHandOverUserResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDefaultHandOverUserResponseBody setDefaultHandoverUserId(String defaultHandoverUserId) {
        this.defaultHandoverUserId = defaultHandoverUserId;
        return this;
    }
    public String getDefaultHandoverUserId() {
        return this.defaultHandoverUserId;
    }

}
