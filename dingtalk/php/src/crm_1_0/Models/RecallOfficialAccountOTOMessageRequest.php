<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class RecallOfficialAccountOTOMessageRequest extends Model
{
    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @description 帐号ID 可空
     *
     * @var string
     */
    public $accountId;

    /**
     * @description 消息推送时返回的ID
     *
     * @var string
     */
    public $openPushId;
    protected $_name = [
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingOrgId'          => 'dingOrgId',
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'accountId'          => 'accountId',
        'openPushId'         => 'openPushId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->accountId) {
            $res['accountId'] = $this->accountId;
        }
        if (null !== $this->openPushId) {
            $res['openPushId'] = $this->openPushId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RecallOfficialAccountOTOMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['accountId'])) {
            $model->accountId = $map['accountId'];
        }
        if (isset($map['openPushId'])) {
            $model->openPushId = $map['openPushId'];
        }

        return $model;
    }
}
