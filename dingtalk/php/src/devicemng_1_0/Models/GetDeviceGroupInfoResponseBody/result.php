<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\GetDeviceGroupInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\GetDeviceGroupInfoResponseBody\result\devices;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var devices[]
     */
    public $devices;

    /**
     * @var string
     */
    public $ownerUser;

    /**
     * @var string[]
     */
    public $subAdminUsers;

    /**
     * @var string
     */
    public $title;

    /**
     * @var string[]
     */
    public $users;
    protected $_name = [
        'devices'       => 'devices',
        'ownerUser'     => 'ownerUser',
        'subAdminUsers' => 'subAdminUsers',
        'title'         => 'title',
        'users'         => 'users',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->devices) {
            $res['devices'] = [];
            if (null !== $this->devices && \is_array($this->devices)) {
                $n = 0;
                foreach ($this->devices as $item) {
                    $res['devices'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->ownerUser) {
            $res['ownerUser'] = $this->ownerUser;
        }
        if (null !== $this->subAdminUsers) {
            $res['subAdminUsers'] = $this->subAdminUsers;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->users) {
            $res['users'] = $this->users;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['devices'])) {
            if (!empty($map['devices'])) {
                $model->devices = [];
                $n              = 0;
                foreach ($map['devices'] as $item) {
                    $model->devices[$n++] = null !== $item ? devices::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['ownerUser'])) {
            $model->ownerUser = $map['ownerUser'];
        }
        if (isset($map['subAdminUsers'])) {
            if (!empty($map['subAdminUsers'])) {
                $model->subAdminUsers = $map['subAdminUsers'];
            }
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['users'])) {
            $model->users = $map['users'];
        }

        return $model;
    }
}
