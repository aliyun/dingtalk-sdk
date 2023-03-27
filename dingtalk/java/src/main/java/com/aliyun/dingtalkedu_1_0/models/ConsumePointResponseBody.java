// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ConsumePointResponseBody extends TeaModel {
    /**
     * <p>结果</p>
     */
    @NameInMap("result")
    public Boolean result;

    /**
     * <p>操作是否成功</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static ConsumePointResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ConsumePointResponseBody self = new ConsumePointResponseBody();
        return TeaModel.build(map, self);
    }

    public ConsumePointResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public ConsumePointResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
