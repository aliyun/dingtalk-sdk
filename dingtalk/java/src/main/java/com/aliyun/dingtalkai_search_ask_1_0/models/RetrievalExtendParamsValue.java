// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_search_ask_1_0.models;

import com.aliyun.tea.*;

public class RetrievalExtendParamsValue extends TeaModel {
    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("keywords")
    public java.util.List<String> keywords;

    @NameInMap("sourceUserParams")
    public java.util.List<RetrievalExtendParamsValueSourceUserParams> sourceUserParams;

    @NameInMap("targetUserParams")
    public java.util.List<RetrievalExtendParamsValueTargetUserParams> targetUserParams;

    public static RetrievalExtendParamsValue build(java.util.Map<String, ?> map) throws Exception {
        RetrievalExtendParamsValue self = new RetrievalExtendParamsValue();
        return TeaModel.build(map, self);
    }

    public RetrievalExtendParamsValue setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public RetrievalExtendParamsValue setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public RetrievalExtendParamsValue setKeywords(java.util.List<String> keywords) {
        this.keywords = keywords;
        return this;
    }
    public java.util.List<String> getKeywords() {
        return this.keywords;
    }

    public RetrievalExtendParamsValue setSourceUserParams(java.util.List<RetrievalExtendParamsValueSourceUserParams> sourceUserParams) {
        this.sourceUserParams = sourceUserParams;
        return this;
    }
    public java.util.List<RetrievalExtendParamsValueSourceUserParams> getSourceUserParams() {
        return this.sourceUserParams;
    }

    public RetrievalExtendParamsValue setTargetUserParams(java.util.List<RetrievalExtendParamsValueTargetUserParams> targetUserParams) {
        this.targetUserParams = targetUserParams;
        return this;
    }
    public java.util.List<RetrievalExtendParamsValueTargetUserParams> getTargetUserParams() {
        return this.targetUserParams;
    }

    public static class RetrievalExtendParamsValueSourceUserParams extends TeaModel {
        @NameInMap("nick")
        public String nick;

        @NameInMap("staffId")
        public String staffId;

        public static RetrievalExtendParamsValueSourceUserParams build(java.util.Map<String, ?> map) throws Exception {
            RetrievalExtendParamsValueSourceUserParams self = new RetrievalExtendParamsValueSourceUserParams();
            return TeaModel.build(map, self);
        }

        public RetrievalExtendParamsValueSourceUserParams setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public RetrievalExtendParamsValueSourceUserParams setStaffId(String staffId) {
            this.staffId = staffId;
            return this;
        }
        public String getStaffId() {
            return this.staffId;
        }

    }

    public static class RetrievalExtendParamsValueTargetUserParams extends TeaModel {
        @NameInMap("nick")
        public String nick;

        @NameInMap("staffId")
        public String staffId;

        public static RetrievalExtendParamsValueTargetUserParams build(java.util.Map<String, ?> map) throws Exception {
            RetrievalExtendParamsValueTargetUserParams self = new RetrievalExtendParamsValueTargetUserParams();
            return TeaModel.build(map, self);
        }

        public RetrievalExtendParamsValueTargetUserParams setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public RetrievalExtendParamsValueTargetUserParams setStaffId(String staffId) {
            this.staffId = staffId;
            return this;
        }
        public String getStaffId() {
            return this.staffId;
        }

    }

}
