// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SubmitAiSportDataResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SubmitAiSportDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SubmitAiSportDataResponseBody self = new SubmitAiSportDataResponseBody();
        return TeaModel.build(map, self);
    }

    public SubmitAiSportDataResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
