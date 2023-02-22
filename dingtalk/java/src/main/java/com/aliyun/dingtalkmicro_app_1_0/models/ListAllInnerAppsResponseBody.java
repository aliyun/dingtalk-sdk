// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListAllInnerAppsResponseBody extends TeaModel {
    /**
     * <p>应用列表</p>
     */
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
        /**
         * <p>应用id</p>
         */
        @NameInMap("agentId")
        public Long agentId;

        /**
         * <p>三方应用id，如果是企业内部应用，返回0</p>
         */
        @NameInMap("appId")
        public Long appId;

        /**
         * <p>应用状态，0：停用，1：启用 ，3：过期</p>
         */
        @NameInMap("appStatus")
        public Integer appStatus;

        /**
         * <p>应用描述</p>
         */
        @NameInMap("desc")
        public String desc;

        /**
         * <p>应用类型，0表示h5应用，1表示小程序</p>
         */
        @NameInMap("developType")
        public Integer developType;

        /**
         * <p>应用移动端首页地址</p>
         */
        @NameInMap("homepageLink")
        public String homepageLink;

        /**
         * <p>应用图标</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <p>应用名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>应用管理后台地址</p>
         */
        @NameInMap("ompLink")
        public String ompLink;

        /**
         * <p>应用PC端首页地址</p>
         */
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
