<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\OkrOpenRecommendResponseBody\okrRecommendItems;

use AlibabaCloud\Tea\Model;

class objectiveRelatedResults extends Model
{
    /**
     * @description objectiveId
     *
     * @var string
     */
    public $objectiveId;

    /**
     * @description semanticLevel
     *
     * @var int
     */
    public $semanticLevel;

    /**
     * @description words
     *
     * @var string[]
     */
    public $words;
    protected $_name = [
        'objectiveId'   => 'objectiveId',
        'semanticLevel' => 'semanticLevel',
        'words'         => 'words',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->objectiveId) {
            $res['objectiveId'] = $this->objectiveId;
        }
        if (null !== $this->semanticLevel) {
            $res['semanticLevel'] = $this->semanticLevel;
        }
        if (null !== $this->words) {
            $res['words'] = $this->words;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return objectiveRelatedResults
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['objectiveId'])) {
            $model->objectiveId = $map['objectiveId'];
        }
        if (isset($map['semanticLevel'])) {
            $model->semanticLevel = $map['semanticLevel'];
        }
        if (isset($map['words'])) {
            if (!empty($map['words'])) {
                $model->words = $map['words'];
            }
        }

        return $model;
    }
}
