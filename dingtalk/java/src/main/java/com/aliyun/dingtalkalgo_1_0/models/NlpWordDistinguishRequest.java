// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalgo_1_0.models;

import com.aliyun.tea.*;

public class NlpWordDistinguishRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("attachExtractDecisionInfo")
    public NlpWordDistinguishRequestAttachExtractDecisionInfo attachExtractDecisionInfo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("isvAppId")
    public String isvAppId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("text")
    public String text;

    public static NlpWordDistinguishRequest build(java.util.Map<String, ?> map) throws Exception {
        NlpWordDistinguishRequest self = new NlpWordDistinguishRequest();
        return TeaModel.build(map, self);
    }

    public NlpWordDistinguishRequest setAttachExtractDecisionInfo(NlpWordDistinguishRequestAttachExtractDecisionInfo attachExtractDecisionInfo) {
        this.attachExtractDecisionInfo = attachExtractDecisionInfo;
        return this;
    }
    public NlpWordDistinguishRequestAttachExtractDecisionInfo getAttachExtractDecisionInfo() {
        return this.attachExtractDecisionInfo;
    }

    public NlpWordDistinguishRequest setIsvAppId(String isvAppId) {
        this.isvAppId = isvAppId;
        return this;
    }
    public String getIsvAppId() {
        return this.isvAppId;
    }

    public NlpWordDistinguishRequest setText(String text) {
        this.text = text;
        return this;
    }
    public String getText() {
        return this.text;
    }

    public static class NlpWordDistinguishRequestAttachExtractDecisionInfo extends TeaModel {
        @NameInMap("blackWords")
        public java.util.List<String> blackWords;

        @NameInMap("candidateWords")
        public java.util.List<String> candidateWords;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("deptIds")
        public java.util.List<String> deptIds;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("userId")
        public String userId;

        public static NlpWordDistinguishRequestAttachExtractDecisionInfo build(java.util.Map<String, ?> map) throws Exception {
            NlpWordDistinguishRequestAttachExtractDecisionInfo self = new NlpWordDistinguishRequestAttachExtractDecisionInfo();
            return TeaModel.build(map, self);
        }

        public NlpWordDistinguishRequestAttachExtractDecisionInfo setBlackWords(java.util.List<String> blackWords) {
            this.blackWords = blackWords;
            return this;
        }
        public java.util.List<String> getBlackWords() {
            return this.blackWords;
        }

        public NlpWordDistinguishRequestAttachExtractDecisionInfo setCandidateWords(java.util.List<String> candidateWords) {
            this.candidateWords = candidateWords;
            return this;
        }
        public java.util.List<String> getCandidateWords() {
            return this.candidateWords;
        }

        public NlpWordDistinguishRequestAttachExtractDecisionInfo setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public NlpWordDistinguishRequestAttachExtractDecisionInfo setDeptIds(java.util.List<String> deptIds) {
            this.deptIds = deptIds;
            return this;
        }
        public java.util.List<String> getDeptIds() {
            return this.deptIds;
        }

        public NlpWordDistinguishRequestAttachExtractDecisionInfo setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
