<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class ECertQueryResponseBody extends Model
{
    /**
     * @description 身份证号码
     *
     * @var string
     */
    public $certNO;

    /**
     * @description 职务ID
     *
     * @var string
     */
    public $employJobId;

    /**
     * @description 职务名称
     *
     * @var string
     */
    public $employJobIdLabel;

    /**
     * @description 职位ID
     *
     * @var string
     */
    public $employPositionId;

    /**
     * @description 职位名称
     *
     * @var string
     */
    public $employPositionIdLabel;

    /**
     * @description 职级ID
     *
     * @var string
     */
    public $employPositionRankId;

    /**
     * @description 职级名称
     *
     * @var string
     */
    public $employPositionRankIdLabel;

    /**
     * @description 入职日期
     *
     * @var string
     */
    public $hiredDate;

    /**
     * @description 离职日期
     *
     * @var string
     */
    public $lastWorkDay;

    /**
     * @description 主部门ID
     *
     * @var int
     */
    public $mainDeptId;

    /**
     * @description 主部门
     *
     * @var string
     */
    public $mainDeptName;

    /**
     * @description 姓名
     *
     * @var string
     */
    public $name;

    /**
     * @description 身份证姓名
     *
     * @var string
     */
    public $realName;

    /**
     * @description 被动离职原因
     *
     * @var string[]
     */
    public $terminationReasonPassive;

    /**
     * @description 主动离职原因
     *
     * @var string[]
     */
    public $terminationReasonVoluntary;
    protected $_name = [
        'certNO'                     => 'certNO',
        'employJobId'                => 'employJobId',
        'employJobIdLabel'           => 'employJobIdLabel',
        'employPositionId'           => 'employPositionId',
        'employPositionIdLabel'      => 'employPositionIdLabel',
        'employPositionRankId'       => 'employPositionRankId',
        'employPositionRankIdLabel'  => 'employPositionRankIdLabel',
        'hiredDate'                  => 'hiredDate',
        'lastWorkDay'                => 'lastWorkDay',
        'mainDeptId'                 => 'mainDeptId',
        'mainDeptName'               => 'mainDeptName',
        'name'                       => 'name',
        'realName'                   => 'realName',
        'terminationReasonPassive'   => 'terminationReasonPassive',
        'terminationReasonVoluntary' => 'terminationReasonVoluntary',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->certNO) {
            $res['certNO'] = $this->certNO;
        }
        if (null !== $this->employJobId) {
            $res['employJobId'] = $this->employJobId;
        }
        if (null !== $this->employJobIdLabel) {
            $res['employJobIdLabel'] = $this->employJobIdLabel;
        }
        if (null !== $this->employPositionId) {
            $res['employPositionId'] = $this->employPositionId;
        }
        if (null !== $this->employPositionIdLabel) {
            $res['employPositionIdLabel'] = $this->employPositionIdLabel;
        }
        if (null !== $this->employPositionRankId) {
            $res['employPositionRankId'] = $this->employPositionRankId;
        }
        if (null !== $this->employPositionRankIdLabel) {
            $res['employPositionRankIdLabel'] = $this->employPositionRankIdLabel;
        }
        if (null !== $this->hiredDate) {
            $res['hiredDate'] = $this->hiredDate;
        }
        if (null !== $this->lastWorkDay) {
            $res['lastWorkDay'] = $this->lastWorkDay;
        }
        if (null !== $this->mainDeptId) {
            $res['mainDeptId'] = $this->mainDeptId;
        }
        if (null !== $this->mainDeptName) {
            $res['mainDeptName'] = $this->mainDeptName;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->realName) {
            $res['realName'] = $this->realName;
        }
        if (null !== $this->terminationReasonPassive) {
            $res['terminationReasonPassive'] = $this->terminationReasonPassive;
        }
        if (null !== $this->terminationReasonVoluntary) {
            $res['terminationReasonVoluntary'] = $this->terminationReasonVoluntary;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ECertQueryResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['certNO'])) {
            $model->certNO = $map['certNO'];
        }
        if (isset($map['employJobId'])) {
            $model->employJobId = $map['employJobId'];
        }
        if (isset($map['employJobIdLabel'])) {
            $model->employJobIdLabel = $map['employJobIdLabel'];
        }
        if (isset($map['employPositionId'])) {
            $model->employPositionId = $map['employPositionId'];
        }
        if (isset($map['employPositionIdLabel'])) {
            $model->employPositionIdLabel = $map['employPositionIdLabel'];
        }
        if (isset($map['employPositionRankId'])) {
            $model->employPositionRankId = $map['employPositionRankId'];
        }
        if (isset($map['employPositionRankIdLabel'])) {
            $model->employPositionRankIdLabel = $map['employPositionRankIdLabel'];
        }
        if (isset($map['hiredDate'])) {
            $model->hiredDate = $map['hiredDate'];
        }
        if (isset($map['lastWorkDay'])) {
            $model->lastWorkDay = $map['lastWorkDay'];
        }
        if (isset($map['mainDeptId'])) {
            $model->mainDeptId = $map['mainDeptId'];
        }
        if (isset($map['mainDeptName'])) {
            $model->mainDeptName = $map['mainDeptName'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['realName'])) {
            $model->realName = $map['realName'];
        }
        if (isset($map['terminationReasonPassive'])) {
            if (!empty($map['terminationReasonPassive'])) {
                $model->terminationReasonPassive = $map['terminationReasonPassive'];
            }
        }
        if (isset($map['terminationReasonVoluntary'])) {
            if (!empty($map['terminationReasonVoluntary'])) {
                $model->terminationReasonVoluntary = $map['terminationReasonVoluntary'];
            }
        }

        return $model;
    }
}
