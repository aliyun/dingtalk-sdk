// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class CheckCloudAccountStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static CheckCloudAccountStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CheckCloudAccountStatusResponseBody self = new CheckCloudAccountStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public CheckCloudAccountStatusResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
