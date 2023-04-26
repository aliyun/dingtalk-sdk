// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteDeviceResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static DeleteDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteDeviceResponseBody self = new DeleteDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteDeviceResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
