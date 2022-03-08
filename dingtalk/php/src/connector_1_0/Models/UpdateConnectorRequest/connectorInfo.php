<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\UpdateConnectorRequest;

use AlibabaCloud\Tea\Model;

class connectorInfo extends Model
{
    /**
     * @description 连接器中执行动作的接口路径域名。
     *
     * @var string
     */
    public $apiDomain;

    /**
     * @description 连接器中执行动作接口的加密签名。
     *
     * @var string
     */
    public $apiSecret;

    /**
     * @description 应用id。
     *
     * @var int
     */
    public $appId;

    /**
     * @description 将执行动作鉴权值设为环境变量。
     *
     * @var bool
     */
    public $authValueEnv;

    /**
     * @description 连接器描述。
     *
     * @var string
     */
    public $description;

    /**
     * @description 连接平台连接器唯一标识。
     *
     * @var string
     */
    public $dingConnectorId;

    /**
     * @description 将执行动作域名设为环境变量。
     *
     * @var bool
     */
    public $domainEnv;

    /**
     * @var string
     */
    public $iconMediaId;

    /**
     * @description 服务商的连接器唯一标识。
     *
     * @var string
     */
    public $integratorConnectorId;

    /**
     * @description 连接器名称。
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'apiDomain'             => 'apiDomain',
        'apiSecret'             => 'apiSecret',
        'appId'                 => 'appId',
        'authValueEnv'          => 'authValueEnv',
        'description'           => 'description',
        'dingConnectorId'       => 'dingConnectorId',
        'domainEnv'             => 'domainEnv',
        'iconMediaId'           => 'iconMediaId',
        'integratorConnectorId' => 'integratorConnectorId',
        'name'                  => 'name',
    ];

    public function validate()
    {
    }

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
