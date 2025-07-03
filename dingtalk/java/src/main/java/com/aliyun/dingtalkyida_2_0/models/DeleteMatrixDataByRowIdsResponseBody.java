// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class DeleteMatrixDataByRowIdsResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteMatrixDataByRowIdsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteMatrixDataByRowIdsResponseBody self = new DeleteMatrixDataByRowIdsResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteMatrixDataByRowIdsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
