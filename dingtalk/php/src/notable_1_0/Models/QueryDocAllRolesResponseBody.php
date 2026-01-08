<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\QueryDocAllRolesResponseBody\allRoles;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\QueryDocAllRolesResponseBody\defaultRole;
use AlibabaCloud\Tea\Model;

class QueryDocAllRolesResponseBody extends Model
{
    /**
     * @var allRoles[]
     */
    public $allRoles;

    /**
     * @var defaultRole
     */
    public $defaultRole;

    /**
     * @var bool
     */
    public $enabled;

    /**
     * @var int[]
     */
    public $systemRoles;
    protected $_name = [
        'allRoles' => 'allRoles',
        'defaultRole' => 'defaultRole',
        'enabled' => 'enabled',
        'systemRoles' => 'systemRoles',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->allRoles) {
            $res['allRoles'] = [];
            if (null !== $this->allRoles && \is_array($this->allRoles)) {
                $n = 0;
                foreach ($this->allRoles as $item) {
                    $res['allRoles'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->defaultRole) {
            $res['defaultRole'] = null !== $this->defaultRole ? $this->defaultRole->toMap() : null;
        }
        if (null !== $this->enabled) {
            $res['enabled'] = $this->enabled;
        }
        if (null !== $this->systemRoles) {
            $res['systemRoles'] = $this->systemRoles;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryDocAllRolesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['allRoles'])) {
            if (!empty($map['allRoles'])) {
                $model->allRoles = [];
                $n = 0;
                foreach ($map['allRoles'] as $item) {
                    $model->allRoles[$n++] = null !== $item ? allRoles::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['defaultRole'])) {
            $model->defaultRole = defaultRole::fromMap($map['defaultRole']);
        }
        if (isset($map['enabled'])) {
            $model->enabled = $map['enabled'];
        }
        if (isset($map['systemRoles'])) {
            if (!empty($map['systemRoles'])) {
                $model->systemRoles = $map['systemRoles'];
            }
        }

        return $model;
    }
}
