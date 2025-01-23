// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class GetAssistantActionInfoResponseBody extends TeaModel {
    @NameInMap("actionList")
    public java.util.List<GetAssistantActionInfoResponseBodyActionList> actionList;

    @NameInMap("assistantId")
    public String assistantId;

    @NameInMap("corpId")
    public String corpId;

    public static GetAssistantActionInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAssistantActionInfoResponseBody self = new GetAssistantActionInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAssistantActionInfoResponseBody setActionList(java.util.List<GetAssistantActionInfoResponseBodyActionList> actionList) {
        this.actionList = actionList;
        return this;
    }
    public java.util.List<GetAssistantActionInfoResponseBodyActionList> getActionList() {
        return this.actionList;
    }

    public GetAssistantActionInfoResponseBody setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

    public GetAssistantActionInfoResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public static class GetAssistantActionInfoResponseBodyActionList extends TeaModel {
        @NameInMap("actionId")
        public String actionId;

        @NameInMap("actionVersion")
        public String actionVersion;

        public static GetAssistantActionInfoResponseBodyActionList build(java.util.Map<String, ?> map) throws Exception {
            GetAssistantActionInfoResponseBodyActionList self = new GetAssistantActionInfoResponseBodyActionList();
            return TeaModel.build(map, self);
        }

        public GetAssistantActionInfoResponseBodyActionList setActionId(String actionId) {
            this.actionId = actionId;
            return this;
        }
        public String getActionId() {
            return this.actionId;
        }

        public GetAssistantActionInfoResponseBodyActionList setActionVersion(String actionVersion) {
            this.actionVersion = actionVersion;
            return this;
        }
        public String getActionVersion() {
            return this.actionVersion;
        }

    }

}
