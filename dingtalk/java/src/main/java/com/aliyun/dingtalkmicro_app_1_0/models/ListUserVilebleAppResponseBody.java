// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListUserVilebleAppResponseBody extends TeaModel {
    // 应用列表
    @NameInMap("appList")
    public java.util.List<ListUserVilebleAppResponseBodyAppList> appList;

    public static ListUserVilebleAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListUserVilebleAppResponseBody self = new ListUserVilebleAppResponseBody();
        return TeaModel.build(map, self);
    }

    public ListUserVilebleAppResponseBody setAppList(java.util.List<ListUserVilebleAppResponseBodyAppList> appList) {
        this.appList = appList;
        return this;
    }
    public java.util.List<ListUserVilebleAppResponseBodyAppList> getAppList() {
        return this.appList;
    }

    public static class ListUserVilebleAppResponseBodyAppList extends TeaModel {
        // 应用id
        @NameInMap("agentId")
        public Long agentId;

        // 三方应用id，如果是企业内部应用，返回0
        @NameInMap("appId")
        public Long appId;

        // 应用状态，0：停用，1：启用 ，3：过期
        @NameInMap("appStatus")
        public Integer appStatus;

        // 应用描述
        @NameInMap("desc")
        public String desc;

        // 应用移动端首页地址
        @NameInMap("homepageLink")
        public String homepageLink;

        // 应用图标
        @NameInMap("icon")
        public String icon;

        // 应用名称
        @NameInMap("name")
        public String name;

        // 应用管理后台地址
        @NameInMap("ompLink")
        public String ompLink;

        // 应用PC端首页地址
        @NameInMap("pcHomepageLink")
        public String pcHomepageLink;

        public static ListUserVilebleAppResponseBodyAppList build(java.util.Map<String, ?> map) throws Exception {
            ListUserVilebleAppResponseBodyAppList self = new ListUserVilebleAppResponseBodyAppList();
            return TeaModel.build(map, self);
        }

        public ListUserVilebleAppResponseBodyAppList setAgentId(Long agentId) {
            this.agentId = agentId;
            return this;
        }
        public Long getAgentId() {
            return this.agentId;
        }

        public ListUserVilebleAppResponseBodyAppList setAppId(Long appId) {
            this.appId = appId;
            return this;
        }
        public Long getAppId() {
            return this.appId;
        }

        public ListUserVilebleAppResponseBodyAppList setAppStatus(Integer appStatus) {
            this.appStatus = appStatus;
            return this;
        }
        public Integer getAppStatus() {
            return this.appStatus;
        }

        public ListUserVilebleAppResponseBodyAppList setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public ListUserVilebleAppResponseBodyAppList setHomepageLink(String homepageLink) {
            this.homepageLink = homepageLink;
            return this;
        }
        public String getHomepageLink() {
            return this.homepageLink;
        }

        public ListUserVilebleAppResponseBodyAppList setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public ListUserVilebleAppResponseBodyAppList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListUserVilebleAppResponseBodyAppList setOmpLink(String ompLink) {
            this.ompLink = ompLink;
            return this;
        }
        public String getOmpLink() {
            return this.ompLink;
        }

        public ListUserVilebleAppResponseBodyAppList setPcHomepageLink(String pcHomepageLink) {
            this.pcHomepageLink = pcHomepageLink;
            return this;
        }
        public String getPcHomepageLink() {
            return this.pcHomepageLink;
        }

    }

}
