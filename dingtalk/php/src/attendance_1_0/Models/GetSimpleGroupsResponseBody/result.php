<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetSimpleGroupsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetSimpleGroupsResponseBody\result\groups;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example []
     *
     * @var groups[]
     */
    public $groups;

    /**
     * @example true
     *
     * @var bool
     */
    public $hasMore;
    protected $_name = [
        'groups' => 'groups',
        'hasMore' => 'hasMore',
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

        return $model;
    }
}
