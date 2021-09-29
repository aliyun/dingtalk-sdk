<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryActiveUsersResponseBody\activeUserInfos;
use AlibabaCloud\Tea\Model;

class QueryActiveUsersResponseBody extends Model
{
    /**
     * @description 活跃用户列表
     *
     * @var activeUserInfos[]
     */
    public $activeUserInfos;
    protected $_name = [
        'activeUserInfos' => 'activeUserInfos',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->activeUserInfos) {
            $res['activeUserInfos'] = [];
            if (null !== $this->activeUserInfos && \is_array($this->activeUserInfos)) {
                $n = 0;
                foreach ($this->activeUserInfos as $item) {
                    $res['activeUserInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryActiveUsersResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activeUserInfos'])) {
            if (!empty($map['activeUserInfos'])) {
                $model->activeUserInfos = [];
                $n                      = 0;
                foreach ($map['activeUserInfos'] as $item) {
                    $model->activeUserInfos[$n++] = null !== $item ? activeUserInfos::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
