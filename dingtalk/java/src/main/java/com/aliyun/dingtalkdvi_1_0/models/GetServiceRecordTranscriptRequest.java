// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetServiceRecordTranscriptRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("id")
    public String id;

    public static GetServiceRecordTranscriptRequest build(java.util.Map<String, ?> map) throws Exception {
        GetServiceRecordTranscriptRequest self = new GetServiceRecordTranscriptRequest();
        return TeaModel.build(map, self);
    }

    public GetServiceRecordTranscriptRequest setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

}
