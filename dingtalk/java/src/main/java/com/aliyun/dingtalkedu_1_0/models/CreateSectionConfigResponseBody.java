// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateSectionConfigResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static CreateSectionConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateSectionConfigResponseBody self = new CreateSectionConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateSectionConfigResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
