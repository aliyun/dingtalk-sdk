// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class UpdateVersionStatusResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public String result;

    public static UpdateVersionStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateVersionStatusResponseBody self = new UpdateVersionStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateVersionStatusResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
