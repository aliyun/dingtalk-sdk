// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ExclusiveBannerResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static ExclusiveBannerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ExclusiveBannerResponseBody self = new ExclusiveBannerResponseBody();
        return TeaModel.build(map, self);
    }

    public ExclusiveBannerResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public ExclusiveBannerResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
