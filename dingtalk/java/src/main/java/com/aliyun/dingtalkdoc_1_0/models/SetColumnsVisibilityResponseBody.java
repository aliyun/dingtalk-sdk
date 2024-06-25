// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetColumnsVisibilityResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>sheet_id</p>
     */
    @NameInMap("id")
    public String id;

    public static SetColumnsVisibilityResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetColumnsVisibilityResponseBody self = new SetColumnsVisibilityResponseBody();
        return TeaModel.build(map, self);
    }

    public SetColumnsVisibilityResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

}
