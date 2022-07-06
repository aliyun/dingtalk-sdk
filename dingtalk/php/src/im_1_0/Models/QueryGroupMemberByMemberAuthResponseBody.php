<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberByMemberAuthResponseBody\groupMemberList;
use AlibabaCloud\Tea\Model;

class QueryGroupMemberByMemberAuthResponseBody extends Model
{
    /**
     * @description 群成员列表
     *
     * @var groupMemberList[]
     */
    public $groupMemberList;
    protected $_name = [
        'groupMemberList' => 'groupMemberList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupMemberList) {
            $res['groupMemberList'] = [];
            if (null !== $this->groupMemberList && \is_array($this->groupMemberList)) {
                $n = 0;
                foreach ($this->groupMemberList as $item) {
                    $res['groupMemberList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryGroupMemberByMemberAuthResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupMemberList'])) {
            if (!empty($map['groupMemberList'])) {
                $model->groupMemberList = [];
                $n                      = 0;
                foreach ($map['groupMemberList'] as $item) {
                    $model->groupMemberList[$n++] = null !== $item ? groupMemberList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
