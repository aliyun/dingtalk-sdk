<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class InvalidTeacherCourseRequest extends Model
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
    public $needDeleteCourseIdList;

    /**
     * @example staffxxx
     *
     * @var string
     */
    public $teacherUserId;
    protected $_name = [
        'corpId'                 => 'corpId',
        'isvCode'                => 'isvCode',
        'needDeleteCourseIdList' => 'needDeleteCourseIdList',
        'teacherUserId'          => 'teacherUserId',
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
        if (null !== $this->needDeleteCourseIdList) {
            $res['needDeleteCourseIdList'] = $this->needDeleteCourseIdList;
        }
        if (null !== $this->teacherUserId) {
            $res['teacherUserId'] = $this->teacherUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InvalidTeacherCourseRequest
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
        if (isset($map['needDeleteCourseIdList'])) {
            if (!empty($map['needDeleteCourseIdList'])) {
                $model->needDeleteCourseIdList = $map['needDeleteCourseIdList'];
            }
        }
        if (isset($map['teacherUserId'])) {
            $model->teacherUserId = $map['teacherUserId'];
        }

        return $model;
    }
}
