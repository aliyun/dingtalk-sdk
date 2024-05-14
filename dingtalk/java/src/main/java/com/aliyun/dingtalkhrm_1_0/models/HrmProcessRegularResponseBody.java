// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmProcessRegularResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static HrmProcessRegularResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrmProcessRegularResponseBody self = new HrmProcessRegularResponseBody();
        return TeaModel.build(map, self);
    }

    public HrmProcessRegularResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
