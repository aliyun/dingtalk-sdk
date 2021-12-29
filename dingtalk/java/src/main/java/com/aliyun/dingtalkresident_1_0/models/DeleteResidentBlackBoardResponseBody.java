// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class DeleteResidentBlackBoardResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteResidentBlackBoardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteResidentBlackBoardResponseBody self = new DeleteResidentBlackBoardResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteResidentBlackBoardResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
