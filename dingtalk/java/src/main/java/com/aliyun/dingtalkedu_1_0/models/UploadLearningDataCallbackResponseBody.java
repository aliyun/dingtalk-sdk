// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UploadLearningDataCallbackResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static UploadLearningDataCallbackResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UploadLearningDataCallbackResponseBody self = new UploadLearningDataCallbackResponseBody();
        return TeaModel.build(map, self);
    }

    public UploadLearningDataCallbackResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public UploadLearningDataCallbackResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
