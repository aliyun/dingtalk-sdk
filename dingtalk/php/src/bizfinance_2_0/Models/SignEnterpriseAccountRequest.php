<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class SignEnterpriseAccountRequest extends Model
{
    /**
     * @example ACC_XXX
     *
     * @var string
     */
    public $accountCode;

    /**
     * @example 123
     *
     * @var string
     */
    public $bankCardNo;

    /**
     * @example 123
     *
     * @var string
     */
    public $bankOpenId;

    /**
     * @example COMM_UNIONPAY
     *
     * @var string
     */
    public $channelType;

    /**
     * @example 123
     *
     * @var string
     */
    public $operator;

    /**
     * @example signed
     *
     * @var string
     */
    public $signOperateType;
    protected $_name = [
        'accountCode' => 'accountCode',
        'bankCardNo' => 'bankCardNo',
        'bankOpenId' => 'bankOpenId',
        'channelType' => 'channelType',
        'operator' => 'operator',
        'signOperateType' => 'signOperateType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountCode) {
            $res['accountCode'] = $this->accountCode;
        }
        if (null !== $this->bankCardNo) {
            $res['bankCardNo'] = $this->bankCardNo;
        }
        if (null !== $this->bankOpenId) {
            $res['bankOpenId'] = $this->bankOpenId;
        }
        if (null !== $this->channelType) {
            $res['channelType'] = $this->channelType;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->signOperateType) {
            $res['signOperateType'] = $this->signOperateType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SignEnterpriseAccountRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountCode'])) {
            $model->accountCode = $map['accountCode'];
        }
        if (isset($map['bankCardNo'])) {
            $model->bankCardNo = $map['bankCardNo'];
        }
        if (isset($map['bankOpenId'])) {
            $model->bankOpenId = $map['bankOpenId'];
        }
        if (isset($map['channelType'])) {
            $model->channelType = $map['channelType'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['signOperateType'])) {
            $model->signOperateType = $map['signOperateType'];
        }

        return $model;
    }
}
