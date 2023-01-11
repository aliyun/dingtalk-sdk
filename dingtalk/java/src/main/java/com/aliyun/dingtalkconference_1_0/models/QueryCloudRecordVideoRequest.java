// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryCloudRecordVideoRequest extends TeaModel {
    /**
     * <p>用户id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryCloudRecordVideoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCloudRecordVideoRequest self = new QueryCloudRecordVideoRequest();
        return TeaModel.build(map, self);
    }

    public QueryCloudRecordVideoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
