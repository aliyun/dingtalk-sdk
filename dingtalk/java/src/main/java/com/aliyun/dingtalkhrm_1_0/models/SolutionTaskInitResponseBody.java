// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class SolutionTaskInitResponseBody extends TeaModel {
    /**
     * <p>数据是否初始化成功</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static SolutionTaskInitResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SolutionTaskInitResponseBody self = new SolutionTaskInitResponseBody();
        return TeaModel.build(map, self);
    }

    public SolutionTaskInitResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
