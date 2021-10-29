<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateInviteUrlRequest extends Model
{
    /**
     * @var string
     */
    public $dingCorpId;

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
    public $dingOauthAppId;

    /**
     * @var string
     */
    public $targetCorpId;

    /**
     * @var string
     */
    public $authCode;

    /**
     * @var string
     */
    public $targetOperator;

    /**
     * @var int
     */
    public $dingIsvOrgId;
    protected $_name = [
        'dingCorpId'         => 'dingCorpId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'dingOauthAppId'     => 'dingOauthAppId',
        'targetCorpId'       => 'targetCorpId',
        'authCode'           => 'authCode',
        'targetOperator'     => 'targetOperator',
        'dingIsvOrgId'       => 'dingIsvOrgId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->dingOauthAppId) {
            $res['dingOauthAppId'] = $this->dingOauthAppId;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }
        if (null !== $this->authCode) {
            $res['authCode'] = $this->authCode;
        }
        if (null !== $this->targetOperator) {
            $res['targetOperator'] = $this->targetOperator;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateInviteUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['dingOauthAppId'])) {
            $model->dingOauthAppId = $map['dingOauthAppId'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }
        if (isset($map['authCode'])) {
            $model->authCode = $map['authCode'];
        }
        if (isset($map['targetOperator'])) {
            $model->targetOperator = $map['targetOperator'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }

        return $model;
    }
}
