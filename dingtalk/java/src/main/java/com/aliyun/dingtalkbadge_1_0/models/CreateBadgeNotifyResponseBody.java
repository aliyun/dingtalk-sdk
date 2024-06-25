// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class CreateBadgeNotifyResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>SUCCESS</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static CreateBadgeNotifyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateBadgeNotifyResponseBody self = new CreateBadgeNotifyResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateBadgeNotifyResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
