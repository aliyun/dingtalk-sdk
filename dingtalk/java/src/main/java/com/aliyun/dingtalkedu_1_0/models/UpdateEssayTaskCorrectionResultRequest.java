// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateEssayTaskCorrectionResultRequest extends TeaModel {
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
     * <p>xxx</p>
     */
    @NameInMap("essayTaskId")
    public String essayTaskId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxx</p>
     */
    @NameInMap("ext")
    public String ext;

    /**
     * <strong>example:</strong>
     * <p>xxx</p>
     */
    @NameInMap("failedMsg")
    public String failedMsg;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxx</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxx</p>
     */
    @NameInMap("taskCode")
    public String taskCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxx</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UpdateEssayTaskCorrectionResultRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateEssayTaskCorrectionResultRequest self = new UpdateEssayTaskCorrectionResultRequest();
        return TeaModel.build(map, self);
    }

    public UpdateEssayTaskCorrectionResultRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public UpdateEssayTaskCorrectionResultRequest setEssayTaskId(String essayTaskId) {
        this.essayTaskId = essayTaskId;
        return this;
    }
    public String getEssayTaskId() {
        return this.essayTaskId;
    }

    public UpdateEssayTaskCorrectionResultRequest setExt(String ext) {
        this.ext = ext;
        return this;
    }
    public String getExt() {
        return this.ext;
    }

    public UpdateEssayTaskCorrectionResultRequest setFailedMsg(String failedMsg) {
        this.failedMsg = failedMsg;
        return this;
    }
    public String getFailedMsg() {
        return this.failedMsg;
    }

    public UpdateEssayTaskCorrectionResultRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public UpdateEssayTaskCorrectionResultRequest setTaskCode(String taskCode) {
        this.taskCode = taskCode;
        return this;
    }
    public String getTaskCode() {
        return this.taskCode;
    }

    public UpdateEssayTaskCorrectionResultRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
