// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateAwaitingCorrectionDataResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static CreateAwaitingCorrectionDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateAwaitingCorrectionDataResponseBody self = new CreateAwaitingCorrectionDataResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateAwaitingCorrectionDataResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
