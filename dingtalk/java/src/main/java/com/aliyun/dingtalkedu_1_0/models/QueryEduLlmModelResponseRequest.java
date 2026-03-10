// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryEduLlmModelResponseRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding819xxxxxx</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>request_xxxxxxxxxx</p>
     */
    @NameInMap("reqId")
    public String reqId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>DING_xxxxxxxxxx</p>
     */
    @NameInMap("taskCode")
    public String taskCode;

    public static QueryEduLlmModelResponseRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryEduLlmModelResponseRequest self = new QueryEduLlmModelResponseRequest();
        return TeaModel.build(map, self);
    }

    public QueryEduLlmModelResponseRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryEduLlmModelResponseRequest setReqId(String reqId) {
        this.reqId = reqId;
        return this;
    }
    public String getReqId() {
        return this.reqId;
    }

    public QueryEduLlmModelResponseRequest setTaskCode(String taskCode) {
        this.taskCode = taskCode;
        return this;
    }
    public String getTaskCode() {
        return this.taskCode;
    }

}
