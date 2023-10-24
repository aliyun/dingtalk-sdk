// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcool_ops_1_0.models;

import com.aliyun.tea.*;

public class UpdateIsvOppStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateIsvOppStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateIsvOppStatusResponseBody self = new UpdateIsvOppStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateIsvOppStatusResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
