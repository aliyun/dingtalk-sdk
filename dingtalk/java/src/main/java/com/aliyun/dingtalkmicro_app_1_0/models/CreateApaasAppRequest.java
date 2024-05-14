// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class CreateApaasAppRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("appDesc")
    public String appDesc;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("appIcon")
    public String appIcon;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("appName")
    public String appName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizAppId")
    public String bizAppId;

    @NameInMap("homepageEditLink")
    public String homepageEditLink;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("homepageLink")
    public String homepageLink;

    @NameInMap("isShortCut")
    public Integer isShortCut;

    @NameInMap("ompLink")
    public String ompLink;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pcHomepageEditLink")
    public String pcHomepageEditLink;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pcHomepageLink")
    public String pcHomepageLink;

    @NameInMap("templateKey")
    public String templateKey;

    public static CreateApaasAppRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateApaasAppRequest self = new CreateApaasAppRequest();
        return TeaModel.build(map, self);
    }

    public CreateApaasAppRequest setAppDesc(String appDesc) {
        this.appDesc = appDesc;
        return this;
    }
    public String getAppDesc() {
        return this.appDesc;
    }

    public CreateApaasAppRequest setAppIcon(String appIcon) {
        this.appIcon = appIcon;
        return this;
    }
    public String getAppIcon() {
        return this.appIcon;
    }

    public CreateApaasAppRequest setAppName(String appName) {
        this.appName = appName;
        return this;
    }
    public String getAppName() {
        return this.appName;
    }

    public CreateApaasAppRequest setBizAppId(String bizAppId) {
        this.bizAppId = bizAppId;
        return this;
    }
    public String getBizAppId() {
        return this.bizAppId;
    }

    public CreateApaasAppRequest setHomepageEditLink(String homepageEditLink) {
        this.homepageEditLink = homepageEditLink;
        return this;
    }
    public String getHomepageEditLink() {
        return this.homepageEditLink;
    }

    public CreateApaasAppRequest setHomepageLink(String homepageLink) {
        this.homepageLink = homepageLink;
        return this;
    }
    public String getHomepageLink() {
        return this.homepageLink;
    }

    public CreateApaasAppRequest setIsShortCut(Integer isShortCut) {
        this.isShortCut = isShortCut;
        return this;
    }
    public Integer getIsShortCut() {
        return this.isShortCut;
    }

    public CreateApaasAppRequest setOmpLink(String ompLink) {
        this.ompLink = ompLink;
        return this;
    }
    public String getOmpLink() {
        return this.ompLink;
    }

    public CreateApaasAppRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public CreateApaasAppRequest setPcHomepageEditLink(String pcHomepageEditLink) {
        this.pcHomepageEditLink = pcHomepageEditLink;
        return this;
    }
    public String getPcHomepageEditLink() {
        return this.pcHomepageEditLink;
    }

    public CreateApaasAppRequest setPcHomepageLink(String pcHomepageLink) {
        this.pcHomepageLink = pcHomepageLink;
        return this;
    }
    public String getPcHomepageLink() {
        return this.pcHomepageLink;
    }

    public CreateApaasAppRequest setTemplateKey(String templateKey) {
        this.templateKey = templateKey;
        return this;
    }
    public String getTemplateKey() {
        return this.templateKey;
    }

}
