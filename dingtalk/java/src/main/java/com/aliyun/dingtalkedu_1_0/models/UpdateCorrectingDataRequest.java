// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCorrectingDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding8196cd122f5cc6abecb851</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dataDetail")
    public String dataDetail;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>terminate_correcting</p>
     */
    @NameInMap("dataType")
    public String dataType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>DING_SCAN_CORRECT_0***0001</p>
     */
    @NameInMap("taskCode")
    public String taskCode;

    public static UpdateCorrectingDataRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateCorrectingDataRequest self = new UpdateCorrectingDataRequest();
        return TeaModel.build(map, self);
    }

    public UpdateCorrectingDataRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public UpdateCorrectingDataRequest setDataDetail(String dataDetail) {
        this.dataDetail = dataDetail;
        return this;
    }
    public String getDataDetail() {
        return this.dataDetail;
    }

    public UpdateCorrectingDataRequest setDataType(String dataType) {
        this.dataType = dataType;
        return this;
    }
    public String getDataType() {
        return this.dataType;
    }

    public UpdateCorrectingDataRequest setTaskCode(String taskCode) {
        this.taskCode = taskCode;
        return this;
    }
    public String getTaskCode() {
        return this.taskCode;
    }

}
