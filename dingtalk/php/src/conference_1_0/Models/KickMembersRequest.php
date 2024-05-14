<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\KickMembersRequest\userList;
use AlibabaCloud\Tea\Model;

class KickMembersRequest extends Model
{
    /**
     * @var bool
     */
    public $forbiddenRejoin;

    /**
     * @description This parameter is required.
     *
     * @var userList[]
     */
    public $userList;
    protected $_name = [
        'forbiddenRejoin' => 'forbiddenRejoin',
        'userList'        => 'userList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->forbiddenRejoin) {
            $res['forbiddenRejoin'] = $this->forbiddenRejoin;
        }
        if (null !== $this->userList) {
            $res['userList'] = [];
            if (null !== $this->userList && \is_array($this->userList)) {
                $n = 0;
                foreach ($this->userList as $item) {
                    $res['userList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return KickMembersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['forbiddenRejoin'])) {
            $model->forbiddenRejoin = $map['forbiddenRejoin'];
        }
        if (isset($map['userList'])) {
            if (!empty($map['userList'])) {
                $model->userList = [];
                $n               = 0;
                foreach ($map['userList'] as $item) {
                    $model->userList[$n++] = null !== $item ? userList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
