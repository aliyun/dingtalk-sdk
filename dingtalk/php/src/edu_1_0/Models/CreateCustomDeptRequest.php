<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCustomDeptRequest\customDept;
use AlibabaCloud\Tea\Model;

class CreateCustomDeptRequest extends Model
{
    /**
     * @var customDept
     */
    public $customDept;

    /**
     * @description 上级部门ID（type为custom_campus时，必须为-7）
     *
     * @var int
     */
    public $superId;

    /**
     * @description 钉钉管理员员工ID
     *
     * @var string
     */
    public $operator;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var int
     */
    public $dingOauthAppId;

    /**
     * @var string
     */
    public $dingCorpId;

    /**
     * @var int
     */
    public $dingIsvOrgId;
    protected $_name = [
        'customDept'         => 'customDept',
        'superId'            => 'superId',
        'operator'           => 'operator',
        'dingOrgId'          => 'dingOrgId',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingOauthAppId'     => 'dingOauthAppId',
        'dingCorpId'         => 'dingCorpId',
        'dingIsvOrgId'       => 'dingIsvOrgId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->customDept) {
            $res['customDept'] = null !== $this->customDept ? $this->customDept->toMap() : null;
        }
        if (null !== $this->superId) {
            $res['superId'] = $this->superId;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingOauthAppId) {
            $res['dingOauthAppId'] = $this->dingOauthAppId;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateCustomDeptRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customDept'])) {
            $model->customDept = customDept::fromMap($map['customDept']);
        }
        if (isset($map['superId'])) {
            $model->superId = $map['superId'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingOauthAppId'])) {
            $model->dingOauthAppId = $map['dingOauthAppId'];
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }

        return $model;
    }
}
