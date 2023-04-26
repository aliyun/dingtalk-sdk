<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class NotifyVerifyResultRequest extends Model
{
    /**
     * @example corpxxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 261234567890
     *
     * @var string
     */
    public $payCode;

    /**
     * @var string
     */
    public $remark;

    /**
     * @example INTERNAL_STAFF
     *
     * @var string
     */
    public $userCorpRelationType;

    /**
     * @example xxxxxx
     *
     * @var string
     */
    public $userIdentity;

    /**
     * @example 门禁验证
     *
     * @var string
     */
    public $verifyEvent;

    /**
     * @example 1号食堂
     *
     * @var string
     */
    public $verifyLocation;

    /**
     * @example 202112120003232
     *
     * @var string
     */
    public $verifyNo;

    /**
     * @example 是否通过
     *
     * @var bool
     */
    public $verifyResult;

    /**
     * @example 2021-01-01 12:12:12
     *
     * @var string
     */
    public $verifyTime;
    protected $_name = [
        'corpId'               => 'corpId',
        'payCode'              => 'payCode',
        'remark'               => 'remark',
        'userCorpRelationType' => 'userCorpRelationType',
        'userIdentity'         => 'userIdentity',
        'verifyEvent'          => 'verifyEvent',
        'verifyLocation'       => 'verifyLocation',
        'verifyNo'             => 'verifyNo',
        'verifyResult'         => 'verifyResult',
        'verifyTime'           => 'verifyTime',
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
        if (null !== $this->payCode) {
            $res['payCode'] = $this->payCode;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->userCorpRelationType) {
            $res['userCorpRelationType'] = $this->userCorpRelationType;
        }
        if (null !== $this->userIdentity) {
            $res['userIdentity'] = $this->userIdentity;
        }
        if (null !== $this->verifyEvent) {
            $res['verifyEvent'] = $this->verifyEvent;
        }
        if (null !== $this->verifyLocation) {
            $res['verifyLocation'] = $this->verifyLocation;
        }
        if (null !== $this->verifyNo) {
            $res['verifyNo'] = $this->verifyNo;
        }
        if (null !== $this->verifyResult) {
            $res['verifyResult'] = $this->verifyResult;
        }
        if (null !== $this->verifyTime) {
            $res['verifyTime'] = $this->verifyTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return NotifyVerifyResultRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['payCode'])) {
            $model->payCode = $map['payCode'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['userCorpRelationType'])) {
            $model->userCorpRelationType = $map['userCorpRelationType'];
        }
        if (isset($map['userIdentity'])) {
            $model->userIdentity = $map['userIdentity'];
        }
        if (isset($map['verifyEvent'])) {
            $model->verifyEvent = $map['verifyEvent'];
        }
        if (isset($map['verifyLocation'])) {
            $model->verifyLocation = $map['verifyLocation'];
        }
        if (isset($map['verifyNo'])) {
            $model->verifyNo = $map['verifyNo'];
        }
        if (isset($map['verifyResult'])) {
            $model->verifyResult = $map['verifyResult'];
        }
        if (isset($map['verifyTime'])) {
            $model->verifyTime = $map['verifyTime'];
        }

        return $model;
    }
}
