// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListInnerAppResponseBody extends TeaModel {
    /**
     * <p>应用列表</p>
     */
    @NameInMap("appList")
    public java.util.List<ListInnerAppResponseBodyAppList> appList;

    public static ListInnerAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListInnerAppResponseBody self = new ListInnerAppResponseBody();
        return TeaModel.build(map, self);
    }

    public ListInnerAppResponseBody setAppList(java.util.List<ListInnerAppResponseBodyAppList> appList) {
        this.appList = appList;
        return this;
    }
    public java.util.List<ListInnerAppResponseBodyAppList> getAppList() {
        return this.appList;
    }

    public static class ListInnerAppResponseBodyAppList extends TeaModel {
        /**
         * <p>应用id</p>
         */
        @NameInMap("agentId")
        public Long agentId;

        /**
         * <p>应用描述</p>
         */
        @NameInMap("desc")
        public String desc;

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

        public static ListInnerAppResponseBodyAppList build(java.util.Map<String, ?> map) throws Exception {
            ListInnerAppResponseBodyAppList self = new ListInnerAppResponseBodyAppList();
            return TeaModel.build(map, self);
        }

        public ListInnerAppResponseBodyAppList setAgentId(Long agentId) {
            this.agentId = agentId;
            return this;
        }
        public Long getAgentId() {
            return this.agentId;
        }

        public ListInnerAppResponseBodyAppList setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public ListInnerAppResponseBodyAppList setHomepageLink(String homepageLink) {
            this.homepageLink = homepageLink;
            return this;
        }
        public String getHomepageLink() {
            return this.homepageLink;
        }

        public ListInnerAppResponseBodyAppList setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public ListInnerAppResponseBodyAppList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListInnerAppResponseBodyAppList setOmpLink(String ompLink) {
            this.ompLink = ompLink;
            return this;
        }
        public String getOmpLink() {
            return this.ompLink;
        }

        public ListInnerAppResponseBodyAppList setPcHomepageLink(String pcHomepageLink) {
            this.pcHomepageLink = pcHomepageLink;
            return this;
        }
        public String getPcHomepageLink() {
            return this.pcHomepageLink;
        }

    }

}
