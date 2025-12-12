<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\AiTrainingDetailResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\AiTrainingDetailResponseBody\result\productInfoList;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\AiTrainingDetailResponseBody\result\taskInfo;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $adminReview;

    /**
     * @var string
     */
    public $aiJobStatus;

    /**
     * @var string
     */
    public $creator;

    /**
     * @var int
     */
    public $duration;

    /**
     * @var int
     */
    public $feedback;

    /**
     * @var string
     */
    public $feedbackContent;

    /**
     * @var string
     */
    public $gmtCreate;

    /**
     * @var string
     */
    public $gmtModified;

    /**
     * @var int
     */
    public $id;

    /**
     * @var int
     */
    public $isExcellent;

    /**
     * @var productInfoList[]
     */
    public $productInfoList;

    /**
     * @var string
     */
    public $productName;

    /**
     * @var taskInfo
     */
    public $taskInfo;

    /**
     * @var int
     */
    public $trainingRanking;

    /**
     * @var int
     */
    public $trainingRankingPercent;

    /**
     * @var int
     */
    public $trainingScore;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $userName;

    /**
     * @var string
     */
    public $videoDownloadUrl;
    protected $_name = [
        'adminReview' => 'adminReview',
        'aiJobStatus' => 'aiJobStatus',
        'creator' => 'creator',
        'duration' => 'duration',
        'feedback' => 'feedback',
        'feedbackContent' => 'feedbackContent',
        'gmtCreate' => 'gmtCreate',
        'gmtModified' => 'gmtModified',
        'id' => 'id',
        'isExcellent' => 'isExcellent',
        'productInfoList' => 'productInfoList',
        'productName' => 'productName',
        'taskInfo' => 'taskInfo',
        'trainingRanking' => 'trainingRanking',
        'trainingRankingPercent' => 'trainingRankingPercent',
        'trainingScore' => 'trainingScore',
        'userId' => 'userId',
        'userName' => 'userName',
        'videoDownloadUrl' => 'videoDownloadUrl',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->adminReview) {
            $res['adminReview'] = $this->adminReview;
        }
        if (null !== $this->aiJobStatus) {
            $res['aiJobStatus'] = $this->aiJobStatus;
        }
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
        }
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->feedback) {
            $res['feedback'] = $this->feedback;
        }
        if (null !== $this->feedbackContent) {
            $res['feedbackContent'] = $this->feedbackContent;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->isExcellent) {
            $res['isExcellent'] = $this->isExcellent;
        }
        if (null !== $this->productInfoList) {
            $res['productInfoList'] = [];
            if (null !== $this->productInfoList && \is_array($this->productInfoList)) {
                $n = 0;
                foreach ($this->productInfoList as $item) {
                    $res['productInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->productName) {
            $res['productName'] = $this->productName;
        }
        if (null !== $this->taskInfo) {
            $res['taskInfo'] = null !== $this->taskInfo ? $this->taskInfo->toMap() : null;
        }
        if (null !== $this->trainingRanking) {
            $res['trainingRanking'] = $this->trainingRanking;
        }
        if (null !== $this->trainingRankingPercent) {
            $res['trainingRankingPercent'] = $this->trainingRankingPercent;
        }
        if (null !== $this->trainingScore) {
            $res['trainingScore'] = $this->trainingScore;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }
        if (null !== $this->videoDownloadUrl) {
            $res['videoDownloadUrl'] = $this->videoDownloadUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['adminReview'])) {
            $model->adminReview = $map['adminReview'];
        }
        if (isset($map['aiJobStatus'])) {
            $model->aiJobStatus = $map['aiJobStatus'];
        }
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['feedback'])) {
            $model->feedback = $map['feedback'];
        }
        if (isset($map['feedbackContent'])) {
            $model->feedbackContent = $map['feedbackContent'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['isExcellent'])) {
            $model->isExcellent = $map['isExcellent'];
        }
        if (isset($map['productInfoList'])) {
            if (!empty($map['productInfoList'])) {
                $model->productInfoList = [];
                $n = 0;
                foreach ($map['productInfoList'] as $item) {
                    $model->productInfoList[$n++] = null !== $item ? productInfoList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['productName'])) {
            $model->productName = $map['productName'];
        }
        if (isset($map['taskInfo'])) {
            $model->taskInfo = taskInfo::fromMap($map['taskInfo']);
        }
        if (isset($map['trainingRanking'])) {
            $model->trainingRanking = $map['trainingRanking'];
        }
        if (isset($map['trainingRankingPercent'])) {
            $model->trainingRankingPercent = $map['trainingRankingPercent'];
        }
        if (isset($map['trainingScore'])) {
            $model->trainingScore = $map['trainingScore'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }
        if (isset($map['videoDownloadUrl'])) {
            $model->videoDownloadUrl = $map['videoDownloadUrl'];
        }

        return $model;
    }
}
