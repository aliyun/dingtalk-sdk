// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateTokenRequest extends TeaModel {
    @NameInMap("sn")
    public String sn;

    @NameInMap("type")
    public String type;

    public static CreateTokenRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTokenRequest self = new CreateTokenRequest();
        return TeaModel.build(map, self);
    }

    public CreateTokenRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public CreateTokenRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
