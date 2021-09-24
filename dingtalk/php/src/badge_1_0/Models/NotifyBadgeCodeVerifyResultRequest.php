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
     * @description 验证地点
     *
     * @var string
     */
    public $verifyLocation;

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
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }

        return $model;
    }
}
