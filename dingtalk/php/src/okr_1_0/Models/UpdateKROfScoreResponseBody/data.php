<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UpdateKROfScoreResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 目标分数。
     *
     * @var int
     */
    public $objectiveScore;
    protected $_name = [
        'objectiveScore' => 'objectiveScore',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
        if (isset($map['objectiveScore'])) {
            $model->objectiveScore = $map['objectiveScore'];
        }

        return $model;
    }
}
