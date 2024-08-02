// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class AddDomainWordsResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static AddDomainWordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddDomainWordsResponseBody self = new AddDomainWordsResponseBody();
        return TeaModel.build(map, self);
    }

    public AddDomainWordsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
