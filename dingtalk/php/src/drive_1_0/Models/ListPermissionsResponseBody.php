<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListPermissionsResponseBody\members;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListPermissionsResponseBody\outMembers;
use AlibabaCloud\Tea\Model;

class ListPermissionsResponseBody extends Model
{
    /**
     * @description 企业内成员权限列表
     *
     * @var members[]
     */
    public $members;

    /**
     * @description 企业外成员权限列表
     *
     * @var outMembers[]
     */
    public $outMembers;
    protected $_name = [
        'members'    => 'members',
        'outMembers' => 'outMembers',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->members) {
            $res['members'] = [];
            if (null !== $this->members && \is_array($this->members)) {
                $n = 0;
                foreach ($this->members as $item) {
                    $res['members'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->outMembers) {
            $res['outMembers'] = [];
            if (null !== $this->outMembers && \is_array($this->outMembers)) {
                $n = 0;
                foreach ($this->outMembers as $item) {
                    $res['outMembers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListPermissionsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['members'])) {
            if (!empty($map['members'])) {
                $model->members = [];
                $n              = 0;
                foreach ($map['members'] as $item) {
                    $model->members[$n++] = null !== $item ? members::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['outMembers'])) {
            if (!empty($map['outMembers'])) {
                $model->outMembers = [];
                $n                 = 0;
                foreach ($map['outMembers'] as $item) {
                    $model->outMembers[$n++] = null !== $item ? outMembers::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
