// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ExclusiveCreateDingPortalResponseBody extends TeaModel {
    /**
     * <p>是否成功。</p>
     */
    @NameInMap("success")
    public String success;

    public static ExclusiveCreateDingPortalResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ExclusiveCreateDingPortalResponseBody self = new ExclusiveCreateDingPortalResponseBody();
        return TeaModel.build(map, self);
    }

    public ExclusiveCreateDingPortalResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

}
