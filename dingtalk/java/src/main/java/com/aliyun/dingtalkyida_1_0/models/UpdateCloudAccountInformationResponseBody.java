// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class UpdateCloudAccountInformationResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateCloudAccountInformationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateCloudAccountInformationResponseBody self = new UpdateCloudAccountInformationResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateCloudAccountInformationResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
