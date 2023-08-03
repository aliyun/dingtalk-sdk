<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class AssignClassRequest extends Model
{
    /**
     * @example 353534
     *
     * @var int
     */
    public $classId;

    /**
     * @var bool
     */
    public $isFinish;

    /**
     * @example staff234
     *
     * @var string
     */
    public $operator;

    /**
     * @example 675656
     *
     * @var int
     */
    public $studentId;

    /**
     * @example 4240028
     *
     * @var int
     */
    public $taskId;
    protected $_name = [
        'classId'   => 'classId',
        'isFinish'  => 'isFinish',
        'operator'  => 'operator',
        'studentId' => 'studentId',
        'taskId'    => 'taskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->isFinish) {
            $res['isFinish'] = $this->isFinish;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->studentId) {
            $res['studentId'] = $this->studentId;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AssignClassRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['isFinish'])) {
            $model->isFinish = $map['isFinish'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['studentId'])) {
            $model->studentId = $map['studentId'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
