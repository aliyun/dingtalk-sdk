// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class SyncExceedApplyResponseBody extends TeaModel {
    /**
     * <p>是否同步成功</p>
     */
    @NameInMap("module")
    public Boolean module;

    public static SyncExceedApplyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SyncExceedApplyResponseBody self = new SyncExceedApplyResponseBody();
        return TeaModel.build(map, self);
    }

    public SyncExceedApplyResponseBody setModule(Boolean module) {
        this.module = module;
        return this;
    }
    public Boolean getModule() {
        return this.module;
    }

}
