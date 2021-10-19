<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmRolePermissionResponseBody\permissions;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmRolePermissionResponseBody\permissions\managingScopeList\ext;
use AlibabaCloud\Tea\Model;

class managingScopeList extends Model
{
    /**
     * @description 管理范围类型
     *
     * @var string
     */
    public $type;

    /**
     * @description 是否是主管
     *
     * @var bool
     */
    public $manager;

    /**
     * @description 扩展信息
     *
     * @var ext
     */
    public $ext;
    protected $_name = [
        'type'    => 'type',
        'manager' => 'manager',
        'ext'     => 'ext',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->manager) {
            $res['manager'] = $this->manager;
        }
        if (null !== $this->ext) {
            $res['ext'] = null !== $this->ext ? $this->ext->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return managingScopeList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['manager'])) {
            $model->manager = $map['manager'];
        }
        if (isset($map['ext'])) {
            $model->ext = ext::fromMap($map['ext']);
        }

        return $model;
    }
}
