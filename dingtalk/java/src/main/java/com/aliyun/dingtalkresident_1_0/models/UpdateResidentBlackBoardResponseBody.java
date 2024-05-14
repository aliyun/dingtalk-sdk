// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidentBlackBoardResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static UpdateResidentBlackBoardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateResidentBlackBoardResponseBody self = new UpdateResidentBlackBoardResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateResidentBlackBoardResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
