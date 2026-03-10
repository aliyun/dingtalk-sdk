// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class CleanFileResponseBody extends TeaModel {
    @NameInMap("failureIds")
    public java.util.List<Long> failureIds;

    @NameInMap("successIds")
    public java.util.List<Long> successIds;

    public static CleanFileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CleanFileResponseBody self = new CleanFileResponseBody();
        return TeaModel.build(map, self);
    }

    public CleanFileResponseBody setFailureIds(java.util.List<Long> failureIds) {
        this.failureIds = failureIds;
        return this;
    }
    public java.util.List<Long> getFailureIds() {
        return this.failureIds;
    }

    public CleanFileResponseBody setSuccessIds(java.util.List<Long> successIds) {
        this.successIds = successIds;
        return this;
    }
    public java.util.List<Long> getSuccessIds() {
        return this.successIds;
    }

}
