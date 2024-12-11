// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CountOrgMessageOpenSceneGroupsResponseBody extends TeaModel {
    @NameInMap("count")
    public Integer count;

    @NameInMap("success")
    public Boolean success;

    public static CountOrgMessageOpenSceneGroupsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CountOrgMessageOpenSceneGroupsResponseBody self = new CountOrgMessageOpenSceneGroupsResponseBody();
        return TeaModel.build(map, self);
    }

    public CountOrgMessageOpenSceneGroupsResponseBody setCount(Integer count) {
        this.count = count;
        return this;
    }
    public Integer getCount() {
        return this.count;
    }

    public CountOrgMessageOpenSceneGroupsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
