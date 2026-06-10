// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetCorrectStyleRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding123...</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding_scan_correct_...</p>
     */
    @NameInMap("taskCode")
    public String taskCode;

    public static GetCorrectStyleRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCorrectStyleRequest self = new GetCorrectStyleRequest();
        return TeaModel.build(map, self);
    }

    public GetCorrectStyleRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetCorrectStyleRequest setTaskCode(String taskCode) {
        this.taskCode = taskCode;
        return this;
    }
    public String getTaskCode() {
        return this.taskCode;
    }

}
