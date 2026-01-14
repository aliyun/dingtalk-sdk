// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateCorrectionDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("correctedDataJsonUrl")
    public String correctedDataJsonUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskCode")
    public String taskCode;

    public static CreateCorrectionDataRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCorrectionDataRequest self = new CreateCorrectionDataRequest();
        return TeaModel.build(map, self);
    }

    public CreateCorrectionDataRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CreateCorrectionDataRequest setCorrectedDataJsonUrl(String correctedDataJsonUrl) {
        this.correctedDataJsonUrl = correctedDataJsonUrl;
        return this;
    }
    public String getCorrectedDataJsonUrl() {
        return this.correctedDataJsonUrl;
    }

    public CreateCorrectionDataRequest setTaskCode(String taskCode) {
        this.taskCode = taskCode;
        return this;
    }
    public String getTaskCode() {
        return this.taskCode;
    }

}
