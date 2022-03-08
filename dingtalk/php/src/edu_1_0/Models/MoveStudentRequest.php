<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class MoveStudentRequest extends Model
{
    /**
     * @description 管理员id
     *
     * @var string
     */
    public $operator;

    /**
     * @description 愿班级id
     *
     * @var int
     */
    public $originClassId;

    /**
     * @description 目标班级id
     *
     * @var int
     */
    public $targetClassId;

    /**
     * @description 学生id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'operator'      => 'operator',
        'originClassId' => 'originClassId',
        'targetClassId' => 'targetClassId',
        'userId'        => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->originClassId) {
            $res['originClassId'] = $this->originClassId;
        }
        if (null !== $this->targetClassId) {
            $res['targetClassId'] = $this->targetClassId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MoveStudentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['originClassId'])) {
            $model->originClassId = $map['originClassId'];
        }
        if (isset($map['targetClassId'])) {
            $model->targetClassId = $map['targetClassId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
