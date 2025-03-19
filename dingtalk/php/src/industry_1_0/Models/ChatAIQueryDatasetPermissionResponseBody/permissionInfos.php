<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatAIQueryDatasetPermissionResponseBody;

use AlibabaCloud\Tea\Model;

class permissionInfos extends Model
{
    /**
     * @var string
     */
    public $permissionType;

    /**
     * @var string[]
     */
    public $permissionValues;
    protected $_name = [
        'permissionType' => 'permissionType',
        'permissionValues' => 'permissionValues',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->permissionType) {
            $res['permissionType'] = $this->permissionType;
        }
        if (null !== $this->permissionValues) {
            $res['permissionValues'] = $this->permissionValues;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return permissionInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['permissionType'])) {
            $model->permissionType = $map['permissionType'];
        }
        if (isset($map['permissionValues'])) {
            if (!empty($map['permissionValues'])) {
                $model->permissionValues = $map['permissionValues'];
            }
        }

        return $model;
    }
}
