// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class SetOrgConfigRequest extends TeaModel {
    /**
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("appDisplayStyle")
    public Integer appDisplayStyle;

    /**
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("homepageCatalogs")
    public java.util.List<String> homepageCatalogs;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("status")
    public Integer status;

    public static SetOrgConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        SetOrgConfigRequest self = new SetOrgConfigRequest();
        return TeaModel.build(map, self);
    }

    public SetOrgConfigRequest setAppDisplayStyle(Integer appDisplayStyle) {
        this.appDisplayStyle = appDisplayStyle;
        return this;
    }
    public Integer getAppDisplayStyle() {
        return this.appDisplayStyle;
    }

    public SetOrgConfigRequest setHomepageCatalogs(java.util.List<String> homepageCatalogs) {
        this.homepageCatalogs = homepageCatalogs;
        return this;
    }
    public java.util.List<String> getHomepageCatalogs() {
        return this.homepageCatalogs;
    }

    public SetOrgConfigRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public SetOrgConfigRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
