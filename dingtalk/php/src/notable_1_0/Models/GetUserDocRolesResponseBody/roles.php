<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetUserDocRolesResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetUserDocRolesResponseBody\roles\subRoles;
use AlibabaCloud\Tea\Model;

class roles extends Model
{
    /**
     * @var string
     */
    public $flowType;

    /**
     * @var int
     */
    public $id;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $roleType;

    /**
     * @var subRoles[]
     */
    public $subRoles;
    protected $_name = [
        'flowType' => 'flowType',
        'id' => 'id',
        'name' => 'name',
        'roleType' => 'roleType',
        'subRoles' => 'subRoles',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->flowType) {
            $res['flowType'] = $this->flowType;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->roleType) {
            $res['roleType'] = $this->roleType;
        }
        if (null !== $this->subRoles) {
            $res['subRoles'] = [];
            if (null !== $this->subRoles && \is_array($this->subRoles)) {
                $n = 0;
                foreach ($this->subRoles as $item) {
                    $res['subRoles'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return roles
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['flowType'])) {
            $model->flowType = $map['flowType'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['roleType'])) {
            $model->roleType = $map['roleType'];
        }
        if (isset($map['subRoles'])) {
            if (!empty($map['subRoles'])) {
                $model->subRoles = [];
                $n = 0;
                foreach ($map['subRoles'] as $item) {
                    $model->subRoles[$n++] = null !== $item ? subRoles::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
