// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateStorageModeResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ding66b0e9d003fc91ed35c2f4xxxxxxxxxx</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static UpdateStorageModeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateStorageModeResponseBody self = new UpdateStorageModeResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateStorageModeResponseBody setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

}
