// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SaveFormRemarkResponseBody extends TeaModel {
    @NameInMap("result")
    public Long result;

    public static SaveFormRemarkResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveFormRemarkResponseBody self = new SaveFormRemarkResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveFormRemarkResponseBody setResult(Long result) {
        this.result = result;
        return this;
    }
    public Long getResult() {
        return this.result;
    }

}
