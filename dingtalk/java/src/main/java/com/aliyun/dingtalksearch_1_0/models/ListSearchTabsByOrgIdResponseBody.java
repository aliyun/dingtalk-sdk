// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class ListSearchTabsByOrgIdResponseBody extends TeaModel {
    /**
     * <p>该企业拥有的所有数据源信息</p>
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
        /**
         * <p>创建时间</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>修改时间</p>
         */
        @NameInMap("gmtModified")
        public String gmtModified;

        /**
         * <p>数据源名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>数据源优先级，数值越小优先级越高</p>
         */
        @NameInMap("priority")
        public Integer priority;

        /**
         * <p>数据来源,非必填,默认来源为钉钉搜索内部引擎</p>
         */
        @NameInMap("source")
        public String source;

        /**
         * <p>数据源状态，1表示上线，0表示下线</p>
         */
        @NameInMap("status")
        public Integer status;

        /**
         * <p>数据源的id,范围为3000-4000</p>
         */
        @NameInMap("tabId")
        public Integer tabId;

        public static ListSearchTabsByOrgIdResponseBodySearchTabResult build(java.util.Map<String, ?> map) throws Exception {
            ListSearchTabsByOrgIdResponseBodySearchTabResult self = new ListSearchTabsByOrgIdResponseBodySearchTabResult();
            return TeaModel.build(map, self);
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
