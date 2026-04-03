// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListAiMinutesResponseBody extends TeaModel {
    @NameInMap("minutes")
    public java.util.List<ListAiMinutesResponseBodyMinutes> minutes;

    public static ListAiMinutesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListAiMinutesResponseBody self = new ListAiMinutesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListAiMinutesResponseBody setMinutes(java.util.List<ListAiMinutesResponseBodyMinutes> minutes) {
        this.minutes = minutes;
        return this;
    }
    public java.util.List<ListAiMinutesResponseBodyMinutes> getMinutes() {
        return this.minutes;
    }

    public static class ListAiMinutesResponseBodyMinutes extends TeaModel {
        @NameInMap("creatorUserId")
        public String creatorUserId;

        @NameInMap("minutesId")
        public String minutesId;

        public static ListAiMinutesResponseBodyMinutes build(java.util.Map<String, ?> map) throws Exception {
            ListAiMinutesResponseBodyMinutes self = new ListAiMinutesResponseBodyMinutes();
            return TeaModel.build(map, self);
        }

        public ListAiMinutesResponseBodyMinutes setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public ListAiMinutesResponseBodyMinutes setMinutesId(String minutesId) {
            this.minutesId = minutesId;
            return this;
        }
        public String getMinutesId() {
            return this.minutesId;
        }

    }

}
