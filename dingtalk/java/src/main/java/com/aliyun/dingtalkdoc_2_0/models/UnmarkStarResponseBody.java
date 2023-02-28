// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class UnmarkStarResponseBody extends TeaModel {
    /**
     * <p>本次操作是否成功</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static UnmarkStarResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UnmarkStarResponseBody self = new UnmarkStarResponseBody();
        return TeaModel.build(map, self);
    }

    public UnmarkStarResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
