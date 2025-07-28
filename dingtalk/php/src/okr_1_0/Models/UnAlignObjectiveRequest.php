<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;

class UnAlignObjectiveRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1006
     *
     * @var string
     */
    public $periodId;

    /**
     * @description This parameter is required.
     *
     * @example 59YD
     *
     * @var string
     */
    public $targetId;

    /**
     * @description This parameter is required.
     *
     * @example 0115396701752283
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'periodId' => 'periodId',
        'targetId' => 'targetId',
        'userId' => 'userId',
    ];

    public function validate() {}

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
     * @return UnAlignObjectiveRequest
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
