<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetOpenCoursesResponseBody\courseList;
use AlibabaCloud\Tea\Model;

class GetOpenCoursesResponseBody extends Model
{
    /**
     * @var courseList[]
     */
    public $courseList;

    /**
     * @description 总记录数
     *
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'courseList' => 'courseList',
        'totalCount' => 'totalCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->courseList) {
            $res['courseList'] = [];
            if (null !== $this->courseList && \is_array($this->courseList)) {
                $n = 0;
                foreach ($this->courseList as $item) {
                    $res['courseList'][$n++] = null !== $item ? $item->toMap() : $item;
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
     * @return GetOpenCoursesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['courseList'])) {
            if (!empty($map['courseList'])) {
                $model->courseList = [];
                $n                 = 0;
                foreach ($map['courseList'] as $item) {
                    $model->courseList[$n++] = null !== $item ? courseList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
