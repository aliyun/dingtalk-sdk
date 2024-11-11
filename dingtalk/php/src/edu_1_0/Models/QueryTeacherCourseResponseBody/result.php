<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryTeacherCourseResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryTeacherCourseResponseBody\result\teacherCourseDetailItemList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $isvCode;

    /**
     * @var teacherCourseDetailItemList[]
     */
    public $teacherCourseDetailItemList;

    /**
     * @var string
     */
    public $teacherName;

    /**
     * @var string
     */
    public $teacherUserId;
    protected $_name = [
        'corpId'                      => 'corpId',
        'isvCode'                     => 'isvCode',
        'teacherCourseDetailItemList' => 'teacherCourseDetailItemList',
        'teacherName'                 => 'teacherName',
        'teacherUserId'               => 'teacherUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->isvCode) {
            $res['isvCode'] = $this->isvCode;
        }
        if (null !== $this->teacherCourseDetailItemList) {
            $res['teacherCourseDetailItemList'] = [];
            if (null !== $this->teacherCourseDetailItemList && \is_array($this->teacherCourseDetailItemList)) {
                $n = 0;
                foreach ($this->teacherCourseDetailItemList as $item) {
                    $res['teacherCourseDetailItemList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->teacherName) {
            $res['teacherName'] = $this->teacherName;
        }
        if (null !== $this->teacherUserId) {
            $res['teacherUserId'] = $this->teacherUserId;
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['isvCode'])) {
            $model->isvCode = $map['isvCode'];
        }
        if (isset($map['teacherCourseDetailItemList'])) {
            if (!empty($map['teacherCourseDetailItemList'])) {
                $model->teacherCourseDetailItemList = [];
                $n                                  = 0;
                foreach ($map['teacherCourseDetailItemList'] as $item) {
                    $model->teacherCourseDetailItemList[$n++] = null !== $item ? teacherCourseDetailItemList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['teacherName'])) {
            $model->teacherName = $map['teacherName'];
        }
        if (isset($map['teacherUserId'])) {
            $model->teacherUserId = $map['teacherUserId'];
        }

        return $model;
    }
}
