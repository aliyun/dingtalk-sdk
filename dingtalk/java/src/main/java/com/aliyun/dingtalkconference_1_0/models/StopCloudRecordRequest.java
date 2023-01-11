// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class StopCloudRecordRequest extends TeaModel {
    /**
     * <p>主持人uid</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static StopCloudRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        StopCloudRecordRequest self = new StopCloudRecordRequest();
        return TeaModel.build(map, self);
    }

    public StopCloudRecordRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
