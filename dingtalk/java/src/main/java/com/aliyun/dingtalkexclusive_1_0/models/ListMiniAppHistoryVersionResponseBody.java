// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListMiniAppHistoryVersionResponseBody extends TeaModel {
    /**
     * <p>result</p>
     */
    @NameInMap("list")
    public java.util.List<ListMiniAppHistoryVersionResponseBodyList> list;

    public static ListMiniAppHistoryVersionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListMiniAppHistoryVersionResponseBody self = new ListMiniAppHistoryVersionResponseBody();
        return TeaModel.build(map, self);
    }

    public ListMiniAppHistoryVersionResponseBody setList(java.util.List<ListMiniAppHistoryVersionResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<ListMiniAppHistoryVersionResponseBodyList> getList() {
        return this.list;
    }

    public static class ListMiniAppHistoryVersionResponseBodyList extends TeaModel {
        /**
         * <p>构建状态</p>
         */
        @NameInMap("buildStatus")
        public Long buildStatus;

        /**
         * <p>h5Bundle地址</p>
         */
        @NameInMap("h5Bundle")
        public String h5Bundle;

        /**
         * <p>包大小</p>
         */
        @NameInMap("packageSize")
        public String packageSize;

        /**
         * <p>包url</p>
         */
        @NameInMap("packageUrl")
        public String packageUrl;

        /**
         * <p>版本</p>
         */
        @NameInMap("version")
        public String version;

        public static ListMiniAppHistoryVersionResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            ListMiniAppHistoryVersionResponseBodyList self = new ListMiniAppHistoryVersionResponseBodyList();
            return TeaModel.build(map, self);
        }

        public ListMiniAppHistoryVersionResponseBodyList setBuildStatus(Long buildStatus) {
            this.buildStatus = buildStatus;
            return this;
        }
        public Long getBuildStatus() {
            return this.buildStatus;
        }

        public ListMiniAppHistoryVersionResponseBodyList setH5Bundle(String h5Bundle) {
            this.h5Bundle = h5Bundle;
            return this;
        }
        public String getH5Bundle() {
            return this.h5Bundle;
        }

        public ListMiniAppHistoryVersionResponseBodyList setPackageSize(String packageSize) {
            this.packageSize = packageSize;
            return this;
        }
        public String getPackageSize() {
            return this.packageSize;
        }

        public ListMiniAppHistoryVersionResponseBodyList setPackageUrl(String packageUrl) {
            this.packageUrl = packageUrl;
            return this;
        }
        public String getPackageUrl() {
            return this.packageUrl;
        }

        public ListMiniAppHistoryVersionResponseBodyList setVersion(String version) {
            this.version = version;
            return this;
        }
        public String getVersion() {
            return this.version;
        }

    }

}
