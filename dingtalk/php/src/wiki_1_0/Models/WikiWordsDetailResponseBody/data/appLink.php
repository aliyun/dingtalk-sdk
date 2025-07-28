<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_1_0\Models\WikiWordsDetailResponseBody\data;

use AlibabaCloud\Tea\Model;

class appLink extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $appId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $appName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $iconLink;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $pcLink;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $phoneLink;
    protected $_name = [
        'appId' => 'appId',
        'appName' => 'appName',
        'iconLink' => 'iconLink',
        'pcLink' => 'pcLink',
        'phoneLink' => 'phoneLink',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->appName) {
            $res['appName'] = $this->appName;
        }
        if (null !== $this->iconLink) {
            $res['iconLink'] = $this->iconLink;
        }
        if (null !== $this->pcLink) {
            $res['pcLink'] = $this->pcLink;
        }
        if (null !== $this->phoneLink) {
            $res['phoneLink'] = $this->phoneLink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return appLink
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['appName'])) {
            $model->appName = $map['appName'];
        }
        if (isset($map['iconLink'])) {
            $model->iconLink = $map['iconLink'];
        }
        if (isset($map['pcLink'])) {
            $model->pcLink = $map['pcLink'];
        }
        if (isset($map['phoneLink'])) {
            $model->phoneLink = $map['phoneLink'];
        }

        return $model;
    }
}
