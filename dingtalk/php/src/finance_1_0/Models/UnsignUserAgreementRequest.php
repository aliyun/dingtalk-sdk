<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class UnsignUserAgreementRequest extends Model
{
    /**
     * @description 主机构编号
     *
     * @var string
     */
    public $instId;

    /**
     * @description 子机构编号
     *
     * @var string
     */
    public $subInstId;

    /**
     * @description 付款人staffId
     *
     * @var string
     */
    public $userId;

    /**
     * @description 业务代码
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description 业务场景
     *
     * @var string
     */
    public $bizScene;

    /**
     * @description 协议编号
     *
     * @var string
     */
    public $agreementNo;

    /**
     * @description 组织id
     *
     * @var int
     */
    public $dingOrgId;

    /**
     * @description isv组织id
     *
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @description 应用id
     *
     * @var string
     */
    public $dingClientId;

    /**
     * @description 应用类型
     *
     * @var int
     */
    public $dingTokenGrantType;
    protected $_name = [
        'instId'             => 'instId',
        'subInstId'          => 'subInstId',
        'userId'             => 'userId',
        'bizCode'            => 'bizCode',
        'bizScene'           => 'bizScene',
        'agreementNo'        => 'agreementNo',
        'dingOrgId'          => 'dingOrgId',
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingClientId'       => 'dingClientId',
        'dingTokenGrantType' => 'dingTokenGrantType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->instId) {
            $res['instId'] = $this->instId;
        }
        if (null !== $this->subInstId) {
            $res['subInstId'] = $this->subInstId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->bizScene) {
            $res['bizScene'] = $this->bizScene;
        }
        if (null !== $this->agreementNo) {
            $res['agreementNo'] = $this->agreementNo;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingClientId) {
            $res['dingClientId'] = $this->dingClientId;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UnsignUserAgreementRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['instId'])) {
            $model->instId = $map['instId'];
        }
        if (isset($map['subInstId'])) {
            $model->subInstId = $map['subInstId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['bizScene'])) {
            $model->bizScene = $map['bizScene'];
        }
        if (isset($map['agreementNo'])) {
            $model->agreementNo = $map['agreementNo'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingClientId'])) {
            $model->dingClientId = $map['dingClientId'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }

        return $model;
    }
}
