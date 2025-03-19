<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class AgoalObjectiveKeyActionListRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 211042291978xxxx
     *
     * @var string
     */
    public $dingUserId;

    /**
     * @example 6444f5e9a4261c6e699dxxxx
     *
     * @var string
     */
    public $keyResultId;

    /**
     * @description This parameter is required.
     *
     * @example 6444f5e9a4261c6e699dxxxx
     *
     * @var string
     */
    public $objectiveId;
    protected $_name = [
        'dingUserId' => 'dingUserId',
        'keyResultId' => 'keyResultId',
        'objectiveId' => 'objectiveId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingUserId) {
            $res['dingUserId'] = $this->dingUserId;
        }
        if (null !== $this->keyResultId) {
            $res['keyResultId'] = $this->keyResultId;
        }
        if (null !== $this->objectiveId) {
            $res['objectiveId'] = $this->objectiveId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AgoalObjectiveKeyActionListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingUserId'])) {
            $model->dingUserId = $map['dingUserId'];
        }
        if (isset($map['keyResultId'])) {
            $model->keyResultId = $map['keyResultId'];
        }
        if (isset($map['objectiveId'])) {
            $model->objectiveId = $map['objectiveId'];
        }

        return $model;
    }
}
