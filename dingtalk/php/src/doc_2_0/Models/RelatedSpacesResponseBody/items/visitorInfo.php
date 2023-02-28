<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\RelatedSpacesResponseBody\items;

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
     * @description 是否置顶
     *
     * @var bool
     */
    public $pinned;

    /**
     * @description 权限
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
        'pinned'        => 'pinned',
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
        if (null !== $this->pinned) {
            $res['pinned'] = $this->pinned;
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
        if (isset($map['pinned'])) {
            $model->pinned = $map['pinned'];
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
