// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListAllInnerAppsResponseBody extends TeaModel {
    @NameInMap("appList")
    public java.util.List<ListAllInnerAppsResponseBodyAppList> appList;

    public static ListAllInnerAppsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListAllInnerAppsResponseBody self = new ListAllInnerAppsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListAllInnerAppsResponseBody setAppList(java.util.List<ListAllInnerAppsResponseBodyAppList> appList) {
        this.appList = appList;
        return this;
    }
    public java.util.List<ListAllInnerAppsResponseBodyAppList> getAppList() {
        return this.appList;
    }

    public static class ListAllInnerAppsResponseBodyAppList extends TeaModel {
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

        public static ListAllInnerAppsResponseBodyAppList build(java.util.Map<String, ?> map) throws Exception {
            ListAllInnerAppsResponseBodyAppList self = new ListAllInnerAppsResponseBodyAppList();
            return TeaModel.build(map, self);
        }

        public ListAllInnerAppsResponseBodyAppList setAgentId(Long agentId) {
            this.agentId = agentId;
            return this;
        }
        public Long getAgentId() {
            return this.agentId;
        }

        public ListAllInnerAppsResponseBodyAppList setAppId(Long appId) {
            this.appId = appId;
            return this;
        }
        public Long getAppId() {
            return this.appId;
        }

        public ListAllInnerAppsResponseBodyAppList setAppStatus(Integer appStatus) {
            this.appStatus = appStatus;
            return this;
        }
        public Integer getAppStatus() {
            return this.appStatus;
        }

        public ListAllInnerAppsResponseBodyAppList setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public ListAllInnerAppsResponseBodyAppList setDevelopType(Integer developType) {
            this.developType = developType;
            return this;
        }
        public Integer getDevelopType() {
            return this.developType;
        }

        public ListAllInnerAppsResponseBodyAppList setHomepageLink(String homepageLink) {
            this.homepageLink = homepageLink;
            return this;
        }
        public String getHomepageLink() {
            return this.homepageLink;
        }

        public ListAllInnerAppsResponseBodyAppList setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public ListAllInnerAppsResponseBodyAppList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListAllInnerAppsResponseBodyAppList setOmpLink(String ompLink) {
            this.ompLink = ompLink;
            return this;
        }
        public String getOmpLink() {
            return this.ompLink;
        }

        public ListAllInnerAppsResponseBodyAppList setPcHomepageLink(String pcHomepageLink) {
            this.pcHomepageLink = pcHomepageLink;
            return this;
        }
        public String getPcHomepageLink() {
            return this.pcHomepageLink;
        }

    }

}
