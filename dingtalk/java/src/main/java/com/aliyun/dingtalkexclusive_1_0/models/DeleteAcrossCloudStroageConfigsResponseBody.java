// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class DeleteAcrossCloudStroageConfigsResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static DeleteAcrossCloudStroageConfigsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteAcrossCloudStroageConfigsResponseBody self = new DeleteAcrossCloudStroageConfigsResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteAcrossCloudStroageConfigsResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
