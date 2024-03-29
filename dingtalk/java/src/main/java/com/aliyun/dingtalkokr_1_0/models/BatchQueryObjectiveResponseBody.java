// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryObjectiveResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<BatchQueryObjectiveResponseBodyData> data;

    @NameInMap("success")
    public Boolean success;

    public static BatchQueryObjectiveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryObjectiveResponseBody self = new BatchQueryObjectiveResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchQueryObjectiveResponseBody setData(java.util.List<BatchQueryObjectiveResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<BatchQueryObjectiveResponseBodyData> getData() {
        return this.data;
    }

    public BatchQueryObjectiveResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class BatchQueryObjectiveResponseBodyDataKrListProgress extends TeaModel {
        @NameInMap("percent")
        public Integer percent;

        public static BatchQueryObjectiveResponseBodyDataKrListProgress build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryObjectiveResponseBodyDataKrListProgress self = new BatchQueryObjectiveResponseBodyDataKrListProgress();
            return TeaModel.build(map, self);
        }

        public BatchQueryObjectiveResponseBodyDataKrListProgress setPercent(Integer percent) {
            this.percent = percent;
            return this;
        }
        public Integer getPercent() {
            return this.percent;
        }

    }

    public static class BatchQueryObjectiveResponseBodyDataKrList extends TeaModel {
        @NameInMap("content")
        public java.io.InputStream content;

        @NameInMap("gmtCreate")
        public Float gmtCreate;

        @NameInMap("gmtModified")
        public Float gmtModified;

        @NameInMap("id")
        public java.io.InputStream id;

        @NameInMap("objectiveId")
        public java.io.InputStream objectiveId;

        @NameInMap("permission")
        public java.util.List<Float> permission;

        @NameInMap("position")
        public Long position;

        @NameInMap("progress")
        public BatchQueryObjectiveResponseBodyDataKrListProgress progress;

        @NameInMap("score")
        public Float score;

        @NameInMap("weight")
        public Float weight;

        public static BatchQueryObjectiveResponseBodyDataKrList build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryObjectiveResponseBodyDataKrList self = new BatchQueryObjectiveResponseBodyDataKrList();
            return TeaModel.build(map, self);
        }

        public BatchQueryObjectiveResponseBodyDataKrList setContent(java.io.InputStream content) {
            this.content = content;
            return this;
        }
        public java.io.InputStream getContent() {
            return this.content;
        }

        public BatchQueryObjectiveResponseBodyDataKrList setGmtCreate(Float gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Float getGmtCreate() {
            return this.gmtCreate;
        }

        public BatchQueryObjectiveResponseBodyDataKrList setGmtModified(Float gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Float getGmtModified() {
            return this.gmtModified;
        }

        public BatchQueryObjectiveResponseBodyDataKrList setId(java.io.InputStream id) {
            this.id = id;
            return this;
        }
        public java.io.InputStream getId() {
            return this.id;
        }

        public BatchQueryObjectiveResponseBodyDataKrList setObjectiveId(java.io.InputStream objectiveId) {
            this.objectiveId = objectiveId;
            return this;
        }
        public java.io.InputStream getObjectiveId() {
            return this.objectiveId;
        }

        public BatchQueryObjectiveResponseBodyDataKrList setPermission(java.util.List<Float> permission) {
            this.permission = permission;
            return this;
        }
        public java.util.List<Float> getPermission() {
            return this.permission;
        }

        public BatchQueryObjectiveResponseBodyDataKrList setPosition(Long position) {
            this.position = position;
            return this;
        }
        public Long getPosition() {
            return this.position;
        }

        public BatchQueryObjectiveResponseBodyDataKrList setProgress(BatchQueryObjectiveResponseBodyDataKrListProgress progress) {
            this.progress = progress;
            return this;
        }
        public BatchQueryObjectiveResponseBodyDataKrListProgress getProgress() {
            return this.progress;
        }

        public BatchQueryObjectiveResponseBodyDataKrList setScore(Float score) {
            this.score = score;
            return this;
        }
        public Float getScore() {
            return this.score;
        }

        public BatchQueryObjectiveResponseBodyDataKrList setWeight(Float weight) {
            this.weight = weight;
            return this;
        }
        public Float getWeight() {
            return this.weight;
        }

    }

    public static class BatchQueryObjectiveResponseBodyDataOwner extends TeaModel {
        @NameInMap("avatarMediaId")
        public java.io.InputStream avatarMediaId;

        @NameInMap("corpId")
        public java.io.InputStream corpId;

        @NameInMap("id")
        public java.io.InputStream id;

        @NameInMap("nickname")
        public java.io.InputStream nickname;

        @NameInMap("userId")
        public java.io.InputStream userId;

        public static BatchQueryObjectiveResponseBodyDataOwner build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryObjectiveResponseBodyDataOwner self = new BatchQueryObjectiveResponseBodyDataOwner();
            return TeaModel.build(map, self);
        }

        public BatchQueryObjectiveResponseBodyDataOwner setAvatarMediaId(java.io.InputStream avatarMediaId) {
            this.avatarMediaId = avatarMediaId;
            return this;
        }
        public java.io.InputStream getAvatarMediaId() {
            return this.avatarMediaId;
        }

        public BatchQueryObjectiveResponseBodyDataOwner setCorpId(java.io.InputStream corpId) {
            this.corpId = corpId;
            return this;
        }
        public java.io.InputStream getCorpId() {
            return this.corpId;
        }

        public BatchQueryObjectiveResponseBodyDataOwner setId(java.io.InputStream id) {
            this.id = id;
            return this;
        }
        public java.io.InputStream getId() {
            return this.id;
        }

        public BatchQueryObjectiveResponseBodyDataOwner setNickname(java.io.InputStream nickname) {
            this.nickname = nickname;
            return this;
        }
        public java.io.InputStream getNickname() {
            return this.nickname;
        }

        public BatchQueryObjectiveResponseBodyDataOwner setUserId(java.io.InputStream userId) {
            this.userId = userId;
            return this;
        }
        public java.io.InputStream getUserId() {
            return this.userId;
        }

    }

    public static class BatchQueryObjectiveResponseBodyDataProgress extends TeaModel {
        @NameInMap("percent")
        public Integer percent;

        public static BatchQueryObjectiveResponseBodyDataProgress build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryObjectiveResponseBodyDataProgress self = new BatchQueryObjectiveResponseBodyDataProgress();
            return TeaModel.build(map, self);
        }

        public BatchQueryObjectiveResponseBodyDataProgress setPercent(Integer percent) {
            this.percent = percent;
            return this;
        }
        public Integer getPercent() {
            return this.percent;
        }

    }

    public static class BatchQueryObjectiveResponseBodyData extends TeaModel {
        @NameInMap("alignFromIds")
        public java.util.List<java.io.InputStream> alignFromIds;

        @NameInMap("alignToIds")
        public java.util.List<java.io.InputStream> alignToIds;

        @NameInMap("content")
        public java.io.InputStream content;

        @NameInMap("gmtCreate")
        public Float gmtCreate;

        @NameInMap("gmtModified")
        public Float gmtModified;

        @NameInMap("id")
        public java.io.InputStream id;

        @NameInMap("krList")
        public java.util.List<BatchQueryObjectiveResponseBodyDataKrList> krList;

        @NameInMap("owner")
        public BatchQueryObjectiveResponseBodyDataOwner owner;

        @NameInMap("periodId")
        public java.io.InputStream periodId;

        @NameInMap("permission")
        public java.util.List<Float> permission;

        @NameInMap("position")
        public Integer position;

        @NameInMap("progress")
        public BatchQueryObjectiveResponseBodyDataProgress progress;

        @NameInMap("progressPercent")
        public Float progressPercent;

        @NameInMap("published")
        public Boolean published;

        @NameInMap("score")
        public Float score;

        @NameInMap("status")
        public Integer status;

        @NameInMap("userId")
        public java.io.InputStream userId;

        @NameInMap("weight")
        public Float weight;

        public static BatchQueryObjectiveResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryObjectiveResponseBodyData self = new BatchQueryObjectiveResponseBodyData();
            return TeaModel.build(map, self);
        }

        public BatchQueryObjectiveResponseBodyData setAlignFromIds(java.util.List<java.io.InputStream> alignFromIds) {
            this.alignFromIds = alignFromIds;
            return this;
        }
        public java.util.List<java.io.InputStream> getAlignFromIds() {
            return this.alignFromIds;
        }

        public BatchQueryObjectiveResponseBodyData setAlignToIds(java.util.List<java.io.InputStream> alignToIds) {
            this.alignToIds = alignToIds;
            return this;
        }
        public java.util.List<java.io.InputStream> getAlignToIds() {
            return this.alignToIds;
        }

        public BatchQueryObjectiveResponseBodyData setContent(java.io.InputStream content) {
            this.content = content;
            return this;
        }
        public java.io.InputStream getContent() {
            return this.content;
        }

        public BatchQueryObjectiveResponseBodyData setGmtCreate(Float gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Float getGmtCreate() {
            return this.gmtCreate;
        }

        public BatchQueryObjectiveResponseBodyData setGmtModified(Float gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Float getGmtModified() {
            return this.gmtModified;
        }

        public BatchQueryObjectiveResponseBodyData setId(java.io.InputStream id) {
            this.id = id;
            return this;
        }
        public java.io.InputStream getId() {
            return this.id;
        }

        public BatchQueryObjectiveResponseBodyData setKrList(java.util.List<BatchQueryObjectiveResponseBodyDataKrList> krList) {
            this.krList = krList;
            return this;
        }
        public java.util.List<BatchQueryObjectiveResponseBodyDataKrList> getKrList() {
            return this.krList;
        }

        public BatchQueryObjectiveResponseBodyData setOwner(BatchQueryObjectiveResponseBodyDataOwner owner) {
            this.owner = owner;
            return this;
        }
        public BatchQueryObjectiveResponseBodyDataOwner getOwner() {
            return this.owner;
        }

        public BatchQueryObjectiveResponseBodyData setPeriodId(java.io.InputStream periodId) {
            this.periodId = periodId;
            return this;
        }
        public java.io.InputStream getPeriodId() {
            return this.periodId;
        }

        public BatchQueryObjectiveResponseBodyData setPermission(java.util.List<Float> permission) {
            this.permission = permission;
            return this;
        }
        public java.util.List<Float> getPermission() {
            return this.permission;
        }

        public BatchQueryObjectiveResponseBodyData setPosition(Integer position) {
            this.position = position;
            return this;
        }
        public Integer getPosition() {
            return this.position;
        }

        public BatchQueryObjectiveResponseBodyData setProgress(BatchQueryObjectiveResponseBodyDataProgress progress) {
            this.progress = progress;
            return this;
        }
        public BatchQueryObjectiveResponseBodyDataProgress getProgress() {
            return this.progress;
        }

        public BatchQueryObjectiveResponseBodyData setProgressPercent(Float progressPercent) {
            this.progressPercent = progressPercent;
            return this;
        }
        public Float getProgressPercent() {
            return this.progressPercent;
        }

        public BatchQueryObjectiveResponseBodyData setPublished(Boolean published) {
            this.published = published;
            return this;
        }
        public Boolean getPublished() {
            return this.published;
        }

        public BatchQueryObjectiveResponseBodyData setScore(Float score) {
            this.score = score;
            return this;
        }
        public Float getScore() {
            return this.score;
        }

        public BatchQueryObjectiveResponseBodyData setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public BatchQueryObjectiveResponseBodyData setUserId(java.io.InputStream userId) {
            this.userId = userId;
            return this;
        }
        public java.io.InputStream getUserId() {
            return this.userId;
        }

        public BatchQueryObjectiveResponseBodyData setWeight(Float weight) {
            this.weight = weight;
            return this;
        }
        public Float getWeight() {
            return this.weight;
        }

    }

}
