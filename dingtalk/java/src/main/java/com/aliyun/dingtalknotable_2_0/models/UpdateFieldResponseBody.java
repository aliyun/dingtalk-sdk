// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_2_0.models;

import com.aliyun.tea.*;

public class UpdateFieldResponseBody extends TeaModel {
    @NameInMap("id")
    public String id;

    public static UpdateFieldResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateFieldResponseBody self = new UpdateFieldResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateFieldResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

}
