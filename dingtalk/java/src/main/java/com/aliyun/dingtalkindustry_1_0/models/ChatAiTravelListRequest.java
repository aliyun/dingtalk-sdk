// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatAiTravelListRequest extends TeaModel {
    @NameInMap("paramList")
    public java.util.List<ChatAiTravelListRequestParamList> paramList;

    /**
     * <strong>example:</strong>
     * <p>qaz12345900</p>
     */
    @NameInMap("travelId")
    public String travelId;

    public static ChatAiTravelListRequest build(java.util.Map<String, ?> map) throws Exception {
        ChatAiTravelListRequest self = new ChatAiTravelListRequest();
        return TeaModel.build(map, self);
    }

    public ChatAiTravelListRequest setParamList(java.util.List<ChatAiTravelListRequestParamList> paramList) {
        this.paramList = paramList;
        return this;
    }
    public java.util.List<ChatAiTravelListRequestParamList> getParamList() {
        return this.paramList;
    }

    public ChatAiTravelListRequest setTravelId(String travelId) {
        this.travelId = travelId;
        return this;
    }
    public String getTravelId() {
        return this.travelId;
    }

    public static class ChatAiTravelListRequestParamList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>qaz1234567</p>
         */
        @NameInMap("itineraryId")
        public String itineraryId;

        /**
         * <strong>example:</strong>
         * <p>{&quot;lineNumber&quot;:1}</p>
         */
        @NameInMap("value")
        public String value;

        public static ChatAiTravelListRequestParamList build(java.util.Map<String, ?> map) throws Exception {
            ChatAiTravelListRequestParamList self = new ChatAiTravelListRequestParamList();
            return TeaModel.build(map, self);
        }

        public ChatAiTravelListRequestParamList setItineraryId(String itineraryId) {
            this.itineraryId = itineraryId;
            return this;
        }
        public String getItineraryId() {
            return this.itineraryId;
        }

        public ChatAiTravelListRequestParamList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
