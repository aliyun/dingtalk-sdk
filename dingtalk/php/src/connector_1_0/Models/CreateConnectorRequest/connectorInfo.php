<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateConnectorRequest;

use AlibabaCloud\Tea\Model;

class connectorInfo extends Model
{
    /**
     * @var string
     */
    public $integratorConnectorId;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $iconMediaId;

    /**
     * @var int
     */
    public $appId;

    /**
     * @description 连接器下action api请求url域名，当baseVariables中无apiDomain，该项必填
     *
     * @var string
     */
    public $apiDomain;

    /**
     * @description 连接器下action api请求时使用http加密签名，当baseVariables无apiSecret，该项必填
     *
     * @var string
     */
    public $apiSecret;

    /**
     * @description 变量列表。目前支持将apiDomain、apiSecret声明为基础变量。若声明为变量，则对应属性可不传值
     *
     * @var string[]
     */
    public $baseVariables;
    protected $_name = [
        'integratorConnectorId' => 'integratorConnectorId',
        'name'                  => 'name',
        'description'           => 'description',
        'iconMediaId'           => 'iconMediaId',
        'appId'                 => 'appId',
        'apiDomain'             => 'apiDomain',
        'apiSecret'             => 'apiSecret',
        'baseVariables'         => 'baseVariables',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->integratorConnectorId) {
            $res['integratorConnectorId'] = $this->integratorConnectorId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->iconMediaId) {
            $res['iconMediaId'] = $this->iconMediaId;
        }
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->apiDomain) {
            $res['apiDomain'] = $this->apiDomain;
        }
        if (null !== $this->apiSecret) {
            $res['apiSecret'] = $this->apiSecret;
        }
        if (null !== $this->baseVariables) {
            $res['baseVariables'] = $this->baseVariables;
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
        if (isset($map['integratorConnectorId'])) {
            $model->integratorConnectorId = $map['integratorConnectorId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['iconMediaId'])) {
            $model->iconMediaId = $map['iconMediaId'];
        }
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['apiDomain'])) {
            $model->apiDomain = $map['apiDomain'];
        }
        if (isset($map['apiSecret'])) {
            $model->apiSecret = $map['apiSecret'];
        }
        if (isset($map['baseVariables'])) {
            if (!empty($map['baseVariables'])) {
                $model->baseVariables = $map['baseVariables'];
            }
        }

        return $model;
    }
}
