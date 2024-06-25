// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncCostCenterRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding89233847892ndkas</p>
     */
    @NameInMap("channelCorpId")
    public String channelCorpId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("costCenterId")
    public String costCenterId;

    /**
     * <strong>if can be null:</strong>
     * <p>false</p>
     */
    @NameInMap("deleteFlag")
    public Boolean deleteFlag;

    /**
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("extension")
    public String extension;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2022-02-21 11:11:11</p>
     */
    @NameInMap("gmtAction")
    public String gmtAction;

    /**
     * <strong>example:</strong>
     * <p>123456</p>
     */
    @NameInMap("number")
    public String number;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("scope")
    public Integer scope;

    /**
     * <strong>example:</strong>
     * <p>阿里商旅</p>
     */
    @NameInMap("source")
    public String source;

    @NameInMap("thirdPartId")
    public String thirdPartId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>默认成本中心</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20881001829000</p>
     */
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

    public SyncCostCenterRequest setScope(Integer scope) {
        this.scope = scope;
        return this;
    }
    public Integer getScope() {
        return this.scope;
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
