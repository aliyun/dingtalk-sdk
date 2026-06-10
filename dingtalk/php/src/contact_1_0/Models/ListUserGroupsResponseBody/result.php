<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListUserGroupsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListUserGroupsResponseBody\result\groups;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var groups[]
     */
    public $groups;

    /**
     * @var bool
     */
    public $hasMore;

    /**
     * @var int
     */
    public $nextOffset;
    protected $_name = [
        'groups' => 'groups',
        'hasMore' => 'hasMore',
        'nextOffset' => 'nextOffset',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->groups) {
            $res['groups'] = [];
            if (null !== $this->groups && \is_array($this->groups)) {
                $n = 0;
                foreach ($this->groups as $item) {
                    $res['groups'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
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
        if (isset($map['groups'])) {
            if (!empty($map['groups'])) {
                $model->groups = [];
                $n = 0;
                foreach ($map['groups'] as $item) {
                    $model->groups[$n++] = null !== $item ? groups::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['nextOffset'])) {
            $model->nextOffset = $map['nextOffset'];
        }

        return $model;
    }
}
