// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UnsubscribeUniversityCourseGroupResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static UnsubscribeUniversityCourseGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UnsubscribeUniversityCourseGroupResponseBody self = new UnsubscribeUniversityCourseGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public UnsubscribeUniversityCourseGroupResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
