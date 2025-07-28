<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOutGroupsByPageResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOutGroupsByPageResponseBody\responseBody\groupList;
use AlibabaCloud\Tea\Model;

class responseBody extends Model
{
    /**
     * @var groupList[]
     */
    public $groupList;

    /**
     * @example 10
     *
     * @var int
     */
    public $total;
    protected $_name = [
        'groupList' => 'groupList',
        'total' => 'total',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupList) {
            $res['groupList'] = [];
            if (null !== $this->groupList && \is_array($this->groupList)) {
                $n = 0;
                foreach ($this->groupList as $item) {
                    $res['groupList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return responseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupList'])) {
            if (!empty($map['groupList'])) {
                $model->groupList = [];
                $n = 0;
                foreach ($map['groupList'] as $item) {
                    $model->groupList[$n++] = null !== $item ? groupList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }

        return $model;
    }
}
