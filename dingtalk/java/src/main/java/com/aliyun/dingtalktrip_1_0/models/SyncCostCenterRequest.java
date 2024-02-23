// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncCostCenterRequest extends TeaModel {
    @NameInMap("channelCorpId")
    public String channelCorpId;

    @NameInMap("costCenterId")
    public String costCenterId;

    @NameInMap("deleteFlag")
    public Boolean deleteFlag;

    @NameInMap("extension")
    public String extension;

    @NameInMap("gmtAction")
    public String gmtAction;

    @NameInMap("number")
    public String number;

    @NameInMap("source")
    public String source;

    @NameInMap("thirdPartId")
    public String thirdPartId;

    @NameInMap("title")
    public String title;

    @NameInMap("userId")
    public String userId;

    public static SyncCostCenterRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncCostCenterRequest self = new SyncCostCenterRequest();
        return TeaModel.build(map, self);
    }

    public SyncCostCenterRequest setChannelCorpId(String channelCorpId) {
        this.channelCorpId = channelCorpId;
        return this;
    }
    public String getChannelCorpId() {
        return this.channelCorpId;
    }

    public SyncCostCenterRequest setCostCenterId(String costCenterId) {
        this.costCenterId = costCenterId;
        return this;
    }
    public String getCostCenterId() {
        return this.costCenterId;
    }

    public SyncCostCenterRequest setDeleteFlag(Boolean deleteFlag) {
        this.deleteFlag = deleteFlag;
        return this;
    }
    public Boolean getDeleteFlag() {
        return this.deleteFlag;
    }

    public SyncCostCenterRequest setExtension(String extension) {
        this.extension = extension;
        return this;
    }
    public String getExtension() {
        return this.extension;
    }

    public SyncCostCenterRequest setGmtAction(String gmtAction) {
        this.gmtAction = gmtAction;
        return this;
    }
    public String getGmtAction() {
        return this.gmtAction;
    }

    public SyncCostCenterRequest setNumber(String number) {
        this.number = number;
        return this;
    }
    public String getNumber() {
        return this.number;
    }

    public SyncCostCenterRequest setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public SyncCostCenterRequest setThirdPartId(String thirdPartId) {
        this.thirdPartId = thirdPartId;
        return this;
    }
    public String getThirdPartId() {
        return this.thirdPartId;
    }

    public SyncCostCenterRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public SyncCostCenterRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
