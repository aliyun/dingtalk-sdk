// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetServiceRecordRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("id")
    public String id;

    public static GetServiceRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        GetServiceRecordRequest self = new GetServiceRecordRequest();
        return TeaModel.build(map, self);
    }

    public GetServiceRecordRequest setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

}
