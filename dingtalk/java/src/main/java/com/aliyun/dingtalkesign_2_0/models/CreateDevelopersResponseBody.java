// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class CreateDevelopersResponseBody extends TeaModel {
    @NameInMap("data")
    public Boolean data;

    public static CreateDevelopersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateDevelopersResponseBody self = new CreateDevelopersResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateDevelopersResponseBody setData(Boolean data) {
        this.data = data;
        return this;
    }
    public Boolean getData() {
        return this.data;
    }

}
