// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class ClearFilterCriteriaResponseBody extends TeaModel {
    @NameInMap("id")
    public String id;

    public static ClearFilterCriteriaResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ClearFilterCriteriaResponseBody self = new ClearFilterCriteriaResponseBody();
        return TeaModel.build(map, self);
    }

    public ClearFilterCriteriaResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

}
