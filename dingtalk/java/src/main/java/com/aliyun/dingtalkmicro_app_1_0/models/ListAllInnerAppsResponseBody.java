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

    public static class ListAllInnerAppsResponseBodyAppListCoolAppInfo extends TeaModel {
        @NameInMap("coolAppCode")
        public String coolAppCode;

        @NameInMap("name")
        public String name;

        public static ListAllInnerAppsResponseBodyAppListCoolAppInfo build(java.util.Map<String, ?> map) throws Exception {
            ListAllInnerAppsResponseBodyAppListCoolAppInfo self = new ListAllInnerAppsResponseBodyAppListCoolAppInfo();
            return TeaModel.build(map, self);
        }

        public ListAllInnerAppsResponseBodyAppListCoolAppInfo setCoolAppCode(String coolAppCode) {
            this.coolAppCode = coolAppCode;
            return this;
        }
        public String getCoolAppCode() {
            return this.coolAppCode;
        }

        public ListAllInnerAppsResponseBodyAppListCoolAppInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class ListAllInnerAppsResponseBodyAppListRobotInfo extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("robotCode")
        public String robotCode;

        public static ListAllInnerAppsResponseBodyAppListRobotInfo build(java.util.Map<String, ?> map) throws Exception {
            ListAllInnerAppsResponseBodyAppListRobotInfo self = new ListAllInnerAppsResponseBodyAppListRobotInfo();
            return TeaModel.build(map, self);
        }

        public ListAllInnerAppsResponseBodyAppListRobotInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListAllInnerAppsResponseBodyAppListRobotInfo setRobotCode(String robotCode) {
            this.robotCode = robotCode;
            return this;
        }
        public String getRobotCode() {
            return this.robotCode;
        }

    }

    public static class ListAllInnerAppsResponseBodyAppList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("agentId")
        public Long agentId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>111</p>
         */
        @NameInMap("appId")
        public Long appId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("appStatus")
        public Integer appStatus;

        @NameInMap("coolAppInfo")
        public java.util.List<ListAllInnerAppsResponseBodyAppListCoolAppInfo> coolAppInfo;

        /**
         * <strong>example:</strong>
         * <p>desc</p>
         */
        @NameInMap("desc")
        public String desc;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("developType")
        public Integer developType;

        /**
         * <strong>example:</strong>
         * <p><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></p>
         */
        @NameInMap("homepageLink")
        public String homepageLink;

        /**
         * <strong>example:</strong>
         * <p>icon</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <strong>example:</strong>
         * <p>name</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></p>
         */
        @NameInMap("ompLink")
        public String ompLink;

        /**
         * <strong>example:</strong>
         * <p><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></p>
         */
        @NameInMap("pcHomepageLink")
        public String pcHomepageLink;

        @NameInMap("robotInfo")
        public ListAllInnerAppsResponseBodyAppListRobotInfo robotInfo;

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

        public ListAllInnerAppsResponseBodyAppList setCoolAppInfo(java.util.List<ListAllInnerAppsResponseBodyAppListCoolAppInfo> coolAppInfo) {
            this.coolAppInfo = coolAppInfo;
            return this;
        }
        public java.util.List<ListAllInnerAppsResponseBodyAppListCoolAppInfo> getCoolAppInfo() {
            return this.coolAppInfo;
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

        public ListAllInnerAppsResponseBodyAppList setRobotInfo(ListAllInnerAppsResponseBodyAppListRobotInfo robotInfo) {
            this.robotInfo = robotInfo;
            return this;
        }
        public ListAllInnerAppsResponseBodyAppListRobotInfo getRobotInfo() {
            return this.robotInfo;
        }

    }

}
