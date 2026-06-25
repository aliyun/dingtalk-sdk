// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateEssayTaskCorrectionResultResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static UpdateEssayTaskCorrectionResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateEssayTaskCorrectionResultResponseBody self = new UpdateEssayTaskCorrectionResultResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateEssayTaskCorrectionResultResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public UpdateEssayTaskCorrectionResultResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
