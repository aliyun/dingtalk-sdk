// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class GetDomainWordsResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<String> result;

    @NameInMap("success")
    public Boolean success;

    public static GetDomainWordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDomainWordsResponseBody self = new GetDomainWordsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDomainWordsResponseBody setResult(java.util.List<String> result) {
        this.result = result;
        return this;
    }
    public java.util.List<String> getResult() {
        return this.result;
    }

    public GetDomainWordsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
