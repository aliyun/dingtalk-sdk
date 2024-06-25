// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class ClearRecycleBinResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static ClearRecycleBinResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ClearRecycleBinResponseBody self = new ClearRecycleBinResponseBody();
        return TeaModel.build(map, self);
    }

    public ClearRecycleBinResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
