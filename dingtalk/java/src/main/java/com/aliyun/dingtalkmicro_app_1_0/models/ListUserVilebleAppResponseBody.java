// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListUserVilebleAppResponseBody extends TeaModel {
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

        /**
         * <strong>example:</strong>
         * <p>unifiedAppId</p>
         */
        @NameInMap("unifiedAppId")
        public String unifiedAppId;

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

        public ListUserVilebleAppResponseBodyAppList setDevelopType(Integer developType) {
            this.developType = developType;
            return this;
        }
        public Integer getDevelopType() {
            return this.developType;
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

        public ListUserVilebleAppResponseBodyAppList setUnifiedAppId(String unifiedAppId) {
            this.unifiedAppId = unifiedAppId;
            return this;
        }
        public String getUnifiedAppId() {
            return this.unifiedAppId;
        }

    }

}
