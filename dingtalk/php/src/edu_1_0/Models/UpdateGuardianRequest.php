<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateGuardianRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 23434234234
     *
     * @var string
     */
    public $bizId;

    /**
     * @description This parameter is required.
     *
     * @example 234324234
     *
     * @var int
     */
    public $classId;

    /**
     * @description This parameter is required.
     *
     * @example 3545979
     *
     * @var string
     */
    public $operator;

    /**
     * @description This parameter is required.
     *
     * @example F
     *
     * @var string
     */
    public $relation;

    /**
     * @description This parameter is required.
     *
     * @example 234234324
     *
     * @var string
     */
    public $stuId;

    /**
     * @description This parameter is required.
     *
     * @example 324324324
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'bizId' => 'bizId',
        'classId' => 'classId',
        'operator' => 'operator',
        'relation' => 'relation',
        'stuId' => 'stuId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->relation) {
            $res['relation'] = $this->relation;
        }
        if (null !== $this->stuId) {
            $res['stuId'] = $this->stuId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateGuardianRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['relation'])) {
            $model->relation = $map['relation'];
        }
        if (isset($map['stuId'])) {
            $model->stuId = $map['stuId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
