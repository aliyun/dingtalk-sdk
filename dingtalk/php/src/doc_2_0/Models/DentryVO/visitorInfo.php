<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\DentryVO;

use AlibabaCloud\Tea\Model;

class visitorInfo extends Model
{
    /**
     * @description 节点的操作列表。
     *
     * @var string[]
     */
    public $dentryActions;

    /**
     * @description 当前用户对这个空间的访问角色。
     *
     * @var string
     */
    public $roleCode;

    /**
     * @description 空间的操作列表。
     *
     * @var string[]
     */
    public $spaceActions;
    protected $_name = [
        'dentryActions' => 'dentryActions',
        'roleCode'      => 'roleCode',
        'spaceActions'  => 'spaceActions',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentryActions) {
            $res['dentryActions'] = $this->dentryActions;
        }
        if (null !== $this->roleCode) {
            $res['roleCode'] = $this->roleCode;
        }
        if (null !== $this->spaceActions) {
            $res['spaceActions'] = $this->spaceActions;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return visitorInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentryActions'])) {
            if (!empty($map['dentryActions'])) {
                $model->dentryActions = $map['dentryActions'];
            }
        }
        if (isset($map['roleCode'])) {
            $model->roleCode = $map['roleCode'];
        }
        if (isset($map['spaceActions'])) {
            if (!empty($map['spaceActions'])) {
                $model->spaceActions = $map['spaceActions'];
            }
        }

        return $model;
    }
}
