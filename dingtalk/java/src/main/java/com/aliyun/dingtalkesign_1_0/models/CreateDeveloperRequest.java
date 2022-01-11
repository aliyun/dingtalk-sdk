// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class CreateDeveloperRequest extends TeaModel {
    @NameInMap("redirectUrl")
    public String redirectUrl;

    public static CreateDeveloperRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateDeveloperRequest self = new CreateDeveloperRequest();
        return TeaModel.build(map, self);
    }

    public CreateDeveloperRequest setRedirectUrl(String redirectUrl) {
        this.redirectUrl = redirectUrl;
        return this;
    }
    public String getRedirectUrl() {
        return this.redirectUrl;
    }

}
