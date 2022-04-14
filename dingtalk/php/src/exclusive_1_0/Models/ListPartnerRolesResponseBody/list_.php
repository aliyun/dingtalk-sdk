<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListPartnerRolesResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListPartnerRolesResponseBody\list_\visibleDepts;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListPartnerRolesResponseBody\list_\visibleUsers;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListPartnerRolesResponseBody\list_\warningDepts;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListPartnerRolesResponseBody\list_\warningUsers;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 角色id
     *
     * @var int
     */
    public $id;

    /**
     * @description 是否必邀角色
     *
     * @var int
     */
    public $isNecessary;

    /**
     * @description 角色名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 可见部门
     *
     * @var visibleDepts[]
     */
    public $visibleDepts;

    /**
     * @description 可见员工
     *
     * @var visibleUsers[]
     */
    public $visibleUsers;

    /**
     * @description 预警部门
     *
     * @var warningDepts[]
     */
    public $warningDepts;

    /**
     * @description 预警成员
     *
     * @var warningUsers[]
     */
    public $warningUsers;
    protected $_name = [
        'id'           => 'id',
        'isNecessary'  => 'isNecessary',
        'name'         => 'name',
        'visibleDepts' => 'visibleDepts',
        'visibleUsers' => 'visibleUsers',
        'warningDepts' => 'warningDepts',
        'warningUsers' => 'warningUsers',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->isNecessary) {
            $res['isNecessary'] = $this->isNecessary;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->visibleDepts) {
            $res['visibleDepts'] = [];
            if (null !== $this->visibleDepts && \is_array($this->visibleDepts)) {
                $n = 0;
                foreach ($this->visibleDepts as $item) {
                    $res['visibleDepts'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->visibleUsers) {
            $res['visibleUsers'] = [];
            if (null !== $this->visibleUsers && \is_array($this->visibleUsers)) {
                $n = 0;
                foreach ($this->visibleUsers as $item) {
                    $res['visibleUsers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->warningDepts) {
            $res['warningDepts'] = [];
            if (null !== $this->warningDepts && \is_array($this->warningDepts)) {
                $n = 0;
                foreach ($this->warningDepts as $item) {
                    $res['warningDepts'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->warningUsers) {
            $res['warningUsers'] = [];
            if (null !== $this->warningUsers && \is_array($this->warningUsers)) {
                $n = 0;
                foreach ($this->warningUsers as $item) {
                    $res['warningUsers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['isNecessary'])) {
            $model->isNecessary = $map['isNecessary'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['visibleDepts'])) {
            if (!empty($map['visibleDepts'])) {
                $model->visibleDepts = [];
                $n                   = 0;
                foreach ($map['visibleDepts'] as $item) {
                    $model->visibleDepts[$n++] = null !== $item ? visibleDepts::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['visibleUsers'])) {
            if (!empty($map['visibleUsers'])) {
                $model->visibleUsers = [];
                $n                   = 0;
                foreach ($map['visibleUsers'] as $item) {
                    $model->visibleUsers[$n++] = null !== $item ? visibleUsers::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['warningDepts'])) {
            if (!empty($map['warningDepts'])) {
                $model->warningDepts = [];
                $n                   = 0;
                foreach ($map['warningDepts'] as $item) {
                    $model->warningDepts[$n++] = null !== $item ? warningDepts::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['warningUsers'])) {
            if (!empty($map['warningUsers'])) {
                $model->warningUsers = [];
                $n                   = 0;
                foreach ($map['warningUsers'] as $item) {
                    $model->warningUsers[$n++] = null !== $item ? warningUsers::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
