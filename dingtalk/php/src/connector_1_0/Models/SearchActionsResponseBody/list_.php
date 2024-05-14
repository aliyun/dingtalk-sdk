<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\SearchActionsResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @example dingtalk://dingtalkclient/page/link?pc_slide=true&url=https%3A%2F%2Fn.dingtalk.com%2Fdingding%2Fh5-common-authority%2Fconnector%2Findex.html%3FcorpId%3Dding32fff839a3e0105d%26accessorUuid%3DAPP-505001%26oPaths%3D%252Fding5b2a0b7e9677128935c2f4657eb6378f%252Fconnector%252FG-CONN-1017AF27C1B20B0FFD490005
     *
     * @var string
     */
    public $authorityUrl;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $authorized;

    /**
     * @example dca://ding32fff839a3e0105d.connect.dingtalk.com/ding32fff839a3e0105d/action/G-ACT-101FDEBD3C6E213DB474000P
     *
     * @var string
     */
    public $connectAssetUri;

    /**
     * @example G-CONN-XXCONNECTOR
     *
     * @var string
     */
    public $connectorId;

    /**
     * @example 示例描述
     *
     * @var string
     */
    public $description;

    /**
     * @example http://example.com/icon.jpg
     *
     * @var string
     */
    public $icon;

    /**
     * @example G-ACT-XXXACTION
     *
     * @var string
     */
    public $id;

    /**
     * @example basic
     *
     * @var string
     */
    public $integrationType;

    /**
     * @example 示例连接器
     *
     * @var string
     */
    public $name;

    /**
     * @example ding32fff839a3e0105d
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
