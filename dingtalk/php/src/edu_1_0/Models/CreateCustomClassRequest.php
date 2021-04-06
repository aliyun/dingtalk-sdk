<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCustomClassRequest\customClass;
use AlibabaCloud\Tea\Model;

class CreateCustomClassRequest extends Model
{
    /**
     * @description 班级信息
     *
     * @var customClass
     */
    public $customClass;

    /**
     * @description 上级部门ID
     *
     * @var int
     */
    public $superId;

    /**
     * @description 钉钉企业管理员工ID
     *
     * @var string
     */
    public $operator;

    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var string
     */
    public $dingCorpId;

    /**
     * @var int
     */
    public $dingOauthAppId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @var int
     */
    public $dingOrgId;
    protected $_name = [
        'customClass'        => 'customClass',
        'superId'            => 'superId',
        'operator'           => 'operator',
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingCorpId'         => 'dingCorpId',
        'dingOauthAppId'     => 'dingOauthAppId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'dingOrgId'          => 'dingOrgId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->customClass) {
            $res['customClass'] = null !== $this->customClass ? $this->customClass->toMap() : null;
        }
        if (null !== $this->superId) {
            $res['superId'] = $this->superId;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->dingOauthAppId) {
            $res['dingOauthAppId'] = $this->dingOauthAppId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateCustomClassRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customClass'])) {
            $model->customClass = customClass::fromMap($map['customClass']);
        }
        if (isset($map['superId'])) {
            $model->superId = $map['superId'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['dingOauthAppId'])) {
            $model->dingOauthAppId = $map['dingOauthAppId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }

        return $model;
    }
}
