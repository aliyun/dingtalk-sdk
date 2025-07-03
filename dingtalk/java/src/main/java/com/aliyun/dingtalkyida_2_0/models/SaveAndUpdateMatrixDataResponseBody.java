// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class SaveAndUpdateMatrixDataResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SaveAndUpdateMatrixDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveAndUpdateMatrixDataResponseBody self = new SaveAndUpdateMatrixDataResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveAndUpdateMatrixDataResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
