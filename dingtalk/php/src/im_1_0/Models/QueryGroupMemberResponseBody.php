<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberResponseBody\groupMembers;
use AlibabaCloud\Tea\Model;

class QueryGroupMemberResponseBody extends Model
{
    /**
     * @description 群成员列表。
     *
     * @var groupMembers[]
     */
    public $groupMembers;

    /**
     * @description 群会话Id。
     *
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'groupMembers'       => 'groupMembers',
        'openConversationId' => 'openConversationId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupMembers) {
            $res['groupMembers'] = [];
            if (null !== $this->groupMembers && \is_array($this->groupMembers)) {
                $n = 0;
                foreach ($this->groupMembers as $item) {
                    $res['groupMembers'][$n++] = null !== $item ? $item->toMap() : $item;
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
     * @return QueryGroupMemberResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupMembers'])) {
            if (!empty($map['groupMembers'])) {
                $model->groupMembers = [];
                $n                   = 0;
                foreach ($map['groupMembers'] as $item) {
                    $model->groupMembers[$n++] = null !== $item ? groupMembers::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
