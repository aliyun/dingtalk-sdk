<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;

class AlignObjectiveRequest extends Model
{
    /**
     * @description 周期 ID。
     *
     * @var string
     */
    public $periodId;

    /**
     * @description 对齐目标的 ID。
     *
     * @var string
     */
    public $targetId;

    /**
     * @description 当前用户的 user ID。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'periodId' => 'periodId',
        'targetId' => 'targetId',
        'userId'   => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->periodId) {
            $res['periodId'] = $this->periodId;
        }
        if (null !== $this->targetId) {
            $res['targetId'] = $this->targetId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AlignObjectiveRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['periodId'])) {
            $model->periodId = $map['periodId'];
        }
        if (isset($map['targetId'])) {
            $model->targetId = $map['targetId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
