<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreUpdateAuthInfoRequest;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreUpdateAuthInfoRequest\updateUserList\roleList;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreUpdateAuthInfoRequest\updateUserList\userAuthList;
use AlibabaCloud\Tea\Model;

class updateUserList extends Model
{
    /**
     * @var roleList[]
     */
    public $roleList;

    /**
     * @var userAuthList[]
     */
    public $userAuthList;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'roleList'     => 'roleList',
        'userAuthList' => 'userAuthList',
        'userId'       => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->roleList) {
            $res['roleList'] = [];
            if (null !== $this->roleList && \is_array($this->roleList)) {
                $n = 0;
                foreach ($this->roleList as $item) {
                    $res['roleList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userAuthList) {
            $res['userAuthList'] = [];
            if (null !== $this->userAuthList && \is_array($this->userAuthList)) {
                $n = 0;
                foreach ($this->userAuthList as $item) {
                    $res['userAuthList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return updateUserList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['roleList'])) {
            if (!empty($map['roleList'])) {
                $model->roleList = [];
                $n               = 0;
                foreach ($map['roleList'] as $item) {
                    $model->roleList[$n++] = null !== $item ? roleList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['userAuthList'])) {
            if (!empty($map['userAuthList'])) {
                $model->userAuthList = [];
                $n                   = 0;
                foreach ($map['userAuthList'] as $item) {
                    $model->userAuthList[$n++] = null !== $item ? userAuthList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
