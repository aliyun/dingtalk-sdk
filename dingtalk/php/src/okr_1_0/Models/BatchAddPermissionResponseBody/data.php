<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchAddPermissionResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchAddPermissionResponseBody\data\permissionTree;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 是否有无效的成员。
     *
     * @var bool
     */
    public $hasInvalidUser;

    /**
     * @description 权限信息。
     *
     * @var permissionTree
     */
    public $permissionTree;
    protected $_name = [
        'hasInvalidUser' => 'hasInvalidUser',
        'permissionTree' => 'permissionTree',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasInvalidUser) {
            $res['hasInvalidUser'] = $this->hasInvalidUser;
        }
        if (null !== $this->permissionTree) {
            $res['permissionTree'] = null !== $this->permissionTree ? $this->permissionTree->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasInvalidUser'])) {
            $model->hasInvalidUser = $map['hasInvalidUser'];
        }
        if (isset($map['permissionTree'])) {
            $model->permissionTree = permissionTree::fromMap($map['permissionTree']);
        }

        return $model;
    }
}
