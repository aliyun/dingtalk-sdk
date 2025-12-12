<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\AiTrainingRecordResponseBody;

use AlibabaCloud\Tea\Model;

class trainingList extends Model
{
    /**
     * @var string
     */
    public $aiJobStatus;

    /**
     * @var string
     */
    public $gmtCreate;

    /**
     * @var int
     */
    public $id;

    /**
     * @var string
     */
    public $productName;

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
    protected $_name = [
        'aiJobStatus' => 'aiJobStatus',
        'gmtCreate' => 'gmtCreate',
        'id' => 'id',
        'productName' => 'productName',
        'trainingRanking' => 'trainingRanking',
        'trainingRankingPercent' => 'trainingRankingPercent',
        'trainingScore' => 'trainingScore',
        'userId' => 'userId',
        'userName' => 'userName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->aiJobStatus) {
            $res['aiJobStatus'] = $this->aiJobStatus;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->productName) {
            $res['productName'] = $this->productName;
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return trainingList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['aiJobStatus'])) {
            $model->aiJobStatus = $map['aiJobStatus'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['productName'])) {
            $model->productName = $map['productName'];
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

        return $model;
    }
}
