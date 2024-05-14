<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ReportCustomerDetailResponseBody;

use AlibabaCloud\Tea\Model;

class records extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $atRobotCnt;

    /**
     * @description This parameter is required.
     *
     * @example 张三
     *
     * @var string
     */
    public $customerName;

    /**
     * @description This parameter is required.
     *
     * @example 测试群
     *
     * @var string
     */
    public $groupName;

    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $hasLogin;

    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $hasOpenConv;

    /**
     * @description This parameter is required.
     *
     * @example 2
     *
     * @var int
     */
    public $sendMsgCnt;

    /**
     * @description This parameter is required.
     *
     * @example xcjlsdf
     *
     * @var string
     */
    public $unionId;

    /**
     * @description This parameter is required.
     *
     * @example 56789
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'atRobotCnt'   => 'atRobotCnt',
        'customerName' => 'customerName',
        'groupName'    => 'groupName',
        'hasLogin'     => 'hasLogin',
        'hasOpenConv'  => 'hasOpenConv',
        'sendMsgCnt'   => 'sendMsgCnt',
        'unionId'      => 'unionId',
        'userId'       => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->atRobotCnt) {
            $res['atRobotCnt'] = $this->atRobotCnt;
        }
        if (null !== $this->customerName) {
            $res['customerName'] = $this->customerName;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->hasLogin) {
            $res['hasLogin'] = $this->hasLogin;
        }
        if (null !== $this->hasOpenConv) {
            $res['hasOpenConv'] = $this->hasOpenConv;
        }
        if (null !== $this->sendMsgCnt) {
            $res['sendMsgCnt'] = $this->sendMsgCnt;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return records
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['atRobotCnt'])) {
            $model->atRobotCnt = $map['atRobotCnt'];
        }
        if (isset($map['customerName'])) {
            $model->customerName = $map['customerName'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['hasLogin'])) {
            $model->hasLogin = $map['hasLogin'];
        }
        if (isset($map['hasOpenConv'])) {
            $model->hasOpenConv = $map['hasOpenConv'];
        }
        if (isset($map['sendMsgCnt'])) {
            $model->sendMsgCnt = $map['sendMsgCnt'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
