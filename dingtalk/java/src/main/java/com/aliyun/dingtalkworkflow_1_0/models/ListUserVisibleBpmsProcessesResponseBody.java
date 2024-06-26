// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ListUserVisibleBpmsProcessesResponseBody extends TeaModel {
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
        /**
         * <strong>example:</strong>
         * <p>12347899</p>
         */
        @NameInMap("dirId")
        public String dirId;

        /**
         * <strong>example:</strong>
         * <p>财务管理</p>
         */
        @NameInMap("dirName")
        public String dirName;

        /**
         * <strong>example:</strong>
         * <p><a href="https://gw.xxxx/T-102-102.png">https://gw.xxxx/T-102-102.png</a></p>
         */
        @NameInMap("iconUrl")
        public String iconUrl;

        /**
         * <strong>example:</strong>
         * <p>物品领用</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>PROC-YMLA1-xxxx-11WFJ-1</p>
         */
        @NameInMap("processCode")
        public String processCode;

        /**
         * <strong>example:</strong>
         * <p><a href="https://aflow.dingtalk.com/dingtalk/mobile/homepage.htm?xxxx">https://aflow.dingtalk.com/dingtalk/mobile/homepage.htm?xxxx</a></p>
         */
        @NameInMap("url")
        public String url;

        public static ListUserVisibleBpmsProcessesResponseBodyResultProcessList build(java.util.Map<String, ?> map) throws Exception {
            ListUserVisibleBpmsProcessesResponseBodyResultProcessList self = new ListUserVisibleBpmsProcessesResponseBodyResultProcessList();
            return TeaModel.build(map, self);
        }

        public ListUserVisibleBpmsProcessesResponseBodyResultProcessList setDirId(String dirId) {
            this.dirId = dirId;
            return this;
        }
        public String getDirId() {
            return this.dirId;
        }

        public ListUserVisibleBpmsProcessesResponseBodyResultProcessList setDirName(String dirName) {
            this.dirName = dirName;
            return this;
        }
        public String getDirName() {
            return this.dirName;
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
        /**
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("nextToken")
        public Long nextToken;

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
