<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddCollegeContactUserRequest\deptOrderList;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddCollegeContactUserRequest\deptPositionSet;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddCollegeContactUserRequest\deptTitleList;
use AlibabaCloud\Tea\Model;

class AddCollegeContactUserRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int[]
     */
    public $deptIdList;

    /**
     * @var deptOrderList[]
     */
    public $deptOrderList;

    /**
     * @var deptPositionSet[]
     */
    public $deptPositionSet;

    /**
     * @var deptTitleList[]
     */
    public $deptTitleList;

    /**
     * @example test@xxx.com
     *
     * @var string
     */
    public $email;

    /**
     * @description This parameter is required.
     *
     * @example college_student
     *
     * @var string
     */
    public $empType;

    /**
     * @var string[]
     */
    public $extension;

    /**
     * @var bool
     */
    public $hideMobile;

    /**
     * @example 1597573616828
     *
     * @var int
     */
    public $hiredDate;

    /**
     * @example 666666
     *
     * @var string
     */
    public $jobNumber;

    /**
     * @example test@xxx.com
     *
     * @var string
     */
    public $loginEmail;

    /**
     * @description This parameter is required.
     *
     * @example 123456
     *
     * @var int
     */
    public $mainDeptId;

    /**
     * @example 001
     *
     * @var string
     */
    public $managerUserid;

    /**
     * @description This parameter is required.
     *
     * @example 185xxxx8888
     *
     * @var string
     */
    public $mobile;

    /**
     * @description This parameter is required.
     *
     * @example 张三
     *
     * @var string
     */
    public $name;

    /**
     * @example test@xxx.com
     *
     * @var string
     */
    public $orgEmail;

    /**
     * @example profession
     *
     * @var string
     */
    public $orgEmailType;

    /**
     * @example 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @var bool
     */
    public $sendActiveSms;

    /**
     * @var bool
     */
    public $seniorMode;

    /**
     * @example 010-86123456-2345
     *
     * @var string
     */
    public $telephone;

    /**
     * @example 学工处处长
     *
     * @var string
     */
    public $title;

    /**
     * @example zhangsan666
     *
     * @var string
     */
    public $userid;

    /**
     * @example 学工处办公室
     *
     * @var string
     */
    public $workPlace;
    protected $_name = [
        'deptIdList' => 'deptIdList',
        'deptOrderList' => 'deptOrderList',
        'deptPositionSet' => 'deptPositionSet',
        'deptTitleList' => 'deptTitleList',
        'email' => 'email',
        'empType' => 'empType',
        'extension' => 'extension',
        'hideMobile' => 'hideMobile',
        'hiredDate' => 'hiredDate',
        'jobNumber' => 'jobNumber',
        'loginEmail' => 'loginEmail',
        'mainDeptId' => 'mainDeptId',
        'managerUserid' => 'managerUserid',
        'mobile' => 'mobile',
        'name' => 'name',
        'orgEmail' => 'orgEmail',
        'orgEmailType' => 'orgEmailType',
        'remark' => 'remark',
        'sendActiveSms' => 'sendActiveSms',
        'seniorMode' => 'seniorMode',
        'telephone' => 'telephone',
        'title' => 'title',
        'userid' => 'userid',
        'workPlace' => 'workPlace',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptIdList) {
            $res['deptIdList'] = $this->deptIdList;
        }
        if (null !== $this->deptOrderList) {
            $res['deptOrderList'] = [];
            if (null !== $this->deptOrderList && \is_array($this->deptOrderList)) {
                $n = 0;
                foreach ($this->deptOrderList as $item) {
                    $res['deptOrderList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->deptPositionSet) {
            $res['deptPositionSet'] = [];
            if (null !== $this->deptPositionSet && \is_array($this->deptPositionSet)) {
                $n = 0;
                foreach ($this->deptPositionSet as $item) {
                    $res['deptPositionSet'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->deptTitleList) {
            $res['deptTitleList'] = [];
            if (null !== $this->deptTitleList && \is_array($this->deptTitleList)) {
                $n = 0;
                foreach ($this->deptTitleList as $item) {
                    $res['deptTitleList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }
        if (null !== $this->empType) {
            $res['empType'] = $this->empType;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->hideMobile) {
            $res['hideMobile'] = $this->hideMobile;
        }
        if (null !== $this->hiredDate) {
            $res['hiredDate'] = $this->hiredDate;
        }
        if (null !== $this->jobNumber) {
            $res['jobNumber'] = $this->jobNumber;
        }
        if (null !== $this->loginEmail) {
            $res['loginEmail'] = $this->loginEmail;
        }
        if (null !== $this->mainDeptId) {
            $res['mainDeptId'] = $this->mainDeptId;
        }
        if (null !== $this->managerUserid) {
            $res['managerUserid'] = $this->managerUserid;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->orgEmail) {
            $res['orgEmail'] = $this->orgEmail;
        }
        if (null !== $this->orgEmailType) {
            $res['orgEmailType'] = $this->orgEmailType;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->sendActiveSms) {
            $res['sendActiveSms'] = $this->sendActiveSms;
        }
        if (null !== $this->seniorMode) {
            $res['seniorMode'] = $this->seniorMode;
        }
        if (null !== $this->telephone) {
            $res['telephone'] = $this->telephone;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->userid) {
            $res['userid'] = $this->userid;
        }
        if (null !== $this->workPlace) {
            $res['workPlace'] = $this->workPlace;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddCollegeContactUserRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptIdList'])) {
            if (!empty($map['deptIdList'])) {
                $model->deptIdList = $map['deptIdList'];
            }
        }
        if (isset($map['deptOrderList'])) {
            if (!empty($map['deptOrderList'])) {
                $model->deptOrderList = [];
                $n = 0;
                foreach ($map['deptOrderList'] as $item) {
                    $model->deptOrderList[$n++] = null !== $item ? deptOrderList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['deptPositionSet'])) {
            if (!empty($map['deptPositionSet'])) {
                $model->deptPositionSet = [];
                $n = 0;
                foreach ($map['deptPositionSet'] as $item) {
                    $model->deptPositionSet[$n++] = null !== $item ? deptPositionSet::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['deptTitleList'])) {
            if (!empty($map['deptTitleList'])) {
                $model->deptTitleList = [];
                $n = 0;
                foreach ($map['deptTitleList'] as $item) {
                    $model->deptTitleList[$n++] = null !== $item ? deptTitleList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['empType'])) {
            $model->empType = $map['empType'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['hideMobile'])) {
            $model->hideMobile = $map['hideMobile'];
        }
        if (isset($map['hiredDate'])) {
            $model->hiredDate = $map['hiredDate'];
        }
        if (isset($map['jobNumber'])) {
            $model->jobNumber = $map['jobNumber'];
        }
        if (isset($map['loginEmail'])) {
            $model->loginEmail = $map['loginEmail'];
        }
        if (isset($map['mainDeptId'])) {
            $model->mainDeptId = $map['mainDeptId'];
        }
        if (isset($map['managerUserid'])) {
            $model->managerUserid = $map['managerUserid'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['orgEmail'])) {
            $model->orgEmail = $map['orgEmail'];
        }
        if (isset($map['orgEmailType'])) {
            $model->orgEmailType = $map['orgEmailType'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['sendActiveSms'])) {
            $model->sendActiveSms = $map['sendActiveSms'];
        }
        if (isset($map['seniorMode'])) {
            $model->seniorMode = $map['seniorMode'];
        }
        if (isset($map['telephone'])) {
            $model->telephone = $map['telephone'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['userid'])) {
            $model->userid = $map['userid'];
        }
        if (isset($map['workPlace'])) {
            $model->workPlace = $map['workPlace'];
        }

        return $model;
    }
}
