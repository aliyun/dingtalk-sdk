<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\BatchGetUserResponseBody;

use AlibabaCloud\Tea\Model;

class userList extends Model
{
    /**
     * @var string
     */
    public $jobNumber;

    /**
     * @var string
     */
    public $mobile;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $nickname;

    /**
     * @var string
     */
    public $remark;

    /**
     * @var bool
     */
    public $senior;

    /**
     * @var string
     */
    public $stateCode;

    /**
     * @var string
     */
    public $unionid;

    /**
     * @var string
     */
    public $userid;
    protected $_name = [
        'jobNumber' => 'job_number',
        'mobile' => 'mobile',
        'name' => 'name',
        'nickname' => 'nickname',
        'remark' => 'remark',
        'senior' => 'senior',
        'stateCode' => 'state_code',
        'unionid' => 'unionid',
        'userid' => 'userid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->jobNumber) {
            $res['job_number'] = $this->jobNumber;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->nickname) {
            $res['nickname'] = $this->nickname;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->senior) {
            $res['senior'] = $this->senior;
        }
        if (null !== $this->stateCode) {
            $res['state_code'] = $this->stateCode;
        }
        if (null !== $this->unionid) {
            $res['unionid'] = $this->unionid;
        }
        if (null !== $this->userid) {
            $res['userid'] = $this->userid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return userList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['job_number'])) {
            $model->jobNumber = $map['job_number'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['nickname'])) {
            $model->nickname = $map['nickname'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['senior'])) {
            $model->senior = $map['senior'];
        }
        if (isset($map['state_code'])) {
            $model->stateCode = $map['state_code'];
        }
        if (isset($map['unionid'])) {
            $model->unionid = $map['unionid'];
        }
        if (isset($map['userid'])) {
            $model->userid = $map['userid'];
        }

        return $model;
    }
}
