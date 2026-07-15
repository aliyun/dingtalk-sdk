<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateAgentResponseBody extends Model
{
    /**
     * @var string
     */
    public $agentId;

    /**
     * @var string
     */
    public $clientId;

    /**
     * @var string
     */
    public $clientSecret;

    /**
     * @var string
     */
    public $robotCode;

    /**
     * @var string
     */
    public $unifiedAppId;
    protected $_name = [
        'agentId' => 'agentId',
        'clientId' => 'clientId',
        'clientSecret' => 'clientSecret',
        'robotCode' => 'robotCode',
        'unifiedAppId' => 'unifiedAppId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->clientId) {
            $res['clientId'] = $this->clientId;
        }
        if (null !== $this->clientSecret) {
            $res['clientSecret'] = $this->clientSecret;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }
        if (null !== $this->unifiedAppId) {
            $res['unifiedAppId'] = $this->unifiedAppId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateAgentResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['clientId'])) {
            $model->clientId = $map['clientId'];
        }
        if (isset($map['clientSecret'])) {
            $model->clientSecret = $map['clientSecret'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }
        if (isset($map['unifiedAppId'])) {
            $model->unifiedAppId = $map['unifiedAppId'];
        }

        return $model;
    }
}
