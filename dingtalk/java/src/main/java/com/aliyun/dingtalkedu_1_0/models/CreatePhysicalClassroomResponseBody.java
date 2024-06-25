// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreatePhysicalClassroomResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>10001</p>
     */
    @NameInMap("classroomId")
    public Long classroomId;

    public static CreatePhysicalClassroomResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreatePhysicalClassroomResponseBody self = new CreatePhysicalClassroomResponseBody();
        return TeaModel.build(map, self);
    }

    public CreatePhysicalClassroomResponseBody setClassroomId(Long classroomId) {
        this.classroomId = classroomId;
        return this;
    }
    public Long getClassroomId() {
        return this.classroomId;
    }

}
