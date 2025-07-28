<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryUserAgreementResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 201220123212312
     *
     * @var string
     */
    public $agreementNo;

    /**
     * @description This parameter is required.
     *
     * @example ding123123234234
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @example 2021-11-11 10:10:10
     *
     * @var string
     */
    public $gmtExpire;

    /**
     * @description This parameter is required.
     *
     * @example 2021-11-11 10:10:10
     *
     * @var string
     */
    public $gmtSign;

    /**
     * @description This parameter is required.
     *
     * @example 2021-11-11 10:10:10
     *
     * @var string
     */
    public $gmtValid;

    /**
     * @description This parameter is required.
     *
     * @example 2021000001
     *
     * @var string
     */
    public $instId;

    /**
     * @description This parameter is required.
     *
     * @example ALIPAY
     *
     * @var string
     */
    public $payChannel;

    /**
     * @description This parameter is required.
     *
     * @example *川
     *
     * @var string
     */
    public $payChannelAccountName;

    /**
     * @description This parameter is required.
     *
     * @example 139*****0
     *
     * @var string
     */
    public $payChannelAccountNo;

    /**
     * @description This parameter is required.
     *
     * @example SUCCESS
     *
     * @var string
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @example 101
     *
     * @var string
     */
    public $subInstId;

    /**
     * @description This parameter is required.
     *
     * @example 54646545
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'agreementNo' => 'agreementNo',
        'corpId' => 'corpId',
        'gmtExpire' => 'gmtExpire',
        'gmtSign' => 'gmtSign',
        'gmtValid' => 'gmtValid',
        'instId' => 'instId',
        'payChannel' => 'payChannel',
        'payChannelAccountName' => 'payChannelAccountName',
        'payChannelAccountNo' => 'payChannelAccountNo',
        'status' => 'status',
        'subInstId' => 'subInstId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agreementNo) {
            $res['agreementNo'] = $this->agreementNo;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->gmtExpire) {
            $res['gmtExpire'] = $this->gmtExpire;
        }
        if (null !== $this->gmtSign) {
            $res['gmtSign'] = $this->gmtSign;
        }
        if (null !== $this->gmtValid) {
            $res['gmtValid'] = $this->gmtValid;
        }
        if (null !== $this->instId) {
            $res['instId'] = $this->instId;
        }
        if (null !== $this->payChannel) {
            $res['payChannel'] = $this->payChannel;
        }
        if (null !== $this->payChannelAccountName) {
            $res['payChannelAccountName'] = $this->payChannelAccountName;
        }
        if (null !== $this->payChannelAccountNo) {
            $res['payChannelAccountNo'] = $this->payChannelAccountNo;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->subInstId) {
            $res['subInstId'] = $this->subInstId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUserAgreementResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agreementNo'])) {
            $model->agreementNo = $map['agreementNo'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['gmtExpire'])) {
            $model->gmtExpire = $map['gmtExpire'];
        }
        if (isset($map['gmtSign'])) {
            $model->gmtSign = $map['gmtSign'];
        }
        if (isset($map['gmtValid'])) {
            $model->gmtValid = $map['gmtValid'];
        }
        if (isset($map['instId'])) {
            $model->instId = $map['instId'];
        }
        if (isset($map['payChannel'])) {
            $model->payChannel = $map['payChannel'];
        }
        if (isset($map['payChannelAccountName'])) {
            $model->payChannelAccountName = $map['payChannelAccountName'];
        }
        if (isset($map['payChannelAccountNo'])) {
            $model->payChannelAccountNo = $map['payChannelAccountNo'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['subInstId'])) {
            $model->subInstId = $map['subInstId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
