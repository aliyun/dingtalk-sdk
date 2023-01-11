// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeletePhysicalClassroomResponseBody extends TeaModel {
    /**
     * <p>是否成功</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static DeletePhysicalClassroomResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeletePhysicalClassroomResponseBody self = new DeletePhysicalClassroomResponseBody();
        return TeaModel.build(map, self);
    }

    public DeletePhysicalClassroomResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
