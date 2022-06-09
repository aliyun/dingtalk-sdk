<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDoctorsResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 考核医疗组id
     *
     * @var string
     */
    public $assessGroupId;

    /**
     * @description 考核医疗组名称
     *
     * @var string
     */
    public $assessGroupName;

    /**
     * @description 关联的部门id
     *
     * @var string
     */
    public $deptCode;

    /**
     * @description 科室医疗组标识
     *
     * @var string
     */
    public $deptType;

    /**
     * @description 用户创建时间
     *
     * @var string
     */
    public $gmtCreateStr;

    /**
     * @description 用户最后修改时间
     *
     * @var string
     */
    public $gmtModifiedStr;

    /**
     * @description 用户id
     *
     * @var int
     */
    public $id;

    /**
     * @description 工号
     *
     * @var string
     */
    public $jobNum;

    /**
     * @description 状态0-有效，1-删除
     *
     * @var int
     */
    public $status;

    /**
     * @description 租户下staffId
     *
     * @var string
     */
    public $uid;

    /**
     * @description 租户内staffId
     *
     * @var string
     */
    public $userCode;

    /**
     * @description 用户名称
     *
     * @var string
     */
    public $userName;
    protected $_name = [
        'assessGroupId'   => 'assessGroupId',
        'assessGroupName' => 'assessGroupName',
        'deptCode'        => 'deptCode',
        'deptType'        => 'deptType',
        'gmtCreateStr'    => 'gmtCreateStr',
        'gmtModifiedStr'  => 'gmtModifiedStr',
        'id'              => 'id',
        'jobNum'          => 'jobNum',
        'status'          => 'status',
        'uid'             => 'uid',
        'userCode'        => 'userCode',
        'userName'        => 'userName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->assessGroupId) {
            $res['assessGroupId'] = $this->assessGroupId;
        }
        if (null !== $this->assessGroupName) {
            $res['assessGroupName'] = $this->assessGroupName;
        }
        if (null !== $this->deptCode) {
            $res['deptCode'] = $this->deptCode;
        }
        if (null !== $this->deptType) {
            $res['deptType'] = $this->deptType;
        }
        if (null !== $this->gmtCreateStr) {
            $res['gmtCreateStr'] = $this->gmtCreateStr;
        }
        if (null !== $this->gmtModifiedStr) {
            $res['gmtModifiedStr'] = $this->gmtModifiedStr;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->jobNum) {
            $res['jobNum'] = $this->jobNum;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->uid) {
            $res['uid'] = $this->uid;
        }
        if (null !== $this->userCode) {
            $res['userCode'] = $this->userCode;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['assessGroupId'])) {
            $model->assessGroupId = $map['assessGroupId'];
        }
        if (isset($map['assessGroupName'])) {
            $model->assessGroupName = $map['assessGroupName'];
        }
        if (isset($map['deptCode'])) {
            $model->deptCode = $map['deptCode'];
        }
        if (isset($map['deptType'])) {
            $model->deptType = $map['deptType'];
        }
        if (isset($map['gmtCreateStr'])) {
            $model->gmtCreateStr = $map['gmtCreateStr'];
        }
        if (isset($map['gmtModifiedStr'])) {
            $model->gmtModifiedStr = $map['gmtModifiedStr'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['jobNum'])) {
            $model->jobNum = $map['jobNum'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['uid'])) {
            $model->uid = $map['uid'];
        }
        if (isset($map['userCode'])) {
            $model->userCode = $map['userCode'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }

        return $model;
    }
}
