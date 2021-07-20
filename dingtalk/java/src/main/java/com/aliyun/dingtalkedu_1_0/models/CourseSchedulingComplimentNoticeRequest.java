// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CourseSchedulingComplimentNoticeRequest extends TeaModel {
    // opUserId
    @NameInMap("opUserId")
    public String opUserId;

    public static CourseSchedulingComplimentNoticeRequest build(java.util.Map<String, ?> map) throws Exception {
        CourseSchedulingComplimentNoticeRequest self = new CourseSchedulingComplimentNoticeRequest();
        return TeaModel.build(map, self);
    }

    public CourseSchedulingComplimentNoticeRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
