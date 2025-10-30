// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class SyncSignEventShrinkRequest extends TeaModel {
    @NameInMap("contractBizId")
    public String contractBizId;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("extInfo")
    public String extInfoShrink;

    @NameInMap("sealType")
    public String sealTypeShrink;

    @NameInMap("signDate")
    public Long signDate;

    @NameInMap("signFileList")
    public String signFileListShrink;

    @NameInMap("staffId")
    public String staffId;

    public static SyncSignEventShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncSignEventShrinkRequest self = new SyncSignEventShrinkRequest();
        return TeaModel.build(map, self);
    }

    public SyncSignEventShrinkRequest setContractBizId(String contractBizId) {
        this.contractBizId = contractBizId;
        return this;
    }
    public String getContractBizId() {
        return this.contractBizId;
    }

    public SyncSignEventShrinkRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public SyncSignEventShrinkRequest setExtInfoShrink(String extInfoShrink) {
        this.extInfoShrink = extInfoShrink;
        return this;
    }
    public String getExtInfoShrink() {
        return this.extInfoShrink;
    }

    public SyncSignEventShrinkRequest setSealTypeShrink(String sealTypeShrink) {
        this.sealTypeShrink = sealTypeShrink;
        return this;
    }
    public String getSealTypeShrink() {
        return this.sealTypeShrink;
    }

    public SyncSignEventShrinkRequest setSignDate(Long signDate) {
        this.signDate = signDate;
        return this;
    }
    public Long getSignDate() {
        return this.signDate;
    }

    public SyncSignEventShrinkRequest setSignFileListShrink(String signFileListShrink) {
        this.signFileListShrink = signFileListShrink;
        return this;
    }
    public String getSignFileListShrink() {
        return this.signFileListShrink;
    }

    public SyncSignEventShrinkRequest setStaffId(String staffId) {
        this.staffId = staffId;
        return this;
    }
    public String getStaffId() {
        return this.staffId;
    }

}
