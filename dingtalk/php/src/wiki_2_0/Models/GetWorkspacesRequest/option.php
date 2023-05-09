<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetWorkspacesRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @example false
     *
     * @var bool
     */
    public $withPermissionRole;
    protected $_name = [
        'withPermissionRole' => 'withPermissionRole',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->withPermissionRole) {
            $res['withPermissionRole'] = $this->withPermissionRole;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return option
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['withPermissionRole'])) {
            $model->withPermissionRole = $map['withPermissionRole'];
        }

        return $model;
    }
}
