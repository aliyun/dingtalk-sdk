// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class QueryLiveInteractionPluginResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryLiveInteractionPluginResponseBodyResult result;

    public static QueryLiveInteractionPluginResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryLiveInteractionPluginResponseBody self = new QueryLiveInteractionPluginResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryLiveInteractionPluginResponseBody setResult(QueryLiveInteractionPluginResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryLiveInteractionPluginResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryLiveInteractionPluginResponseBodyResultLivePluginList extends TeaModel {
        @NameInMap("anchorJumpUrl")
        public String anchorJumpUrl;

        @NameInMap("pluginIconUrl")
        public String pluginIconUrl;

        @NameInMap("pluginId")
        public String pluginId;

        @NameInMap("pluginName")
        public String pluginName;

        @NameInMap("pluginNameEn")
        public String pluginNameEn;

        @NameInMap("viewerJumpUrl")
        public String viewerJumpUrl;

        public static QueryLiveInteractionPluginResponseBodyResultLivePluginList build(java.util.Map<String, ?> map) throws Exception {
            QueryLiveInteractionPluginResponseBodyResultLivePluginList self = new QueryLiveInteractionPluginResponseBodyResultLivePluginList();
            return TeaModel.build(map, self);
        }

        public QueryLiveInteractionPluginResponseBodyResultLivePluginList setAnchorJumpUrl(String anchorJumpUrl) {
            this.anchorJumpUrl = anchorJumpUrl;
            return this;
        }
        public String getAnchorJumpUrl() {
            return this.anchorJumpUrl;
        }

        public QueryLiveInteractionPluginResponseBodyResultLivePluginList setPluginIconUrl(String pluginIconUrl) {
            this.pluginIconUrl = pluginIconUrl;
            return this;
        }
        public String getPluginIconUrl() {
            return this.pluginIconUrl;
        }

        public QueryLiveInteractionPluginResponseBodyResultLivePluginList setPluginId(String pluginId) {
            this.pluginId = pluginId;
            return this;
        }
        public String getPluginId() {
            return this.pluginId;
        }

        public QueryLiveInteractionPluginResponseBodyResultLivePluginList setPluginName(String pluginName) {
            this.pluginName = pluginName;
            return this;
        }
        public String getPluginName() {
            return this.pluginName;
        }

        public QueryLiveInteractionPluginResponseBodyResultLivePluginList setPluginNameEn(String pluginNameEn) {
            this.pluginNameEn = pluginNameEn;
            return this;
        }
        public String getPluginNameEn() {
            return this.pluginNameEn;
        }

        public QueryLiveInteractionPluginResponseBodyResultLivePluginList setViewerJumpUrl(String viewerJumpUrl) {
            this.viewerJumpUrl = viewerJumpUrl;
            return this;
        }
        public String getViewerJumpUrl() {
            return this.viewerJumpUrl;
        }

    }

    public static class QueryLiveInteractionPluginResponseBodyResult extends TeaModel {
        @NameInMap("livePluginList")
        public java.util.List<QueryLiveInteractionPluginResponseBodyResultLivePluginList> livePluginList;

        public static QueryLiveInteractionPluginResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryLiveInteractionPluginResponseBodyResult self = new QueryLiveInteractionPluginResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryLiveInteractionPluginResponseBodyResult setLivePluginList(java.util.List<QueryLiveInteractionPluginResponseBodyResultLivePluginList> livePluginList) {
            this.livePluginList = livePluginList;
            return this;
        }
        public java.util.List<QueryLiveInteractionPluginResponseBodyResultLivePluginList> getLivePluginList() {
            return this.livePluginList;
        }

    }

}
