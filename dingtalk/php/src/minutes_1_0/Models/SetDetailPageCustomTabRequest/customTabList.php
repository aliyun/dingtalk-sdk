<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\SetDetailPageCustomTabRequest;

use AlibabaCloud\Tea\Model;

class customTabList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example analyze
     *
     * @var string
     */
    public $bizType;

    /**
     * @description This parameter is required.
     *
     * @example cn_ZH
     *
     * @var string
     */
    public $defaultLocale;

    /**
     * @description This parameter is required.
     *
     * @var mixed[]
     */
    public $nameI18nMap;

    /**
     * @example https://example.com/pc/tab
     *
     * @var string
     */
    public $pcUrl;

    /**
     * @description This parameter is required.
     *
     * @example https://example.com/tab
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'bizType' => 'bizType',
        'defaultLocale' => 'defaultLocale',
        'nameI18nMap' => 'nameI18nMap',
        'pcUrl' => 'pcUrl',
        'url' => 'url',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->defaultLocale) {
            $res['defaultLocale'] = $this->defaultLocale;
        }
        if (null !== $this->nameI18nMap) {
            $res['nameI18nMap'] = $this->nameI18nMap;
        }
        if (null !== $this->pcUrl) {
            $res['pcUrl'] = $this->pcUrl;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return customTabList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['defaultLocale'])) {
            $model->defaultLocale = $map['defaultLocale'];
        }
        if (isset($map['nameI18nMap'])) {
            $model->nameI18nMap = $map['nameI18nMap'];
        }
        if (isset($map['pcUrl'])) {
            $model->pcUrl = $map['pcUrl'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
