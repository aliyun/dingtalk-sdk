<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateClassRequest\openClass;
use AlibabaCloud\Tea\Model;

class UpdateClassRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 23424324324
     *
     * @var int
     */
    public $deptId;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $gradeLevel;

    /**
     * @description This parameter is required.
     *
     * @var openClass
     */
    public $openClass;

    /**
     * @description This parameter is required.
     *
     * @example manager234234
     *
     * @var string
     */
    public $operator;

    /**
     * @description This parameter is required.
     *
     * @example 23423423
     *
     * @var int
     */
    public $superId;
    protected $_name = [
        'deptId' => 'deptId',
        'gradeLevel' => 'gradeLevel',
        'openClass' => 'openClass',
        'operator' => 'operator',
        'superId' => 'superId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->gradeLevel) {
            $res['gradeLevel'] = $this->gradeLevel;
        }
        if (null !== $this->openClass) {
            $res['openClass'] = null !== $this->openClass ? $this->openClass->toMap() : null;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->superId) {
            $res['superId'] = $this->superId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateClassRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['gradeLevel'])) {
            $model->gradeLevel = $map['gradeLevel'];
        }
        if (isset($map['openClass'])) {
            $model->openClass = openClass::fromMap($map['openClass']);
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['superId'])) {
            $model->superId = $map['superId'];
        }

        return $model;
    }
}
