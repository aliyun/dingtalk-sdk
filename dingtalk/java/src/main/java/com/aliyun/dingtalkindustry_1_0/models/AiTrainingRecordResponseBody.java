// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class AiTrainingRecordResponseBody extends TeaModel {
    @NameInMap("direction")
    public Integer direction;

    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("lastId")
    public Long lastId;

    @NameInMap("trainingList")
    public java.util.List<AiTrainingRecordResponseBodyTrainingList> trainingList;

    public static AiTrainingRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AiTrainingRecordResponseBody self = new AiTrainingRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public AiTrainingRecordResponseBody setDirection(Integer direction) {
        this.direction = direction;
        return this;
    }
    public Integer getDirection() {
        return this.direction;
    }

    public AiTrainingRecordResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public AiTrainingRecordResponseBody setLastId(Long lastId) {
        this.lastId = lastId;
        return this;
    }
    public Long getLastId() {
        return this.lastId;
    }

    public AiTrainingRecordResponseBody setTrainingList(java.util.List<AiTrainingRecordResponseBodyTrainingList> trainingList) {
        this.trainingList = trainingList;
        return this;
    }
    public java.util.List<AiTrainingRecordResponseBodyTrainingList> getTrainingList() {
        return this.trainingList;
    }

    public static class AiTrainingRecordResponseBodyTrainingList extends TeaModel {
        @NameInMap("aiJobStatus")
        public String aiJobStatus;

        @NameInMap("gmtCreate")
        public String gmtCreate;

        @NameInMap("id")
        public Long id;

        @NameInMap("productName")
        public String productName;

        @NameInMap("trainingRanking")
        public Integer trainingRanking;

        @NameInMap("trainingRankingPercent")
        public Integer trainingRankingPercent;

        @NameInMap("trainingScore")
        public Integer trainingScore;

        @NameInMap("userId")
        public String userId;

        @NameInMap("userName")
        public String userName;

        public static AiTrainingRecordResponseBodyTrainingList build(java.util.Map<String, ?> map) throws Exception {
            AiTrainingRecordResponseBodyTrainingList self = new AiTrainingRecordResponseBodyTrainingList();
            return TeaModel.build(map, self);
        }

        public AiTrainingRecordResponseBodyTrainingList setAiJobStatus(String aiJobStatus) {
            this.aiJobStatus = aiJobStatus;
            return this;
        }
        public String getAiJobStatus() {
            return this.aiJobStatus;
        }

        public AiTrainingRecordResponseBodyTrainingList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public AiTrainingRecordResponseBodyTrainingList setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public AiTrainingRecordResponseBodyTrainingList setProductName(String productName) {
            this.productName = productName;
            return this;
        }
        public String getProductName() {
            return this.productName;
        }

        public AiTrainingRecordResponseBodyTrainingList setTrainingRanking(Integer trainingRanking) {
            this.trainingRanking = trainingRanking;
            return this;
        }
        public Integer getTrainingRanking() {
            return this.trainingRanking;
        }

        public AiTrainingRecordResponseBodyTrainingList setTrainingRankingPercent(Integer trainingRankingPercent) {
            this.trainingRankingPercent = trainingRankingPercent;
            return this;
        }
        public Integer getTrainingRankingPercent() {
            return this.trainingRankingPercent;
        }

        public AiTrainingRecordResponseBodyTrainingList setTrainingScore(Integer trainingScore) {
            this.trainingScore = trainingScore;
            return this;
        }
        public Integer getTrainingScore() {
            return this.trainingScore;
        }

        public AiTrainingRecordResponseBodyTrainingList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public AiTrainingRecordResponseBodyTrainingList setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

}
