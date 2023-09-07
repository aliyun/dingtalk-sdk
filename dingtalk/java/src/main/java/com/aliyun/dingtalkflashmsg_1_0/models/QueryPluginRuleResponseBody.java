// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class QueryPluginRuleResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryPluginRuleResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryPluginRuleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryPluginRuleResponseBody self = new QueryPluginRuleResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryPluginRuleResponseBody setResult(QueryPluginRuleResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryPluginRuleResponseBodyResult getResult() {
        return this.result;
    }

    public QueryPluginRuleResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryPluginRuleResponseBodyResultData extends TeaModel {
        @NameInMap("bizId")
        public String bizId;

        @NameInMap("chatType")
        public String chatType;

        @NameInMap("code")
        public String code;

        @NameInMap("gmtCreate")
        public String gmtCreate;

        @NameInMap("itemId")
        public String itemId;

        @NameInMap("itemName")
        public String itemName;

        @NameInMap("itemType")
        public String itemType;

        public static QueryPluginRuleResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            QueryPluginRuleResponseBodyResultData self = new QueryPluginRuleResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public QueryPluginRuleResponseBodyResultData setBizId(String bizId) {
            this.bizId = bizId;
            return this;
        }
        public String getBizId() {
            return this.bizId;
        }

        public QueryPluginRuleResponseBodyResultData setChatType(String chatType) {
            this.chatType = chatType;
            return this;
        }
        public String getChatType() {
            return this.chatType;
        }

        public QueryPluginRuleResponseBodyResultData setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryPluginRuleResponseBodyResultData setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public QueryPluginRuleResponseBodyResultData setItemId(String itemId) {
            this.itemId = itemId;
            return this;
        }
        public String getItemId() {
            return this.itemId;
        }

        public QueryPluginRuleResponseBodyResultData setItemName(String itemName) {
            this.itemName = itemName;
            return this;
        }
        public String getItemName() {
            return this.itemName;
        }

        public QueryPluginRuleResponseBodyResultData setItemType(String itemType) {
            this.itemType = itemType;
            return this;
        }
        public String getItemType() {
            return this.itemType;
        }

    }

    public static class QueryPluginRuleResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public java.util.List<QueryPluginRuleResponseBodyResultData> data;

        @NameInMap("total")
        public Long total;

        public static QueryPluginRuleResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryPluginRuleResponseBodyResult self = new QueryPluginRuleResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryPluginRuleResponseBodyResult setData(java.util.List<QueryPluginRuleResponseBodyResultData> data) {
            this.data = data;
            return this;
        }
        public java.util.List<QueryPluginRuleResponseBodyResultData> getData() {
            return this.data;
        }

        public QueryPluginRuleResponseBodyResult setTotal(Long total) {
            this.total = total;
            return this;
        }
        public Long getTotal() {
            return this.total;
        }

    }

}
