// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class UpdateSheetResponseBody extends TeaModel {
    /**
     * <p>本次操作是否成功</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static UpdateSheetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateSheetResponseBody self = new UpdateSheetResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateSheetResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
