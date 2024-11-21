<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryCollegeContactUserDetailResponseBody\result;

use AlibabaCloud\Tea\Model;

class deptPositionSet extends Model
{
    /**
     * @example 123456
     *
     * @var int
     */
    public $deptId;

    /**
     * @var bool
     */
    public $isMain;

    /**
     * @example 001
     *
     * @var string
     */
    public $managerUserId;

    /**
     * @example 学工处处长
     *
     * @var string
     */
    public $title;

    /**
     * @example 学工处办公室
     *
     * @var string
     */
    public $workPlace;
    protected $_name = [
        'deptId'        => 'deptId',
        'isMain'        => 'isMain',
        'managerUserId' => 'managerUserId',
        'title'         => 'title',
        'workPlace'     => 'workPlace',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->isMain) {
            $res['isMain'] = $this->isMain;
        }
        if (null !== $this->managerUserId) {
            $res['managerUserId'] = $this->managerUserId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->workPlace) {
            $res['workPlace'] = $this->workPlace;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return deptPositionSet
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['isMain'])) {
            $model->isMain = $map['isMain'];
        }
        if (isset($map['managerUserId'])) {
            $model->managerUserId = $map['managerUserId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['workPlace'])) {
            $model->workPlace = $map['workPlace'];
        }

        return $model;
    }
}
