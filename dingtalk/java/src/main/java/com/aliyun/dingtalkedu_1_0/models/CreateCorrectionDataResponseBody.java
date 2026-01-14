// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateCorrectionDataResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static CreateCorrectionDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateCorrectionDataResponseBody self = new CreateCorrectionDataResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateCorrectionDataResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
