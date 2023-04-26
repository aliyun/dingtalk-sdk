<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\SearchConnectorsResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @example 【钉钉官方】通讯录
     *
     * @var string
     */
    public $description;

    /**
     * @example https://static.dingtalk.com/media/lALPDfJ6WadAG1dgYA_96_96.png
     *
     * @var string
     */
    public $icon;

    /**
     * @example G-CONN-1015BC8093540B01B8D0000Q
     *
     * @var string
     */
    public $id;

    /**
     * @example 通讯录
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
