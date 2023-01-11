// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListConnectorInformationResponseBody extends TeaModel {
    /**
     * <p>当前第几页</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>分页大小</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>pluginInfos</p>
     */
    @NameInMap("pluginInfos")
    public java.util.List<ListConnectorInformationResponseBodyPluginInfos> pluginInfos;

    /**
     * <p>总数量</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static ListConnectorInformationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListConnectorInformationResponseBody self = new ListConnectorInformationResponseBody();
        return TeaModel.build(map, self);
    }

    public ListConnectorInformationResponseBody setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ListConnectorInformationResponseBody setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListConnectorInformationResponseBody setPluginInfos(java.util.List<ListConnectorInformationResponseBodyPluginInfos> pluginInfos) {
        this.pluginInfos = pluginInfos;
        return this;
    }
    public java.util.List<ListConnectorInformationResponseBodyPluginInfos> getPluginInfos() {
        return this.pluginInfos;
    }

    public ListConnectorInformationResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class ListConnectorInformationResponseBodyPluginInfosApps extends TeaModel {
        /**
         * <p>appName</p>
         */
        @NameInMap("appName")
        public String appName;

        public static ListConnectorInformationResponseBodyPluginInfosApps build(java.util.Map<String, ?> map) throws Exception {
            ListConnectorInformationResponseBodyPluginInfosApps self = new ListConnectorInformationResponseBodyPluginInfosApps();
            return TeaModel.build(map, self);
        }

        public ListConnectorInformationResponseBodyPluginInfosApps setAppName(String appName) {
            this.appName = appName;
            return this;
        }
        public String getAppName() {
            return this.appName;
        }

    }

    public static class ListConnectorInformationResponseBodyPluginInfos extends TeaModel {
        /**
         * <p>apps</p>
         */
        @NameInMap("apps")
        public java.util.List<ListConnectorInformationResponseBodyPluginInfosApps> apps;

        /**
         * <p>iconUrl</p>
         */
        @NameInMap("iconUrl")
        public String iconUrl;

        /**
         * <p>pluginName</p>
         */
        @NameInMap("pluginName")
        public String pluginName;

        /**
         * <p>pluginPayType</p>
         */
        @NameInMap("pluginPayType")
        public Integer pluginPayType;

        /**
         * <p>pluginStatus</p>
         */
        @NameInMap("pluginStatus")
        public Integer pluginStatus;

        /**
         * <p>pluginTotalAmount</p>
         */
        @NameInMap("pluginTotalAmount")
        public Long pluginTotalAmount;

        /**
         * <p>pluginUsageAmount</p>
         */
        @NameInMap("pluginUsageAmount")
        public Long pluginUsageAmount;

        /**
         * <p>pluginUuid</p>
         */
        @NameInMap("pluginUuid")
        public String pluginUuid;

        public static ListConnectorInformationResponseBodyPluginInfos build(java.util.Map<String, ?> map) throws Exception {
            ListConnectorInformationResponseBodyPluginInfos self = new ListConnectorInformationResponseBodyPluginInfos();
            return TeaModel.build(map, self);
        }

        public ListConnectorInformationResponseBodyPluginInfos setApps(java.util.List<ListConnectorInformationResponseBodyPluginInfosApps> apps) {
            this.apps = apps;
            return this;
        }
        public java.util.List<ListConnectorInformationResponseBodyPluginInfosApps> getApps() {
            return this.apps;
        }

        public ListConnectorInformationResponseBodyPluginInfos setIconUrl(String iconUrl) {
            this.iconUrl = iconUrl;
            return this;
        }
        public String getIconUrl() {
            return this.iconUrl;
        }

        public ListConnectorInformationResponseBodyPluginInfos setPluginName(String pluginName) {
            this.pluginName = pluginName;
            return this;
        }
        public String getPluginName() {
            return this.pluginName;
        }

        public ListConnectorInformationResponseBodyPluginInfos setPluginPayType(Integer pluginPayType) {
            this.pluginPayType = pluginPayType;
            return this;
        }
        public Integer getPluginPayType() {
            return this.pluginPayType;
        }

        public ListConnectorInformationResponseBodyPluginInfos setPluginStatus(Integer pluginStatus) {
            this.pluginStatus = pluginStatus;
            return this;
        }
        public Integer getPluginStatus() {
            return this.pluginStatus;
        }

        public ListConnectorInformationResponseBodyPluginInfos setPluginTotalAmount(Long pluginTotalAmount) {
            this.pluginTotalAmount = pluginTotalAmount;
            return this;
        }
        public Long getPluginTotalAmount() {
            return this.pluginTotalAmount;
        }

        public ListConnectorInformationResponseBodyPluginInfos setPluginUsageAmount(Long pluginUsageAmount) {
            this.pluginUsageAmount = pluginUsageAmount;
            return this;
        }
        public Long getPluginUsageAmount() {
            return this.pluginUsageAmount;
        }

        public ListConnectorInformationResponseBodyPluginInfos setPluginUuid(String pluginUuid) {
            this.pluginUuid = pluginUuid;
            return this;
        }
        public String getPluginUuid() {
            return this.pluginUuid;
        }

    }

}
