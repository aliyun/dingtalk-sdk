// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class ConfirmRightsResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static ConfirmRightsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ConfirmRightsResponseBody self = new ConfirmRightsResponseBody();
        return TeaModel.build(map, self);
    }

    public ConfirmRightsResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
