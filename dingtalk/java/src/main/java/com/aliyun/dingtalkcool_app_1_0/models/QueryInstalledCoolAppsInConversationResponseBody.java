// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcool_app_1_0.models;

import com.aliyun.tea.*;

public class QueryInstalledCoolAppsInConversationResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryInstalledCoolAppsInConversationResponseBodyResult result;

    public static QueryInstalledCoolAppsInConversationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryInstalledCoolAppsInConversationResponseBody self = new QueryInstalledCoolAppsInConversationResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryInstalledCoolAppsInConversationResponseBody setResult(QueryInstalledCoolAppsInConversationResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryInstalledCoolAppsInConversationResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryInstalledCoolAppsInConversationResponseBodyResultCoolApps extends TeaModel {
        @NameInMap("coolAppCode")
        public String coolAppCode;

        @NameInMap("coolAppName")
        public String coolAppName;

        public static QueryInstalledCoolAppsInConversationResponseBodyResultCoolApps build(java.util.Map<String, ?> map) throws Exception {
            QueryInstalledCoolAppsInConversationResponseBodyResultCoolApps self = new QueryInstalledCoolAppsInConversationResponseBodyResultCoolApps();
            return TeaModel.build(map, self);
        }

        public QueryInstalledCoolAppsInConversationResponseBodyResultCoolApps setCoolAppCode(String coolAppCode) {
            this.coolAppCode = coolAppCode;
            return this;
        }
        public String getCoolAppCode() {
            return this.coolAppCode;
        }

        public QueryInstalledCoolAppsInConversationResponseBodyResultCoolApps setCoolAppName(String coolAppName) {
            this.coolAppName = coolAppName;
            return this;
        }
        public String getCoolAppName() {
            return this.coolAppName;
        }

    }

    public static class QueryInstalledCoolAppsInConversationResponseBodyResult extends TeaModel {
        @NameInMap("coolApps")
        public java.util.List<QueryInstalledCoolAppsInConversationResponseBodyResultCoolApps> coolApps;

        public static QueryInstalledCoolAppsInConversationResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryInstalledCoolAppsInConversationResponseBodyResult self = new QueryInstalledCoolAppsInConversationResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryInstalledCoolAppsInConversationResponseBodyResult setCoolApps(java.util.List<QueryInstalledCoolAppsInConversationResponseBodyResultCoolApps> coolApps) {
            this.coolApps = coolApps;
            return this;
        }
        public java.util.List<QueryInstalledCoolAppsInConversationResponseBodyResultCoolApps> getCoolApps() {
            return this.coolApps;
        }

    }

}
