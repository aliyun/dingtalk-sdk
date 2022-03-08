<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryAllSubjectsFromClassScheduleResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryAllSubjectsFromClassScheduleResponseBody\result\ext\teacherList;
use AlibabaCloud\Tea\Model;

class ext extends Model
{
    /**
     * @description 学科背景颜色
     *
     * @var string
     */
    public $backgroundColor;

    /**
     * @description 班级id。
     *
     * @var int
     */
    public $classId;

    /**
     * @description 学科字体颜色
     *
     * @var string
     */
    public $fontColor;

    /**
     * @description 老师列表
     *
     * @var teacherList[]
     */
    public $teacherList;
    protected $_name = [
        'backgroundColor' => 'backgroundColor',
        'classId'         => 'classId',
        'fontColor'       => 'fontColor',
        'teacherList'     => 'teacherList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->backgroundColor) {
            $res['backgroundColor'] = $this->backgroundColor;
        }
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->fontColor) {
            $res['fontColor'] = $this->fontColor;
        }
        if (null !== $this->teacherList) {
            $res['teacherList'] = [];
            if (null !== $this->teacherList && \is_array($this->teacherList)) {
                $n = 0;
                foreach ($this->teacherList as $item) {
                    $res['teacherList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ext
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['backgroundColor'])) {
            $model->backgroundColor = $map['backgroundColor'];
        }
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['fontColor'])) {
            $model->fontColor = $map['fontColor'];
        }
        if (isset($map['teacherList'])) {
            if (!empty($map['teacherList'])) {
                $model->teacherList = [];
                $n                  = 0;
                foreach ($map['teacherList'] as $item) {
                    $model->teacherList[$n++] = null !== $item ? teacherList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
