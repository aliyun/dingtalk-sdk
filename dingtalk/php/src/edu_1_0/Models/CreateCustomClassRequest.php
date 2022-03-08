<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCustomClassRequest\customClass;
use AlibabaCloud\Tea\Model;

class CreateCustomClassRequest extends Model
{
    /**
     * @description 班级信息
     *
     * @var customClass
     */
    public $customClass;

    /**
     * @description 钉钉企业管理员工ID
     *
     * @var string
     */
    public $operator;

    /**
     * @description 上级部门ID
     *
     * @var int
     */
    public $superId;
    protected $_name = [
        'customClass' => 'customClass',
        'operator'    => 'operator',
        'superId'     => 'superId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->customClass) {
            $res['customClass'] = null !== $this->customClass ? $this->customClass->toMap() : null;
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
     * @return CreateCustomClassRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customClass'])) {
            $model->customClass = customClass::fromMap($map['customClass']);
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
