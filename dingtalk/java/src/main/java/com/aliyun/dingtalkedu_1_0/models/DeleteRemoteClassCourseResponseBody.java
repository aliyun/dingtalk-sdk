// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteRemoteClassCourseResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteRemoteClassCourseResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteRemoteClassCourseResponseBody self = new DeleteRemoteClassCourseResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteRemoteClassCourseResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
