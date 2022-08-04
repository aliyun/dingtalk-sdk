<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeListStudentInfoResponseBody\studentInfoSimpleList;
use AlibabaCloud\Tea\Model;

class CollegeListStudentInfoResponseBody extends Model
{
    /**
     * @description 学生信息列表
     *
     * @var studentInfoSimpleList[]
     */
    public $studentInfoSimpleList;

    /**
     * @description 条目总数
     *
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'studentInfoSimpleList' => 'studentInfoSimpleList',
        'totalCount'            => 'totalCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->studentInfoSimpleList) {
            $res['studentInfoSimpleList'] = [];
            if (null !== $this->studentInfoSimpleList && \is_array($this->studentInfoSimpleList)) {
                $n = 0;
                foreach ($this->studentInfoSimpleList as $item) {
                    $res['studentInfoSimpleList'][$n++] = null !== $item ? $item->toMap() : $item;
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
     * @return CollegeListStudentInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['studentInfoSimpleList'])) {
            if (!empty($map['studentInfoSimpleList'])) {
                $model->studentInfoSimpleList = [];
                $n                            = 0;
                foreach ($map['studentInfoSimpleList'] as $item) {
                    $model->studentInfoSimpleList[$n++] = null !== $item ? studentInfoSimpleList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
