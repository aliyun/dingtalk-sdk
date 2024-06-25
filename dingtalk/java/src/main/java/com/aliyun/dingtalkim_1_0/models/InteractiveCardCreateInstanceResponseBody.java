// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class InteractiveCardCreateInstanceResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>xxxxxx</p>
     */
    @NameInMap("processQueryKey")
    public String processQueryKey;

    public static InteractiveCardCreateInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InteractiveCardCreateInstanceResponseBody self = new InteractiveCardCreateInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public InteractiveCardCreateInstanceResponseBody setProcessQueryKey(String processQueryKey) {
        this.processQueryKey = processQueryKey;
        return this;
    }
    public String getProcessQueryKey() {
        return this.processQueryKey;
    }

}
