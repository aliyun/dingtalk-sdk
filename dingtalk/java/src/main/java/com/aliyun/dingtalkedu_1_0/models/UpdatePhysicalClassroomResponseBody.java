// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdatePhysicalClassroomResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdatePhysicalClassroomResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdatePhysicalClassroomResponseBody self = new UpdatePhysicalClassroomResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdatePhysicalClassroomResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
