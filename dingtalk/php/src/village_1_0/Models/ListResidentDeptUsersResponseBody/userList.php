<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListResidentDeptUsersResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListResidentDeptUsersResponseBody\userList\roles;
use AlibabaCloud\Tea\Model;

class userList extends Model
{
    /**
     * @var string
     */
    public $feature;

    /**
     * @var string
     */
    public $name;

    /**
     * @var roles[]
     */
    public $roles;

    /**
     * @var string
     */
    public $unionId;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'feature' => 'feature',
        'name'    => 'name',
        'roles'   => 'roles',
        'unionId' => 'unionId',
        'userId'  => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->feature) {
            $res['feature'] = $this->feature;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->roles) {
            $res['roles'] = [];
            if (null !== $this->roles && \is_array($this->roles)) {
                $n = 0;
                foreach ($this->roles as $item) {
                    $res['roles'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return userList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['feature'])) {
            $model->feature = $map['feature'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['roles'])) {
            if (!empty($map['roles'])) {
                $model->roles = [];
                $n            = 0;
                foreach ($map['roles'] as $item) {
                    $model->roles[$n++] = null !== $item ? roles::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
