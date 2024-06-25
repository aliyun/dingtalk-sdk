// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class SolutionTaskSaveResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static SolutionTaskSaveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SolutionTaskSaveResponseBody self = new SolutionTaskSaveResponseBody();
        return TeaModel.build(map, self);
    }

    public SolutionTaskSaveResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
