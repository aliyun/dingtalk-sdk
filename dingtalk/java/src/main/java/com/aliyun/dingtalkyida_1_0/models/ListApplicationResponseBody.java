// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListApplicationResponseBody extends TeaModel {
    /**
     * <p>数据</p>
     */
    @NameInMap("data")
    public java.util.List<ListApplicationResponseBodyData> data;

    /**
     * <p>当前第几页</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>总数量</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static ListApplicationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListApplicationResponseBody self = new ListApplicationResponseBody();
        return TeaModel.build(map, self);
    }

    public ListApplicationResponseBody setData(java.util.List<ListApplicationResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<ListApplicationResponseBodyData> getData() {
        return this.data;
    }

    public ListApplicationResponseBody setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public ListApplicationResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class ListApplicationResponseBodyData extends TeaModel {
        /**
         * <p>宜搭应用配置</p>
         */
        @NameInMap("appConfig")
        public String appConfig;

        /**
         * <p>宜搭应用编码</p>
         */
        @NameInMap("appType")
        public String appType;

        /**
         * <p>应用状态</p>
         */
        @NameInMap("applicationStatus")
        public String applicationStatus;

        /**
         * <p>钉钉组织id</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>创建者的userId</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

        /**
         * <p>描述信息</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <p>宜搭图标编码</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <p>是否被删除了</p>
         */
        @NameInMap("inexistence")
        public String inexistence;

        /**
         * <p>名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>子组织的钉钉CorpId</p>
         */
        @NameInMap("subCorpId")
        public String subCorpId;

        public static ListApplicationResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            ListApplicationResponseBodyData self = new ListApplicationResponseBodyData();
            return TeaModel.build(map, self);
        }

        public ListApplicationResponseBodyData setAppConfig(String appConfig) {
            this.appConfig = appConfig;
            return this;
        }
        public String getAppConfig() {
            return this.appConfig;
        }

        public ListApplicationResponseBodyData setAppType(String appType) {
            this.appType = appType;
            return this;
        }
        public String getAppType() {
            return this.appType;
        }

        public ListApplicationResponseBodyData setApplicationStatus(String applicationStatus) {
            this.applicationStatus = applicationStatus;
            return this;
        }
        public String getApplicationStatus() {
            return this.applicationStatus;
        }

        public ListApplicationResponseBodyData setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public ListApplicationResponseBodyData setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public ListApplicationResponseBodyData setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListApplicationResponseBodyData setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public ListApplicationResponseBodyData setInexistence(String inexistence) {
            this.inexistence = inexistence;
            return this;
        }
        public String getInexistence() {
            return this.inexistence;
        }

        public ListApplicationResponseBodyData setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListApplicationResponseBodyData setSubCorpId(String subCorpId) {
            this.subCorpId = subCorpId;
            return this;
        }
        public String getSubCorpId() {
            return this.subCorpId;
        }

    }

}
