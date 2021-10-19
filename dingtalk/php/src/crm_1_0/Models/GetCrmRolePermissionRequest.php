<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCrmRolePermissionRequest extends Model
{
    /**
     * @description 表单标识（formCode & bizType二选一）
     *
     * @var string
     */
    public $formCode;

    /**
     * @description 表单业务标识（formCode & bizType二选一）
     *
     * @var string
     */
    public $bizType;
    protected $_name = [
        'formCode' => 'formCode',
        'bizType'  => 'bizType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCrmRolePermissionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }

        return $model;
    }
}
