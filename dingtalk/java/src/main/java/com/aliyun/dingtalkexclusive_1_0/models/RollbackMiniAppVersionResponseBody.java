// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class RollbackMiniAppVersionResponseBody extends TeaModel {
    // 结果码
    @NameInMap("code")
    public Long code;

    // 失败原因
    @NameInMap("cause")
    public String cause;

    public static RollbackMiniAppVersionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RollbackMiniAppVersionResponseBody self = new RollbackMiniAppVersionResponseBody();
        return TeaModel.build(map, self);
    }

    public RollbackMiniAppVersionResponseBody setCode(Long code) {
        this.code = code;
        return this;
    }
    public Long getCode() {
        return this.code;
    }

    public RollbackMiniAppVersionResponseBody setCause(String cause) {
        this.cause = cause;
        return this;
    }
    public String getCause() {
        return this.cause;
    }

}
