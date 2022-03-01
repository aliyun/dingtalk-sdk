// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalgo_1_0.models;

import com.aliyun.tea.*;

public class OkrOpenRecommendResponseBody extends TeaModel {
    // okrRecommendItems
    @NameInMap("okrRecommendItems")
    public java.util.List<OkrOpenRecommendResponseBodyOkrRecommendItems> okrRecommendItems;

    // requestId
    @NameInMap("requestId")
    public String requestId;

    public static OkrOpenRecommendResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OkrOpenRecommendResponseBody self = new OkrOpenRecommendResponseBody();
        return TeaModel.build(map, self);
    }

    public OkrOpenRecommendResponseBody setOkrRecommendItems(java.util.List<OkrOpenRecommendResponseBodyOkrRecommendItems> okrRecommendItems) {
        this.okrRecommendItems = okrRecommendItems;
        return this;
    }
    public java.util.List<OkrOpenRecommendResponseBodyOkrRecommendItems> getOkrRecommendItems() {
        return this.okrRecommendItems;
    }

    public OkrOpenRecommendResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public static class OkrOpenRecommendResponseBodyOkrRecommendItemsKrResultRelatedResults extends TeaModel {
        // krId
        @NameInMap("krId")
        public String krId;

        // words
        @NameInMap("words")
        public java.util.List<String> words;

        public static OkrOpenRecommendResponseBodyOkrRecommendItemsKrResultRelatedResults build(java.util.Map<String, ?> map) throws Exception {
            OkrOpenRecommendResponseBodyOkrRecommendItemsKrResultRelatedResults self = new OkrOpenRecommendResponseBodyOkrRecommendItemsKrResultRelatedResults();
            return TeaModel.build(map, self);
        }

        public OkrOpenRecommendResponseBodyOkrRecommendItemsKrResultRelatedResults setKrId(String krId) {
            this.krId = krId;
            return this;
        }
        public String getKrId() {
            return this.krId;
        }

        public OkrOpenRecommendResponseBodyOkrRecommendItemsKrResultRelatedResults setWords(java.util.List<String> words) {
            this.words = words;
            return this;
        }
        public java.util.List<String> getWords() {
            return this.words;
        }

    }

    public static class OkrOpenRecommendResponseBodyOkrRecommendItemsObjectiveRelatedResults extends TeaModel {
        // objectiveId
        @NameInMap("objectiveId")
        public String objectiveId;

        // words
        @NameInMap("words")
        public java.util.List<String> words;

        public static OkrOpenRecommendResponseBodyOkrRecommendItemsObjectiveRelatedResults build(java.util.Map<String, ?> map) throws Exception {
            OkrOpenRecommendResponseBodyOkrRecommendItemsObjectiveRelatedResults self = new OkrOpenRecommendResponseBodyOkrRecommendItemsObjectiveRelatedResults();
            return TeaModel.build(map, self);
        }

        public OkrOpenRecommendResponseBodyOkrRecommendItemsObjectiveRelatedResults setObjectiveId(String objectiveId) {
            this.objectiveId = objectiveId;
            return this;
        }
        public String getObjectiveId() {
            return this.objectiveId;
        }

        public OkrOpenRecommendResponseBodyOkrRecommendItemsObjectiveRelatedResults setWords(java.util.List<String> words) {
            this.words = words;
            return this;
        }
        public java.util.List<String> getWords() {
            return this.words;
        }

    }

    public static class OkrOpenRecommendResponseBodyOkrRecommendItems extends TeaModel {
        // krResultRelatedResults
        @NameInMap("krResultRelatedResults")
        public java.util.List<OkrOpenRecommendResponseBodyOkrRecommendItemsKrResultRelatedResults> krResultRelatedResults;

        // objectiveRelatedResults
        @NameInMap("objectiveRelatedResults")
        public java.util.List<OkrOpenRecommendResponseBodyOkrRecommendItemsObjectiveRelatedResults> objectiveRelatedResults;

        // relatedLevel
        @NameInMap("relatedLevel")
        public Long relatedLevel;

        // userId
        @NameInMap("userId")
        public String userId;

        public static OkrOpenRecommendResponseBodyOkrRecommendItems build(java.util.Map<String, ?> map) throws Exception {
            OkrOpenRecommendResponseBodyOkrRecommendItems self = new OkrOpenRecommendResponseBodyOkrRecommendItems();
            return TeaModel.build(map, self);
        }

        public OkrOpenRecommendResponseBodyOkrRecommendItems setKrResultRelatedResults(java.util.List<OkrOpenRecommendResponseBodyOkrRecommendItemsKrResultRelatedResults> krResultRelatedResults) {
            this.krResultRelatedResults = krResultRelatedResults;
            return this;
        }
        public java.util.List<OkrOpenRecommendResponseBodyOkrRecommendItemsKrResultRelatedResults> getKrResultRelatedResults() {
            return this.krResultRelatedResults;
        }

        public OkrOpenRecommendResponseBodyOkrRecommendItems setObjectiveRelatedResults(java.util.List<OkrOpenRecommendResponseBodyOkrRecommendItemsObjectiveRelatedResults> objectiveRelatedResults) {
            this.objectiveRelatedResults = objectiveRelatedResults;
            return this;
        }
        public java.util.List<OkrOpenRecommendResponseBodyOkrRecommendItemsObjectiveRelatedResults> getObjectiveRelatedResults() {
            return this.objectiveRelatedResults;
        }

        public OkrOpenRecommendResponseBodyOkrRecommendItems setRelatedLevel(Long relatedLevel) {
            this.relatedLevel = relatedLevel;
            return this;
        }
        public Long getRelatedLevel() {
            return this.relatedLevel;
        }

        public OkrOpenRecommendResponseBodyOkrRecommendItems setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
