// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateInteractiveCardResponseBody extends TeaModel {
    @NameInMap("success")
    public String success;

    public static UpdateInteractiveCardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateInteractiveCardResponseBody self = new UpdateInteractiveCardResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateInteractiveCardResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

}
