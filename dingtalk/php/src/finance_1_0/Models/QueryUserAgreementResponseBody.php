<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryUserAgreementResponseBody extends Model
{
    /**
     * @description 用户id
     *
     * @var string
     */
    public $staffId;

    /**
     * @description 组织id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 主机构id
     *
     * @var string
     */
    public $instId;

    /**
     * @description 子机构id
     *
     * @var string
     */
    public $subInstId;

    /**
     * @description 支付渠道
     *
     * @var string
     */
    public $payChannel;

    /**
     * @description 协议编号
     *
     * @var string
     */
    public $agreementNo;

    /**
     * @description 实际支付账号（脱敏）
     *
     * @var string
     */
    public $payChannelAccountNo;

    /**
     * @description 实际支付账户名（脱敏）
     *
     * @var string
     */
    public $payChannelAccountName;

    /**
     * @description 实际签约日期
     *
     * @var string
     */
    public $gmtSign;

    /**
     * @description 签约状态
     *
     * @var string
     */
    public $status;

    /**
     * @description 实际生效日期
     *
     * @var string
     */
    public $gmtValid;

    /**
     * @description 实际过期日期
     *
     * @var string
     */
    public $gmtExpire;
    protected $_name = [
        'staffId'               => 'staffId',
        'corpId'                => 'corpId',
        'instId'                => 'instId',
        'subInstId'             => 'subInstId',
        'payChannel'            => 'payChannel',
        'agreementNo'           => 'agreementNo',
        'payChannelAccountNo'   => 'payChannelAccountNo',
        'payChannelAccountName' => 'payChannelAccountName',
        'gmtSign'               => 'gmtSign',
        'status'                => 'status',
        'gmtValid'              => 'gmtValid',
        'gmtExpire'             => 'gmtExpire',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->instId) {
            $res['instId'] = $this->instId;
        }
        if (null !== $this->subInstId) {
            $res['subInstId'] = $this->subInstId;
        }
        if (null !== $this->payChannel) {
            $res['payChannel'] = $this->payChannel;
        }
        if (null !== $this->agreementNo) {
            $res['agreementNo'] = $this->agreementNo;
        }
        if (null !== $this->payChannelAccountNo) {
            $res['payChannelAccountNo'] = $this->payChannelAccountNo;
        }
        if (null !== $this->payChannelAccountName) {
            $res['payChannelAccountName'] = $this->payChannelAccountName;
        }
        if (null !== $this->gmtSign) {
            $res['gmtSign'] = $this->gmtSign;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->gmtValid) {
            $res['gmtValid'] = $this->gmtValid;
        }
        if (null !== $this->gmtExpire) {
            $res['gmtExpire'] = $this->gmtExpire;
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
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['instId'])) {
            $model->instId = $map['instId'];
        }
        if (isset($map['subInstId'])) {
            $model->subInstId = $map['subInstId'];
        }
        if (isset($map['payChannel'])) {
            $model->payChannel = $map['payChannel'];
        }
        if (isset($map['agreementNo'])) {
            $model->agreementNo = $map['agreementNo'];
        }
        if (isset($map['payChannelAccountNo'])) {
            $model->payChannelAccountNo = $map['payChannelAccountNo'];
        }
        if (isset($map['payChannelAccountName'])) {
            $model->payChannelAccountName = $map['payChannelAccountName'];
        }
        if (isset($map['gmtSign'])) {
            $model->gmtSign = $map['gmtSign'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['gmtValid'])) {
            $model->gmtValid = $map['gmtValid'];
        }
        if (isset($map['gmtExpire'])) {
            $model->gmtExpire = $map['gmtExpire'];
        }

        return $model;
    }
}
