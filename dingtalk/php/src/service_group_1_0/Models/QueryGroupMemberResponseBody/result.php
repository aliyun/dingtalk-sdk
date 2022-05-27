<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryGroupMemberResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryGroupMemberResponseBody\result\groupMemberList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 群成员列表
     *
     * @var groupMemberList[]
     */
    public $groupMemberList;

    /**
     * @description 群开放id
     *
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'groupMemberList'    => 'groupMemberList',
        'openConversationId' => 'openConversationId',
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
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
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
        if (isset($map['groupMemberList'])) {
            if (!empty($map['groupMemberList'])) {
                $model->groupMemberList = [];
                $n                      = 0;
                foreach ($map['groupMemberList'] as $item) {
                    $model->groupMemberList[$n++] = null !== $item ? groupMemberList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
