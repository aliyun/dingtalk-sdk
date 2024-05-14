// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalgo_1_0.models;

import com.aliyun.tea.*;

public class OkrOpenRecommendRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("candidateOkrItems")
    public java.util.List<OkrOpenRecommendRequestCandidateOkrItems> candidateOkrItems;

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
    @NameInMap("isvAppId")
    public String isvAppId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    @NameInMap("words")
    public java.util.List<String> words;

    public static OkrOpenRecommendRequest build(java.util.Map<String, ?> map) throws Exception {
        OkrOpenRecommendRequest self = new OkrOpenRecommendRequest();
        return TeaModel.build(map, self);
    }

    public OkrOpenRecommendRequest setCandidateOkrItems(java.util.List<OkrOpenRecommendRequestCandidateOkrItems> candidateOkrItems) {
        this.candidateOkrItems = candidateOkrItems;
        return this;
    }
    public java.util.List<OkrOpenRecommendRequestCandidateOkrItems> getCandidateOkrItems() {
        return this.candidateOkrItems;
    }

    public OkrOpenRecommendRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public OkrOpenRecommendRequest setDeptIds(java.util.List<String> deptIds) {
        this.deptIds = deptIds;
        return this;
    }
    public java.util.List<String> getDeptIds() {
        return this.deptIds;
    }

    public OkrOpenRecommendRequest setIsvAppId(String isvAppId) {
        this.isvAppId = isvAppId;
        return this;
    }
    public String getIsvAppId() {
        return this.isvAppId;
    }

    public OkrOpenRecommendRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public OkrOpenRecommendRequest setWords(java.util.List<String> words) {
        this.words = words;
        return this;
    }
    public java.util.List<String> getWords() {
        return this.words;
    }

    public static class OkrOpenRecommendRequestCandidateOkrItemsOkrInfosKeyResultInfos extends TeaModel {
        @NameInMap("kr")
        public String kr;

        @NameInMap("krId")
        public String krId;

        @NameInMap("words")
        public java.util.List<String> words;

        public static OkrOpenRecommendRequestCandidateOkrItemsOkrInfosKeyResultInfos build(java.util.Map<String, ?> map) throws Exception {
            OkrOpenRecommendRequestCandidateOkrItemsOkrInfosKeyResultInfos self = new OkrOpenRecommendRequestCandidateOkrItemsOkrInfosKeyResultInfos();
            return TeaModel.build(map, self);
        }

        public OkrOpenRecommendRequestCandidateOkrItemsOkrInfosKeyResultInfos setKr(String kr) {
            this.kr = kr;
            return this;
        }
        public String getKr() {
            return this.kr;
        }

        public OkrOpenRecommendRequestCandidateOkrItemsOkrInfosKeyResultInfos setKrId(String krId) {
            this.krId = krId;
            return this;
        }
        public String getKrId() {
            return this.krId;
        }

        public OkrOpenRecommendRequestCandidateOkrItemsOkrInfosKeyResultInfos setWords(java.util.List<String> words) {
            this.words = words;
            return this;
        }
        public java.util.List<String> getWords() {
            return this.words;
        }

    }

    public static class OkrOpenRecommendRequestCandidateOkrItemsOkrInfos extends TeaModel {
        @NameInMap("keyResultInfos")
        public java.util.List<OkrOpenRecommendRequestCandidateOkrItemsOkrInfosKeyResultInfos> keyResultInfos;

        @NameInMap("objective")
        public String objective;

        @NameInMap("objectiveId")
        public String objectiveId;

        @NameInMap("words")
        public java.util.List<String> words;

        public static OkrOpenRecommendRequestCandidateOkrItemsOkrInfos build(java.util.Map<String, ?> map) throws Exception {
            OkrOpenRecommendRequestCandidateOkrItemsOkrInfos self = new OkrOpenRecommendRequestCandidateOkrItemsOkrInfos();
            return TeaModel.build(map, self);
        }

        public OkrOpenRecommendRequestCandidateOkrItemsOkrInfos setKeyResultInfos(java.util.List<OkrOpenRecommendRequestCandidateOkrItemsOkrInfosKeyResultInfos> keyResultInfos) {
            this.keyResultInfos = keyResultInfos;
            return this;
        }
        public java.util.List<OkrOpenRecommendRequestCandidateOkrItemsOkrInfosKeyResultInfos> getKeyResultInfos() {
            return this.keyResultInfos;
        }

        public OkrOpenRecommendRequestCandidateOkrItemsOkrInfos setObjective(String objective) {
            this.objective = objective;
            return this;
        }
        public String getObjective() {
            return this.objective;
        }

        public OkrOpenRecommendRequestCandidateOkrItemsOkrInfos setObjectiveId(String objectiveId) {
            this.objectiveId = objectiveId;
            return this;
        }
        public String getObjectiveId() {
            return this.objectiveId;
        }

        public OkrOpenRecommendRequestCandidateOkrItemsOkrInfos setWords(java.util.List<String> words) {
            this.words = words;
            return this;
        }
        public java.util.List<String> getWords() {
            return this.words;
        }

    }

    public static class OkrOpenRecommendRequestCandidateOkrItems extends TeaModel {
        @NameInMap("okrInfos")
        public java.util.List<OkrOpenRecommendRequestCandidateOkrItemsOkrInfos> okrInfos;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("relation")
        public String relation;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("userId")
        public String userId;

        public static OkrOpenRecommendRequestCandidateOkrItems build(java.util.Map<String, ?> map) throws Exception {
            OkrOpenRecommendRequestCandidateOkrItems self = new OkrOpenRecommendRequestCandidateOkrItems();
            return TeaModel.build(map, self);
        }

        public OkrOpenRecommendRequestCandidateOkrItems setOkrInfos(java.util.List<OkrOpenRecommendRequestCandidateOkrItemsOkrInfos> okrInfos) {
            this.okrInfos = okrInfos;
            return this;
        }
        public java.util.List<OkrOpenRecommendRequestCandidateOkrItemsOkrInfos> getOkrInfos() {
            return this.okrInfos;
        }

        public OkrOpenRecommendRequestCandidateOkrItems setRelation(String relation) {
            this.relation = relation;
            return this;
        }
        public String getRelation() {
            return this.relation;
        }

        public OkrOpenRecommendRequestCandidateOkrItems setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
