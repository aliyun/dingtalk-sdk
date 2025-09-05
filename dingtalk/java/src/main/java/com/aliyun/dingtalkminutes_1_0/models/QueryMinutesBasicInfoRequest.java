// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesBasicInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskUuid")
    public String taskUuid;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryMinutesBasicInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesBasicInfoRequest self = new QueryMinutesBasicInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryMinutesBasicInfoRequest setTaskUuid(String taskUuid) {
        this.taskUuid = taskUuid;
        return this;
    }
    public String getTaskUuid() {
        return this.taskUuid;
    }

    public QueryMinutesBasicInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
