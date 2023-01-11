// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateRemoteClassCourseResponseBody extends TeaModel {
    /**
     * <p>result</p>
     */
    @NameInMap("result")
    public String result;

    /**
     * <p>success</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static UpdateRemoteClassCourseResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateRemoteClassCourseResponseBody self = new UpdateRemoteClassCourseResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateRemoteClassCourseResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public UpdateRemoteClassCourseResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
