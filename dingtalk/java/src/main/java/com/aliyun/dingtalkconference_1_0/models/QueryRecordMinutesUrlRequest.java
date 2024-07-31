// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryRecordMinutesUrlRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cloud_record</p>
     */
    @NameInMap("bizType")
    public String bizType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>lJcRnm39OsU4jlFVmRG9KXXXX</p>
     */
    @NameInMap("recorderUnionId")
    public String recorderUnionId;

    public static QueryRecordMinutesUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryRecordMinutesUrlRequest self = new QueryRecordMinutesUrlRequest();
        return TeaModel.build(map, self);
    }

    public QueryRecordMinutesUrlRequest setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

    public QueryRecordMinutesUrlRequest setRecorderUnionId(String recorderUnionId) {
        this.recorderUnionId = recorderUnionId;
        return this;
    }
    public String getRecorderUnionId() {
        return this.recorderUnionId;
    }

}
