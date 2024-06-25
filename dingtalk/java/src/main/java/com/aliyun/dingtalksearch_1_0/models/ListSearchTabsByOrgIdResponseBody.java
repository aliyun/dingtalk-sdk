// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class ListSearchTabsByOrgIdResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("searchTabResult")
    public java.util.List<ListSearchTabsByOrgIdResponseBodySearchTabResult> searchTabResult;

    public static ListSearchTabsByOrgIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListSearchTabsByOrgIdResponseBody self = new ListSearchTabsByOrgIdResponseBody();
        return TeaModel.build(map, self);
    }

    public ListSearchTabsByOrgIdResponseBody setSearchTabResult(java.util.List<ListSearchTabsByOrgIdResponseBodySearchTabResult> searchTabResult) {
        this.searchTabResult = searchTabResult;
        return this;
    }
    public java.util.List<ListSearchTabsByOrgIdResponseBodySearchTabResult> getSearchTabResult() {
        return this.searchTabResult;
    }

    public static class ListSearchTabsByOrgIdResponseBodySearchTabResult extends TeaModel {
        @NameInMap("darkIcon")
        public String darkIcon;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-09-17T19:43Z</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-09-17T19:43Z</p>
         */
        @NameInMap("gmtModified")
        public String gmtModified;

        @NameInMap("icon")
        public String icon;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>专辑</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("priority")
        public Integer priority;

        @NameInMap("source")
        public String source;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("status")
        public Integer status;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>3333</p>
         */
        @NameInMap("tabId")
        public Integer tabId;

        public static ListSearchTabsByOrgIdResponseBodySearchTabResult build(java.util.Map<String, ?> map) throws Exception {
            ListSearchTabsByOrgIdResponseBodySearchTabResult self = new ListSearchTabsByOrgIdResponseBodySearchTabResult();
            return TeaModel.build(map, self);
        }

        public ListSearchTabsByOrgIdResponseBodySearchTabResult setDarkIcon(String darkIcon) {
            this.darkIcon = darkIcon;
            return this;
        }
        public String getDarkIcon() {
            return this.darkIcon;
        }

        public ListSearchTabsByOrgIdResponseBodySearchTabResult setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public ListSearchTabsByOrgIdResponseBodySearchTabResult setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public ListSearchTabsByOrgIdResponseBodySearchTabResult setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public ListSearchTabsByOrgIdResponseBodySearchTabResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListSearchTabsByOrgIdResponseBodySearchTabResult setPriority(Integer priority) {
            this.priority = priority;
            return this;
        }
        public Integer getPriority() {
            return this.priority;
        }

        public ListSearchTabsByOrgIdResponseBodySearchTabResult setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

        public ListSearchTabsByOrgIdResponseBodySearchTabResult setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public ListSearchTabsByOrgIdResponseBodySearchTabResult setTabId(Integer tabId) {
            this.tabId = tabId;
            return this;
        }
        public Integer getTabId() {
            return this.tabId;
        }

    }

}
