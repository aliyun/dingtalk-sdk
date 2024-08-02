// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class DeleteDomainWordsResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteDomainWordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteDomainWordsResponseBody self = new DeleteDomainWordsResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteDomainWordsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
