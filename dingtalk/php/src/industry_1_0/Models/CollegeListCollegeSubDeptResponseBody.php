<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeListCollegeSubDeptResponseBody\collegeDeptInfoSimpleList;
use AlibabaCloud\Tea\Model;

class CollegeListCollegeSubDeptResponseBody extends Model
{
    /**
     * @description 部门信息列表
     *
     * @var collegeDeptInfoSimpleList[]
     */
    public $collegeDeptInfoSimpleList;
    protected $_name = [
        'collegeDeptInfoSimpleList' => 'collegeDeptInfoSimpleList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->collegeDeptInfoSimpleList) {
            $res['collegeDeptInfoSimpleList'] = [];
            if (null !== $this->collegeDeptInfoSimpleList && \is_array($this->collegeDeptInfoSimpleList)) {
                $n = 0;
                foreach ($this->collegeDeptInfoSimpleList as $item) {
                    $res['collegeDeptInfoSimpleList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CollegeListCollegeSubDeptResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['collegeDeptInfoSimpleList'])) {
            if (!empty($map['collegeDeptInfoSimpleList'])) {
                $model->collegeDeptInfoSimpleList = [];
                $n                                = 0;
                foreach ($map['collegeDeptInfoSimpleList'] as $item) {
                    $model->collegeDeptInfoSimpleList[$n++] = null !== $item ? collegeDeptInfoSimpleList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
