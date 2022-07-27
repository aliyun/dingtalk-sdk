<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListBasicRoleInPageResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListBasicRoleInPageResponseBody\list_\openAction;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListBasicRoleInPageResponseBody\list_\openMembers;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var openAction
     */
    public $openAction;

    /**
     * @var openMembers[]
     */
    public $openMembers;

    /**
     * @var string[]
     */
    public $openResources;

    /**
     * @var string
     */
    public $openRoleId;

    /**
     * @var string
     */
    public $openRoleName;
    protected $_name = [
        'openAction'    => 'openAction',
        'openMembers'   => 'openMembers',
        'openResources' => 'openResources',
        'openRoleId'    => 'openRoleId',
        'openRoleName'  => 'openRoleName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openAction) {
            $res['openAction'] = null !== $this->openAction ? $this->openAction->toMap() : null;
        }
        if (null !== $this->openMembers) {
            $res['openMembers'] = [];
            if (null !== $this->openMembers && \is_array($this->openMembers)) {
                $n = 0;
                foreach ($this->openMembers as $item) {
                    $res['openMembers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->openResources) {
            $res['openResources'] = $this->openResources;
        }
        if (null !== $this->openRoleId) {
            $res['openRoleId'] = $this->openRoleId;
        }
        if (null !== $this->openRoleName) {
            $res['openRoleName'] = $this->openRoleName;
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
        if (isset($map['openAction'])) {
            $model->openAction = openAction::fromMap($map['openAction']);
        }
        if (isset($map['openMembers'])) {
            if (!empty($map['openMembers'])) {
                $model->openMembers = [];
                $n                  = 0;
                foreach ($map['openMembers'] as $item) {
                    $model->openMembers[$n++] = null !== $item ? openMembers::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['openResources'])) {
            if (!empty($map['openResources'])) {
                $model->openResources = $map['openResources'];
            }
        }
        if (isset($map['openRoleId'])) {
            $model->openRoleId = $map['openRoleId'];
        }
        if (isset($map['openRoleName'])) {
            $model->openRoleName = $map['openRoleName'];
        }

        return $model;
    }
}
