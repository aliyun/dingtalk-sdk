// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SubmitGetContentJobRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <strong>example:</strong>
     * <p>markdown</p>
     */
    @NameInMap("targetFormat")
    public String targetFormat;

    public static SubmitGetContentJobRequest build(java.util.Map<String, ?> map) throws Exception {
        SubmitGetContentJobRequest self = new SubmitGetContentJobRequest();
        return TeaModel.build(map, self);
    }

    public SubmitGetContentJobRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public SubmitGetContentJobRequest setTargetFormat(String targetFormat) {
        this.targetFormat = targetFormat;
        return this;
    }
    public String getTargetFormat() {
        return this.targetFormat;
    }

}
