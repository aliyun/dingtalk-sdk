// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CourseSchedulingComplimentNoticeResponseBody extends TeaModel {
    // 通知课程导入完成是否成功。
    @NameInMap("result")
    public Boolean result;

    public static CourseSchedulingComplimentNoticeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CourseSchedulingComplimentNoticeResponseBody self = new CourseSchedulingComplimentNoticeResponseBody();
        return TeaModel.build(map, self);
    }

    public CourseSchedulingComplimentNoticeResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
