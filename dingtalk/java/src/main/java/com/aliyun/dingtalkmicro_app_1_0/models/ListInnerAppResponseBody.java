// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListInnerAppResponseBody extends TeaModel {
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("agentId")
        public Long agentId;

        /**
         * <strong>example:</strong>
         * <p>desc</p>
         */
        @NameInMap("desc")
        public String desc;

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
