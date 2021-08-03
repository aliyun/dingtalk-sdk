// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class CreateApaasAppRequest extends TeaModel {
    @NameInMap("appName")
    public String appName;

    @NameInMap("appDesc")
    public String appDesc;

    @NameInMap("appIcon")
    public String appIcon;

    @NameInMap("homepageLink")
    public String homepageLink;

    @NameInMap("pcHomepageLink")
    public String pcHomepageLink;

    @NameInMap("ompLink")
    public String ompLink;

    @NameInMap("homepageEditLink")
    public String homepageEditLink;

    @NameInMap("pcHomepageEditLink")
    public String pcHomepageEditLink;

    @NameInMap("opUserId")
    public String opUserId;

    @NameInMap("bizAppId")
    public String bizAppId;

    @NameInMap("templateKey")
    public String templateKey;

    @NameInMap("isShortCut")
    public Integer isShortCut;

    public static CreateApaasAppRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateApaasAppRequest self = new CreateApaasAppRequest();
        return TeaModel.build(map, self);
    }

    public CreateApaasAppRequest setAppName(String appName) {
        this.appName = appName;
        return this;
    }
    public String getAppName() {
        return this.appName;
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

    public CreateApaasAppRequest setHomepageLink(String homepageLink) {
        this.homepageLink = homepageLink;
        return this;
    }
    public String getHomepageLink() {
        return this.homepageLink;
    }

    public CreateApaasAppRequest setPcHomepageLink(String pcHomepageLink) {
        this.pcHomepageLink = pcHomepageLink;
        return this;
    }
    public String getPcHomepageLink() {
        return this.pcHomepageLink;
    }

    public CreateApaasAppRequest setOmpLink(String ompLink) {
        this.ompLink = ompLink;
        return this;
    }
    public String getOmpLink() {
        return this.ompLink;
    }

    public CreateApaasAppRequest setHomepageEditLink(String homepageEditLink) {
        this.homepageEditLink = homepageEditLink;
        return this;
    }
    public String getHomepageEditLink() {
        return this.homepageEditLink;
    }

    public CreateApaasAppRequest setPcHomepageEditLink(String pcHomepageEditLink) {
        this.pcHomepageEditLink = pcHomepageEditLink;
        return this;
    }
    public String getPcHomepageEditLink() {
        return this.pcHomepageEditLink;
    }

    public CreateApaasAppRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public CreateApaasAppRequest setBizAppId(String bizAppId) {
        this.bizAppId = bizAppId;
        return this;
    }
    public String getBizAppId() {
        return this.bizAppId;
    }

    public CreateApaasAppRequest setTemplateKey(String templateKey) {
        this.templateKey = templateKey;
        return this;
    }
    public String getTemplateKey() {
        return this.templateKey;
    }

    public CreateApaasAppRequest setIsShortCut(Integer isShortCut) {
        this.isShortCut = isShortCut;
        return this;
    }
    public Integer getIsShortCut() {
        return this.isShortCut;
    }

}
