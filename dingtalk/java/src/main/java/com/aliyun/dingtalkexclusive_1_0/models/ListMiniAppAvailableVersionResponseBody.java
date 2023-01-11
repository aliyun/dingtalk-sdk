// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListMiniAppAvailableVersionResponseBody extends TeaModel {
    /**
     * <p>result</p>
     */
    @NameInMap("list")
    public java.util.List<ListMiniAppAvailableVersionResponseBodyList> list;

    public static ListMiniAppAvailableVersionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListMiniAppAvailableVersionResponseBody self = new ListMiniAppAvailableVersionResponseBody();
        return TeaModel.build(map, self);
    }

    public ListMiniAppAvailableVersionResponseBody setList(java.util.List<ListMiniAppAvailableVersionResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<ListMiniAppAvailableVersionResponseBodyList> getList() {
        return this.list;
    }

    public static class ListMiniAppAvailableVersionResponseBodyList extends TeaModel {
        /**
         * <p>打包状态，0-打包中，1-成功，2-失败</p>
         */
        @NameInMap("buildStatus")
        public Long buildStatus;

        /**
         * <p>版本</p>
         */
        @NameInMap("version")
        public String version;

        public static ListMiniAppAvailableVersionResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            ListMiniAppAvailableVersionResponseBodyList self = new ListMiniAppAvailableVersionResponseBodyList();
            return TeaModel.build(map, self);
        }

        public ListMiniAppAvailableVersionResponseBodyList setBuildStatus(Long buildStatus) {
            this.buildStatus = buildStatus;
            return this;
        }
        public Long getBuildStatus() {
            return this.buildStatus;
        }

        public ListMiniAppAvailableVersionResponseBodyList setVersion(String version) {
            this.version = version;
            return this;
        }
        public String getVersion() {
            return this.version;
        }

    }

}
