<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCustomDeptRequest\customDept;
use AlibabaCloud\Tea\Model;

class CreateCustomDeptRequest extends Model
{
    /**
     * @var customDept
     */
    public $customDept;

    /**
     * @description 钉钉管理员员工ID
     *
     * @var string
     */
    public $operator;

    /**
     * @description 上级部门ID（type为custom_campus时，必须为-7）
     *
     * @var int
     */
    public $superId;
    protected $_name = [
        'customDept' => 'customDept',
        'operator'   => 'operator',
        'superId'    => 'superId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->customDept) {
            $res['customDept'] = null !== $this->customDept ? $this->customDept->toMap() : null;
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
     * @return CreateCustomDeptRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customDept'])) {
            $model->customDept = customDept::fromMap($map['customDept']);
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
