// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class PublishInnerAppVersionResponseBody extends TeaModel {
    /**
     * <p>小程序发布结果</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static PublishInnerAppVersionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PublishInnerAppVersionResponseBody self = new PublishInnerAppVersionResponseBody();
        return TeaModel.build(map, self);
    }

    public PublishInnerAppVersionResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
