<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\SearchConnectorsResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 连接器的描述信息
     *
     * @var string
     */
    public $description;

    /**
     * @description 连接器的图标
     *
     * @var string
     */
    public $icon;

    /**
     * @description 连接器的ID
     *
     * @var string
     */
    public $id;

    /**
     * @description 连接器的名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 连接器的提供组织
     *
     * @var string
     */
    public $providerCorpId;
    protected $_name = [
        'description'    => 'description',
        'icon'           => 'icon',
        'id'             => 'id',
        'name'           => 'name',
        'providerCorpId' => 'providerCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
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
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
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
