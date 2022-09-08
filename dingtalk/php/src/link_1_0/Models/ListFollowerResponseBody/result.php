<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\ListFollowerResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\ListFollowerResponseBody\result\userList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 下一页查询位置
     * 当此返回值不为空时，可以将此值设置为下一次查询的参数。
     * @var string
     */
    public $nextToken;

    /**
     * @description 用户列表
     *
     * @var userList[]
     */
    public $userList;
    protected $_name = [
        'nextToken' => 'nextToken',
        'userList'  => 'userList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
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
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
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
