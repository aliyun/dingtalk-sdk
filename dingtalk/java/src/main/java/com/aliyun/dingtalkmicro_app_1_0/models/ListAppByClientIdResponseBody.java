// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListAppByClientIdResponseBody extends TeaModel {
    @NameInMap("agentId")
    public Long agentId;

    @NameInMap("appId")
    public Long appId;

    @NameInMap("appStatus")
    public Integer appStatus;

    @NameInMap("desc")
    public String desc;

    @NameInMap("developType")
    public Integer developType;

    @NameInMap("homepageLink")
    public String homepageLink;

    @NameInMap("icon")
    public String icon;

    @NameInMap("name")
    public String name;

    @NameInMap("ompLink")
    public String ompLink;

    @NameInMap("pcHomepageLink")
    public String pcHomepageLink;

    public static ListAppByClientIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListAppByClientIdResponseBody self = new ListAppByClientIdResponseBody();
        return TeaModel.build(map, self);
    }

    public ListAppByClientIdResponseBody setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

    public ListAppByClientIdResponseBody setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public ListAppByClientIdResponseBody setAppStatus(Integer appStatus) {
        this.appStatus = appStatus;
        return this;
    }
    public Integer getAppStatus() {
        return this.appStatus;
    }

    public ListAppByClientIdResponseBody setDesc(String desc) {
        this.desc = desc;
        return this;
    }
    public String getDesc() {
        return this.desc;
    }

    public ListAppByClientIdResponseBody setDevelopType(Integer developType) {
        this.developType = developType;
        return this;
    }
    public Integer getDevelopType() {
        return this.developType;
    }

    public ListAppByClientIdResponseBody setHomepageLink(String homepageLink) {
        this.homepageLink = homepageLink;
        return this;
    }
    public String getHomepageLink() {
        return this.homepageLink;
    }

    public ListAppByClientIdResponseBody setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public ListAppByClientIdResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public ListAppByClientIdResponseBody setOmpLink(String ompLink) {
        this.ompLink = ompLink;
        return this;
    }
    public String getOmpLink() {
        return this.ompLink;
    }

    public ListAppByClientIdResponseBody setPcHomepageLink(String pcHomepageLink) {
        this.pcHomepageLink = pcHomepageLink;
        return this;
    }
    public String getPcHomepageLink() {
        return this.pcHomepageLink;
    }

}
