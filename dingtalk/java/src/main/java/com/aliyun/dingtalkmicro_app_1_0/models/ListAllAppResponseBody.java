// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListAllAppResponseBody extends TeaModel {
    // 应用列表
    @NameInMap("appList")
    public java.util.List<ListAllAppResponseBodyAppList> appList;

    public static ListAllAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListAllAppResponseBody self = new ListAllAppResponseBody();
        return TeaModel.build(map, self);
    }

    public ListAllAppResponseBody setAppList(java.util.List<ListAllAppResponseBodyAppList> appList) {
        this.appList = appList;
        return this;
    }
    public java.util.List<ListAllAppResponseBodyAppList> getAppList() {
        return this.appList;
    }

    public static class ListAllAppResponseBodyAppList extends TeaModel {
        // 应用id
        @NameInMap("agentId")
        public Long agentId;

        // 应用名称
        @NameInMap("name")
        public String name;

        // 应用描述
        @NameInMap("desc")
        public String desc;

        // 应用图标
        @NameInMap("icon")
        public String icon;

        // 应用移动端首页地址
        @NameInMap("homepageLink")
        public String homepageLink;

        // 应用PC端首页地址
        @NameInMap("pcHomepageLink")
        public String pcHomepageLink;

        // 应用管理后台地址
        @NameInMap("ompLink")
        public String ompLink;

        // 三方应用id，如果是企业内部应用，返回0
        @NameInMap("appId")
        public Long appId;

        // 应用状态，0：停用，1：启用 ，3：过期
        @NameInMap("appStatus")
        public Integer appStatus;

        public static ListAllAppResponseBodyAppList build(java.util.Map<String, ?> map) throws Exception {
            ListAllAppResponseBodyAppList self = new ListAllAppResponseBodyAppList();
            return TeaModel.build(map, self);
        }

        public ListAllAppResponseBodyAppList setAgentId(Long agentId) {
            this.agentId = agentId;
            return this;
        }
        public Long getAgentId() {
            return this.agentId;
        }

        public ListAllAppResponseBodyAppList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListAllAppResponseBodyAppList setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public ListAllAppResponseBodyAppList setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public ListAllAppResponseBodyAppList setHomepageLink(String homepageLink) {
            this.homepageLink = homepageLink;
            return this;
        }
        public String getHomepageLink() {
            return this.homepageLink;
        }

        public ListAllAppResponseBodyAppList setPcHomepageLink(String pcHomepageLink) {
            this.pcHomepageLink = pcHomepageLink;
            return this;
        }
        public String getPcHomepageLink() {
            return this.pcHomepageLink;
        }

        public ListAllAppResponseBodyAppList setOmpLink(String ompLink) {
            this.ompLink = ompLink;
            return this;
        }
        public String getOmpLink() {
            return this.ompLink;
        }

        public ListAllAppResponseBodyAppList setAppId(Long appId) {
            this.appId = appId;
            return this;
        }
        public Long getAppId() {
            return this.appId;
        }

        public ListAllAppResponseBodyAppList setAppStatus(Integer appStatus) {
            this.appStatus = appStatus;
            return this;
        }
        public Integer getAppStatus() {
            return this.appStatus;
        }

    }

}
