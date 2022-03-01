<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\OkrOpenRecommendResponseBody;

use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\OkrOpenRecommendResponseBody\okrRecommendItems\krResultRelatedResults;
use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\OkrOpenRecommendResponseBody\okrRecommendItems\objectiveRelatedResults;
use AlibabaCloud\Tea\Model;

class okrRecommendItems extends Model
{
    /**
     * @description userId
     *
     * @var string
     */
    public $userId;

    /**
     * @description relatedLevel
     *
     * @var int
     */
    public $relatedLevel;

    /**
     * @description objectiveRelatedResults
     *
     * @var objectiveRelatedResults[]
     */
    public $objectiveRelatedResults;

    /**
     * @description krResultRelatedResults
     *
     * @var krResultRelatedResults[]
     */
    public $krResultRelatedResults;
    protected $_name = [
        'userId'                  => 'userId',
        'relatedLevel'            => 'relatedLevel',
        'objectiveRelatedResults' => 'objectiveRelatedResults',
        'krResultRelatedResults'  => 'krResultRelatedResults',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->relatedLevel) {
            $res['relatedLevel'] = $this->relatedLevel;
        }
        if (null !== $this->objectiveRelatedResults) {
            $res['objectiveRelatedResults'] = [];
            if (null !== $this->objectiveRelatedResults && \is_array($this->objectiveRelatedResults)) {
                $n = 0;
                foreach ($this->objectiveRelatedResults as $item) {
                    $res['objectiveRelatedResults'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->krResultRelatedResults) {
            $res['krResultRelatedResults'] = [];
            if (null !== $this->krResultRelatedResults && \is_array($this->krResultRelatedResults)) {
                $n = 0;
                foreach ($this->krResultRelatedResults as $item) {
                    $res['krResultRelatedResults'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return okrRecommendItems
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['relatedLevel'])) {
            $model->relatedLevel = $map['relatedLevel'];
        }
        if (isset($map['objectiveRelatedResults'])) {
            if (!empty($map['objectiveRelatedResults'])) {
                $model->objectiveRelatedResults = [];
                $n                              = 0;
                foreach ($map['objectiveRelatedResults'] as $item) {
                    $model->objectiveRelatedResults[$n++] = null !== $item ? objectiveRelatedResults::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['krResultRelatedResults'])) {
            if (!empty($map['krResultRelatedResults'])) {
                $model->krResultRelatedResults = [];
                $n                             = 0;
                foreach ($map['krResultRelatedResults'] as $item) {
                    $model->krResultRelatedResults[$n++] = null !== $item ? krResultRelatedResults::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
