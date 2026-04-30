<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\BatchGetUserResponseBody\userList;
use AlibabaCloud\Tea\Model;

class BatchGetUserResponseBody extends Model
{
    /**
     * @var string[]
     */
    public $unauthorizedUserIdList;

    /**
     * @var userList[]
     */
    public $userList;
    protected $_name = [
        'unauthorizedUserIdList' => 'unauthorizedUserIdList',
        'userList' => 'userList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->unauthorizedUserIdList) {
            $res['unauthorizedUserIdList'] = $this->unauthorizedUserIdList;
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
     * @return BatchGetUserResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['unauthorizedUserIdList'])) {
            if (!empty($map['unauthorizedUserIdList'])) {
                $model->unauthorizedUserIdList = $map['unauthorizedUserIdList'];
            }
        }
        if (isset($map['userList'])) {
            if (!empty($map['userList'])) {
                $model->userList = [];
                $n = 0;
                foreach ($map['userList'] as $item) {
                    $model->userList[$n++] = null !== $item ? userList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
