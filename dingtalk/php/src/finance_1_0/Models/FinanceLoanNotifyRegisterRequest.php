<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class FinanceLoanNotifyRegisterRequest extends Model
{
    /**
     * @example 2024-06-18 14:53:33
     *
     * @var string
     */
    public $completeTime;

    /**
     * @example {}
     *
     * @var string
     */
    public $extension;

    /**
     * @example 330725189509101234
     *
     * @var string
     */
    public $idCardNo;

    /**
     * @example 中原消费金融
     *
     * @var string
     */
    public $openChannelName;

    /**
     * @example XFD201909210001
     *
     * @var string
     */
    public $openProductCode;

    /**
     * @example 员工贷
     *
     * @var string
     */
    public $openProductName;

    /**
     * @example ZYXJ_XFD
     *
     * @var string
     */
    public $openProductType;

    /**
     * @example 0
     *
     * @var string
     */
    public $processingStatus;

    /**
     * @example ZRSB2020
     *
     * @var string
     */
    public $refuseCode;

    /**
     * @example 进件准入失败
     *
     * @var string
     */
    public $refuseReason;

    /**
     * @example 2024061814654041710801
     *
     * @var string
     */
    public $registerNo;

    /**
     * @example 0
     *
     * @var string
     */
    public $status;

    /**
     * @example 2024-06-18 14:53:33
     *
     * @var string
     */
    public $submitTime;

    /**
     * @example 18092149430
     *
     * @var string
     */
    public $userMobile;
    protected $_name = [
        'completeTime'     => 'completeTime',
        'extension'        => 'extension',
        'idCardNo'         => 'idCardNo',
        'openChannelName'  => 'openChannelName',
        'openProductCode'  => 'openProductCode',
        'openProductName'  => 'openProductName',
        'openProductType'  => 'openProductType',
        'processingStatus' => 'processingStatus',
        'refuseCode'       => 'refuseCode',
        'refuseReason'     => 'refuseReason',
        'registerNo'       => 'registerNo',
        'status'           => 'status',
        'submitTime'       => 'submitTime',
        'userMobile'       => 'userMobile',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->completeTime) {
            $res['completeTime'] = $this->completeTime;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->idCardNo) {
            $res['idCardNo'] = $this->idCardNo;
        }
        if (null !== $this->openChannelName) {
            $res['openChannelName'] = $this->openChannelName;
        }
        if (null !== $this->openProductCode) {
            $res['openProductCode'] = $this->openProductCode;
        }
        if (null !== $this->openProductName) {
            $res['openProductName'] = $this->openProductName;
        }
        if (null !== $this->openProductType) {
            $res['openProductType'] = $this->openProductType;
        }
        if (null !== $this->processingStatus) {
            $res['processingStatus'] = $this->processingStatus;
        }
        if (null !== $this->refuseCode) {
            $res['refuseCode'] = $this->refuseCode;
        }
        if (null !== $this->refuseReason) {
            $res['refuseReason'] = $this->refuseReason;
        }
        if (null !== $this->registerNo) {
            $res['registerNo'] = $this->registerNo;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->submitTime) {
            $res['submitTime'] = $this->submitTime;
        }
        if (null !== $this->userMobile) {
            $res['userMobile'] = $this->userMobile;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return FinanceLoanNotifyRegisterRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['completeTime'])) {
            $model->completeTime = $map['completeTime'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['idCardNo'])) {
            $model->idCardNo = $map['idCardNo'];
        }
        if (isset($map['openChannelName'])) {
            $model->openChannelName = $map['openChannelName'];
        }
        if (isset($map['openProductCode'])) {
            $model->openProductCode = $map['openProductCode'];
        }
        if (isset($map['openProductName'])) {
            $model->openProductName = $map['openProductName'];
        }
        if (isset($map['openProductType'])) {
            $model->openProductType = $map['openProductType'];
        }
        if (isset($map['processingStatus'])) {
            $model->processingStatus = $map['processingStatus'];
        }
        if (isset($map['refuseCode'])) {
            $model->refuseCode = $map['refuseCode'];
        }
        if (isset($map['refuseReason'])) {
            $model->refuseReason = $map['refuseReason'];
        }
        if (isset($map['registerNo'])) {
            $model->registerNo = $map['registerNo'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['submitTime'])) {
            $model->submitTime = $map['submitTime'];
        }
        if (isset($map['userMobile'])) {
            $model->userMobile = $map['userMobile'];
        }

        return $model;
    }
}
