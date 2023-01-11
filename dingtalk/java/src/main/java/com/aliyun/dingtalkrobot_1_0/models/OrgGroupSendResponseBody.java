// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class OrgGroupSendResponseBody extends TeaModel {
    /**
     * <p>加密消息id</p>
     */
    @NameInMap("processQueryKey")
    public String processQueryKey;

    public static OrgGroupSendResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OrgGroupSendResponseBody self = new OrgGroupSendResponseBody();
        return TeaModel.build(map, self);
    }

    public OrgGroupSendResponseBody setProcessQueryKey(String processQueryKey) {
        this.processQueryKey = processQueryKey;
        return this;
    }
    public String getProcessQueryKey() {
        return this.processQueryKey;
    }

}
