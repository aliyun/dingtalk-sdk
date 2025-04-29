<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateStudentRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 32432432432
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
     * @example 李四
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example manager34234
     *
     * @var string
     */
    public $operator;

    /**
     * @description This parameter is required.
     *
     * @example 23
     *
     * @var string
     */
    public $studentNo;

    /**
     * @description This parameter is required.
     *
     * @example 234234234
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'bizId' => 'bizId',
        'classId' => 'classId',
        'name' => 'name',
        'operator' => 'operator',
        'studentNo' => 'studentNo',
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->studentNo) {
            $res['studentNo'] = $this->studentNo;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateStudentRequest
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
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['studentNo'])) {
            $model->studentNo = $map['studentNo'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
