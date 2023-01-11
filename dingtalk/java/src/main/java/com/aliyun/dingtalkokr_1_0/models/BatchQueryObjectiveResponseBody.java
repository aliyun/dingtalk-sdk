// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryObjectiveResponseBody extends TeaModel {
    /**
     * <p>data</p>
     */
    @NameInMap("data")
    public java.util.List<BatchQueryObjectiveResponseBodyData> data;

    /**
     * <p>请求成功的标识。</p>
     */
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
        /**
         * <p>百分比。</p>
         */
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
        /**
         * <p>KR 内容。</p>
         */
        @NameInMap("content")
        public java.io.InputStream content;

        /**
         * <p>创建时间。时间戳</p>
         */
        @NameInMap("gmtCreate")
        public Float gmtCreate;

        /**
         * <p>更新时间。时间戳</p>
         */
        @NameInMap("gmtModified")
        public Float gmtModified;

        /**
         * <p>KR 的 ID。</p>
         */
        @NameInMap("id")
        public java.io.InputStream id;

        /**
         * <p>所属 Objective ID。</p>
         */
        @NameInMap("objectiveId")
        public java.io.InputStream objectiveId;

        /**
         * <p>KR 权限。</p>
         */
        @NameInMap("permission")
        public java.util.List<Float> permission;

        /**
         * <p>所处位置。</p>
         */
        @NameInMap("position")
        public Long position;

        /**
         * <p>KR 进度。</p>
         */
        @NameInMap("progress")
        public BatchQueryObjectiveResponseBodyDataKrListProgress progress;

        /**
         * <p>所占分数。</p>
         */
        @NameInMap("score")
        public Float score;

        /**
         * <p>所占权重。</p>
         */
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
        /**
         * <p>所属者头像。 ID</p>
         */
        @NameInMap("avatarMediaId")
        public java.io.InputStream avatarMediaId;

        /**
         * <p>所属者组织 I。D</p>
         */
        @NameInMap("corpId")
        public java.io.InputStream corpId;

        /**
         * <p>所属者在 OKR 系统中的 ID。</p>
         */
        @NameInMap("id")
        public java.io.InputStream id;

        /**
         * <p>所属者昵称。</p>
         */
        @NameInMap("nickname")
        public java.io.InputStream nickname;

        /**
         * <p>所属者 userId。</p>
         */
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
        /**
         * <p>百分比。</p>
         */
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
        /**
         * <p>被对齐的 Objective。</p>
         */
        @NameInMap("alignFromIds")
        public java.util.List<java.io.InputStream> alignFromIds;

        /**
         * <p>对齐的 Objective。</p>
         */
        @NameInMap("alignToIds")
        public java.util.List<java.io.InputStream> alignToIds;

        /**
         * <p>Objective 内容。</p>
         */
        @NameInMap("content")
        public java.io.InputStream content;

        /**
         * <p>创建时间。时间戳</p>
         */
        @NameInMap("gmtCreate")
        public Float gmtCreate;

        /**
         * <p>更新时间。时间戳</p>
         */
        @NameInMap("gmtModified")
        public Float gmtModified;

        /**
         * <p>objective。</p>
         */
        @NameInMap("id")
        public java.io.InputStream id;

        /**
         * <p>KR 详情列表。</p>
         */
        @NameInMap("krList")
        public java.util.List<BatchQueryObjectiveResponseBodyDataKrList> krList;

        /**
         * <p>所属者信息。</p>
         */
        @NameInMap("owner")
        public BatchQueryObjectiveResponseBodyDataOwner owner;

        /**
         * <p>周期 ID。</p>
         */
        @NameInMap("periodId")
        public java.io.InputStream periodId;

        /**
         * <p>权限值。</p>
         */
        @NameInMap("permission")
        public java.util.List<Float> permission;

        /**
         * <p>所在位置。</p>
         */
        @NameInMap("position")
        public Integer position;

        /**
         * <p>进度值。</p>
         */
        @NameInMap("progress")
        public BatchQueryObjectiveResponseBodyDataProgress progress;

        /**
         * <p>百分比值。</p>
         */
        @NameInMap("progressPercent")
        public Float progressPercent;

        /**
         * <p>是否已发布。</p>
         */
        @NameInMap("published")
        public Boolean published;

        /**
         * <p>分数值。</p>
         */
        @NameInMap("score")
        public Float score;

        /**
         * <p>当前内容状态。</p>
         */
        @NameInMap("status")
        public Integer status;

        /**
         * <p>用户 ID。</p>
         */
        @NameInMap("userId")
        public java.io.InputStream userId;

        /**
         * <p>权重值。</p>
         */
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
