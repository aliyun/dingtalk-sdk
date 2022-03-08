<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class NotifyVerifyResultRequest extends Model
{
    /**
     * @description 企业ID
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 码值
     *
     * @var string
     */
    public $payCode;

    /**
     * @description 备注信息
     *
     * @var string
     */
    public $remark;

    /**
     * @description 用户和企业的关系类型，区分内部员工，外部联系人，无关系普通用户
     *
     * @var string
     */
    public $userCorpRelationType;

    /**
     * @description 用户身份标识
     *
     * @var string
     */
    public $userIdentity;

    /**
     * @description 验证事件，长度不超过8个中文
     *
     * @var string
     */
    public $verifyEvent;

    /**
     * @description 验证地点，调用时请务必传入，以便生成工牌使用记录
     *
     * @var string
     */
    public $verifyLocation;

    /**
     * @description 验证流水号，长度不超过32位，用户下唯一，调用时请务必传入，以便生成工牌使用记录
     *
     * @var string
     */
    public $verifyNo;

    /**
     * @description 验证结果
     *
     * @var bool
     */
    public $verifyResult;

    /**
     * @description 验证时间
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
