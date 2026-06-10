<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListUserGroupMembersResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListUserGroupMembersResponseBody\result\members;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bool
     */
    public $hasMore;

    /**
     * @var members[]
     */
    public $members;

    /**
     * @var int
     */
    public $nextOffset;
    protected $_name = [
        'hasMore' => 'hasMore',
        'members' => 'members',
        'nextOffset' => 'nextOffset',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->members) {
            $res['members'] = [];
            if (null !== $this->members && \is_array($this->members)) {
                $n = 0;
                foreach ($this->members as $item) {
                    $res['members'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->nextOffset) {
            $res['nextOffset'] = $this->nextOffset;
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
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['members'])) {
            if (!empty($map['members'])) {
                $model->members = [];
                $n = 0;
                foreach ($map['members'] as $item) {
                    $model->members[$n++] = null !== $item ? members::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['nextOffset'])) {
            $model->nextOffset = $map['nextOffset'];
        }

        return $model;
    }
}
