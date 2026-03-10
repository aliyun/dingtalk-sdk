// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCorrectingDataResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateCorrectingDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateCorrectingDataResponseBody self = new UpdateCorrectingDataResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateCorrectingDataResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
