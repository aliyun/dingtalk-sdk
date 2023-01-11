// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh5package_1_0.models;

import com.aliyun.tea.*;

public class PublishPackageResponseBody extends TeaModel {
    /**
     * <p>成功标记</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static PublishPackageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PublishPackageResponseBody self = new PublishPackageResponseBody();
        return TeaModel.build(map, self);
    }

    public PublishPackageResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
