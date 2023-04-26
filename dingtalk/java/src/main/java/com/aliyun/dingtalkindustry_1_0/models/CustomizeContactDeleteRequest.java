// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactDeleteRequest extends TeaModel {
    @NameInMap("code")
    public String code;

    public static CustomizeContactDeleteRequest build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactDeleteRequest self = new CustomizeContactDeleteRequest();
        return TeaModel.build(map, self);
    }

    public CustomizeContactDeleteRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

}
