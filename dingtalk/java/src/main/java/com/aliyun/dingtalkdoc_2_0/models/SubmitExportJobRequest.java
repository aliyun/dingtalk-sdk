// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SubmitExportJobRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dentryUuid")
    public String dentryUuid;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>docx</p>
     */
    @NameInMap("targetFormat")
    public String targetFormat;

    public static SubmitExportJobRequest build(java.util.Map<String, ?> map) throws Exception {
        SubmitExportJobRequest self = new SubmitExportJobRequest();
        return TeaModel.build(map, self);
    }

    public SubmitExportJobRequest setDentryUuid(String dentryUuid) {
        this.dentryUuid = dentryUuid;
        return this;
    }
    public String getDentryUuid() {
        return this.dentryUuid;
    }

    public SubmitExportJobRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public SubmitExportJobRequest setTargetFormat(String targetFormat) {
        this.targetFormat = targetFormat;
        return this;
    }
    public String getTargetFormat() {
        return this.targetFormat;
    }

}
