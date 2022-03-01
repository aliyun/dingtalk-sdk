<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\OkrOpenRecommendRequest\candidateOkrItems;

use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\OkrOpenRecommendRequest\candidateOkrItems\okrInfos\keyResultInfos;
use AlibabaCloud\Tea\Model;

class okrInfos extends Model
{
    /**
     * @var keyResultInfos[]
     */
    public $keyResultInfos;

    /**
     * @var string
     */
    public $objective;

    /**
     * @var string
     */
    public $objectiveId;

    /**
     * @var string[]
     */
    public $words;
    protected $_name = [
        'keyResultInfos' => 'keyResultInfos',
        'objective'      => 'objective',
        'objectiveId'    => 'objectiveId',
        'words'          => 'words',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->keyResultInfos) {
            $res['keyResultInfos'] = [];
            if (null !== $this->keyResultInfos && \is_array($this->keyResultInfos)) {
                $n = 0;
                foreach ($this->keyResultInfos as $item) {
                    $res['keyResultInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->objective) {
            $res['objective'] = $this->objective;
        }
        if (null !== $this->objectiveId) {
            $res['objectiveId'] = $this->objectiveId;
        }
        if (null !== $this->words) {
            $res['words'] = $this->words;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return okrInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['keyResultInfos'])) {
            if (!empty($map['keyResultInfos'])) {
                $model->keyResultInfos = [];
                $n                     = 0;
                foreach ($map['keyResultInfos'] as $item) {
                    $model->keyResultInfos[$n++] = null !== $item ? keyResultInfos::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['objective'])) {
            $model->objective = $map['objective'];
        }
        if (isset($map['objectiveId'])) {
            $model->objectiveId = $map['objectiveId'];
        }
        if (isset($map['words'])) {
            if (!empty($map['words'])) {
                $model->words = $map['words'];
            }
        }

        return $model;
    }
}
