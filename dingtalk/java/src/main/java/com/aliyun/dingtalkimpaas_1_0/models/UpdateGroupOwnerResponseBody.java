// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupOwnerResponseBody extends TeaModel {
    // 返回结果
    @NameInMap("result")
    public Boolean result;

    public static UpdateGroupOwnerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupOwnerResponseBody self = new UpdateGroupOwnerResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateGroupOwnerResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
