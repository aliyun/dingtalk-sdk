// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetSsoUserInfoRequest extends TeaModel {
    @NameInMap("code")
    public String code;

    public static GetSsoUserInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSsoUserInfoRequest self = new GetSsoUserInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetSsoUserInfoRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

}
