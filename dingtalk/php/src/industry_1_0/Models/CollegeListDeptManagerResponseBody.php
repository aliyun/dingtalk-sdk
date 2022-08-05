<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeListDeptManagerResponseBody\managerInfoSimpleList;
use AlibabaCloud\Tea\Model;

class CollegeListDeptManagerResponseBody extends Model
{
    /**
     * @description 负责人信息列表
     *
     * @var managerInfoSimpleList[]
     */
    public $managerInfoSimpleList;

    /**
     * @description 数据总条目数
     *
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'managerInfoSimpleList' => 'managerInfoSimpleList',
        'totalCount'            => 'totalCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->managerInfoSimpleList) {
            $res['managerInfoSimpleList'] = [];
            if (null !== $this->managerInfoSimpleList && \is_array($this->managerInfoSimpleList)) {
                $n = 0;
                foreach ($this->managerInfoSimpleList as $item) {
                    $res['managerInfoSimpleList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CollegeListDeptManagerResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['managerInfoSimpleList'])) {
            if (!empty($map['managerInfoSimpleList'])) {
                $model->managerInfoSimpleList = [];
                $n                            = 0;
                foreach ($map['managerInfoSimpleList'] as $item) {
                    $model->managerInfoSimpleList[$n++] = null !== $item ? managerInfoSimpleList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
