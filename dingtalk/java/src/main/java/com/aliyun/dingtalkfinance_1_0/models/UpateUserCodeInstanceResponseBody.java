// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UpateUserCodeInstanceResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>codexxxxxx</p>
     */
    @NameInMap("codeId")
    public String codeId;

    public static UpateUserCodeInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpateUserCodeInstanceResponseBody self = new UpateUserCodeInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public UpateUserCodeInstanceResponseBody setCodeId(String codeId) {
        this.codeId = codeId;
        return this;
    }
    public String getCodeId() {
        return this.codeId;
    }

}
