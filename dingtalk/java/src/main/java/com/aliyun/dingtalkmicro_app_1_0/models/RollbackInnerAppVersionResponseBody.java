// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class RollbackInnerAppVersionResponseBody extends TeaModel {
    /**
     * <p>小程序回滚结果</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static RollbackInnerAppVersionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RollbackInnerAppVersionResponseBody self = new RollbackInnerAppVersionResponseBody();
        return TeaModel.build(map, self);
    }

    public RollbackInnerAppVersionResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
