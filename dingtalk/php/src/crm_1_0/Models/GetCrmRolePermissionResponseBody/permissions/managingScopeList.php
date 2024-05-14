<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmRolePermissionResponseBody\permissions;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmRolePermissionResponseBody\permissions\managingScopeList\ext;
use AlibabaCloud\Tea\Model;

class managingScopeList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var ext
     */
    public $ext;

    /**
     * @description This parameter is required.
     *
     * @example false 如果是主管，要做逻辑的单独处理。比如如果设置了管理下属或当前部门，只管理他是主管的部门
     *
     * @var bool
     */
    public $manager;

    /**
     * @description This parameter is required.
     *
     * @example 10_own 自己负责的 15_all_org 全公司 20_selfDept 同层级 30_selfSubDept 下属的 40_customized 自定义的
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'ext'     => 'ext',
        'manager' => 'manager',
        'type'    => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->ext) {
            $res['ext'] = null !== $this->ext ? $this->ext->toMap() : null;
        }
        if (null !== $this->manager) {
            $res['manager'] = $this->manager;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
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
        if (isset($map['ext'])) {
            $model->ext = ext::fromMap($map['ext']);
        }
        if (isset($map['manager'])) {
            $model->manager = $map['manager'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
