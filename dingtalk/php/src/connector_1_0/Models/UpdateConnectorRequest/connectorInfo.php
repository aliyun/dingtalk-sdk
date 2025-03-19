<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\UpdateConnectorRequest;

use AlibabaCloud\Tea\Model;

class connectorInfo extends Model
{
    /**
     * @var string
     */
    public $apiDomain;

    /**
     * @var string
     */
    public $apiSecret;

    /**
     * @var int
     */
    public $appId;

    /**
     * @var bool
     */
    public $authValueEnv;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $dingConnectorId;

    /**
     * @var bool
     */
    public $domainEnv;

    /**
     * @var string
     */
    public $iconMediaId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $integratorConnectorId;

    /**
     * @var string
     */
    public $name;
    protected $_name = [
        'apiDomain' => 'apiDomain',
        'apiSecret' => 'apiSecret',
        'appId' => 'appId',
        'authValueEnv' => 'authValueEnv',
        'description' => 'description',
        'dingConnectorId' => 'dingConnectorId',
        'domainEnv' => 'domainEnv',
        'iconMediaId' => 'iconMediaId',
        'integratorConnectorId' => 'integratorConnectorId',
        'name' => 'name',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->apiDomain) {
            $res['apiDomain'] = $this->apiDomain;
        }
        if (null !== $this->apiSecret) {
            $res['apiSecret'] = $this->apiSecret;
        }
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->authValueEnv) {
            $res['authValueEnv'] = $this->authValueEnv;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->dingConnectorId) {
            $res['dingConnectorId'] = $this->dingConnectorId;
        }
        if (null !== $this->domainEnv) {
            $res['domainEnv'] = $this->domainEnv;
        }
        if (null !== $this->iconMediaId) {
            $res['iconMediaId'] = $this->iconMediaId;
        }
        if (null !== $this->integratorConnectorId) {
            $res['integratorConnectorId'] = $this->integratorConnectorId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return connectorInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['apiDomain'])) {
            $model->apiDomain = $map['apiDomain'];
        }
        if (isset($map['apiSecret'])) {
            $model->apiSecret = $map['apiSecret'];
        }
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['authValueEnv'])) {
            $model->authValueEnv = $map['authValueEnv'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['dingConnectorId'])) {
            $model->dingConnectorId = $map['dingConnectorId'];
        }
        if (isset($map['domainEnv'])) {
            $model->domainEnv = $map['domainEnv'];
        }
        if (isset($map['iconMediaId'])) {
            $model->iconMediaId = $map['iconMediaId'];
        }
        if (isset($map['integratorConnectorId'])) {
            $model->integratorConnectorId = $map['integratorConnectorId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
