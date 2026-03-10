// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class RecordActionPointRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>UPLOAD</p>
     */
    @NameInMap("actionCode")
    public String actionCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1770361351000</p>
     */
    @NameInMap("actionTime")
    public Long actionTime;

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
     * <p>DING_xxxxxxxxxx</p>
     */
    @NameInMap("taskCode")
    public String taskCode;

    public static RecordActionPointRequest build(java.util.Map<String, ?> map) throws Exception {
        RecordActionPointRequest self = new RecordActionPointRequest();
        return TeaModel.build(map, self);
    }

    public RecordActionPointRequest setActionCode(String actionCode) {
        this.actionCode = actionCode;
        return this;
    }
    public String getActionCode() {
        return this.actionCode;
    }

    public RecordActionPointRequest setActionTime(Long actionTime) {
        this.actionTime = actionTime;
        return this;
    }
    public Long getActionTime() {
        return this.actionTime;
    }

    public RecordActionPointRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public RecordActionPointRequest setTaskCode(String taskCode) {
        this.taskCode = taskCode;
        return this;
    }
    public String getTaskCode() {
        return this.taskCode;
    }

}
