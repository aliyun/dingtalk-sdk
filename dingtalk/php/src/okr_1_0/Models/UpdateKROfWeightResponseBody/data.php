<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UpdateKROfWeightResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UpdateKROfWeightResponseBody\data\objectiveProgress;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var objectiveProgress
     */
    public $objectiveProgress;

    /**
     * @description 目标分数。
     *
     * @var int
     */
    public $objectiveScore;
    protected $_name = [
        'objectiveProgress' => 'objectiveProgress',
        'objectiveScore'    => 'objectiveScore',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->objectiveProgress) {
            $res['objectiveProgress'] = null !== $this->objectiveProgress ? $this->objectiveProgress->toMap() : null;
        }
        if (null !== $this->objectiveScore) {
            $res['objectiveScore'] = $this->objectiveScore;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['objectiveProgress'])) {
            $model->objectiveProgress = objectiveProgress::fromMap($map['objectiveProgress']);
        }
        if (isset($map['objectiveScore'])) {
            $model->objectiveScore = $map['objectiveScore'];
        }

        return $model;
    }
}
