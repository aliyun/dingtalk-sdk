// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidentUserResponseBody extends TeaModel {
    // 是否更新成功
    @NameInMap("result")
    public Boolean result;

    public static UpdateResidentUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateResidentUserResponseBody self = new UpdateResidentUserResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateResidentUserResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
