// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CountSceneGroupsByTemplateIdResponseBody extends TeaModel {
    @NameInMap("count")
    public Integer count;

    @NameInMap("success")
    public Boolean success;

    public static CountSceneGroupsByTemplateIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CountSceneGroupsByTemplateIdResponseBody self = new CountSceneGroupsByTemplateIdResponseBody();
        return TeaModel.build(map, self);
    }

    public CountSceneGroupsByTemplateIdResponseBody setCount(Integer count) {
        this.count = count;
        return this;
    }
    public Integer getCount() {
        return this.count;
    }

    public CountSceneGroupsByTemplateIdResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
