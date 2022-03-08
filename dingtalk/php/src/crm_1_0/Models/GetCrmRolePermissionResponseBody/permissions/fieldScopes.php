<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmRolePermissionResponseBody\permissions;

use AlibabaCloud\Tea\Model;

class fieldScopes extends Model
{
    /**
     * @description 字段权限点
     *
     * @var string[]
     */
    public $fieldActions;

    /**
     * @description 字段id
     *
     * @var string
     */
    public $fieldId;
    protected $_name = [
        'fieldActions' => 'fieldActions',
        'fieldId'      => 'fieldId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldActions) {
            $res['fieldActions'] = $this->fieldActions;
        }
        if (null !== $this->fieldId) {
            $res['fieldId'] = $this->fieldId;
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
        if (isset($map['fieldActions'])) {
            if (!empty($map['fieldActions'])) {
                $model->fieldActions = $map['fieldActions'];
            }
        }
        if (isset($map['fieldId'])) {
            $model->fieldId = $map['fieldId'];
        }

        return $model;
    }
}
