<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\ListWorkBenchGroupResponseBody\groupList;
use AlibabaCloud\Tea\Model;

class ListWorkBenchGroupResponseBody extends Model
{
    /**
     * @description 应用列表
     *
     * @var groupList[]
     */
    public $groupList;
    protected $_name = [
        'groupList' => 'groupList',
    ];

    public function validate()
    {
    }

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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListWorkBenchGroupResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupList'])) {
            if (!empty($map['groupList'])) {
                $model->groupList = [];
                $n                = 0;
                foreach ($map['groupList'] as $item) {
                    $model->groupList[$n++] = null !== $item ? groupList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
