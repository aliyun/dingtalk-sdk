<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberByAppUidsResponseBody\groupMembers;
use AlibabaCloud\Tea\Model;

class QueryGroupMemberByAppUidsResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var groupMembers[]
     */
    public $groupMembers;
    protected $_name = [
        'groupMembers' => 'groupMembers',
    ];

    public function validate() {}

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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryGroupMemberByAppUidsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupMembers'])) {
            if (!empty($map['groupMembers'])) {
                $model->groupMembers = [];
                $n = 0;
                foreach ($map['groupMembers'] as $item) {
                    $model->groupMembers[$n++] = null !== $item ? groupMembers::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
