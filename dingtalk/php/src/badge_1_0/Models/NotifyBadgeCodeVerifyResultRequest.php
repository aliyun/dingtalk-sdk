<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models;

use AlibabaCloud\Tea\Model;

class NotifyBadgeCodeVerifyResultRequest extends Model
{
    /**
     * @description 码值
     *
     * @var string
     */
    public $payCode;

    /**
     * @description 企业ID
     *
     * @var string
     */
    public $corpId;

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
     * @description 验证时间
     *
     * @var string
     */
    public $verifyTime;

    /**
     * @description 验证结果
     *
     * @var bool
     */
    public $verifyResult;

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
     * @description 验证事件，长度不超过8个中文
     *
     * @var string
     */
    public $verifyEvent;

    /**
     * @description 备注信息
     *
     * @var string
     */
    public $remark;

    /**
     * @description 组织ID
     *
     * @var int
     */
    public $dingOrgId;

    /**
     * @description ISV组织ID
     *
     * @var int
     */
    public $dingIsvOrgId;
    protected $_name = [
        'payCode'              => 'payCode',
        'corpId'               => 'corpId',
        'userCorpRelationType' => 'userCorpRelationType',
        'userIdentity'         => 'userIdentity',
        'verifyTime'           => 'verifyTime',
        'verifyResult'         => 'verifyResult',
        'verifyLocation'       => 'verifyLocation',
        'verifyNo'             => 'verifyNo',
        'verifyEvent'          => 'verifyEvent',
        'remark'               => 'remark',
        'dingOrgId'            => 'dingOrgId',
        'dingIsvOrgId'         => 'dingIsvOrgId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->payCode) {
            $res['payCode'] = $this->payCode;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->userCorpRelationType) {
            $res['userCorpRelationType'] = $this->userCorpRelationType;
        }
        if (null !== $this->userIdentity) {
            $res['userIdentity'] = $this->userIdentity;
        }
        if (null !== $this->verifyTime) {
            $res['verifyTime'] = $this->verifyTime;
        }
        if (null !== $this->verifyResult) {
            $res['verifyResult'] = $this->verifyResult;
        }
        if (null !== $this->verifyLocation) {
            $res['verifyLocation'] = $this->verifyLocation;
        }
        if (null !== $this->verifyNo) {
            $res['verifyNo'] = $this->verifyNo;
        }
        if (null !== $this->verifyEvent) {
            $res['verifyEvent'] = $this->verifyEvent;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return NotifyBadgeCodeVerifyResultRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['payCode'])) {
            $model->payCode = $map['payCode'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['userCorpRelationType'])) {
            $model->userCorpRelationType = $map['userCorpRelationType'];
        }
        if (isset($map['userIdentity'])) {
            $model->userIdentity = $map['userIdentity'];
        }
        if (isset($map['verifyTime'])) {
            $model->verifyTime = $map['verifyTime'];
        }
        if (isset($map['verifyResult'])) {
            $model->verifyResult = $map['verifyResult'];
        }
        if (isset($map['verifyLocation'])) {
            $model->verifyLocation = $map['verifyLocation'];
        }
        if (isset($map['verifyNo'])) {
            $model->verifyNo = $map['verifyNo'];
        }
        if (isset($map['verifyEvent'])) {
            $model->verifyEvent = $map['verifyEvent'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }

        return $model;
    }
}
