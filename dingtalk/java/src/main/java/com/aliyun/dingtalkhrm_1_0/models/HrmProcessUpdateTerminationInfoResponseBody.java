// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmProcessUpdateTerminationInfoResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static HrmProcessUpdateTerminationInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrmProcessUpdateTerminationInfoResponseBody self = new HrmProcessUpdateTerminationInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public HrmProcessUpdateTerminationInfoResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
