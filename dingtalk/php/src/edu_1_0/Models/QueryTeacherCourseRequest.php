<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryTeacherCourseRequest extends Model
{
    /**
     * @example dingxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @example ISV_XXX
     *
     * @var string
     */
    public $isvCode;

    /**
     * @var string[]
     */
    public $isvCourseIdList;

    /**
     * @example staffxxx
     *
     * @var string
     */
    public $teacherUserId;
    protected $_name = [
        'corpId'          => 'corpId',
        'isvCode'         => 'isvCode',
        'isvCourseIdList' => 'isvCourseIdList',
        'teacherUserId'   => 'teacherUserId',
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
        if (null !== $this->isvCourseIdList) {
            $res['isvCourseIdList'] = $this->isvCourseIdList;
        }
        if (null !== $this->teacherUserId) {
            $res['teacherUserId'] = $this->teacherUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryTeacherCourseRequest
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
        if (isset($map['isvCourseIdList'])) {
            if (!empty($map['isvCourseIdList'])) {
                $model->isvCourseIdList = $map['isvCourseIdList'];
            }
        }
        if (isset($map['teacherUserId'])) {
            $model->teacherUserId = $map['teacherUserId'];
        }

        return $model;
    }
}
