// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class RemoveResidentUserResponseBody extends TeaModel {
    /**
     * <p>是否移除成功</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static RemoveResidentUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RemoveResidentUserResponseBody self = new RemoveResidentUserResponseBody();
        return TeaModel.build(map, self);
    }

    public RemoveResidentUserResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
