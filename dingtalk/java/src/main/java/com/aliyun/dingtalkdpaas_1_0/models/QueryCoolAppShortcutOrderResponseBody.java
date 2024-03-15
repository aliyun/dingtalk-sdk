// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdpaas_1_0.models;

import com.aliyun.tea.*;

public class QueryCoolAppShortcutOrderResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryCoolAppShortcutOrderResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryCoolAppShortcutOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCoolAppShortcutOrderResponseBody self = new QueryCoolAppShortcutOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCoolAppShortcutOrderResponseBody setResult(QueryCoolAppShortcutOrderResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryCoolAppShortcutOrderResponseBodyResult getResult() {
        return this.result;
    }

    public QueryCoolAppShortcutOrderResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryCoolAppShortcutOrderResponseBodyResultForbiddenPluginList extends TeaModel {
        @NameInMap("appCode")
        public String appCode;

        @NameInMap("desc")
        public String desc;

        @NameInMap("pluginId")
        public String pluginId;

        @NameInMap("source")
        public String source;

        @NameInMap("title")
        public String title;

        public static QueryCoolAppShortcutOrderResponseBodyResultForbiddenPluginList build(java.util.Map<String, ?> map) throws Exception {
            QueryCoolAppShortcutOrderResponseBodyResultForbiddenPluginList self = new QueryCoolAppShortcutOrderResponseBodyResultForbiddenPluginList();
            return TeaModel.build(map, self);
        }

        public QueryCoolAppShortcutOrderResponseBodyResultForbiddenPluginList setAppCode(String appCode) {
            this.appCode = appCode;
            return this;
        }
        public String getAppCode() {
            return this.appCode;
        }

        public QueryCoolAppShortcutOrderResponseBodyResultForbiddenPluginList setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public QueryCoolAppShortcutOrderResponseBodyResultForbiddenPluginList setPluginId(String pluginId) {
            this.pluginId = pluginId;
            return this;
        }
        public String getPluginId() {
            return this.pluginId;
        }

        public QueryCoolAppShortcutOrderResponseBodyResultForbiddenPluginList setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

        public QueryCoolAppShortcutOrderResponseBodyResultForbiddenPluginList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class QueryCoolAppShortcutOrderResponseBodyResultMyPluginList extends TeaModel {
        @NameInMap("appCode")
        public String appCode;

        @NameInMap("desc")
        public String desc;

        @NameInMap("pluginId")
        public String pluginId;

        @NameInMap("source")
        public String source;

        @NameInMap("title")
        public String title;

        public static QueryCoolAppShortcutOrderResponseBodyResultMyPluginList build(java.util.Map<String, ?> map) throws Exception {
            QueryCoolAppShortcutOrderResponseBodyResultMyPluginList self = new QueryCoolAppShortcutOrderResponseBodyResultMyPluginList();
            return TeaModel.build(map, self);
        }

        public QueryCoolAppShortcutOrderResponseBodyResultMyPluginList setAppCode(String appCode) {
            this.appCode = appCode;
            return this;
        }
        public String getAppCode() {
            return this.appCode;
        }

        public QueryCoolAppShortcutOrderResponseBodyResultMyPluginList setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public QueryCoolAppShortcutOrderResponseBodyResultMyPluginList setPluginId(String pluginId) {
            this.pluginId = pluginId;
            return this;
        }
        public String getPluginId() {
            return this.pluginId;
        }

        public QueryCoolAppShortcutOrderResponseBodyResultMyPluginList setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

        public QueryCoolAppShortcutOrderResponseBodyResultMyPluginList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class QueryCoolAppShortcutOrderResponseBodyResultOtherPluginList extends TeaModel {
        @NameInMap("appCode")
        public String appCode;

        @NameInMap("desc")
        public String desc;

        @NameInMap("pluginId")
        public String pluginId;

        @NameInMap("source")
        public String source;

        @NameInMap("title")
        public String title;

        public static QueryCoolAppShortcutOrderResponseBodyResultOtherPluginList build(java.util.Map<String, ?> map) throws Exception {
            QueryCoolAppShortcutOrderResponseBodyResultOtherPluginList self = new QueryCoolAppShortcutOrderResponseBodyResultOtherPluginList();
            return TeaModel.build(map, self);
        }

        public QueryCoolAppShortcutOrderResponseBodyResultOtherPluginList setAppCode(String appCode) {
            this.appCode = appCode;
            return this;
        }
        public String getAppCode() {
            return this.appCode;
        }

        public QueryCoolAppShortcutOrderResponseBodyResultOtherPluginList setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public QueryCoolAppShortcutOrderResponseBodyResultOtherPluginList setPluginId(String pluginId) {
            this.pluginId = pluginId;
            return this;
        }
        public String getPluginId() {
            return this.pluginId;
        }

        public QueryCoolAppShortcutOrderResponseBodyResultOtherPluginList setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

        public QueryCoolAppShortcutOrderResponseBodyResultOtherPluginList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class QueryCoolAppShortcutOrderResponseBodyResult extends TeaModel {
        @NameInMap("forbiddenPluginList")
        public java.util.List<QueryCoolAppShortcutOrderResponseBodyResultForbiddenPluginList> forbiddenPluginList;

        @NameInMap("myPluginList")
        public java.util.List<QueryCoolAppShortcutOrderResponseBodyResultMyPluginList> myPluginList;

        @NameInMap("otherPluginList")
        public java.util.List<QueryCoolAppShortcutOrderResponseBodyResultOtherPluginList> otherPluginList;

        public static QueryCoolAppShortcutOrderResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryCoolAppShortcutOrderResponseBodyResult self = new QueryCoolAppShortcutOrderResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryCoolAppShortcutOrderResponseBodyResult setForbiddenPluginList(java.util.List<QueryCoolAppShortcutOrderResponseBodyResultForbiddenPluginList> forbiddenPluginList) {
            this.forbiddenPluginList = forbiddenPluginList;
            return this;
        }
        public java.util.List<QueryCoolAppShortcutOrderResponseBodyResultForbiddenPluginList> getForbiddenPluginList() {
            return this.forbiddenPluginList;
        }

        public QueryCoolAppShortcutOrderResponseBodyResult setMyPluginList(java.util.List<QueryCoolAppShortcutOrderResponseBodyResultMyPluginList> myPluginList) {
            this.myPluginList = myPluginList;
            return this;
        }
        public java.util.List<QueryCoolAppShortcutOrderResponseBodyResultMyPluginList> getMyPluginList() {
            return this.myPluginList;
        }

        public QueryCoolAppShortcutOrderResponseBodyResult setOtherPluginList(java.util.List<QueryCoolAppShortcutOrderResponseBodyResultOtherPluginList> otherPluginList) {
            this.otherPluginList = otherPluginList;
            return this;
        }
        public java.util.List<QueryCoolAppShortcutOrderResponseBodyResultOtherPluginList> getOtherPluginList() {
            return this.otherPluginList;
        }

    }

}
