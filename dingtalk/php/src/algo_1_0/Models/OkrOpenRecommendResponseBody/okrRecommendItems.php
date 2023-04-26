<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\OkrOpenRecommendResponseBody;

use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\OkrOpenRecommendResponseBody\okrRecommendItems\krResultRelatedResults;
use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\OkrOpenRecommendResponseBody\okrRecommendItems\objectiveRelatedResults;
use AlibabaCloud\Tea\Model;

class okrRecommendItems extends Model
{
    /**
     * @var krResultRelatedResults[]
     */
    public $krResultRelatedResults;

    /**
     * @var objectiveRelatedResults[]
     */
    public $objectiveRelatedResults;

    /**
     * @var int
     */
    public $relatedLevel;

    /**
     * @example 3
     *
     * @var int
     */
    public $semanticLevel;

    /**
     * @example 111
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'krResultRelatedResults'  => 'krResultRelatedResults',
        'objectiveRelatedResults' => 'objectiveRelatedResults',
        'relatedLevel'            => 'relatedLevel',
        'semanticLevel'           => 'semanticLevel',
        'userId'                  => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->krResultRelatedResults) {
            $res['krResultRelatedResults'] = [];
            if (null !== $this->krResultRelatedResults && \is_array($this->krResultRelatedResults)) {
                $n = 0;
                foreach ($this->krResultRelatedResults as $item) {
                    $res['krResultRelatedResults'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (null !== $this->relatedLevel) {
            $res['relatedLevel'] = $this->relatedLevel;
        }
        if (null !== $this->semanticLevel) {
            $res['semanticLevel'] = $this->semanticLevel;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['krResultRelatedResults'])) {
            if (!empty($map['krResultRelatedResults'])) {
                $model->krResultRelatedResults = [];
                $n                             = 0;
                foreach ($map['krResultRelatedResults'] as $item) {
                    $model->krResultRelatedResults[$n++] = null !== $item ? krResultRelatedResults::fromMap($item) : $item;
                }
            }
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
        if (isset($map['relatedLevel'])) {
            $model->relatedLevel = $map['relatedLevel'];
        }
        if (isset($map['semanticLevel'])) {
            $model->semanticLevel = $map['semanticLevel'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
