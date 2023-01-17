<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\SearchActionsResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 授权页地址
     *
     * @var string
     */
    public $authorityUrl;

    /**
     * @description 是否已授权
     *
     * @var bool
     */
    public $authorized;

    /**
     * @description 连接资产唯一标识
     *
     * @var string
     */
    public $connectAssetUri;

    /**
     * @description 执行动作所属连接器ID
     *
     * @var string
     */
    public $connectorId;

    /**
     * @description 描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 图标
     *
     * @var string
     */
    public $icon;

    /**
     * @description 执行动作的ID
     *
     * @var string
     */
    public $id;

    /**
     * @description 集成类型
     *
     * @var string
     */
    public $integrationType;

    /**
     * @description 名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 提供组织
     *
     * @var string
     */
    public $providerCorpId;
    protected $_name = [
        'authorityUrl'    => 'authorityUrl',
        'authorized'      => 'authorized',
        'connectAssetUri' => 'connectAssetUri',
        'connectorId'     => 'connectorId',
        'description'     => 'description',
        'icon'            => 'icon',
        'id'              => 'id',
        'integrationType' => 'integrationType',
        'name'            => 'name',
        'providerCorpId'  => 'providerCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authorityUrl) {
            $res['authorityUrl'] = $this->authorityUrl;
        }
        if (null !== $this->authorized) {
            $res['authorized'] = $this->authorized;
        }
        if (null !== $this->connectAssetUri) {
            $res['connectAssetUri'] = $this->connectAssetUri;
        }
        if (null !== $this->connectorId) {
            $res['connectorId'] = $this->connectorId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->integrationType) {
            $res['integrationType'] = $this->integrationType;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->providerCorpId) {
            $res['providerCorpId'] = $this->providerCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authorityUrl'])) {
            $model->authorityUrl = $map['authorityUrl'];
        }
        if (isset($map['authorized'])) {
            $model->authorized = $map['authorized'];
        }
        if (isset($map['connectAssetUri'])) {
            $model->connectAssetUri = $map['connectAssetUri'];
        }
        if (isset($map['connectorId'])) {
            $model->connectorId = $map['connectorId'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['integrationType'])) {
            $model->integrationType = $map['integrationType'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['providerCorpId'])) {
            $model->providerCorpId = $map['providerCorpId'];
        }

        return $model;
    }
}
