// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ListUserVisibleBpmsProcessesResponseBody extends TeaModel {
    // 返回结果。
    @NameInMap("result")
    public ListUserVisibleBpmsProcessesResponseBodyResult result;

    public static ListUserVisibleBpmsProcessesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListUserVisibleBpmsProcessesResponseBody self = new ListUserVisibleBpmsProcessesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListUserVisibleBpmsProcessesResponseBody setResult(ListUserVisibleBpmsProcessesResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ListUserVisibleBpmsProcessesResponseBodyResult getResult() {
        return this.result;
    }

    public static class ListUserVisibleBpmsProcessesResponseBodyResultProcessList extends TeaModel {
        // 图标URL。
        @NameInMap("iconUrl")
        public String iconUrl;

        // 表单名称。
        @NameInMap("name")
        public String name;

        // 表单唯一标识。
        @NameInMap("processCode")
        public String processCode;

        // 表单URL。
        @NameInMap("url")
        public String url;

        public static ListUserVisibleBpmsProcessesResponseBodyResultProcessList build(java.util.Map<String, ?> map) throws Exception {
            ListUserVisibleBpmsProcessesResponseBodyResultProcessList self = new ListUserVisibleBpmsProcessesResponseBodyResultProcessList();
            return TeaModel.build(map, self);
        }

        public ListUserVisibleBpmsProcessesResponseBodyResultProcessList setIconUrl(String iconUrl) {
            this.iconUrl = iconUrl;
            return this;
        }
        public String getIconUrl() {
            return this.iconUrl;
        }

        public ListUserVisibleBpmsProcessesResponseBodyResultProcessList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListUserVisibleBpmsProcessesResponseBodyResultProcessList setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public ListUserVisibleBpmsProcessesResponseBodyResultProcessList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class ListUserVisibleBpmsProcessesResponseBodyResult extends TeaModel {
        // 下一次分页调用的值，当返回结果里没有nextToken时，表示分页结束。
        @NameInMap("nextToken")
        public Long nextToken;

        // 可见表单列表。
        @NameInMap("processList")
        public java.util.List<ListUserVisibleBpmsProcessesResponseBodyResultProcessList> processList;

        public static ListUserVisibleBpmsProcessesResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListUserVisibleBpmsProcessesResponseBodyResult self = new ListUserVisibleBpmsProcessesResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListUserVisibleBpmsProcessesResponseBodyResult setNextToken(Long nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public Long getNextToken() {
            return this.nextToken;
        }

        public ListUserVisibleBpmsProcessesResponseBodyResult setProcessList(java.util.List<ListUserVisibleBpmsProcessesResponseBodyResultProcessList> processList) {
            this.processList = processList;
            return this;
        }
        public java.util.List<ListUserVisibleBpmsProcessesResponseBodyResultProcessList> getProcessList() {
            return this.processList;
        }

    }

}
