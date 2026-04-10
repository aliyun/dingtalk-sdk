// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SyncCheckedDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>https://...</p>
     */
    @NameInMap("checkJsonUrl")
    public String checkJsonUrl;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>https:.....</p>
     * 
     * <strong>if can be null:</strong>
     * <p>false</p>
     */
    @NameInMap("checkUrl")
    public String checkUrl;

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

    public static SyncCheckedDataRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncCheckedDataRequest self = new SyncCheckedDataRequest();
        return TeaModel.build(map, self);
    }

    public SyncCheckedDataRequest setCheckJsonUrl(String checkJsonUrl) {
        this.checkJsonUrl = checkJsonUrl;
        return this;
    }
    public String getCheckJsonUrl() {
        return this.checkJsonUrl;
    }

    public SyncCheckedDataRequest setCheckUrl(String checkUrl) {
        this.checkUrl = checkUrl;
        return this;
    }
    public String getCheckUrl() {
        return this.checkUrl;
    }

    public SyncCheckedDataRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public SyncCheckedDataRequest setTaskCode(String taskCode) {
        this.taskCode = taskCode;
        return this;
    }
    public String getTaskCode() {
        return this.taskCode;
    }

}
