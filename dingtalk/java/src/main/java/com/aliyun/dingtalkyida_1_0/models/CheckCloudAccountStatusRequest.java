// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class CheckCloudAccountStatusRequest extends TeaModel {
    @NameInMap("accessKey")
    public String accessKey;

    public static CheckCloudAccountStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        CheckCloudAccountStatusRequest self = new CheckCloudAccountStatusRequest();
        return TeaModel.build(map, self);
    }

    public CheckCloudAccountStatusRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

}
