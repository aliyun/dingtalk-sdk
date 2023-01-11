// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidenceResponseBody extends TeaModel {
    /**
     * <p>是否更新成功</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static UpdateResidenceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateResidenceResponseBody self = new UpdateResidenceResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateResidenceResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
