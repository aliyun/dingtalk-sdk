// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResideceGroupResponseBody extends TeaModel {
    /**
     * <p>是否更新成功</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static UpdateResideceGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateResideceGroupResponseBody self = new UpdateResideceGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateResideceGroupResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
