<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmRolePermissionResponseBody\permissions;

use AlibabaCloud\Tea\Model;

class fieldScopes extends Model
{
    /**
     * @description 字段id
     *
     * @var string
     */
    public $fieldId;

    /**
     * @description 字段权限点
     *
     * @var string[]
     */
    public $fieldActions;
    protected $_name = [
        'fieldId'      => 'fieldId',
        'fieldActions' => 'fieldActions',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldId) {
            $res['fieldId'] = $this->fieldId;
        }
        if (null !== $this->fieldActions) {
            $res['fieldActions'] = $this->fieldActions;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return fieldScopes
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldId'])) {
            $model->fieldId = $map['fieldId'];
        }
        if (isset($map['fieldActions'])) {
            if (!empty($map['fieldActions'])) {
                $model->fieldActions = $map['fieldActions'];
            }
        }

        return $model;
    }
}
