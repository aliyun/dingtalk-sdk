// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class UpgradeTemplateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingcd2016f425331dc1acaaa37764f94726</p>
     */
    @NameInMap("channelCorpId")
    public String channelCorpId;

    @NameInMap("forceUpgrade")
    public Boolean forceUpgrade;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingcd2016f425331dc1acaaa37764f94726</p>
     */
    @NameInMap("tmcCorpId")
    public String tmcCorpId;

    public static UpgradeTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        UpgradeTemplateRequest self = new UpgradeTemplateRequest();
        return TeaModel.build(map, self);
    }

    public UpgradeTemplateRequest setChannelCorpId(String channelCorpId) {
        this.channelCorpId = channelCorpId;
        return this;
    }
    public String getChannelCorpId() {
        return this.channelCorpId;
    }

    public UpgradeTemplateRequest setForceUpgrade(Boolean forceUpgrade) {
        this.forceUpgrade = forceUpgrade;
        return this;
    }
    public Boolean getForceUpgrade() {
        return this.forceUpgrade;
    }

    public UpgradeTemplateRequest setTmcCorpId(String tmcCorpId) {
        this.tmcCorpId = tmcCorpId;
        return this;
    }
    public String getTmcCorpId() {
        return this.tmcCorpId;
    }

}
